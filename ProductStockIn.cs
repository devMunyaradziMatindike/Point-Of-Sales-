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
    public partial class ProductStockIn : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        string stitle = "Point Of Sales";
        SqlDataReader dr;
        StockIn stockIn;
        public ProductStockIn(StockIn stk)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoadProduct();
            stockIn = stk;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void LoadProduct()
        {

            try
            {
                int i = 0;
                dgvProductStockIn.Rows.Clear();
                cm = new SqlCommand("SELECT pcode,pdesc,qty FROM tblProduct WHERE pdesc LIKE  '%" + txtSearch.Text + "%'", cn);
                cn.Open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvProductStockIn.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());

                }
                dr.Close();
                cn.Close();

            }
            catch (Exception ex)
            {


                //     MessageBox.Show(ex.Message);
            }

            void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                string colName = dgvProductStockIn.Columns[e.ColumnIndex].Name;

                if (colName == "Select")


                {

                    if (stockIn.txtStockInBy.Text == string.Empty)
                    {
                        MessageBox.Show("Enter stock In By Name", stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        stockIn.txtStockInBy.Focus();
                        this.Dispose();

                        return;

                    }
                    if (MessageBox.Show("Add this item", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        try
                        {
                            {
                                cn.Open();
                                cm = new SqlCommand("INSERT INTO tbStockIn (refno,pcode,sdate,stockinby,supplierid)VALUES(@refno,@pcode,@sdate,@stockinby,@supplierid) ", cn);
                                cm.Parameters.AddWithValue("@refno", stockIn.txtRefNo.Text);
                                cm.Parameters.AddWithValue("@pcode", dgvProductStockIn.Rows[e.RowIndex].Cells[1].Value.ToString());
                                cm.Parameters.AddWithValue("@sdate", stockIn.dtStockIn.Value);
                                cm.Parameters.AddWithValue("@stockinby", stockIn.txtStockInBy.Text);
                                cm.Parameters.AddWithValue("@supplierid", stockIn.lblId.Text);
                                cm.ExecuteNonQuery();
                                cn.Close();
                                stockIn.LoadStockIn();
                                MessageBox.Show("Product has been added succesfully", stitle,MessageBoxButtons.OK, MessageBoxIcon.Information);


                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, stitle);
                        }

                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void dgvProductStockIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvProductStockIn.Columns[e.ColumnIndex].Name;

            if (colName == "Select")


            {

                if (stockIn.txtStockInBy.Text == string.Empty)
                {
                    MessageBox.Show("Enter stock In By Name", stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    stockIn.txtStockInBy.Focus();
                    this.Dispose();

                    return;

                }
                if (MessageBox.Show("Add this item", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    try
                    {
                        {
                            cn.Open();
                            cm = new SqlCommand("INSERT INTO tbStockIn (refno,pcode,sdate,stockinby,supplierid)VALUES(@refno,@pcode,@sdate,@stockinby,@supplierid) ", cn);
                            cm.Parameters.AddWithValue("@refno", stockIn.txtRefNo.Text);
                            cm.Parameters.AddWithValue("@pcode", dgvProductStockIn.Rows[e.RowIndex].Cells[1].Value.ToString());
                            cm.Parameters.AddWithValue("@sdate", stockIn.dtStockIn.Value);
                            cm.Parameters.AddWithValue("@stockinby", stockIn.txtStockInBy.Text);
                            cm.Parameters.AddWithValue("@supplierid", stockIn.lblId.Text);
                            cm.ExecuteNonQuery();
                            cn.Close();
                            stockIn.LoadStockIn();
                            MessageBox.Show("Product has been added succesfully", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, stitle);
                    }

            }
        }
    }
}
