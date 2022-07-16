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
    public partial class Void : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        CancelOrder cancelOrder;
        public Void(CancelOrder cancel)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            txtUsername.Focus();
            cancelOrder = cancel;
        }

        private void Void_Load(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == cancelOrder.txtCancelledBy.Text)
                {
                    MessageBox.Show("Void by Name and Cancelled by Name are the same, PLEASE REQUEST FOR A VOID ASSISTANT","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;

                }
                cn.Open();
                string user;
                cm = new SqlCommand("SELECT * FROM tblUser WHERE username=@username AND password=@password", cn);
                cm.Parameters.AddWithValue("@username", txtUsername.Text);
                cm.Parameters.AddWithValue("@password", txtPass.Text);
                dr = cm.ExecuteReader();
                //cn.Close();
                dr.Read();
                if (dr.HasRows)
                {
                    user = dr["username"].ToString();
                    SaveCancelOrder(user);
                    if (cancelOrder.cbAddToInventory.Text == "Yes")
                    {
                        dbcon.ExecuteQuery("UPDATE tblProduct SET qty=qty+"+cancelOrder.udCancelQty.Value+"WHERE pcode='"+cancelOrder.txtPCode.Text+"'");
                    }
                    dbcon.ExecuteQuery("UPDATE tblQty SET qty=qty+" + cancelOrder.udCancelQty.Value + "WHERE id LIKE='" + cancelOrder.txtId.Text + "'");
                    MessageBox.Show("VOID SUCCESSFULL!!!", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                    cancelOrder.ReloadList();
                    cancelOrder.Dispose();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dr.Close();
            cn.Close();
        }

        private void SaveCancelOrder(string user)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("INSERT INTO tblCancel (transno,pcode,price,qty,total,sdate,voidby,cancelledby,reason,action) VALUES(@transno,@pcode,@price,@qty,@total,@sdate,@voidby,@cancelledby,@reason,@action)", cn);
                cm.Parameters.AddWithValue("@transno", cancelOrder.txtTransno.Text);
                cm.Parameters.AddWithValue("@pcode", cancelOrder.txtPCode.Text);
                cm.Parameters.AddWithValue("@price", double.Parse(cancelOrder.txtPrice.Text));
                cm.Parameters.AddWithValue("@qty", int.Parse(cancelOrder.txtQty.Text));
                cm.Parameters.AddWithValue("@qty", double.Parse(cancelOrder.txtTotal.Text));
                cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                cm.Parameters.AddWithValue("@voidby", user);
                cm.Parameters.AddWithValue("@cancelledby", cancelOrder.txtCancelledBy.Text);
                cm.Parameters.AddWithValue("@reason", cancelOrder.txtReason.Text);
                cm.Parameters.AddWithValue("@action", cancelOrder.cbAddToInventory.Text);
                cm.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }


        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
