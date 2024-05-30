namespace NetworkSetup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // ������������ ������������ �����
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Գ������� �����
            this.MaximizeBox = false; // ��������� ������ �����������

            // ������������ ���������� �� ������������� ������, ��� ������� ����� ����������
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
    }
}
