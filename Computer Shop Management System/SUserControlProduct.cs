using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Shop_Management_System
{
    public partial class SUserControlProduct : UserControl
    {


        private DataAccess Da { get; set; }
        public SUserControlProduct()
        {
            InitializeComponent();

            this.Da = new DataAccess();

            this.PopulateGridView();
        }

        private void PopulateGridView(string sql = "select * from Product ;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvProduct.AutoGenerateColumns = true;
            this.dgvProduct.DataSource = ds.Tables[0];
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from Product where Product Category like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        

        private void dgvProduct_DoubleClick_1(object sender, EventArgs e)
        {
            this.txtPId.Text = this.dgvProduct.CurrentRow.Cells["ID"].Value.ToString();
            this.txtPName.Text = this.dgvProduct.CurrentRow.Cells["Name"].Value.ToString();
            this.txtCategory.Text = this.dgvProduct.CurrentRow.Cells["Category"].Value.ToString();
            this.txtPrice.Text = this.dgvProduct.CurrentRow.Cells["Price"].Value.ToString();
            this.txtQuantity.Text = this.dgvProduct.CurrentRow.Cells["Quantity"].Value.ToString();
        }
        private void btnAddToCart_Click(object sender, EventArgs e)
        {

            try
            {
                if (!IsDataValidToSave())
                {
                    MessageBox.Show("Please Fill all the Data.");
                    return;
                }

                int var_stock = 0;
                int var_sell = 0;
                int result = 0;



                var_stock = Convert.ToInt32(txtQuantity.Text);
                var_sell = Convert.ToInt32(txtadd.Text);
                result = var_stock - var_sell;


                var sql1 = @"update Product 
                                set Quantity= " + result + @"
                               
                                where ID = '" + this.txtPId.Text + "';";
                int count = this.Da.ExecuteDMLQuery(sql1);
                var sql = @"insert into Cart  values('" + this.txtPId.Text + "', '" + this.txtPName.Text + "',' " + this.txtCategory.Text + "', " + this.txtPrice.Text + "," + this.txtadd.Text + ");";
                int count1 = this.Da.ExecuteDMLQuery(sql);



                if (count == 1)
                { MessageBox.Show("Product added into  cart properly"); }
                else
               MessageBox.Show("Product add failed");
         





                this.PopulateGridView();
                
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
            }
        }

        private bool IsDataValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtPId.Text) || String.IsNullOrEmpty(this.txtPName.Text) ||
                String.IsNullOrEmpty(this.txtCategory.Text) || String.IsNullOrEmpty(this.txtPrice.Text) ||
                String.IsNullOrEmpty(this.txtQuantity.Text))
                return false;
            else
                return true;
        }


        private void txtAutoSearch_TextChanged_1(object sender, EventArgs e)
        {
               var sql = "select * from Product  where Category like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
