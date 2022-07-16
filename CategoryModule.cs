
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
    public partial class CategoryModule : Form
    {
        #region Variables&Constructor
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        Category category;
        public CategoryModule(Category ct)
        {
            InitializeComponent();
              cn=new SqlConnection(dbcon.myConnection());
            category = ct;
        }

        #endregion
        #region Clear&Save
        public void Clear()
        {

            txtCategory.Clear();
            txtCategory.Focus();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            // to insert category name to brand table 
            try
            {


                if (MessageBox.Show("Are you sure you want to save this category ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblCategory(category)VALUES(@category)", cn);
                    cm.Parameters.AddWithValue("@category", txtCategory.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully saved.", "Point Of Sales");
                   Clear();
                 


                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
        #endregion
        #region Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Update category name


            if (MessageBox.Show("Are you sure you want to update this category ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("UPDATE tblCategory SET category =@category WHERE id LIKE '" + lblId.Text + "'", cn);
                cm.Parameters.AddWithValue("@category", txtCategory.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Category has been successfully updated.", "Point Of Sales");
                Clear();
                this.Dispose();//close this form after update data


            }
            category.LoadCategory();
           
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion

        private void CategoryModule_Load(object sender, EventArgs e)
        {

        }
    }
}
