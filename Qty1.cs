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
    public partial class Qty1 : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        private string pcode;
        private double price;
        private String transno;
        private int qty;
        Cashier cashier;
       public Qty1(Cashier cash)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            cashier = cash;
        }

        public void ProductDetails(string pcode, double price, string transno, int qty)
        {
            this.pcode = pcode;
            this.price = price;
            this.transno = transno;
            this.qty = qty;

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQty1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar == 13) && (txtQty1.Text != string.Empty))
            {




                try
                {
                    string id = "";
                    int cart_qty = 0;
                    bool found = false;
                    cn.Open();
                    cm = new SqlCommand("SELECT * FROM tbCart WHERE transno=@transno AND pcode=@pcode", cn);
                    cm.Parameters.AddWithValue("@transno", transno);
                    cm.Parameters.AddWithValue("@pcode", pcode);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {

                        id = dr["id"].ToString();
                        cart_qty = int.Parse(dr["qty"].ToString());
                        found = true;

                    }

                    else found = false;
                    
                    dr.Close();
                    cn.Close();

                    if (found)
                    {
                        if (qty < (int.Parse(txtQty1.Text) + cart_qty))
                        {



                            MessageBox.Show("Unable to proceed,Remaining quantity on hand is " + qty, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        cn.Open();
                        cm = new SqlCommand("UPDATE tbCart SET qty=(qty+" + int.Parse(txtQty1.Text) + ") WHERE id='" + id + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        cashier.txtBarcode.Clear();
                        cashier.txtBarcode.Focus();
                        cashier.LoadCart();
                        this.Dispose();

                    }
                    else
                    {



                        if (qty < (int.Parse(txtQty1.Text) + cart_qty))
                        {



                            MessageBox.Show("Unable to proceed,Remaining quantity on hand is " + qty, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        cn.Open();
                        cm = new SqlCommand("INSERT INTO tbCart(transno,pcode,price,qty,sdate,cashier)VALUES (@transno,@pcode,@price,@qty,@sdate,@cashier)",cn);
                        cm.Parameters.AddWithValue("@transno", transno);
                        cm.Parameters.AddWithValue("@pcode", pcode);
                        cm.Parameters.AddWithValue("@price", price);
                        cm.Parameters.AddWithValue("@qty", int.Parse(txtQty1.Text));
                        cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                        cm.Parameters.AddWithValue("@cashier", cashier.lblUsername.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        cashier.txtBarcode.Clear();
                        cashier.txtBarcode.Focus();
                        cashier.LoadCart();
                        this.Dispose();
                        

                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }
    }
}
