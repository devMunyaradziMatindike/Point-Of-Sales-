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
#endregion Imports
namespace PointOfSales
{
    public partial class Brand : Form
    {
        #region Variables
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        #endregion    
        #region Constructor
        public Brand()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoadBrand();
        }
        #endregion
        #region DataGridView
        private void dgvBrand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //for update & delete Brand by cell click from tblBrand
            string colName = dgvBrand.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this brand ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblBrand WHERE id LIKE '" + dgvBrand[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Brand has been successfully deleted.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (colName == "Edit")
            {

                BrandModule brandModule = new BrandModule(this);
                brandModule.lblId.Text = dgvBrand[1, e.RowIndex].Value.ToString();
                brandModule.txtBrand.Text = dgvBrand[2, e.RowIndex].Value.ToString();
                brandModule.btnSave.Enabled = false;
                brandModule.btnUpdate.Enabled = true;
                brandModule.ShowDialog();



            }
            LoadBrand();
            cn.Close();
        }

        #endregion
        #region LoadBrand
        //Data retrieve from tblBrand to dgvBrand on Brand from
        public void LoadBrand()
        {
            try
            {
                int i = 0;
                dgvBrand.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("SELECT * FROM tblBrand ORDER BY brand", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {

                    i++;
                    dgvBrand.Rows.Add(i, dr["id"].ToString(), dr["brand"].ToString());
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                dr.Close();
              cn.Close();
                MessageBox.Show(ex.Message);
            }


        }
        #endregion
        #region Update
        private void button1_Click(object sender, EventArgs e)
        {
            BrandModule moduleForm = new BrandModule(this);
            moduleForm.ShowDialog();
        }
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BrandModule brandModule = new BrandModule(this);
            brandModule.ShowDialog();
        }
    }
}
