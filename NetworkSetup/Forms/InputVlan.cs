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

        public InputVlan(SwitchConfigurationDcn dcnConfig)
        {
            _dcnConfig = dcnConfig;

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

            // Встановлення висоти форми залежно від кількості VLAN-ів
            this.Height = 170 + numberOfVlans * 30;
            this.Width = 460; // Збільшуємо ширину для CheckBox

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void GenerateVlanControls(int vlanCount)
        {
            for (int i = 0; i < vlanCount; i++)
            {
                Label labelVlan = new Label
                {
                    Text = $"VLAN {_dcnConfig.Vlans[i].}",
                    Location = new System.Drawing.Point(20, 80 + i * 30),
                    AutoSize = true
                };

                TextBox textBoxTrunk = new TextBox
                {
                    Location = new System.Drawing.Point(100, 80 + i * 30),
                    Width = 100,
                    Name = $"textBoxTrunk{i + 1}"
                };

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

            // Додавання кнопки "Save"
            Button buttonSave = new Button
            {
                Text = "Save",
                Location = new System.Drawing.Point(100, 80 + vlanCount * 30 + 10),
                Width = 220, // Від початку першого TextBox до кінця другого
                Height = 30
            };

            this.Controls.Add(buttonSave);
        }

        private void InputVlan_Load(object sender, EventArgs e)
        {

        }
    }
}
