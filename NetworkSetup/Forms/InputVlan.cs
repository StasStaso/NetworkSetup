using NetworkSetup.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkSetup
{
    public partial class InputVlan : Form
    {
        private readonly SwitchConfigurationDcn _dcnConfig;
        private readonly int _portCount;

        public InputVlan(SwitchConfigurationDcn dcnConfig, int portCounts)
        {
            _dcnConfig = dcnConfig;
            _portCount = portCounts;

            InitializeComponent();

            Label labelAllVlans = new Label
            {
                Text = "All VLANs",
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Font = new System.Drawing.Font("Arial", 16, System.Drawing.FontStyle.Bold),
                Height = 40
            };
            this.Controls.Add(labelAllVlans);

            Label labelTrunkHeader = new Label
            {
                Text = "Trunk",
                Location = new System.Drawing.Point(100, 50),
                AutoSize = true
            };
            Label labelAllowedHeader = new Label
            {
                Text = "Allowed",
                Location = new System.Drawing.Point(220, 50),
                AutoSize = true
            };

            Label labelSnoopingHeader = new Label
            {
                Text = "Ip Snooping",
                Location = new System.Drawing.Point(340, 50),
                AutoSize = true
            };

            this.Controls.Add(labelTrunkHeader);
            this.Controls.Add(labelAllowedHeader);
            this.Controls.Add(labelSnoopingHeader);

            int numberOfVlans = _dcnConfig.Vlans.Count;
            GenerateVlanControls(numberOfVlans);

            // Adjust the height of the form depending on the number of VLANs
            this.Height = 170 + numberOfVlans * 30;
            this.Width = 460; // Increase width for CheckBox

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void GenerateVlanControls(int vlanCount)
        {
            for (int i = 0; i < vlanCount; i++)
            {
                Label labelVlan = new Label
                {
                    Text = $"VLAN {_dcnConfig.Vlans[i].Id}",
                    Location = new System.Drawing.Point(20, 80 + i * 30),
                    AutoSize = true
                };

                TextBox textBoxTrunk = new TextBox
                {
                    Location = new System.Drawing.Point(100, 80 + i * 30),
                    Width = 100,
                    Name = $"textBoxTrunk{i + 1}"
                };
                textBoxTrunk.TextChanged += (sender, e) => UpdateAllowedPorts();

                TextBox textBoxAllowed = new TextBox
                {
                    Location = new System.Drawing.Point(220, 80 + i * 30),
                    Width = 100,
                    Name = $"textBoxAllowed{i + 1}"
                };
                textBoxAllowed.TextChanged += (sender, e) => UpdateAllowedPorts();

                CheckBox checkBoxSnooping = new CheckBox
                {
                    Location = new System.Drawing.Point(340, 80 + i * 30),
                    Name = $"checkBoxSnooping{i + 1}"
                };

                this.Controls.Add(labelVlan);
                this.Controls.Add(textBoxTrunk);
                this.Controls.Add(textBoxAllowed);
                this.Controls.Add(checkBoxSnooping);
            }

            Button buttonSave = new Button
            {
                Text = "Save",
                Location = new System.Drawing.Point(100, 80 + vlanCount * 30 + 10),
                Width = 220,
                Height = 30
            };
            buttonSave.Click += ButtonSave_Click;

            this.Controls.Add(buttonSave);
        }

        private void InputVlan_Load(object sender, EventArgs e)
        {

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            List<string> portCommands = new List<string>();

            for (int i = 1; i <= _dcnConfig.Vlans.Count; i++)
            {
                TextBox trunkTextBox = (TextBox)this.Controls.Find($"textBoxTrunk{i}", true)[0];
                TextBox allowedTextBox = (TextBox)this.Controls.Find($"textBoxAllowed{i}", true)[0];
                CheckBox snoopingCheckBox = (CheckBox)this.Controls.Find($"checkBoxSnooping{i}", true)[0];

                string trunkPorts = trunkTextBox.Text;
                string allowedPorts = allowedTextBox.Text;
                bool snooping = snoopingCheckBox.Checked;

                // Handle trunk ports
                if (!string.IsNullOrWhiteSpace(trunkPorts))
                {
                    foreach (var portRange in trunkPorts.Split(';'))
                    {
                        if (portRange.Contains('-'))
                        {
                            var rangeParts = portRange.Split('-');
                            if (int.TryParse(rangeParts[0], out int start) && int.TryParse(rangeParts[1], out int end))
                            {
                                for (int port = start; port <= end; port++)
                                {
                                    portCommands.Add($"Interface Ethernet1/0/{port}");
                                    portCommands.Add(" switchport mode trunk");
                                    portCommands.Add($" switchport trunk allowed vlan {i}");
                                    if (snooping)
                                    {
                                        portCommands.Add(" ip dhcp snooping trust");
                                    }
                                    portCommands.Add("!");
                                }
                            }
                        }
                        else if (int.TryParse(portRange, out int port))
                        {
                            portCommands.Add($"Interface Ethernet1/0/{port}");
                            portCommands.Add(" switchport mode trunk");
                            portCommands.Add($" switchport trunk allowed vlan {i}");
                            if (snooping)
                            {
                                portCommands.Add(" ip dhcp snooping trust");
                            }
                            portCommands.Add("!");
                        }
                    }
                }

                // Handle allowed ports
                if (!string.IsNullOrWhiteSpace(allowedPorts))
                {
                    foreach (var portRange in allowedPorts.Split(';'))
                    {
                        if (portRange.Contains('-'))
                        {
                            var rangeParts = portRange.Split('-');
                            if (int.TryParse(rangeParts[0], out int start) && int.TryParse(rangeParts[1], out int end))
                            {
                                for (int port = start; port <= end; port++)
                                {
                                    portCommands.Add($"Interface Ethernet1/0/{port}");
                                    portCommands.Add($" switchport access vlan {i}");
                                    portCommands.Add($" loopback-detection specified-vlan {i}");
                                    portCommands.Add(" loopback-detection control shutdown");
                                    portCommands.Add(" ip dhcp snooping action shutdown recovery 600");
                                    portCommands.Add("!");
                                }
                            }
                        }
                        else if (int.TryParse(portRange, out int port))
                        {
                            portCommands.Add($"Interface Ethernet1/0/{port}");
                            portCommands.Add($" switchport access vlan {i}");
                            portCommands.Add($" loopback-detection specified-vlan {i}");
                            portCommands.Add(" loopback-detection control shutdown");
                            portCommands.Add(" ip dhcp snooping action shutdown recovery 600");
                            portCommands.Add("!");
                        }
                    }
                }
            }

            // Add the generated commands to the SwitchConfigurationDcn instance
            _dcnConfig.AddPortCommands(portCommands);
        }

        private void UpdateAllowedPorts()
        {
            HashSet<int> trunkPorts = new HashSet<int>();
            HashSet<int> allAllowedPorts = new HashSet<int>();

            // Collect all trunk ports from all trunk text boxes
            for (int i = 1; i <= _dcnConfig.Vlans.Count; i++)
            {
                TextBox trunkTextBox = (TextBox)this.Controls.Find($"textBoxTrunk{i}", true)[0];
                string trunkValue = trunkTextBox.Text;
                if (!string.IsNullOrWhiteSpace(trunkValue))
                {
                    foreach (var portRange in trunkValue.Split(';'))
                    {
                        if (portRange.Contains('-'))
                        {
                            var rangeParts = portRange.Split('-');
                            if (int.TryParse(rangeParts[0], out int start) && int.TryParse(rangeParts[1], out int end))
                            {
                                for (int p = start; p <= end; p++)
                                {
                                    trunkPorts.Add(p);
                                }
                            }
                        }
                        else if (int.TryParse(portRange, out int port))
                        {
                            trunkPorts.Add(port);
                        }
                    }
                }
            }

            // Collect all allowed ports from all allowed text boxes
            for (int i = 1; i <= _dcnConfig.Vlans.Count; i++)
            {
                TextBox allowedTextBox = (TextBox)this.Controls.Find($"textBoxAllowed{i}", true)[0];
                string allowedValue = allowedTextBox.Text;
                if (!string.IsNullOrWhiteSpace(allowedValue))
                {
                    foreach (var portRange in allowedValue.Split(';'))
                    {
                        if (portRange.Contains('-'))
                        {
                            var rangeParts = portRange.Split('-');
                            if (int.TryParse(rangeParts[0], out int start) && int.TryParse(rangeParts[1], out int end))
                            {
                                for (int p = start; p <= end; p++)
                                {
                                    allAllowedPorts.Add(p);
                                }
                            }
                        }
                        else if (int.TryParse(portRange, out int port))
                        {
                            allAllowedPorts.Add(port);
                        }
                    }
                }
            }

            // Remove trunk ports from all allowed ports
            allAllowedPorts.ExceptWith(trunkPorts);

            // Update all allowed text boxes based on the collected trunk and allowed ports
            for (int i = 1; i <= _dcnConfig.Vlans.Count; i++)
            {
                TextBox allowedTextBox = (TextBox)this.Controls.Find($"textBoxAllowed{i}", true)[0];
                List<int> remainingPorts = Enumerable.Range(1, _portCount).ToList();
                remainingPorts.RemoveAll(p => trunkPorts.Contains(p) || allAllowedPorts.Contains(p));

                StringBuilder allowedPortsText = new StringBuilder();
                int startRange = 0;
                int endRange = 0;

                foreach (int port in remainingPorts)
                {
                    if (startRange == 0)
                    {
                        startRange = port;
                        endRange = port;
                    }
                    else if (port == endRange + 1)
                    {
                        endRange = port;
                    }
                    else
                    {
                        if (startRange == endRange)
                        {
                            allowedPortsText.Append($"{startRange};");
                        }
                        else
                        {
                            allowedPortsText.Append($"{startRange}-{endRange};");
                        }

                        startRange = port;
                        endRange = port;
                    }
                }

                if (startRange == endRange)
                {
                    allowedPortsText.Append($"{startRange}");
                }
                else
                {
                    allowedPortsText.Append($"{startRange}-{endRange}");
                }

                allowedTextBox.PlaceholderText = allowedPortsText.ToString().TrimEnd(';');
            }
        }
    }
}
