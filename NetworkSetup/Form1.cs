using NetworkSetup.Model;
using NetworkSetup.Service;

namespace NetworkSetup
{
    public partial class Form1 : Form
    {
        private readonly SwitchConfigurationDcn _dcnConfig;        

        private bool IsVlanAdd = true;
        private bool IsDCNSwitch = false;

        public Form1(SwitchConfigurationDcn dcnConfig)
        {
            _dcnConfig = dcnConfig;

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;


            this.MinimumSize = new Size(this.Width, this.Height);
            this.MaximumSize = new Size(this.Width, this.Height);

            //TextBoxLogs
            TextBoxLogs.ReadOnly = true;
            TextBoxLogs.Enter += new EventHandler(TextBoxLogs_Enter);
        }

        private void TextBoxLogs_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void dCNS420028ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateComboBox(comboBoxInterface, 28);
            IsDCNSwitch = true;
        }

        private void dCNS420052ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateComboBox(comboBoxInterface, 52);
            IsDCNSwitch = true;
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
            InputVlan inputVlan = new InputVlan(_dcnConfig);

            inputVlan.Show();
        }

        private void btn_AddVlan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_VlanId.Text))
            {
                MessageBox.Show("Vlan Id: empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            } 
            
            if (IsVlanAdd == false && vlanExists)
            {
                var removeVlan = _dcnConfig.Vlans.FirstOrDefault(x => x.Id == (textBox_VlanId.Text));

                _dcnConfig.Vlans.Remove(removeVlan);
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

            }
        }
    }
}
