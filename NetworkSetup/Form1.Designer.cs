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
            groupBox1 = new GroupBox();
            label1 = new Label();
            textBox1 = new TextBox();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
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
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(12, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 372);
            panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(478, 56);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "s";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 1;
            label1.Text = "Choose Hostname:";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(120, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(108, 23);
            textBox1.TabIndex = 0;
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
        private Label label1;
        private TextBox textBox1;
    }
}
