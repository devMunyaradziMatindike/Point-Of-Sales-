#region Imports
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
#endregion

namespace PointOfSales
{
    public partial class SupplierModule : Form
    {
        #region Variables/Clear/Save
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        string stitle = "Point Of Sales";
        Supplier supplier;
        public SupplierModule(Supplier sp)
        {
            InitializeComponent();
            cn=new SqlConnection(dbcon.myConnection());
            supplier = sp;
        }

              private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void Clear()
        {


            txtAddress.Clear();
            txtConPerson.Clear();
            txtEmail.Clear();
            txtFaxNo.Clear();
            txtPhone.Clear();
            txtSupplier.Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            txtSupplier.Focus();


        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are you sure you want to save this supplier ?", "CONFRIM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tblSupplier(supplier,address,contactperson,phone,email,fax)VALUES(@supplier,@address,@contactperson,@phone,@email,@fax)", cn);
                    cm.Parameters.AddWithValue("@supplier",txtSupplier.Text);
                    cm.Parameters.AddWithValue("@address",txtAddress.Text);
                    cm.Parameters.AddWithValue("@contactperson", txtConPerson.Text);
                    cm.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cm.Parameters.AddWithValue("@email", txtEmail.Text);
                    cm.Parameters.AddWithValue("@fax", txtFaxNo.Text);
                    cn.Open();
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Supplier has been successfully saved.", stitle);
                    Clear();
                   supplier.LoadSupplier();
                }

               



            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);

            }

        }
        #endregion
        #region Cancel/Update
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try {
                if (MessageBox.Show("Are you sure you want to save this supplier ?", "CONFRIM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblSupplier SET supplier=@supplier,address=@address,contactperson=@contactperson,phone=@phone,email=@email,fax=@fax ",cn);
                    cm.Parameters.AddWithValue("@id", lblId.Text);
                    cm.Parameters.AddWithValue("@supplier", txtSupplier.Text);
                    cm.Parameters.AddWithValue("@address", txtAddress.Text);
                    cm.Parameters.AddWithValue("@contactperson", txtConPerson.Text);
                    cm.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cm.Parameters.AddWithValue("@email", txtEmail.Text);
                    cm.Parameters.AddWithValue("@fax", txtFaxNo.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                     MessageBox.Show("Supplier has been successfully updated.", "Update Record");
                    this.Dispose();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void SupplierModule_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }
    }
}
