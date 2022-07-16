        using System.Xml.Linq;
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
    public partial class LogIn : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        string _pass = "";
        public bool _isactive;
        public LogIn()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {


        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string _username = "", _name = "", _role = "";
            try
            {
                bool found;
                cn.Open();
                cm=new SqlCommand("SELECT * FROM tblUser WHERE username=@username AND password=@password",cn);
                cm.Parameters.AddWithValue("@username",txtName.Text);
                cm.Parameters.AddWithValue("@password",txtPass.Text);
                dr=cm.ExecuteReader();
               //cn.Close();
                    dr.Read();
                if (dr.HasRows)
                {

                    found=true;
                    _username=dr["username"].ToString();
                    _name=dr["name"].ToString();
                    _role=dr["role"].ToString();
                    _pass=dr["password"].ToString();
                    _isactive=bool.Parse(dr["isactive"].ToString());
                }
                else
                {
                    found=false;
                }

                if (found)
                {


                    if (!_isactive)
                    {

                        MessageBox.Show("Account is unactive, Unable to Log In", "Inactive Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return;
                    }
                    if (_role == "Cashier")
                    {
                        MessageBox.Show("Welcome "+_name+ "|", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtName.Clear();
                        txtPass.Clear();
                        this.Hide();
                        Cashier cashier=new Cashier();
                        cashier.lblUsername.Text = _username;
                        cashier.labelNames.Text = _name + " " + _role;
                        cashier.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Welcome " + _name + "|", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtName.Clear();
                        txtPass.Clear();
                        this.Hide();
                        MainForm mainForm=new MainForm();
                        mainForm.lblUser.Text = _username;
                        mainForm.lblRole.Text = _name;
                        mainForm.ShowDialog();

                    }
                }
                dr.Close();cn.Close();
                
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

     

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        
        


    }


}
