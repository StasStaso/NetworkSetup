namespace NetworkSetup
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TextBoxLogs = new TextBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            fileToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            switchToolStripMenuItem = new ToolStripMenuItem();
            dCNS420028ToolStripMenuItem = new ToolStripMenuItem();
            dCNS420052ToolStripMenuItem = new ToolStripMenuItem();
            dLinkDES3528ToolStripMenuItem = new ToolStripMenuItem();
            onuToolStripMenuItem = new ToolStripMenuItem();
            zTEF601ToolStripMenuItem = new ToolStripMenuItem();
            analizeToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            groupBox5 = new GroupBox();
            groupBox7 = new GroupBox();
            label10 = new Label();
            textBox10 = new TextBox();
            button7 = new Button();
            textBox9 = new TextBox();
            comboBox5 = new ComboBox();
            label9 = new Label();
            comboBox4 = new ComboBox();
            label8 = new Label();
            comboBox3 = new ComboBox();
            button8 = new Button();
            groupBox4 = new GroupBox();
            button4 = new Button();
            comboBox2 = new ComboBox();
            label7 = new Label();
            groupBox6 = new GroupBox();
            button6 = new Button();
            button5 = new Button();
            label6 = new Label();
            label5 = new Label();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            label4 = new Label();
            groupBox3 = new GroupBox();
            button3 = new Button();
            textBox5 = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            button9 = new Button();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // TextBoxLogs
            // 
            TextBoxLogs.Location = new Point(502, 27);
            TextBoxLogs.Multiline = true;
            TextBoxLogs.Name = "TextBoxLogs";
            TextBoxLogs.ReadOnly = true;
            TextBoxLogs.Size = new Size(270, 329);
            TextBoxLogs.TabIndex = 0;
            TextBoxLogs.Text = "***************************************************\r\n******************NetworkSetup******************\r\n***************************************************\r\n";
            TextBoxLogs.Enter += TextBoxLogs_Enter;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, switchToolStripMenuItem, onuToolStripMenuItem, analizeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(784, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fileToolStripMenuItem1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // fileToolStripMenuItem1
            // 
            fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            fileToolStripMenuItem1.Size = new Size(93, 22);
            fileToolStripMenuItem1.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(93, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // switchToolStripMenuItem
            // 
            switchToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dCNS420028ToolStripMenuItem, dCNS420052ToolStripMenuItem, dLinkDES3528ToolStripMenuItem });
            switchToolStripMenuItem.Name = "switchToolStripMenuItem";
            switchToolStripMenuItem.Size = new Size(54, 20);
            switchToolStripMenuItem.Text = "Switch";
            // 
            // dCNS420028ToolStripMenuItem
            // 
            dCNS420028ToolStripMenuItem.Name = "dCNS420028ToolStripMenuItem";
            dCNS420028ToolStripMenuItem.Size = new Size(156, 22);
            dCNS420028ToolStripMenuItem.Text = "DCN-S4200-28";
            // 
            // dCNS420052ToolStripMenuItem
            // 
            dCNS420052ToolStripMenuItem.Name = "dCNS420052ToolStripMenuItem";
            dCNS420052ToolStripMenuItem.Size = new Size(156, 22);
            dCNS420052ToolStripMenuItem.Text = "DCN-S4200-52";
            // 
            // dLinkDES3528ToolStripMenuItem
            // 
            dLinkDES3528ToolStripMenuItem.Name = "dLinkDES3528ToolStripMenuItem";
            dLinkDES3528ToolStripMenuItem.Size = new Size(156, 22);
            dLinkDES3528ToolStripMenuItem.Text = "D-Link DES3528";
            // 
            // onuToolStripMenuItem
            // 
            onuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zTEF601ToolStripMenuItem });
            onuToolStripMenuItem.Name = "onuToolStripMenuItem";
            onuToolStripMenuItem.Size = new Size(42, 20);
            onuToolStripMenuItem.Text = "Onu";
            // 
            // zTEF601ToolStripMenuItem
            // 
            zTEF601ToolStripMenuItem.Name = "zTEF601ToolStripMenuItem";
            zTEF601ToolStripMenuItem.Size = new Size(122, 22);
            zTEF601ToolStripMenuItem.Text = "ZTE-F601";
            // 
            // analizeToolStripMenuItem
            // 
            analizeToolStripMenuItem.Name = "analizeToolStripMenuItem";
            analizeToolStripMenuItem.Size = new Size(57, 20);
            analizeToolStripMenuItem.Text = "Analize";
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox5);
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(12, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 372);
            panel1.TabIndex = 2;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(groupBox7);
            groupBox5.Controls.Add(comboBox3);
            groupBox5.Controls.Add(button8);
            groupBox5.Location = new Point(276, 111);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(208, 258);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Interface";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(label10);
            groupBox7.Controls.Add(textBox10);
            groupBox7.Controls.Add(button7);
            groupBox7.Controls.Add(textBox9);
            groupBox7.Controls.Add(comboBox5);
            groupBox7.Controls.Add(label9);
            groupBox7.Controls.Add(comboBox4);
            groupBox7.Controls.Add(label8);
            groupBox7.Location = new Point(6, 55);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(196, 163);
            groupBox7.TabIndex = 9;
            groupBox7.TabStop = false;
            groupBox7.Text = "Interface config";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 78);
            label10.Name = "label10";
            label10.Size = new Size(33, 15);
            label10.TabIndex = 14;
            label10.Text = "Vlan:";
            label10.TextAlign = ContentAlignment.TopRight;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(54, 75);
            textBox10.Name = "textBox10";
            textBox10.PlaceholderText = "2;10;201";
            textBox10.Size = new Size(136, 23);
            textBox10.TabIndex = 13;
            // 
            // button7
            // 
            button7.Location = new Point(6, 133);
            button7.Name = "button7";
            button7.Size = new Size(183, 23);
            button7.TabIndex = 10;
            button7.Text = "Modify";
            button7.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(6, 104);
            textBox9.Name = "textBox9";
            textBox9.PlaceholderText = "Description";
            textBox9.Size = new Size(184, 23);
            textBox9.TabIndex = 5;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "auto", "full", "half", "fx" });
            comboBox5.Location = new Point(54, 46);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(136, 23);
            comboBox5.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 49);
            label9.Name = "label9";
            label9.Size = new Size(47, 15);
            label9.TabIndex = 11;
            label9.Text = "Duplex:";
            label9.TextAlign = ContentAlignment.TopRight;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "10", "100", "1G" });
            comboBox4.Location = new Point(54, 17);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(136, 23);
            comboBox4.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 19);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 3;
            label8.Text = "Speed:";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Ethernet 1/0/1", "Ethernet 1/0/2", "Ethernet 1/0/3", "Ethernet 1/0/4", "Ethernet 1/0/5", "Ethernet 1/0/6", "Ethernet 1/0/7" });
            comboBox3.Location = new Point(6, 22);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(196, 23);
            comboBox3.TabIndex = 8;
            comboBox3.Text = "Interface";
            // 
            // button8
            // 
            button8.Location = new Point(6, 224);
            button8.Name = "button8";
            button8.Size = new Size(196, 28);
            button8.TabIndex = 7;
            button8.Text = "Config Port";
            button8.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button4);
            groupBox4.Controls.Add(comboBox2);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(groupBox6);
            groupBox4.Location = new Point(6, 166);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(264, 203);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Vlan";
            // 
            // button4
            // 
            button4.Location = new Point(182, 16);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 7;
            button4.Text = "Load";
            button4.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Add", "Remove" });
            comboBox2.Location = new Point(57, 16);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(119, 23);
            comboBox2.TabIndex = 8;
            comboBox2.Text = "Add";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 19);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 7;
            label7.Text = "Action:";
            label7.TextAlign = ContentAlignment.TopRight;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(button6);
            groupBox6.Controls.Add(button5);
            groupBox6.Controls.Add(label6);
            groupBox6.Controls.Add(label5);
            groupBox6.Controls.Add(textBox8);
            groupBox6.Controls.Add(textBox7);
            groupBox6.Controls.Add(textBox6);
            groupBox6.Controls.Add(label4);
            groupBox6.Location = new Point(6, 45);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(251, 152);
            groupBox6.TabIndex = 0;
            groupBox6.TabStop = false;
            groupBox6.Text = "New Vlan";
            // 
            // button6
            // 
            button6.Location = new Point(6, 123);
            button6.Name = "button6";
            button6.Size = new Size(239, 23);
            button6.TabIndex = 14;
            button6.Text = "Clear";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(6, 95);
            button5.Name = "button5";
            button5.Size = new Size(239, 23);
            button5.TabIndex = 13;
            button5.Text = "Add";
            button5.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 69);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 12;
            label6.Text = "IP address:";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 43);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 11;
            label5.Text = "Description:";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(82, 66);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(163, 23);
            textBox8.TabIndex = 10;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(82, 40);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(163, 23);
            textBox7.TabIndex = 9;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(82, 16);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(163, 23);
            textBox6.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 3;
            label4.Text = "Vlan Id:";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(6, 111);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(264, 49);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Snmp-server";
            // 
            // button3
            // 
            button3.Location = new Point(182, 16);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(47, 16);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(129, 23);
            textBox5.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 2;
            label1.Text = "Host:";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(6, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(478, 48);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Basic Info";
            // 
            // button1
            // 
            button1.Location = new Point(397, 16);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(283, 16);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(108, 23);
            textBox3.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(212, 19);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 2;
            label3.Text = "Ntp Server:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "Hostname:";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(77, 16);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(129, 23);
            textBox2.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Location = new Point(6, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(478, 48);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Account";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" });
            comboBox1.Location = new Point(294, 16);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(97, 23);
            comboBox1.TabIndex = 7;
            comboBox1.Text = "Privilege";
            // 
            // button2
            // 
            button2.Location = new Point(397, 16);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(148, 16);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Password";
            textBox1.Size = new Size(140, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(6, 17);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Username";
            textBox4.Size = new Size(136, 23);
            textBox4.TabIndex = 3;
            // 
            // button9
            // 
            button9.Location = new Point(502, 361);
            button9.Name = "button9";
            button9.Size = new Size(270, 38);
            button9.TabIndex = 10;
            button9.Text = "Save to TXT";
            button9.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(button9);
            Controls.Add(panel1);
            Controls.Add(TextBoxLogs);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Network SetUp";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxLogs;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem switchToolStripMenuItem;
        private ToolStripMenuItem dCNS420028ToolStripMenuItem;
        private ToolStripMenuItem dCNS420052ToolStripMenuItem;
        private ToolStripMenuItem dLinkDES3528ToolStripMenuItem;
        private ToolStripMenuItem onuToolStripMenuItem;
        private ToolStripMenuItem zTEF601ToolStripMenuItem;
        private ToolStripMenuItem analizeToolStripMenuItem;
        private Panel panel1;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private TextBox textBox3;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
        private TextBox textBox4;
        private Button button2;
        private ComboBox comboBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private Button button3;
        private TextBox textBox5;
        private Label label1;
        private GroupBox groupBox6;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private Label label4;
        private Label label6;
        private Label label5;
        private ComboBox comboBox2;
        private Label label7;
        private Button button4;
        private Button button6;
        private Button button5;
        private GroupBox groupBox7;
        private ComboBox comboBox3;
        private Button button8;
        private Button button7;
        private TextBox textBox9;
        private ComboBox comboBox5;
        private Label label9;
        private ComboBox comboBox4;
        private Label label8;
        private Label label10;
        private TextBox textBox10;
        private Button button9;
    }
}
