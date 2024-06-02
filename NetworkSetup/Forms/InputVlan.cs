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
                textBoxTrunk.TextChanged += (sender, e) => UpdateAllowedPorts(sender, e, vlanCount);

                TextBox textBoxAllowed = new TextBox
                {
                    Location = new System.Drawing.Point(220, 80 + i * 30),
                    Width = 100,
                    Name = $"textBoxAllowed{i + 1}"
                };

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

            this.Controls.Add(buttonSave);
        }

        private void InputVlan_Load(object sender, EventArgs e)
        {

        }

        private void UpdateAllowedPorts(object sender, EventArgs e, int vlanCount)
        {
            // Collect all Trunk ports
            HashSet<int> trunkPorts = new HashSet<int>();
            for (int i = 1; i <= vlanCount; i++)
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

            // Update all Allowed ports
            for (int i = 1; i <= vlanCount; i++)
            {
                TextBox allowedTextBox = (TextBox)this.Controls.Find($"textBoxAllowed{i}", true)[0];
                List<int> allPorts = Enumerable.Range(1, _portCount).ToList();
                allPorts.RemoveAll(p => trunkPorts.Contains(p));

                // Build allowed ports string
                StringBuilder allowedPortsText = new StringBuilder();
                int startRange = 0;
                int endRange = 0;

                foreach (int port in allPorts)
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
