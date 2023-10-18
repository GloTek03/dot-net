namespace WinFormsApp
{
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
            cboSubject.Items.Add("Java");
        }

        public FrmStudent(string text)
        {
            InitializeComponent();
            cboSubject.Items.Add("Java");
            Text = "Hello" + text;
        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Mày có muốn thoát?", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void txtCode_Enter(object sender, EventArgs e)
        {
            txtCode.BackColor = Color.Pink;
        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            txtCode.BackColor = Color.White;
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            txtName.BackColor = Color.Pink;
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            txtName.BackColor = Color.White;
        }

        List<Student> data = new List<Student>();
        Dictionary<string, string> dic = new Dictionary<string, string>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dic.ContainsKey(txtCode.Text))
            {
                MessageBox.Show("Code đã tồn tại");
                return;
            }
            dic.Add(txtCode.Text, txtName.Text);

            Student s = new Student()
            {
                Code = txtCode.Text,
                Name = txtName.Text,
                Subject = cboSubject.SelectedItem.ToString(),
                Mark = (int)numMark.Value
            };
            lstStudent.Items.Add(s);
            data.Add(s);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstStudent.SelectedIndex == -1)//Không chọn
            {
                MessageBox.Show("Mịa, Không chọn thì xóa bằng mắt à?");
                return;
            }

            string item = lstStudent.SelectedItem.ToString();
            string[] s = item.Split("\t");
            int index = lstStudent.SelectedIndex;
            lstStudent.Items.RemoveAt(index);
            data.RemoveAt(index);
            dic.Remove(s[0]);
        }

        private void FrmStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}