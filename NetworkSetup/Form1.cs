using NetworkSetup.Model;
using NetworkSetup.Service;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace NetworkSetup
{
    public partial class Form1 : Form
    {
        private readonly SwitchConfigurationDcn _dcnConfig;
        private readonly Logger _logger;
        private ZTEF601Service _service;

        private bool IsVlanAdd = true;
        private bool IsDCNSwitch = false;
        private bool isBasicInfoSet = false;
        private int PortCount = 28;

        public Form1(SwitchConfigurationDcn dcnConfig, Logger logger)
        {
            _dcnConfig = dcnConfig;

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            _service = new ZTEF601Service();

            this.MinimumSize = new Size(this.Width, this.Height);
            this.MaximumSize = new Size(this.Width, this.Height);

            //TextBoxLogs
            TextBoxLogs.ReadOnly = true;
            TextBoxLogs.Enter += new EventHandler(TextBoxLogs_Enter);

            _logger = logger;
            _logger.LogAdded += OnLogAdded;
        }

        private void OnLogAdded(string log)
        {
            TextBoxLogs.Text += log + Environment.NewLine;
        }

        private void TextBoxLogs_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void dCNS420028ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PortCount = 28;
            UpdateComboBox(comboBoxInterface, PortCount);
            IsDCNSwitch = true;
            _dcnConfig.command.Clear();
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void dCNS420052ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PortCount = 52;
            UpdateComboBox(comboBoxInterface, PortCount);
            IsDCNSwitch = true;
            _dcnConfig.command.Clear();
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private void dCNS460028PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PortCount = 28;
            UpdateComboBox(comboBoxInterface, PortCount);
            IsDCNSwitch = true;
            _dcnConfig.command.Clear();
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void UpdateComboBox(ComboBox comboBox, int port)
        {
            comboBox.Items.Clear();

            if (port == 28)
            {
                for (int i = 1; i <= port; i++)
                {
                    comboBox.Items.Add($"Ethernet 1/0/{i}");
                }
            }
            else if (port == 52)
            {
                for (int i = 1; i <= port; i++)
                {
                    comboBox.Items.Add($"Ethernet 1/0/{i}");
                }
            }
        }

        private void comboBox_InterfaceSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_InterfaceSpeed.SelectedItem == "auto")
            {
                comboBox_InterfaceDuplex.Text = "";
                comboBox_InterfaceDuplex.Enabled = false;
            }
            else
            {
                comboBox_InterfaceDuplex.Enabled = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            InputVlan inputVlan = new InputVlan(_dcnConfig, PortCount);

            inputVlan.Show();
        }

        private void btn_AddVlan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_VlanId.Text))
            {
                IsVlanAdd = false;
                MessageBox.Show("Vlan Id: empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if (string.IsNullOrEmpty(textBox_VlanDescription.Text))
            {
                IsVlanAdd = false;
                MessageBox.Show("Description: empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                IsVlanAdd = true;
            }

            if (!IsValidIPAddress(textBox_VlanIpAddress.Text) && !string.IsNullOrEmpty(textBox_VlanIpAddress.Text))
            {
                MessageBox.Show("Invalid IP Address");
                return;
            }

            bool vlanExists = _dcnConfig.Vlans
                .Any(v => v.Id == textBox_VlanId.Text);


            if (!vlanExists && IsVlanAdd)
            {
                _dcnConfig.Vlans.Add(new Vlan
                {
                    Id = textBox_VlanId.Text,
                    Description = textBox_VlanDescription.Text,
                    IpAddress = textBox_VlanIpAddress.Text
                });

                _logger.AddLog($"Vlan {textBox_VlanId.Text} has been add");
            }

            if (comboBox_ActionVlan.SelectedIndex == 1)
            {
                var removeVlan = _dcnConfig.Vlans.FirstOrDefault(x => x.Id == (textBox_VlanId.Text));

                _dcnConfig.Vlans.Remove(removeVlan);

                _logger.AddLog($"Vlan {removeVlan.Id} has been remove");
            }
        }

        private void btn_ClearVlanField_Click(object sender, EventArgs e)
        {
            string vlans = "";

            foreach (var item in _dcnConfig.Vlans)
            {
                vlans += item.Id + ";";
            }

            MessageBox.Show($"Vlan : {vlans}");
        }

        private void btn_LoadActionVlan_Click(object sender, EventArgs e)
        {
            if (comboBox_ActionVlan.SelectedIndex == 0)
            {
                IsVlanAdd = true;
                groupBox6.Text = "Add Vlan";
                textBox_VlanDescription.Enabled = true;
                textBox_VlanIpAddress.Enabled = true;
                btn_AddVlan.Text = "Add";
            }

            if (comboBox_ActionVlan.SelectedIndex == 1)
            {
                IsVlanAdd = false;
                groupBox6.Text = "Remove Vlan";
                textBox_VlanDescription.Enabled = false;
                textBox_VlanIpAddress.Enabled = false;
                btn_AddVlan.Text = "Remove";
            }
        }

        private void btn_SaveToTXT_Click(object sender, EventArgs e)
        {
            if (IsDCNSwitch)
            {
                string command = string.Join(Environment.NewLine, _dcnConfig.GetCommand());
                SaveToFile(command);
            }
        }

        private void btn_AddAccount_Click(object sender, EventArgs e)
        {
            if (IsDCNSwitch)
            {
                if (string.IsNullOrEmpty(textBox_UserName.Text)
                    || string.IsNullOrEmpty(textBox_Password.Text))
                {
                    MessageBox.Show("Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (comboBox_Privilege.SelectedIndex == -1)
                {
                    MessageBox.Show("Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool accountExists = _dcnConfig.Accounts
                 .Any(v => v.UserName == textBox_UserName.Text);

                if (!accountExists)
                {
                    _dcnConfig.Accounts.Add(new Account
                    {
                        UserName = textBox_UserName.Text,
                        Password = textBox_Password.Text,
                        Privilege = comboBox_Privilege.SelectedIndex + 1
                    });

                    _logger.AddLog("Info: Account has been added successfully");
                }
                else
                {
                    MessageBox.Show("An account with this name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_SaveBasicInfo_Click(object sender, EventArgs e)
        {
            if (IsDCNSwitch)
            {
                string hostName = textBox_HostName.Text;
                string ntpServer = textBox_NtpServer.Text;

                if (string.IsNullOrEmpty(hostName) || string.IsNullOrEmpty(ntpServer))
                {
                    MessageBox.Show("Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsValidIPAddress(ntpServer))
                {
                    MessageBox.Show("Invalid IP Address");
                    return;
                }

                if (string.IsNullOrEmpty(_dcnConfig.HostName) && string.IsNullOrEmpty(_dcnConfig.NtpServer))
                {
                    _dcnConfig.HostName = hostName;
                    _dcnConfig.NtpServer = ntpServer;

                    _logger.AddLog("Info: Add Hostname and Ntp-server");
                }
                else
                {
                    MessageBox.Show("Hostname and Ntp-server have already been set and cannot be changed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_AddSNMP_Click(object sender, EventArgs e)
        {
            if (IsDCNSwitch)
            {
                if (string.IsNullOrEmpty(textBox_HostSNMP.Text))
                {
                    MessageBox.Show("Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsValidIPAddress(textBox_HostSNMP.Text))
                {
                    MessageBox.Show("Invalid IP Address");
                    return;
                }

                bool hostExists = _dcnConfig.SnmpHost
                 .Any(v => v == textBox_HostSNMP.Text);

                if (!hostExists)
                {
                    _dcnConfig.SnmpHost.Add(textBox_HostSNMP.Text);

                    _logger.AddLog("Info: host has been added successfully");
                }
                else
                {
                    MessageBox.Show("An host with this address already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_InterfaceModify_Click(object sender, EventArgs e)
        {
            if (IsDCNSwitch)
            {
                int interfaceId = comboBoxInterface.SelectedIndex + 1;
                string speed = comboBox_InterfaceSpeed.Text;
                string duplex = comboBox_InterfaceDuplex.Text;
                string description = textBox_InterfaceDescription.Text;


                string[] strings =
                {
                    $"interface Ethernet 1/0/{interfaceId}",
                    $"speed-duplex {speed}-{duplex}",
                    $"description {description}",
                    $"exit"
                };

                _dcnConfig.InterfaceMoreConfig.AddRange(strings);
            }
        }

        private void zTEF601ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Передбачаємо формат VLAN5, де VLAN - назва, а 5 - ID
                string vlanText = txtVlan.Text;
                int vlanId = int.Parse(new string(vlanText.Where(char.IsDigit).ToArray()));
                string vlanName = vlanText;  // Використовуємо весь введений текст як назву

                // Розділяємо Position по ':'
                string positionText = txtPosition.Text;
                string[] positionParts = positionText.Split(':');
                if (positionParts.Length != 2)
                {
                    throw new FormatException("Position should be in format '1/1/1:1'");
                }

                var model = new ZTEF601Model
                {
                    SerialNumber = txtSerialNumber.Text,
                    VlanName = vlanName,
                    VlanId = vlanId,
                    Position = txtPosition.Text,
                    SpeedProfile = txtSpeedProfile.Text,
                    DhcpOption82 = chkDhcpOption82.Checked
                };

                var service = new ZTEF601Service();
                string configText = service.GenerateConfig(model);

                SaveToFile(configText);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing input: " + ex.Message);
            }
        }

        private void SaveToFile(string text)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.FilterIndex = 1;
                sfd.RestoreDirectory = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, text);
                }
            }
        }

        private void btnSaveToTXT_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = txtSerialNumberFile.Text;
                string position = txtPositions.Text;
                string speedProfile = txtSpeedProfiles.Text;
                string vlanName = txtVlans.Text;
                int vlanId = int.Parse(vlanName.Substring(4)); // Assuming VLAN5 => 5
                bool dhcpOption82 = chkDhcpOption82s.Checked;

                string config = _service.GenerateMultiConfig(filePath, position, speedProfile, vlanName, vlanId, dhcpOption82);

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, config);
                        MessageBox.Show("Configuration saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtSerialNumberFile.Text = openFileDialog.FileName;
                }
            }
        }
        private bool IsValidIPAddress(string ipAddress)
        {
            // Регулярний вираз для перевірки IPv4
            string pattern = @"^(\d{1,3}\.){3}\d{1,3}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(ipAddress))
            {
                string[] parts = ipAddress.Split('.');
                foreach (string part in parts)
                {
                    if (int.Parse(part) > 255)
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
    }
}
