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
    public partial class Product : Form
    {
        #region Variables&Constructor
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        public Product()
        {
            InitializeComponent();
            cn=new SqlConnection(dbcon.myConnection());
            LoadProduct();
        }


        #endregion
        #region DataGridView

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvProduct.Columns[e.ColumnIndex].Name;
            if(colName == "Edit")
            {

                ProductModule product = new ProductModule(this);
                product.txtPCode.Text =dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                product.txtBarcode.Text =dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                product.txtPdesc.Text =dgvProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                product.cboBrand.Text =dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                product.cboCategory.Text =dgvProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
                product.txtPrice.Text =dgvProduct.Rows[e.RowIndex].Cells[6].Value.ToString();
                product.UDReOrder.Value =int.Parse(dgvProduct.Rows[e.RowIndex].Cells[7].Value.ToString());

                product.txtPCode.Enabled = false;
                product.btnSave.Enabled = false;
                product.btnUpdate.Enabled = true;
                product.ShowDialog();

               

            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this product ?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblProduct WHERE pcode LIKE '" + dgvProduct[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Product has been successfully deleted.", "Point Of Sales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            LoadProduct();
        }
        #endregion
        #region LoadProduct/Update
        public void LoadProduct()
        {
            try
            {
                int i = 0;
                dgvProduct.Rows.Clear();
                cm = new SqlCommand("SELECT p.pcode,p.barcode,p.pdesc,b.brand,c.category,p.price,p.reorder FROM tblProduct AS p INNER JOIN tblBrand AS b ON b.id = p.bid INNER JOIN tblCategory AS c ON c.id = p.cid WHERE CONCAT (p.pdesc, b.brand,c.category) LIKE '%"+txtSearch.Text+"%'", cn);
                cn.Open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvProduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());

                }
                dr.Close();
                cn.Close();


            }
            catch (Exception ex)
            {


           //     MessageBox.Show(ex.Message);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductModule productModule = new ProductModule(this);
            productModule .ShowDialog();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }
        #endregion

        private void btnAdd_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
