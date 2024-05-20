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

namespace Computer_Shop_Management_System
{
    public partial class MUCProductlist : UserControl
    {
        private DataAccess Da { get; set; }
        public MUCProductlist()
        {
            InitializeComponent();
            this.Da = new DataAccess();


            this.PopulateGridView();
            this.AutoIDgenerate();
        }

        public void AutoIDgenerate()
        {
            SqlConnection Con = new SqlConnection("Data Source=LAPTOP-RGV87R9G\\SQLEXPRESS01;Initial Catalog=\"Company DATA\";Persist Security Info=True;User ID=ADITYO;Password=1111");
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select isnull(max(cast(ID as int)),00)+01 from Product;", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            txtPid.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }


        private void PopulateGridView(string sql = "select * from Product;")
        {
            var ds = this.Da.ExecuteQuery(sql);



            this.dgvProduct.AutoGenerateColumns = true;
            this.dgvProduct.DataSource = ds.Tables[0];
        }

        private void btnShowproduct_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from Product where Category = '" + this.txtMsearch.Text + "';";
            this.PopulateGridView(sql);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void ClearAll()
        {
            this.txtPid.Clear();
            this.txtPname.Clear();
            this.txtprice.Clear();
            this.txtquantity.Clear();

            this.cmbPcategory.SelectedIndex = -1;

            this.txtMsearch.Clear();
            this.txtASearch.Clear();

            this.txtPid.ReadOnly = false;
            this.dgvProduct.ClearSelection();

            this.AutoIDgenerate();

            
        }
        private void txtASearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from Product where Name like '" + this.txtASearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsDataValidToSave())
                {
                    MessageBox.Show("Please Fill all the Data.");
                    return;
                }

                var query = "select * from Product where ID = '" + this.txtPid.Text + "';";
                var ds = this.Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    //update operation
                    var sql = @"update Product
                                set Name = '" + this.txtPname.Text + @"',
                                Price = " + this.txtprice.Text + @",
                                Quantity = '" + this.txtquantity.Text + @"',
                                Category = '" + this.cmbPcategory.Text + @"'
                                where ID = '" + this.txtPid.Text + "';";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data updated properly");
                    else
                        MessageBox.Show("Data upgradation failed");
                }
                else
                {
                    //insert operation
                    var sql = "insert into Product values('" + txtPid.Text + "','" + txtPname.Text + "','" + cmbPcategory.Text + "','" + txtprice.Text + "', '" + this.txtquantity.Text + "');";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data Added properly");
                    else
                        MessageBox.Show("Data insertion failed");
                }

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }
        }

        private bool IsDataValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtPid.Text) || String.IsNullOrEmpty(this.txtPname.Text) ||
                String.IsNullOrEmpty(this.txtprice.Text) || String.IsNullOrEmpty(this.txtquantity.Text) ||
                String.IsNullOrEmpty(this.cmbPcategory.Text))
                return false;
            else
                return true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (this.dgvProduct.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Please select a row first to delete.");
                    return;
                }

                var Pid = this.dgvProduct.CurrentRow.Cells[0].Value.ToString();
                var Pname = this.dgvProduct.CurrentRow.Cells["Name"].Value.ToString();

                //MessageBox.Show(id + title);
                var sql = "delete from Product where ID = '" + Pid + "'; ";

                int count = this.Da.ExecuteDMLQuery(sql);


                if (count == 1)
                    MessageBox.Show(Pname.ToUpper() + " has been removed properly");
                else
                    MessageBox.Show("Data remove failed");

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }


        }

        private void MUCProductlist_Load(object sender, EventArgs e)
        {
            this.dgvProduct.ClearSelection();
        }

        private void dgvProduct_DoubleClick(object sender, EventArgs e)
        {
            this.txtPid.Text = this.dgvProduct.CurrentRow.Cells["ID"].Value.ToString();
            this.txtPname.Text = this.dgvProduct.CurrentRow.Cells["Name"].Value.ToString();
            this.cmbPcategory.Text = this.dgvProduct.CurrentRow.Cells["Category"].Value.ToString();
            this.txtprice.Text = this.dgvProduct.CurrentRow.Cells["Price"].Value.ToString();
            this.txtquantity.Text = this.dgvProduct.CurrentRow.Cells["Quantity"].Value.ToString();

            //this.txtId.ReadOnly = true;
        }

       
    }
}

