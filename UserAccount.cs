using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSales
{
    public partial class UserAccount : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        string stitle = "Point Of Sales";
        public UserAccount()
        {
            InitializeComponent();
            cn=new SqlConnection(dbcon.myConnection());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvBrand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          

        }

        public void Clear()
        {
            txtName.Clear();
            txtPass.Clear();
            txtRePass.Clear();
            txtUsername.Clear();
            cbRole.Text="";
            txtUsername.Focus();



        }

        private void UserAccount_Load(object sender, EventArgs e)
        {

        }

        private void btnAccSave_Click(object sender, EventArgs e)
        {
            try
            {

                {

                    if (txtPass != txtRePass)
                    {
                        MessageBox.Show("Passwords do not match.","Save Record.",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblUser(username,password,role,name)VALUES(@username,@password,@role,@name)", cn);
                    cm.Parameters.AddWithValue("@username", txtUsername.Text);
                    cm.Parameters.AddWithValue("@password",txtPass.Text);
                    cm.Parameters.AddWithValue("@role", cbRole.Text);
                    cm.Parameters.AddWithValue("@name", txtName.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("New Account has been succesfully saved.","Save Record",MessageBoxButtons.OK ,MessageBoxIcon.Information);
                    Clear();
                 
                }

            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);

            }
        }

        private void btnAccCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
