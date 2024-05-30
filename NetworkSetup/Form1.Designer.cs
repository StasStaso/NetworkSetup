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
            groupBox3 = new GroupBox();
            label1 = new Label();
            textBox5 = new TextBox();
            button3 = new Button();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // TextBoxLogs
            // 
            TextBoxLogs.Location = new Point(502, 27);
            TextBoxLogs.Multiline = true;
            TextBoxLogs.Name = "TextBoxLogs";
            TextBoxLogs.ReadOnly = true;
            TextBoxLogs.Size = new Size(270, 372);
            TextBoxLogs.TabIndex = 0;
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
            // textBox5
            // 
            textBox5.Location = new Point(47, 16);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(129, 23);
            textBox5.TabIndex = 3;
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
            // groupBox4
            // 
            groupBox4.Location = new Point(6, 166);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(264, 203);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Vlan";
            // 
            // groupBox5
            // 
            groupBox5.Location = new Point(276, 111);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(208, 258);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Interface";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(panel1);
            Controls.Add(TextBoxLogs);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
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
    }
}
