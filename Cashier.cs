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
    public partial class Cashier : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;

        int qty;
        string price;
        string id;

        public Cashier()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            getTransNo();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void picClose_Click(object sender, EventArgs e)
        {
            //this.Dispose();
            if (MessageBox.Show(" Exit the application ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Application.Exit();

            }
        }

        public void slide(Button button)
        {
            panelSlide.BackColor = Color.White;
            panelSlide.Height = button.Height;
            panelSlide.Top = button.Top;

        }

        #region button
        private void btTransaction_Click(object sender, EventArgs e)
        {
            slide(btTransaction);
            getTransNo();
        }

        private void btnSerach_Click(object sender, EventArgs e)
        {

            slide(btnSearch);
            LookUpProduct lookUp = new LookUpProduct(this);
            lookUp.LoadProduct();
            lookUp.ShowDialog();
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            slide(btnDiscount);
            Discount discount = new Discount(this);
            discount.lblId.Text = id;
            discount.txtTotalPrice.Text = price;
            discount.ShowDialog();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            slide(btnClear);
            if (MessageBox.Show(" Remove all items from cart ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("DELETE FROM tbCart WHERE transno LIKE'" + lblTransNo.Text + "'", cn);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("All products have been saved succesfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCart();

            }
        }

        private void btnDSales_Click(object sender, EventArgs e)
        {
            slide(btnDSales);
            DailySale dailySale = new DailySale();
            dailySale.solduser=lblUsername.Text;
            dailySale.ShowDialog();
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            slide(btnPass);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            slide(btnLogout);
            if (dgvCash.Rows.Count > 0)
            {
                MessageBox.Show("Unable to LogOut ,please cancel transcation!", "Warning ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (MessageBox.Show("LogOut Application !", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.Hide();
                LogIn login = new LogIn();
                login.ShowDialog();
            }

        }

        private void panelSlide_Paint(object sender, PaintEventArgs e)
        {
            // slide(this);
        }

        private void btnSettle_Click(object sender, EventArgs e)
        {
            slide(btnSettle);
            Settle settle = new Settle(this);
            settle.txtSale.Text = lblDisplayTotal.Text;
            settle.ShowDialog();
        }

        #endregion 

        public void LoadCart()
        {
            try
            {
                Boolean hascart = false;
                int i = 0;
                double total = 0;
                double discount = 0;
                dgvCash.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("SELECT c.id,c.pcode,p.pdesc,c.price,c.qty,c.disc,c.total FROM tbCart AS c INNER JOIN tblProduct AS p ON c.pcode=p.pcode WHERE c.transno LIKE @transno AND c.status LIKE 'Pending'", cn);
                cm.Parameters.AddWithValue("@transno", lblTransNo.Text);
                cm.ExecuteNonQuery();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    total += Convert.ToDouble(dr["total"].ToString());
                    discount += Convert.ToDouble(dr["disc"].ToString());
                    i++;
                    dgvCash.Rows.Add(i, dr["id"].ToString(), dr["pcode"].ToString(), dr["pdesc"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["disc"].ToString(), double.Parse(dr["total"].ToString()).ToString("#,##0.00"));
                    hascart = true;
                }

                lblSalesTotal.Text = total.ToString("#,##0.00");
                lblDiscount.Text = discount.ToString("#,##0.00");
                getCartTotal();
                if (hascart) { btnClear.Enabled = true; btnSettle.Enabled = true; btnDiscount.Enabled = true; }
                else { btnClear.Enabled = false; btnSettle.Enabled = false; btnDiscount.Enabled = false; }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            dr.Close();
            cn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCash.Columns[e.ColumnIndex].Name;

            if (colName == "Delete")
            {
                if (MessageBox.Show(" Remove this item ?", "Remove Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbcon.ExecuteQuery("DELETE FROM tbCart WHERE id LIKE'" + dgvCash.Rows[e.RowIndex].Cells[1].ToString() + "'");
                    MessageBox.Show("Item has been succesfully removed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCart();

                }
            }
            else if (colName == "colAdd")
            {
                int i = 0;
                cn.Open();
                cm = new SqlCommand("SELECT SUM(qty) as qty FROM tblProduct WHERE pcode LIKE '" + dgvCash.Rows[e.RowIndex].Cells[2].Value.ToString() + "' GROUP BY pcode ", cn);
                i = int.Parse(cm.ExecuteScalar().ToString());

                cn.Close();

                if (int.Parse(dgvCash.Rows[e.RowIndex].Cells[5].Value.ToString()) < i)
                {

                    dbcon.ExecuteQuery("UPDATE tbCart SET qty=qty+" + int.Parse(txtQty.Text) + "WHERE transno LIKE '" + lblTransNo.Text + "' AND pcode LIKE '" + dgvCash.Rows[e.RowIndex].Cells[2].Value.ToString() + "'");
                    LoadCart();
                }
                else
                {
                    MessageBox.Show(" Remaining on hand is" + i + "!", "Out Of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


            }
            else if (colName == "colReduce")
            {
                int i = 0;
                cn.Open();
                cm = new SqlCommand("SELECT SUM(qty) as qty FROM tblProduct WHERE pcode LIKE '" + dgvCash.Rows[e.RowIndex].Cells[2].Value.ToString() + "' GROUP BY pcode ", cn);
                i = int.Parse(cm.ExecuteScalar().ToString());
                if (i > 1)
                {
                    dbcon.ExecuteQuery("UPDATE tbCart SET qty=qty-" + int.Parse(txtQty.Text) + "WHERE transno LIKE '" + lblTransNo.Text + "' AND pcode LIKE '" + dgvCash.Rows[e.RowIndex].Cells[2].Value.ToString() + "'");
                    cn.Close();

                    LoadCart();
                    cn.Close();

                }

                else
                {
                    MessageBox.Show(" Remaining on hand is" + i + "!", "Out Of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            cn.Close();

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void lblTimer_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        public void getCartTotal()
        {
            double discount = double.Parse(lblDiscount.Text);
            double sales = double.Parse(lblSalesTotal.Text) - discount;
            double VAT = sales * 0.145;//VAT Rate As per ZIMRA Requirements
            double vatable = sales + VAT;

            lblVat.Text = VAT.ToString("#,##0.00");
            lblVatable.Text = vatable.ToString("#,##0.00");
            lblDisplayTotal.Text = vatable.ToString("#,##0.00");




        }

        public void getTransNo()
        {
            try
            {
                string sdate = DateTime.Now.ToString("yyyyMMddss");
                string transno;
                int count;
                cn.Open();
                cm = new SqlCommand("SELECT TOP 1 transno FROM tbCart WHERE transno LIKE '" + sdate + "%'ORDER BY id desc", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    transno = dr[0].ToString();
                    count = int.Parse(transno.Substring(8, 4));
                    lblTransNo.Text = sdate + (count + 1);

                }
                else
                {

                    transno = sdate + "1001";
                    lblTransNo.Text = transno;
                }

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Point Of Sales");
            }
            dr.Close();
            cn.Close();
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (txtBarcode.Text == string.Empty) return;
                else
                {
                    string _pcode;
                    double _price;
                    int _qty;
                    cn.Open();
                    cm = new SqlCommand("SELECT * FROM tblProduct WHERE barcode LIKE '" + txtBarcode.Text + "'", cn);
                    dr = cm.ExecuteReader();
                    cn.Close();

                    if (dr.HasRows)
                    {

                        qty = int.Parse(dr["qty"].ToString());
                        _pcode = dr["pcode"].ToString();
                        _price = double.Parse(dr["price"].ToString());
                        _qty = int.Parse(txtQty.Text);

                        dr.Close();
                        cn.Close();
                        AddToCart(_pcode, _price, _qty);


                    }
                    dr.Close();
                    cn.Close();
                }




            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Point Of Sales", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void AddToCart(string _pcode, double _price, int _qty)
        {
            try
            {
                string id = "";
                int cart_qty = 0;
                bool found = false;
                cn.Open();
                cm = new SqlCommand("SELECT * FROM tblCart WHERE transno=@transno AND pcode=@pcode", cn);
                cm.Parameters.AddWithValue("@transno", lblTransNo.Text);
                cm.Parameters.AddWithValue("@pcode", _pcode);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {

                    id = dr["id"].ToString();
                    cart_qty = int.Parse(dr["qty"].ToString());
                    found = true;
                    AddToCart(_pcode, _price, _qty);

                }

                else found = false;
                dr.Close();
                cn.Close();

                if (found)
                {
                    if (qty < (int.Parse(txtQty.Text) + cart_qty))
                    {



                        MessageBox.Show("Unable to proceed,Remaining quantity on hand is " + qty, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    cn.Open();
                    cm = new SqlCommand("UPDATE tblCart SET qty=(qty+" + qty + ") WHERE id='" + id + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    txtBarcode.SelectionStart = 0;
                    txtBarcode.SelectionLength = txtBarcode.Text.Length;
                    LoadCart();


                }
                else
                {



                    if (qty < (int.Parse(txtQty.Text) + cart_qty))
                    {



                        MessageBox.Show("Unable to proceed,Remaining quantity on hand is " + qty, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tbCart(transno,pcode,price,qty,sdate,cashier)VALUES (@transno,@pcode,@price,@qty,@sdate,@cashier)");
                    cm.Parameters.AddWithValue("@transno", lblTransNo.Text);
                    cm.Parameters.AddWithValue("@pcode", _pcode);
                    cm.Parameters.AddWithValue("@price", _price);
                    cm.Parameters.AddWithValue("@qty", _qty);
                    cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                    cm.Parameters.AddWithValue("@cashier", lblUsername.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    LoadCart();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvCash_SelectionChanged(object sender, EventArgs e)
        {
            int i = dgvCash.CurrentRow.Index;
            id = dgvCash[1, i].Value.ToString();
            price = dgvCash[7, i].Value.ToString();

        }

        private void lblSalesTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
