#region Imports
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using RevmaxAPI;
#endregion 
namespace PointOfSales
{
    #region MainClass
    public partial class MainForm : Form
    {
        #region MainForm

       // Revmaxlib revmax=new Revmaxlib();
        SqlConnection cn=new SqlConnection();
        SqlCommand cm=new SqlCommand();
        DBConnect dbcon=new DBConnect();

        public MainForm()
        {
            InitializeComponent();
            CustomizeDesign();
            cn=new SqlConnection(dbcon.myConnection());
            cn.Open();
            //MessageBox.Show("Database is connected");
        }
        #endregion
        #region panelSlide
        private void CustomizeDesign()
        {

            panelSubProduct.Visible = false;
            panelSubRecord.Visible = false;
            panelSubStock.Visible = false;
            panelSubSetting.Visible = false;
        }
        private void hideSubMenu()
        {

            if (panelSubProduct.Visible == true)
                panelSubProduct.Visible = false;
            if (panelSubRecord.Visible == true)
                panelSubRecord.Visible=false;
            if (panelSubStock.Visible == true)
                panelSubStock.Visible = false;
            if (panelSubSetting.Visible == true)
                panelSubSetting.Visible=false;


        }
        private void showSubMenu(Panel submenu)
        {
            if(submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
            
                submenu.Visible = false;
            
        }
        #endregion
        #region PanelLogo
        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion
        #region PanelSlide

        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if(activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel=false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            lblTitle.Text = childForm.Text;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubProduct);
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            openChildForm(new Product());
            hideSubMenu();
        }

        private void btnCategory_Click(object sender, EventArgs e)

        {
            openChildForm(new Category());
            hideSubMenu();
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            openChildForm(new Brand());
            hideSubMenu();
        }

        private void btnInStock_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubStock);
        }

        private void btnStockEntry_Click(object sender, EventArgs e)
        {
            openChildForm(new StockIn());
            hideSubMenu();
        }

        private void btnStockAdjustment_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            openChildForm(new Supplier());
            hideSubMenu();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubRecord);
        }

        private void btnSaleHistory_Click(object sender, EventArgs e)
        {
            hideSubMenu();

        }

        private void btnPosRecord_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubSetting);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            openChildForm(new UserAccount());
            hideSubMenu();
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        #endregion

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
    #endregion
}
