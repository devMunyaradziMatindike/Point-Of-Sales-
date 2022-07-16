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
    public partial class ProductModule : Form
    {


        #region Variables&Constructor
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        string stitle = "Point Of Sales";
        Product product;
        public ProductModule(Product pd)
        {
            InitializeComponent();
            cn=new SqlConnection(dbcon.myConnection());
            product = pd;
            LoadBrand();
            LoadCategory();
        }

        #endregion
        #region LoadCategory/LoadBrand/Close/Clear
        public void LoadCategory()
        {
            cboCategory.Items.Clear();
            cboCategory.DataSource = dbcon.getTable("SELECT * FROM tblCategory");
            cboCategory.DisplayMember = "category";
            cboCategory.ValueMember = "id";
        }

        public void LoadBrand()
        {
            cboBrand.Items.Clear();
            cboBrand.DataSource=dbcon.getTable("SELECT * FROM tblBrand");
            cboBrand.DisplayMember = "brand";
            cboBrand.ValueMember = "id";



        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void Clear()
        {

            txtPCode.Clear();
            txtBarcode.Clear();
            txtPdesc.Clear();
            txtPrice.Clear();
            cboBrand.SelectedIndex = 0;
            cboCategory.SelectedIndex = 0;
            UDReOrder.Value = 1;
            txtPCode.Enabled = true;
            txtPCode.Focus();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }
        #endregion
        #region Save/Cancel/Update
        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
            
             if (MessageBox.Show("Are you sure you want to save this brand ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm =new SqlCommand("INSERT INTO tblProduct(pcode,barcode,pdesc,bid,cid,price,reorder)VALUES(@pcode,@barcode,@pdesc,@bid,@cid,@price,@reorder)",cn);
                    cm.Parameters.AddWithValue("@pcode",txtPCode.Text);
                    cm.Parameters.AddWithValue("@barcode",txtBarcode.Text);
                    cm.Parameters.AddWithValue("@pdesc",txtPdesc.Text);
                    cm.Parameters.AddWithValue("@bid",cboBrand.SelectedValue);
                    cm.Parameters.AddWithValue("@cid",cboCategory.SelectedValue);
                    cm.Parameters.AddWithValue("@price",double.Parse(txtPrice.Text));
                    cm.Parameters.AddWithValue("@reorder",UDReOrder.Value);
                    cn.Open();
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product has been successfully saved.",stitle);
                    Clear();
                    product.LoadProduct();
                }
            
            
            
            }
            catch(Exception ex) {


                MessageBox.Show(ex.Message);
            
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try {

                if (MessageBox.Show("Are you sure you want to save this brand ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    cm=new SqlCommand("UPDATE tblProduct SET barcode=@barcode,pdesc=@pdesc,bid=@bid,cid=@cid,price=@price,reorder=@reorder WHERE pcode LIKE @pcode",cn);
                    cm.Parameters.AddWithValue("@pcode", txtPCode.Text);
                    cm.Parameters.AddWithValue("@barcode", txtBarcode.Text);
                    cm.Parameters.AddWithValue("@pdesc", txtPdesc.Text);
                    cm.Parameters.AddWithValue("@bid", cboBrand.SelectedValue);
                    cm.Parameters.AddWithValue("@cid", cboCategory.SelectedValue);
                    cm.Parameters.AddWithValue("@price", double.Parse(txtPrice.Text));
                    cm.Parameters.AddWithValue("@reorder", UDReOrder.Value);
                    cn.Open();
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product has been successfully updated.", stitle);
                    Clear();
                    this.Dispose();

                }







            }
            catch (Exception ex) {


                MessageBox.Show(ex.Message);
            
            }

        }
        #endregion

        private void ProductModule_Load(object sender, EventArgs e)
        {

        }
    }
}
