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
    public partial class BrandModule : Form
    {
        #region Variables
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        Brand brand;
        #endregion
        #region Contructor
        public BrandModule(Brand br)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            brand = br;
        }
        #endregion 
        #region Close&Save
        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // to insert brand name to brand table 
            try
            {


                if (MessageBox.Show("Are you sure you want to save this brand ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblBrand(brand)VALUES(@brand)", cn);
                    cm.Parameters.AddWithValue("@brand", txtBrand.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully saved.", "POS");
                    Clear();
                    brand.LoadBrand();


                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }
        #endregion
        #region Clear&Cancel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            txtBrand.Clear();


        }
        #endregion
      

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            //Update brand name


            if (MessageBox.Show("Are you sure you want to update this brand ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("UPDATE tblBrand SET brand =@brand WHERE id LIKE '" + lblId.Text + "'", cn);
                cm.Parameters.AddWithValue("@brand", txtBrand.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Brand has been successfully updated.", "POS");
                Clear();
                this.Dispose();//close this form after update data


            }

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BrandModule_Load(object sender, EventArgs e)
        {

        }
    }
}
