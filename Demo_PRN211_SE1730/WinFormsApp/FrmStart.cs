using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class FrmStart : Form
    {
        public FrmStart()
        {
            InitializeComponent();
        }

        int n = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            n--;
            if (n==0)
            {
                timer1.Stop();

                //Di chuyển sang FrmStudent
                FrmStudent f=new FrmStudent(txtName.Text);
                f.Show();
                this.Hide();
            }
            lblStart.Text = n.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
