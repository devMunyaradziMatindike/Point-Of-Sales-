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
    public partial class LookUpProduct : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        Cashier cashier;


        public LookUpProduct(Cashier cash)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoadProduct();
            cashier = cash;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void LoadProduct()
        {
            try
            {
                int i = 0;
                dgvLookUp.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("SELECT p.pcode,p.barcode,p.pdesc,b.brand,c.category,p.price,p.qty FROM tblProduct AS p INNER JOIN tblBrand AS b ON b.id = p.bid INNER JOIN tblCategory AS c ON c.id = p.cid WHERE CONCAT (p.pdesc, b.brand,c.category) LIKE '%" + txtSearch.Text + "%'", cn);
               // cm.ExecuteNonQuery();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvLookUp.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());

                }

                dr.Close();
                cn.Close();

            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
            }
            dr.Close();
            cn.Close();

        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string colName = dgvLookUp.Columns[e.ColumnIndex].Name;
                if (colName == "Select")
                {
                    Qty1 qty = new Qty1(cashier);
                    qty.ProductDetails(dgvLookUp.Rows[e.RowIndex].Cells[1].Value.ToString(), double.Parse(dgvLookUp.Rows[e.RowIndex].Cells[6].Value.ToString()), cashier.lblTransNo.Text, int.Parse(dgvLookUp.Rows[e.RowIndex].Cells[7].Value.ToString()));
                    qty.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void LookUpProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }

        private void dgvProduct_AllowUserToAddRowsChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
