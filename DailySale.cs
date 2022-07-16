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
    public partial class DailySale : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        public string solduser;
        public DailySale()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoadCashier();




        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void LoadCashier()
        {

            cboCashier.Items.Clear();
            cboCashier.Items.Add("All Cashier");
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblUser WHERE role LIKE 'Cashier'", cn);
            dr = cm.ExecuteReader();

            while (dr.Read())
            {
                cboCashier.Items.Add(dr["username"].ToString());
            }
            dr.Close();
            cn.Close();
        }
        public void LoadSold()
        {
            try
            {

                int i = 0; double total = 0;
                dgvSoldItems.Rows.Clear();
                cn.Open();
                if (cboCashier.Text == "All Cashier")
                {
                    cm = new SqlCommand("SELECT c.id,c.transno,c.pcode,p.pdesc,c.price,c.qty,c.disc,c.total FROM tbCart AS c INNER JOIN tblProduct AS p ON c.pcode=p.pcode WHERE STATUS LIKE 'Sold' AND sdate BETWEEN  '" + dtFrom.Value.ToString("yyyyMMdd") + "' AND '" + dtTo.Value.ToString("yyyyMMdd") + "'", cn);
                }
                else
                {
                    cm = new SqlCommand("SELECT c.id,c.transno,c.pcode,p.pdesc,c.price,c.qty,c.disc,c.total FROM tbCart AS c INNER JOIN tblProduct AS p ON c.pcode=p.pcode WHERE STATUS LIKE 'Sold' AND sdate BETWEEN  '" + dtFrom.Value.ToString("yyyyMMdd") + "' AND '" + dtTo.Value.ToString("yyyyMMdd") + "' AND cashier LIKE '" + cboCashier.Text + "'", cn);

                }
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    total += double.Parse(dr["total"].ToString());
                    dgvSoldItems.Rows.Add(i, dr["id"].ToString(), dr["transno"].ToString(), dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["disc"].ToString(), dr["total"].ToString(), cn);
                }
                dr.Close();
                cn.Close();
                lblTotal.Text = total.ToString("#,##0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboCashier_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSold();
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            LoadSold();

        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            LoadSold();

        }

        private void DailySale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void dgvSoldItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string colName = dgvSoldItems.Columns[e.ColumnIndex].Name;
                if (colName == "Cancel")
                {
                    CancelOrder cancelOrder = new CancelOrder(this);
                    cancelOrder.txtId.Text = dgvSoldItems.Rows[e.RowIndex].Cells[0].Value.ToString();
                    cancelOrder.txtTransno.Text = dgvSoldItems.Rows[e.RowIndex].Cells[1].Value.ToString();
                    cancelOrder.txtPCode.Text = dgvSoldItems.Rows[e.RowIndex].Cells[2].Value.ToString();
                    cancelOrder.txtDescription.Text = dgvSoldItems.Rows[e.RowIndex].Cells[3].Value.ToString();
                    cancelOrder.txtPrice.Text = dgvSoldItems.Rows[e.RowIndex].Cells[4].Value.ToString();
                    cancelOrder.txtQty.Text = dgvSoldItems.Rows[e.RowIndex].Cells[5].Value.ToString();
                    cancelOrder.txtDisc.Text = dgvSoldItems.Rows[e.RowIndex].Cells[6].Value.ToString();
                    cancelOrder.txtTotal.Text = dgvSoldItems.Rows[e.RowIndex].Cells[7].Value.ToString();
                    cancelOrder.txtCancelledBy.Text = solduser;
                    cancelOrder.ShowDialog();



                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {

         
        }
    }
}
