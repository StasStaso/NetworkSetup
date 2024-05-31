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
        private readonly VlanService _vlanService;

        public InputVlan(VlanService vlanService)
        {
            _vlanService = vlanService;

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

            // Додання заголовків для стовпців
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

            this.Controls.Add(labelTrunkHeader);
            this.Controls.Add(labelAllowedHeader);



            int numberOfVlans = _vlanService.VlanList.Count; // Змінити на потрібну кількість VLAN-ів
            GenerateVlanControls(numberOfVlans);

            // Встановлення висоти форми залежно від кількості VLAN-ів
            this.Height = 170 + numberOfVlans * 30;
            this.Width = 350;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void GenerateVlanControls(int vlanCount)
        {
            for (int i = 0; i < vlanCount; i++)
            {
                Label labelVlan = new Label
                {
                    Text = $"VLAN {i + 1}",
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

                // Додавання кнопки "Save"
                Button buttonSave = new Button
                {
                    Text = "Save",
                    Location = new System.Drawing.Point(100, 80 + vlanCount * 30 + 10),
                    Width = 220, // Від початку першого TextBox до кінця другого
                    Height = 30
                };

                this.Controls.Add(buttonSave);
                this.Controls.Add(labelVlan);
                this.Controls.Add(textBoxTrunk);
                this.Controls.Add(textBoxAllowed);
            }
        }

        private void InputVlan_Load(object sender, EventArgs e)
        {

        }
    }
}
