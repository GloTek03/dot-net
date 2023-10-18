using Microsoft.Data.SqlClient;
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
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }

        DataProvider d = new DataProvider();
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void LoadCustomer()
        {
            List<Customer> data = new List<Customer>();
            using (IDataReader dr = d.executeQuery2("select * from Customers"))
            {
                while (dr.Read())
                {
                    string id = dr.GetInt32(0).ToString();
                    string name = dr.GetString(1).ToString();
                    string birthdate = dr.GetDateTime(2).ToString().Substring(0, 10);
                    string gender = "Male";
                    if (!dr.GetBoolean(3))
                        gender = "Female";
                    string address = dr.GetString(4).ToString();
                    Customer c = new Customer(id, name, birthdate, gender, address);
                    data.Add(c);
                }
            }
            dgCustomer.DataSource = data;
        }

        private void dgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text = dgCustomer.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txt_name.Text = dgCustomer.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txt_birth.Text = dgCustomer.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            txt_address.Text = dgCustomer.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();

            if (dgCustomer.Rows[e.RowIndex].Cells[3].FormattedValue.ToString().Equals("Male"))
            {
                radio_M.Checked = true;
            }
            else
            {
                radio_Fe.Checked = true;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string strSQL = "delete from Customers where CustomerID=@id";
                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                new SqlParameter("@id",txt_ID.Text)
                };
                if (d.executeNonQuery(strSQL, sqlParameters))
                {
                    MessageBox.Show("Delete success");
                    LoadCustomer();
                }
                else
                {
                    MessageBox.Show("Please choose a Customer");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete error:" + ex.Message);
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                string strSQL = "insert into Customers(CustomerName,Birthdate,Gender,Address) " +
                    "values(@name,@birthdate,@gender,@address)";
                string gender = "true";
                if (radio_Fe.Checked)
                {
                    gender = "false";
                }
                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                new SqlParameter("@name",txt_name.Text),
                new SqlParameter("@birthdate",Convert.ToDateTime(txt_birth.Text)),
                new SqlParameter("@gender",gender),
                new SqlParameter("@address",txt_address.Text)
                };
                if (d.executeNonQuery(strSQL, sqlParameters))
                {
                    MessageBox.Show("Add success");
                    LoadCustomer();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add error:" + ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                string strSQL = "update Customers "+
                    "set CustomerName=@name, Birthdate =@birthdate, Gender =@gender, Address=@address "+
                    "where CustomerId = @id";
                string strSQL1 = "select count(*) from Customers where CustomerId = @id";
                string gender = "true";
                if (radio_Fe.Checked)
                {
                    gender = "false";
                }
                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                new SqlParameter("@id",txt_ID.Text),
                new SqlParameter("@name",txt_name.Text),
                new SqlParameter("@birthdate",Convert.ToDateTime(txt_birth.Text)),
                new SqlParameter("@gender",gender),
                new SqlParameter("@address",txt_address.Text)
                };
                if (d.executeNonQuery(strSQL, sqlParameters))
                {
                    MessageBox.Show("Update success");
                    LoadCustomer();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update error:" + ex.Message);
            }
        }
    }
}
