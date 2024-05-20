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
using System.Xml.Linq;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace Computer_Shop_Management_System
{
    public partial class UserControlProduct : UserControl
    {

        private DataAccess Da { get; set; }
        public UserControlProduct()
        {
            InitializeComponent();
            this.Da = new DataAccess();


            this.vaildData();
           this.PopulateGridView();

            this.AutoIDgenerate();

        }
        private void PopulateGridView(string sql = "select *  from Product;")
        {
            var ds = this.Da.ExecuteQuery(sql);



            this.dgvproduct.AutoGenerateColumns = true;
            this.dgvproduct.DataSource = ds.Tables[0];
           
           
        }




        private void label6_Click(object sender, EventArgs e)
        {



        }



        private void button1_MouseClick(object sender, MouseEventArgs e)
        {



        }



 
        public void AutoIDgenerate()
        {
            SqlConnection Con = new SqlConnection("Data Source=LAPTOP-RGV87R9G\\SQLEXPRESS01;Initial Catalog=\"Company DATA\";Persist Security Info=True;User ID=ADITYO;Password=1111");
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select isnull(max(cast(ID as int)),00)+01 from Product;", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
         
            
            txtId.Text = dt.Rows[0][0].ToString();
            Con.Close();    
        }

        



        private bool IsDataValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtchangeprice.Text) || String.IsNullOrEmpty(this.txtchangeprice.Text))
            {   // String.IsNullOrEmpty(this.txtIMDB.Text) || String.IsNullOrEmpty(this.txtIncome.Text) ||
                //String.IsNullOrEmpty(this.cmbGenre.Text))
                return false;
            }
            else
                return true;
        }

    

        private void dgvproduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     
      

        private void UserControl1_Load(object sender, EventArgs e)
        {
           
        }

        private void cmbcategory_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            string sql = "select * from Product where Category = '" + this.cmbcategory.Text + "';";
            this.PopulateGridView(sql);
        }

       

        private void txtchangeprice_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from Product  where Name like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {

            if (txtName.Text == "" || txtId.Text == "" || txtchangeprice.Text == "" || txtQuant.Text == "")
            {
                MessageBox.Show("Missing Information");
            }

            else
            {
             
            }


            try
              {

                  if (!IsDataValidToSave())
                  {
                      MessageBox.Show("Please Fill all the Data.");
                      return;
                  }
                var sql = "SELECT abs(Price) AS Price FROM Product;";
                this.Da.ExecuteDMLQuery(sql);
    
                      var query = "select * from Product where ID = '" + this.txtId.Text + "';";
                  var ds = this.Da.ExecuteQuery(query);

                  if (ds.Tables[0].Rows.Count == 1)
                  {
                      //update operation
                      var sql2 = @"update Product
                                  set Name = ' " + this.txtName.Text + @"',
                                 Category = '" + this.cmbcate.Text + @" ',
                                   Price = " + this.txtchangeprice.Text + @" ,
                                 Quantity = "+ this.txtQuant.Text+ @" 
                                where Id = '"+this.txtId.Text +" '; ";
                      int count = this.Da.ExecuteDMLQuery(sql2);

                      if (count == 1)
                          MessageBox.Show("Data updated properly");
                      else
                          MessageBox.Show("Data upgradation failed");
                  }
                  else
                  {
                      //insert operation
                      var sql3 = @"insert into Product  values('" + this.txtId.Text + "', '" + this.txtName.Text + "', '" + this.cmbcate.Text + "', " + this.txtchangeprice.Text + ", " + this.txtQuant.Text + ");";
                    int count = this.Da.ExecuteDMLQuery(sql3);
                        var sql4 = "SELECT abs(Price) AS Price FROM Product;";
                    this.Da.ExecuteDMLQuery(sql4);


                    if (count == 1)
                          MessageBox.Show("Data Added properly");
                      else
                          MessageBox.Show("Data insertion failed");
                  }
                this.vaildData();
                  this.PopulateGridView();
                  this.ClearAll();
              }




              catch (Exception exc)
              {
                  MessageBox.Show("An error has occured, please try again.\n" + exc.Message);
              }
        }

        private void btncleiear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }
        private void ClearAll()
        {
            this.txtId.Clear();
            this.txtName.Clear();
            this.cmbcate.SelectedIndex = -1;
            this.txtchangeprice.Clear();
            this.txtQuant.Clear();

            this.txtAutoSearch.Clear();
            // this.cmbcategory.SelectedIndex = -1;

            this.txtId.ReadOnly = false;
            this.dgvproduct.ClearSelection();

            this.AutoIDgenerate();
        }
        private void bgvproduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bgvproduct_DoubleClick(object sender, EventArgs e)
        {
            this.txtId.Text = this.dgvproduct.CurrentRow.Cells["Id"].Value.ToString();
            this.txtName.Text = this.dgvproduct.CurrentRow.Cells["Name"].Value.ToString();
            this.cmbcate.Text = this.dgvproduct.CurrentRow.Cells["Category"].Value.ToString();
            this.txtchangeprice.Text = this.dgvproduct.CurrentRow.Cells["price"].Value.ToString();
            this.txtQuant.Text = this.dgvproduct.CurrentRow.Cells["Quantity"].Value.ToString();
       
        }

        private void UserControl1_Load_1(object sender, EventArgs e)
        {

        }
        private void vaildData()
        {
            var sql = "SELECT abs(Price) AS Price FROM Product;";
            this.Da.ExecuteDMLQuery(sql);
        }
        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
    
}