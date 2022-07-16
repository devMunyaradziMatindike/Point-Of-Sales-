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
    public partial class Category : Form
    {
        #region Variables
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
         SqlDataReader dr;


        #endregion
        #region Constructor
        public Category()
        {
            InitializeComponent();
              cn=new SqlConnection(dbcon.myConnection());
            LoadCategory();
        }
        #endregion
        #region LoadCategory
        //Data retrieve from tblCategory to dgvCategory on Brand from
        public void LoadCategory()
        {
            try
            {

                int i = 0;
                dgvCategory.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("SELECT * FROM tblCategory ORDER BY category", cn);
                dr = cm.ExecuteReader();

                while (dr.Read())
                {

                    i++;
                    dgvCategory.Rows.Add(i, dr["id"].ToString(), dr["category"].ToString());
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
        #endregion
        #region Update
        private void button1_Click(object sender, EventArgs e)
        {
            CategoryModule module = new CategoryModule(this);
            module.ShowDialog();
        }

        #endregion
        #region DataGridView
        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCategory.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this brand ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblCategory WHERE id LIKE '" + dgvCategory[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Category has been successfully deleted.", "Point Of Sales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (colName == "Edit")
            {

                CategoryModule categoryModule = new CategoryModule(this);
                categoryModule .lblId.Text = dgvCategory[1, e.RowIndex].Value.ToString();
               categoryModule.txtCategory.Text = dgvCategory[2, e.RowIndex].Value.ToString();
                categoryModule.btnSave.Enabled = false;
                categoryModule .btnUpdate.Enabled = true;
                categoryModule .ShowDialog();



            }
            cn.Close();
             LoadCategory();
        }
        #endregion
    }
}
