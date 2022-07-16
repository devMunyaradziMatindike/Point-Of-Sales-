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
    public partial class StockIn : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        string stitle = "Point Of Sales";
        SqlDataReader dr;
        public StockIn()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoadSupplier();
        }

        private void StockIn_Load(object sender, EventArgs e)
        {

        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvStockIn.Columns[e.ColumnIndex].Name;
            if(colName == "Delete")
            {
                if(MessageBox.Show("Remove this item ?",stitle,MessageBoxButtons.OK,MessageBoxIcon.Question) == DialogResult.OK)
                {

                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tbStockIn WHERE id='" + dgvStockIn.Rows[e.RowIndex].Cells[1].Value.ToString() + "'",cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Item has been successfully saved.",stitle, MessageBoxButtons.OK,MessageBoxIcon.Information);
                    LoadStockIn();

                }



            }
        }

        private void LoadSupplier()
        {

            cbSupplier.Items.Clear();
            cbSupplier.DataSource = dbcon.getTable("SELECT * FROM tblSupplier");
            cbSupplier.DisplayMember = "supplier";

        }

        public void LoadStockIn()
        {
            try
            {

                int i = 0;
                dgvStockIn.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("SELECT * FROM vwStockIn WHERE refNo LIKE '" + txtRefNo.Text + "' AND STATUS LIKE 'Pending' ", cn);
                dr = cm.ExecuteReader();

                while (dr.Read())
                {


                    i++;
                    dgvStockIn.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {


                //MessageBox.Show(ex.Message);
            }
        }
        public void getRefNo()
        {
            Random rm = new Random();
            txtRefNo.Clear();
            txtRefNo.Text += rm.Next();
        }

        private void cbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                cn.Open();
                cm = new SqlCommand("SELECT * FROM tblSupplier WHERE supplier LIKE  '" + cbSupplier.Text + "", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {

                    lblId.Text = dr["id"].ToString();
                    txtConPerson.Text = dr["contactperson"].ToString();
                    txtAddress.Text = dr["address"].ToString();

                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                //  MessageBox.Show(ex.Message,stitle);
            }
        }

        private void cbSupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void LnGenerate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            getRefNo();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProductStockIn productStock = new ProductStockIn(this);
            productStock.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if(dgvStockIn.Rows.Count > 0)
                {

                    if(MessageBox.Show("Are you sure you want to save this record",stitle,MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes){


                        for(int i = 0; i < dgvStockIn.Rows.Count; i++)
                        {
                            cn.Open();
                            //product quantity
                            cm=new SqlCommand("UPDATE tblProduct SET qty=qty + "+int.Parse(dgvStockIn.Rows[i].Cells[5].Value.ToString())+" WHERE pcode LIKE '"+dgvStockIn.Rows[i].Cells[3].Value.ToString()+"'",cn);
                            cm.ExecuteNonQuery();
                            cn.Close();

                            //stockIn quantity
                            cm = new SqlCommand("UPDATE tbStockIn SET qty=qty + " + int.Parse(dgvStockIn.Rows[i].Cells[5].Value.ToString()) + " status='Done' WHERE id LIKE '" + dgvStockIn.Rows[i].Cells[1].Value.ToString() + "'", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();


                        }
                        Clear();
                        LoadStockIn();
                    }
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,stitle,MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }


        public void Clear()
        {

            txtRefNo.Clear();
            txtStockInBy.Clear();
            dtStockIn.Value = DateTime.Now;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
