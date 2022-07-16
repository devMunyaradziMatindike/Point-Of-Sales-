
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

    #region Variables/Constructor/Load Supplier
    public partial class Supplier : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        public Supplier()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoadSupplier();
        }

        public void LoadSupplier()
        {
            try
            {
                int i = 0;
                dgvSupplier.Rows.Clear();
                cm = new SqlCommand("SELECT * FROM tblSupplier", cn);
                cn.Open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvSupplier.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());

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
        #region Update/DataGridView
        private void button1_Click(object sender, EventArgs e)
        {
            SupplierModule supplierModule = new SupplierModule(this);
            supplierModule.ShowDialog();
        }

        private void dgvSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvSupplier.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                SupplierModule supplierModule = new SupplierModule(this);
                supplierModule.lblId.Text = dgvSupplier.Rows[e.RowIndex].Cells[1].Value.ToString();
                supplierModule.txtSupplier.Text = dgvSupplier.Rows[e.RowIndex].Cells[2].Value.ToString();
                supplierModule.txtAddress.Text = dgvSupplier.Rows[e.RowIndex].Cells[3].Value.ToString();
                supplierModule.txtConPerson.Text = dgvSupplier.Rows[e.RowIndex].Cells[4].Value.ToString();
                supplierModule.txtPhone.Text = dgvSupplier.Rows[e.RowIndex].Cells[5].Value.ToString();
                supplierModule.txtFaxNo.Text = dgvSupplier.Rows[e.RowIndex].Cells[6].Value.ToString();
                supplierModule.txtEmail.Text = dgvSupplier.Rows[e.RowIndex].Cells[7].Value.ToString();

                supplierModule.btnSave.Enabled = false;
                supplierModule.btnUpdate.Enabled = true;
                supplierModule.ShowDialog();


            }
            if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want delete this supplier ?", "CONFRIM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblSupplier WHERE id LIKE '" + dgvSupplier[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Supplier has been successfully deleted.", "Point Of Sales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            cn.Close();
            LoadSupplier();
        }
        #endregion 
    }

}
