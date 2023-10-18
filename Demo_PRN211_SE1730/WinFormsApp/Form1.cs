namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAsa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ohayou gozaimasu!","Alert",MessageBoxButtons.OKCancel);
        }

        private void btnHiru_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Konichiwa!","Alert",MessageBoxButtons.YesNo);
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Konbanwa!");
        }
    }
}