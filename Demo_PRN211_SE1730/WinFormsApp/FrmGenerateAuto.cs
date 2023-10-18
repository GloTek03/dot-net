using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp
{
    public partial class FrmGenerateAuto : Form
    {
        public FrmGenerateAuto()
        {
            InitializeComponent();
        }

        int n;
        List<TextBox> lstText = new List<TextBox>();
        private void btnCreateText_Click(object sender, EventArgs e)
        {
            //Nơi sẽ viết code để tạo text
            n = (int)numText.Value;
            for (int i = 0; i < n; i++)
            {
                Label lbl = new Label();
                lbl.Text = "Enter text " + (i + 1) + ":";
                lbl.Location = new System.Drawing.Point(42, 150 + i * 70);
                lbl.Size = new System.Drawing.Size(200, 30);

                TextBox txt = new TextBox();
                txt.Location = new System.Drawing.Point(300, 150 + i * 70);
                txt.Size = new System.Drawing.Size(300, 30);
                lstText.Add(txt);
                txt.TextChanged += Txt_TextChanged;

                this.Controls.Add(lbl);
                this.Controls.Add(txt);
            }
            btnAddCheck.Enabled = true;
        }

        private void Txt_TextChanged(object? sender, EventArgs e)
        {
            //Viết xử lý
            //cứ text nào thay đổi thì text của checkbox thay đổi theo

        }

        private void numText_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCheck_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                CheckBox chk = new CheckBox();
                chk.Location = new System.Drawing.Point(650, 155 + i * 70);
                chk.Size = new System.Drawing.Size(200, 30);
                chk.Text = lstText[i].Text;
                chk.CheckedChanged += Chk_CheckedChanged;
                this.Controls.Add(chk);
            }
        }

        private void Chk_CheckedChanged(object? sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            String status = chk.Checked ? " checked" : " uncheck";
            MessageBox.Show("Checkbox " + chk.Text + status);
        }
    }
}
