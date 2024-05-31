using NetworkSetup.Service;

namespace NetworkSetup
{
    public partial class Form1 : Form
    {
        private readonly VlanService _vlanService;
        private readonly InputVlan _inputVlan;

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
            _vlanService.Add(textBox_VlanId.Text,
                textBox_VlanDescription.Text,
                textBox_VlanIpAddress.Text);
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
    }
}
