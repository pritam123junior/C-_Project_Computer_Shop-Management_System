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
    public partial class MUCorderlist : UserControl
    {
        private DataAccess Da { get; set; }
        public MUCorderlist()
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
            SqlDataAdapter sda = new SqlDataAdapter("select isnull(max(cast(Order_ID as int)),00)+01 from OrderList;", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            txtOid.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void PopulateGridView(string sql = "select * from OrderList;")
        {
            var ds = this.Da.ExecuteQuery(sql);



            this.dgvOrder.AutoGenerateColumns = true;
            this.dgvOrder.DataSource = ds.Tables[0];
        }
     

    
        private void btnShowOrder_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

    

        private void txtOMsearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from OrderList where Order_Category = '" + this.txtOMsearch.Text + "';";
            this.PopulateGridView(sql);
        }

        private void txtOASearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from OrderList where Order_Product like '" + this.txtOASearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnOClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void ClearAll()
        {

            this.txtOproduct.Clear();
            this.txtOid.Clear();
            this.cmbOcategory.SelectedIndex = -1;
            this.txtOquantity.Clear();
            
            this.dtpDate.Value = DateTime.Now; //Devdoot er nijer code not sure


            this.txtOMsearch.Clear();
            this.txtOASearch.Clear();


            this.txtOid.ReadOnly = false;
            this.dgvOrder.ClearSelection();

            this.AutoIDgenerate();
        }

        private bool IsDataValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtOproduct.Text) || String.IsNullOrEmpty(this.txtOid.Text) ||
                String.IsNullOrEmpty(this.txtOquantity.Text) ||
                String.IsNullOrEmpty(this.dtpDate.Text)|| String.IsNullOrEmpty(this.cmbOcategory.Text))

                return false;
            else
                return true;
        }
       
        private void btnOUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsDataValidToSave())
                {
                    MessageBox.Show("Please Fill all the Data.");
                    return;
                }

                var query = "select * from OrderList where Order_ID = '" + this.txtOid.Text + "';";
                var ds = this.Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    //update operation
                    var sql = @"update OrderList
                                set Order_Product = '" + this.txtOproduct.Text + @"',
                                   Order_Category = '" + this.cmbOcategory.Text + @"',
                                Order_Quantity = " + this.txtOquantity.Text + @",
                                 Order_Date = ' " + this.dtpDate.Text + @" '
                                where Order_ID = '" + this.txtOid.Text + "';";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data updated properly");
                    else
                        MessageBox.Show("Data upgradation failed");
                }
                else
                {
                    //insert operation
                    var sql = "insert into OrderList values('" + txtOid.Text + "','" + txtOproduct.Text + "','" + cmbOcategory.Text + "', '" + this.txtOquantity.Text + "',' "+this.dtpDate.Text+"');";
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

        private void btnORemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvOrder.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Please select a row first to delete.");
                    return;
                }

                var Pid = this.dgvOrder.CurrentRow.Cells[0].Value.ToString();
                var Pname = this.dgvOrder.CurrentRow.Cells["Order_Product"].Value.ToString();

                //MessageBox.Show(id + title);
                var sql = "delete from OrderList where Order_ID = '" + Pid + "'; ";

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

        private void MUCorderlist_Load(object sender, EventArgs e)
        {
            this.dgvOrder.ClearSelection();
        }

        private void dgvOrder_DoubleClick(object sender, EventArgs e)
        {
            this.txtOid.Text = this.dgvOrder.CurrentRow.Cells[0].Value.ToString();
            this.txtOproduct.Text = this.dgvOrder.CurrentRow.Cells[1].Value.ToString();
            this.cmbOcategory.Text = this.dgvOrder.CurrentRow.Cells[2].Value.ToString();
        //    this.txtprice.Text = this.dgvOrder.CurrentRow.Cells["Product_Price"].Value.ToString();
            this.txtOquantity.Text = this.dgvOrder.CurrentRow.Cells[3].Value.ToString();
            this.dtpDate.Text = this.dgvOrder.CurrentRow.Cells[4].Value.ToString();


            //this.txtId.ReadOnly = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
