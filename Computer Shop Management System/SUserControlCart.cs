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
    public partial class SUserControlCart : UserControl
    {
        private DataAccess Da { get; set; }
        public SUserControlCart()
        {
            InitializeComponent();

            this.Da = new DataAccess();

            this.PopulateGridView();
            this.AutoIDgenerate();
        }
        private void PopulateGridView(string sql = "select * from Cart;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvCart.AutoGenerateColumns = true;
            this.dgvCart.DataSource = ds.Tables[0];
        }
        public void AutoIDgenerate()
        {
            SqlConnection Con = new SqlConnection("Data Source=LAPTOP-RGV87R9G\\SQLEXPRESS01;Initial Catalog=\"Company DATA\";Persist Security Info=True;User ID=ADITYO;Password=1111");
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select isnull(max(cast(Customer_ID as int)),00)+01 from CustomerInfo;", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            txtId.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvCart.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Please select a row first to delete.");
                    return;
                }

                var id = this.dgvCart.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvCart.CurrentRow.Cells["Name"].Value.ToString();
                
                var sql = "delete from Cart where ID= '" + id + "';";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(name.ToUpper() + " has been removed properly");
                else
                    MessageBox.Show("Data remove failed");

                this.PopulateGridView();
                
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            try
            {




                if (this.dgvCart.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Please select a row first to delete.");
                    return;
                }

                var id = this.dgvCart.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvCart.CurrentRow.Cells["Name"].Value.ToString();

                var sql2 = "delete from Cart where  ID = '" + id + "';";
                int count2 = this.Da.ExecuteDMLQuery(sql2);

                if (count2 == 1)




                    this.PopulateGridView();
                //  this.ClearAll();



                var sql = @"insert into Sells values('" + this.txtId.Text + "', '" + this.txtName.Text + "',' " + this.txtProduct.Text + "','" + this.dtpPurchaseDate.Text + "'," + this.txtQuantity.Text + ", " + this.txtPrice.Text + ",'" + this.txtSName.Text + "');";
                int count = this.Da.ExecuteDMLQuery(sql);

                var sql1 = @"insert into CustomerInfo values('" + this.txtId.Text + "','" + this.txtName.Text + "', " + this.txtNumber.Text + ",'" + this.txtAddress.Text + "');";
                int count1 = this.Da.ExecuteDMLQuery(sql1);

                if (count == 1)
                    MessageBox.Show("Product sold");
                else
                    MessageBox.Show("Data insertion failed");
                this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }
        }

        private void dgvCart_DoubleClick(object sender, EventArgs e)
        {
            this.txtProduct.Text = this.dgvCart.CurrentRow.Cells["Name"].Value.ToString();
            this.txtPrice.Text = this.dgvCart.CurrentRow.Cells["Price"].Value.ToString();
            this.txtQuantity.Text = this.dgvCart.CurrentRow.Cells["Quantity"].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void ClearAll()
        {
           
            this.txtName.Clear();
            this.txtProduct.Clear();
            this.txtQuantity.Clear();
            

            this.txtNumber.Clear();
            this.txtAddress.Clear();
            this.txtPrice.Clear();
            this.txtName.Clear();

            
            this.dgvCart.ClearSelection();

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection("Data Source=LAPTOP-RGV87R9G\\SQLEXPRESS01;Initial Catalog=\"Company DATA\";Persist Security Info=True;User ID=ADITYO;Password=1111");
            Con.Open();

            SqlDataAdapter sda1 = new SqlDataAdapter("select SUM(Price) from Cart", Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            lblPrice.Text = dt1.Rows[0][0].ToString();

        }
    }
}
