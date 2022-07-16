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
    public partial class CancelOrder : Form
    {
       DailySale dailySale=new DailySale();
        public CancelOrder(DailySale daily)
        {
            InitializeComponent();
            dailySale=daily;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbAddToInventory.Text != string.Empty && udCancelQty.Value > 0 && txtReason.Text != string.Empty)
                {
                    if (int.Parse(txtQty.Text) >= udCancelQty.Value)
                    {
                        Void @void = new Void(this);
                        @void.txtUsername.Focus();
                        @void.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        public void ReloadList()
        {
            dailySale.LoadSold();
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void CancelOrder_Load(object sender, EventArgs e)
        {

        }

        private void cbAddToInventory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
