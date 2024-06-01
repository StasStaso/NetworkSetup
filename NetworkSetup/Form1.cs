using NetworkSetup.Service;

namespace NetworkSetup
{
    public partial class Form1 : Form
    {
        private readonly VlanService _vlanService;
        private readonly InputVlan _inputVlan;

        private bool IsVlanAdd = true;

        public Form1(VlanService vlanService)
        {
            _vlanService = vlanService;

            InitializeComponent();

            // Встановлення властивостей форми
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Фіксована рамка
            this.MaximizeBox = false; // Вимкнення кнопки максимізації

            // Встановлення мінімального та максимального розміру, щоб зробити розмір фіксованим
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
        }

        private void dCNS420052ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateComboBox(comboBoxInterface, 52);
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
            InputVlan inputVlan = new InputVlan(_vlanService);

            inputVlan.Show();
        }

        private void btn_AddVlan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_VlanId.Text))
            {
                MessageBox.Show("Vlan Id: empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            bool vlanExists = _vlanService.VlanList                
                .Any(v => v.Id == textBox_VlanId.Text);

            if (!vlanExists && IsVlanAdd)
            {
                _vlanService.Add(textBox_VlanId.Text,
                                 textBox_VlanDescription.Text,
                                 textBox_VlanIpAddress.Text);
            }
            else if (IsVlanAdd == false && vlanExists)
            {
                var removeVlan = _vlanService.VlanList.FirstOrDefault(x => x.Id == (textBox_VlanId.Text));

                _vlanService.VlanList.Remove(removeVlan);
            }
        }

        private void btn_ClearVlanField_Click(object sender, EventArgs e)
        {
            string vlans = "";

            foreach (var item in _vlanService.VlanList)
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
    }
}
