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
            switchToolStripMenuItem = new ToolStripMenuItem();
            dCNS420028ToolStripMenuItem = new ToolStripMenuItem();
            dCNS420052ToolStripMenuItem = new ToolStripMenuItem();
            dCNS460028PToolStripMenuItem = new ToolStripMenuItem();
            onuToolStripMenuItem = new ToolStripMenuItem();
            zTEF601ToolStripMenuItem = new ToolStripMenuItem();
            analizeToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            groupBox5 = new GroupBox();
            btn_SaveToTXT = new Button();
            groupBox7 = new GroupBox();
            btn_InterfaceModify = new Button();
            textBox_InterfaceDescription = new TextBox();
            comboBox_InterfaceDuplex = new ComboBox();
            label9 = new Label();
            comboBox_InterfaceSpeed = new ComboBox();
            label8 = new Label();
            comboBoxInterface = new ComboBox();
            button8 = new Button();
            groupBox4 = new GroupBox();
            btn_LoadActionVlan = new Button();
            comboBox_ActionVlan = new ComboBox();
            label7 = new Label();
            groupBox6 = new GroupBox();
            btn_ClearVlanField = new Button();
            btn_AddVlan = new Button();
            label6 = new Label();
            label5 = new Label();
            textBox_VlanIpAddress = new TextBox();
            textBox_VlanDescription = new TextBox();
            textBox_VlanId = new TextBox();
            label4 = new Label();
            groupBox3 = new GroupBox();
            btn_AddSNMP = new Button();
            textBox_HostSNMP = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btn_SaveBasicInfo = new Button();
            textBox_NtpServer = new TextBox();
            label_NtpServer = new Label();
            label_HostName = new Label();
            textBox_HostName = new TextBox();
            groupBox1 = new GroupBox();
            comboBox_Privilege = new ComboBox();
            btn_AddAccount = new Button();
            textBox_Password = new TextBox();
            textBox_UserName = new TextBox();
            panel2 = new Panel();
            groupBox9 = new GroupBox();
            groupBox8 = new GroupBox();
            txtSpeedProfile = new TextBox();
            label11 = new Label();
            button1 = new Button();
            chkDhcpOption82 = new CheckBox();
            label10 = new Label();
            txtPosition = new TextBox();
            txtVlan = new TextBox();
            label3 = new Label();
            txtSerialNumber = new TextBox();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox8.SuspendLayout();
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
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fileToolStripMenuItem1 });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // fileToolStripMenuItem1
            // 
            fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            fileToolStripMenuItem1.Size = new Size(93, 22);
            fileToolStripMenuItem1.Text = "exit";
            // 
            // switchToolStripMenuItem
            // 
            switchToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dCNS420028ToolStripMenuItem, dCNS420052ToolStripMenuItem, dCNS460028PToolStripMenuItem });
            switchToolStripMenuItem.Name = "switchToolStripMenuItem";
            switchToolStripMenuItem.Size = new Size(54, 20);
            switchToolStripMenuItem.Text = "Switch";
            // 
            // dCNS420028ToolStripMenuItem
            // 
            dCNS420028ToolStripMenuItem.Name = "dCNS420028ToolStripMenuItem";
            dCNS420028ToolStripMenuItem.Size = new Size(158, 22);
            dCNS420028ToolStripMenuItem.Text = "DCN-S4200-28P";
            dCNS420028ToolStripMenuItem.Click += dCNS420028ToolStripMenuItem_Click;
            // 
            // dCNS420052ToolStripMenuItem
            // 
            dCNS420052ToolStripMenuItem.Name = "dCNS420052ToolStripMenuItem";
            dCNS420052ToolStripMenuItem.Size = new Size(158, 22);
            dCNS420052ToolStripMenuItem.Text = "DCN-S4600-52P";
            dCNS420052ToolStripMenuItem.Click += dCNS420052ToolStripMenuItem_Click;
            // 
            // dCNS460028PToolStripMenuItem
            // 
            dCNS460028PToolStripMenuItem.Name = "dCNS460028PToolStripMenuItem";
            dCNS460028PToolStripMenuItem.Size = new Size(158, 22);
            dCNS460028PToolStripMenuItem.Text = "DCN-S4600-28P";
            dCNS460028PToolStripMenuItem.Click += dCNS460028PToolStripMenuItem_Click;
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
            zTEF601ToolStripMenuItem.Size = new Size(247, 22);
            zTEF601ToolStripMenuItem.Text = "ZTE-F601(ZTE ZXA10 C320 Gpon)";
            zTEF601ToolStripMenuItem.Click += zTEF601ToolStripMenuItem_Click;
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
            panel1.Visible = false;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btn_SaveToTXT);
            groupBox5.Controls.Add(groupBox7);
            groupBox5.Controls.Add(comboBoxInterface);
            groupBox5.Controls.Add(button8);
            groupBox5.Location = new Point(276, 111);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(208, 258);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Interface";
            // 
            // btn_SaveToTXT
            // 
            btn_SaveToTXT.Location = new Point(6, 224);
            btn_SaveToTXT.Name = "btn_SaveToTXT";
            btn_SaveToTXT.Size = new Size(196, 28);
            btn_SaveToTXT.TabIndex = 10;
            btn_SaveToTXT.Text = "Save to TXT";
            btn_SaveToTXT.UseVisualStyleBackColor = true;
            btn_SaveToTXT.Click += btn_SaveToTXT_Click;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(btn_InterfaceModify);
            groupBox7.Controls.Add(textBox_InterfaceDescription);
            groupBox7.Controls.Add(comboBox_InterfaceDuplex);
            groupBox7.Controls.Add(label9);
            groupBox7.Controls.Add(comboBox_InterfaceSpeed);
            groupBox7.Controls.Add(label8);
            groupBox7.Location = new Point(6, 55);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(196, 134);
            groupBox7.TabIndex = 9;
            groupBox7.TabStop = false;
            groupBox7.Text = "Interface config";
            // 
            // btn_InterfaceModify
            // 
            btn_InterfaceModify.Location = new Point(6, 104);
            btn_InterfaceModify.Name = "btn_InterfaceModify";
            btn_InterfaceModify.Size = new Size(184, 23);
            btn_InterfaceModify.TabIndex = 10;
            btn_InterfaceModify.Text = "Modify";
            btn_InterfaceModify.UseVisualStyleBackColor = true;
            btn_InterfaceModify.Click += btn_InterfaceModify_Click;
            // 
            // textBox_InterfaceDescription
            // 
            textBox_InterfaceDescription.Location = new Point(7, 75);
            textBox_InterfaceDescription.Name = "textBox_InterfaceDescription";
            textBox_InterfaceDescription.PlaceholderText = "Description";
            textBox_InterfaceDescription.Size = new Size(183, 23);
            textBox_InterfaceDescription.TabIndex = 5;
            // 
            // comboBox_InterfaceDuplex
            // 
            comboBox_InterfaceDuplex.FormattingEnabled = true;
            comboBox_InterfaceDuplex.Items.AddRange(new object[] { "full", "half", "fx" });
            comboBox_InterfaceDuplex.Location = new Point(54, 46);
            comboBox_InterfaceDuplex.Name = "comboBox_InterfaceDuplex";
            comboBox_InterfaceDuplex.Size = new Size(136, 23);
            comboBox_InterfaceDuplex.TabIndex = 12;
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
            // comboBox_InterfaceSpeed
            // 
            comboBox_InterfaceSpeed.FormattingEnabled = true;
            comboBox_InterfaceSpeed.Items.AddRange(new object[] { "10", "100", "1g" });
            comboBox_InterfaceSpeed.Location = new Point(54, 17);
            comboBox_InterfaceSpeed.Name = "comboBox_InterfaceSpeed";
            comboBox_InterfaceSpeed.Size = new Size(136, 23);
            comboBox_InterfaceSpeed.TabIndex = 10;
            comboBox_InterfaceSpeed.SelectedIndexChanged += comboBox_InterfaceSpeed_SelectedIndexChanged;
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
            // comboBoxInterface
            // 
            comboBoxInterface.FormattingEnabled = true;
            comboBoxInterface.Location = new Point(6, 22);
            comboBoxInterface.Name = "comboBoxInterface";
            comboBoxInterface.Size = new Size(196, 23);
            comboBoxInterface.TabIndex = 8;
            comboBoxInterface.Text = "Interface";
            // 
            // button8
            // 
            button8.Location = new Point(6, 195);
            button8.Name = "button8";
            button8.Size = new Size(196, 23);
            button8.TabIndex = 7;
            button8.Text = "Interface";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btn_LoadActionVlan);
            groupBox4.Controls.Add(comboBox_ActionVlan);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(groupBox6);
            groupBox4.Location = new Point(6, 166);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(264, 203);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Vlan";
            // 
            // btn_LoadActionVlan
            // 
            btn_LoadActionVlan.Location = new Point(182, 16);
            btn_LoadActionVlan.Name = "btn_LoadActionVlan";
            btn_LoadActionVlan.Size = new Size(75, 23);
            btn_LoadActionVlan.TabIndex = 7;
            btn_LoadActionVlan.Text = "Load";
            btn_LoadActionVlan.UseVisualStyleBackColor = true;
            btn_LoadActionVlan.Click += btn_LoadActionVlan_Click;
            // 
            // comboBox_ActionVlan
            // 
            comboBox_ActionVlan.FormattingEnabled = true;
            comboBox_ActionVlan.Items.AddRange(new object[] { "Add", "Remove" });
            comboBox_ActionVlan.Location = new Point(57, 16);
            comboBox_ActionVlan.Name = "comboBox_ActionVlan";
            comboBox_ActionVlan.Size = new Size(119, 23);
            comboBox_ActionVlan.TabIndex = 8;
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
            groupBox6.Controls.Add(btn_ClearVlanField);
            groupBox6.Controls.Add(btn_AddVlan);
            groupBox6.Controls.Add(label6);
            groupBox6.Controls.Add(label5);
            groupBox6.Controls.Add(textBox_VlanIpAddress);
            groupBox6.Controls.Add(textBox_VlanDescription);
            groupBox6.Controls.Add(textBox_VlanId);
            groupBox6.Controls.Add(label4);
            groupBox6.Location = new Point(6, 45);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(251, 152);
            groupBox6.TabIndex = 0;
            groupBox6.TabStop = false;
            groupBox6.Text = "Vlan";
            // 
            // btn_ClearVlanField
            // 
            btn_ClearVlanField.Location = new Point(6, 123);
            btn_ClearVlanField.Name = "btn_ClearVlanField";
            btn_ClearVlanField.Size = new Size(239, 23);
            btn_ClearVlanField.TabIndex = 14;
            btn_ClearVlanField.Text = "Show Vlan";
            btn_ClearVlanField.UseVisualStyleBackColor = true;
            btn_ClearVlanField.Click += btn_ClearVlanField_Click;
            // 
            // btn_AddVlan
            // 
            btn_AddVlan.Location = new Point(6, 95);
            btn_AddVlan.Name = "btn_AddVlan";
            btn_AddVlan.Size = new Size(239, 23);
            btn_AddVlan.TabIndex = 13;
            btn_AddVlan.Text = "Add";
            btn_AddVlan.UseVisualStyleBackColor = true;
            btn_AddVlan.Click += btn_AddVlan_Click;
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
            // textBox_VlanIpAddress
            // 
            textBox_VlanIpAddress.Location = new Point(82, 66);
            textBox_VlanIpAddress.Name = "textBox_VlanIpAddress";
            textBox_VlanIpAddress.Size = new Size(163, 23);
            textBox_VlanIpAddress.TabIndex = 10;
            // 
            // textBox_VlanDescription
            // 
            textBox_VlanDescription.Location = new Point(82, 40);
            textBox_VlanDescription.Name = "textBox_VlanDescription";
            textBox_VlanDescription.Size = new Size(163, 23);
            textBox_VlanDescription.TabIndex = 9;
            // 
            // textBox_VlanId
            // 
            textBox_VlanId.Location = new Point(82, 16);
            textBox_VlanId.Name = "textBox_VlanId";
            textBox_VlanId.Size = new Size(163, 23);
            textBox_VlanId.TabIndex = 7;
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
            groupBox3.Controls.Add(btn_AddSNMP);
            groupBox3.Controls.Add(textBox_HostSNMP);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(6, 111);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(264, 49);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Snmp-server";
            // 
            // btn_AddSNMP
            // 
            btn_AddSNMP.Location = new Point(182, 16);
            btn_AddSNMP.Name = "btn_AddSNMP";
            btn_AddSNMP.Size = new Size(75, 23);
            btn_AddSNMP.TabIndex = 6;
            btn_AddSNMP.Text = "Add";
            btn_AddSNMP.UseVisualStyleBackColor = true;
            btn_AddSNMP.Click += btn_AddSNMP_Click;
            // 
            // textBox_HostSNMP
            // 
            textBox_HostSNMP.Location = new Point(47, 16);
            textBox_HostSNMP.Name = "textBox_HostSNMP";
            textBox_HostSNMP.Size = new Size(129, 23);
            textBox_HostSNMP.TabIndex = 3;
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
            groupBox2.Controls.Add(btn_SaveBasicInfo);
            groupBox2.Controls.Add(textBox_NtpServer);
            groupBox2.Controls.Add(label_NtpServer);
            groupBox2.Controls.Add(label_HostName);
            groupBox2.Controls.Add(textBox_HostName);
            groupBox2.Location = new Point(6, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(478, 48);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Basic Info";
            // 
            // btn_SaveBasicInfo
            // 
            btn_SaveBasicInfo.Location = new Point(397, 16);
            btn_SaveBasicInfo.Name = "btn_SaveBasicInfo";
            btn_SaveBasicInfo.Size = new Size(75, 23);
            btn_SaveBasicInfo.TabIndex = 4;
            btn_SaveBasicInfo.Text = "Save";
            btn_SaveBasicInfo.UseVisualStyleBackColor = true;
            btn_SaveBasicInfo.Click += btn_SaveBasicInfo_Click;
            // 
            // textBox_NtpServer
            // 
            textBox_NtpServer.Location = new Point(283, 16);
            textBox_NtpServer.Name = "textBox_NtpServer";
            textBox_NtpServer.Size = new Size(108, 23);
            textBox_NtpServer.TabIndex = 3;
            // 
            // label_NtpServer
            // 
            label_NtpServer.AutoSize = true;
            label_NtpServer.Location = new Point(212, 19);
            label_NtpServer.Name = "label_NtpServer";
            label_NtpServer.Size = new Size(65, 15);
            label_NtpServer.TabIndex = 2;
            label_NtpServer.Text = "Ntp Server:";
            label_NtpServer.TextAlign = ContentAlignment.TopRight;
            // 
            // label_HostName
            // 
            label_HostName.AutoSize = true;
            label_HostName.Location = new Point(6, 19);
            label_HostName.Name = "label_HostName";
            label_HostName.Size = new Size(65, 15);
            label_HostName.TabIndex = 1;
            label_HostName.Text = "Hostname:";
            label_HostName.TextAlign = ContentAlignment.TopRight;
            // 
            // textBox_HostName
            // 
            textBox_HostName.Location = new Point(77, 16);
            textBox_HostName.Name = "textBox_HostName";
            textBox_HostName.Size = new Size(129, 23);
            textBox_HostName.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox_Privilege);
            groupBox1.Controls.Add(btn_AddAccount);
            groupBox1.Controls.Add(textBox_Password);
            groupBox1.Controls.Add(textBox_UserName);
            groupBox1.Location = new Point(6, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(478, 48);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Account";
            // 
            // comboBox_Privilege
            // 
            comboBox_Privilege.FormattingEnabled = true;
            comboBox_Privilege.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" });
            comboBox_Privilege.Location = new Point(294, 16);
            comboBox_Privilege.Name = "comboBox_Privilege";
            comboBox_Privilege.Size = new Size(97, 23);
            comboBox_Privilege.TabIndex = 7;
            comboBox_Privilege.Text = "Privilege";
            // 
            // btn_AddAccount
            // 
            btn_AddAccount.Location = new Point(397, 16);
            btn_AddAccount.Name = "btn_AddAccount";
            btn_AddAccount.Size = new Size(75, 23);
            btn_AddAccount.TabIndex = 5;
            btn_AddAccount.Text = "Add";
            btn_AddAccount.UseVisualStyleBackColor = true;
            btn_AddAccount.Click += btn_AddAccount_Click;
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(148, 16);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.PlaceholderText = "Password";
            textBox_Password.Size = new Size(140, 23);
            textBox_Password.TabIndex = 0;
            // 
            // textBox_UserName
            // 
            textBox_UserName.Location = new Point(6, 17);
            textBox_UserName.Name = "textBox_UserName";
            textBox_UserName.PlaceholderText = "Username";
            textBox_UserName.Size = new Size(136, 23);
            textBox_UserName.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox9);
            panel2.Controls.Add(groupBox8);
            panel2.Location = new Point(6, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(490, 372);
            panel2.TabIndex = 3;
            // 
            // groupBox9
            // 
            groupBox9.Location = new Point(6, 166);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(478, 197);
            groupBox9.TabIndex = 1;
            groupBox9.TabStop = false;
            groupBox9.Text = "ZTE ZXA10 C320";
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(txtSpeedProfile);
            groupBox8.Controls.Add(label11);
            groupBox8.Controls.Add(button1);
            groupBox8.Controls.Add(chkDhcpOption82);
            groupBox8.Controls.Add(label10);
            groupBox8.Controls.Add(txtPosition);
            groupBox8.Controls.Add(txtVlan);
            groupBox8.Controls.Add(label3);
            groupBox8.Controls.Add(txtSerialNumber);
            groupBox8.Controls.Add(label2);
            groupBox8.Location = new Point(6, 3);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(270, 142);
            groupBox8.TabIndex = 0;
            groupBox8.TabStop = false;
            groupBox8.Text = "ZTE-F601";
            // 
            // txtSpeedProfile
            // 
            txtSpeedProfile.Location = new Point(91, 108);
            txtSpeedProfile.Name = "txtSpeedProfile";
            txtSpeedProfile.PlaceholderText = "gpon";
            txtSpeedProfile.Size = new Size(75, 23);
            txtSpeedProfile.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 112);
            label11.Name = "label11";
            label11.Size = new Size(79, 15);
            label11.TabIndex = 9;
            label11.Text = "Speed profile:";
            // 
            // button1
            // 
            button1.Location = new Point(172, 93);
            button1.Name = "button1";
            button1.Size = new Size(91, 38);
            button1.TabIndex = 8;
            button1.Text = "Save to TXT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // chkDhcpOption82
            // 
            chkDhcpOption82.AutoSize = true;
            chkDhcpOption82.CheckAlign = ContentAlignment.BottomCenter;
            chkDhcpOption82.Location = new Point(172, 54);
            chkDhcpOption82.Name = "chkDhcpOption82";
            chkDhcpOption82.Size = new Size(91, 33);
            chkDhcpOption82.TabIndex = 7;
            chkDhcpOption82.Text = "Dhcp-option82";
            chkDhcpOption82.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 79);
            label10.Name = "label10";
            label10.Size = new Size(53, 15);
            label10.TabIndex = 5;
            label10.Text = "Position:";
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(65, 76);
            txtPosition.Name = "txtPosition";
            txtPosition.PlaceholderText = "1/1/1:1";
            txtPosition.Size = new Size(101, 23);
            txtPosition.TabIndex = 4;
            // 
            // txtVlan
            // 
            txtVlan.Location = new Point(45, 50);
            txtVlan.Name = "txtVlan";
            txtVlan.PlaceholderText = "VLAN5";
            txtVlan.Size = new Size(121, 23);
            txtVlan.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 54);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Vlan:";
            // 
            // txtSerialNumber
            // 
            txtSerialNumber.Location = new Point(97, 21);
            txtSerialNumber.Name = "txtSerialNumber";
            txtSerialNumber.Size = new Size(166, 23);
            txtSerialNumber.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 24);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 0;
            label2.Text = "Serial Number:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(panel2);
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
            panel2.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxLogs;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripMenuItem switchToolStripMenuItem;
        private ToolStripMenuItem dCNS420028ToolStripMenuItem;
        private ToolStripMenuItem dCNS420052ToolStripMenuItem;
        private ToolStripMenuItem dCNS460028PToolStripMenuItem;
        private ToolStripMenuItem onuToolStripMenuItem;
        private ToolStripMenuItem zTEF601ToolStripMenuItem;
        private ToolStripMenuItem analizeToolStripMenuItem;
        private Panel panel1;
        private GroupBox groupBox1;
        private TextBox textBox_Password;
        private GroupBox groupBox2;
        private TextBox textBox_NtpServer;
        private Label label_NtpServer;
        private Label label_HostName;
        private TextBox textBox_HostName;
        private Button btn_SaveBasicInfo;
        private TextBox textBox_UserName;
        private Button btn_AddAccount;
        private ComboBox comboBox_Privilege;
        private GroupBox groupBox3;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private Button btn_AddSNMP;
        private TextBox textBox_HostSNMP;
        private Label label1;
        private GroupBox groupBox6;
        private TextBox textBox_VlanIpAddress;
        private TextBox textBox_VlanDescription;
        private TextBox textBox_VlanId;
        private Label label4;
        private Label label6;
        private Label label5;
        private ComboBox comboBox_ActionVlan;
        private Label label7;
        private Button btn_LoadActionVlan;
        private Button btn_ClearVlanField;
        private Button btn_AddVlan;
        private GroupBox groupBox7;
        private ComboBox comboBoxInterface;
        private Button button8;
        private Button btn_InterfaceModify;
        private TextBox textBox_InterfaceDescription;
        private ComboBox comboBox_InterfaceDuplex;
        private Label label9;
        private ComboBox comboBox_InterfaceSpeed;
        private Label label8;
        private Button btn_SaveToTXT;
        private Panel panel2;
        private GroupBox groupBox8;
        private TextBox txtSerialNumber;
        private Label label2;
        private GroupBox groupBox9;
        private TextBox txtVlan;
        private Label label3;
        private Label label10;
        private TextBox txtPosition;
        private CheckBox chkDhcpOption82;
        private Button button1;
        private TextBox txtSpeedProfile;
        private Label label11;
    }
}
