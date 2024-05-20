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
    public partial class UserControlEmployee : UserControl
    {
        private DataAccess Da { get; set; }
        public UserControlEmployee()
        {
            InitializeComponent();
            this.Da = new DataAccess();



            this.PopulateGridView();

        }
        private void PopulateGridView(string sql = "select * from Employee;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvemployee.AutoGenerateColumns = true;
            this.dgvemployee.DataSource = ds.Tables[0];
            this.AutoIDgenerate();
        }

        public void AutoIDgenerate()
        {
            SqlConnection Con = new SqlConnection("Data Source=LAPTOP-RGV87R9G\\SQLEXPRESS01;Initial Catalog=\"Company DATA\";Persist Security Info=True;User ID=ADITYO;Password=1111");
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select isnull(max(cast(ID as Varchar)),00)+01 from Employee;", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            txtId.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private bool IsDataValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtSalary.Text) || String.IsNullOrEmpty(this.txtSalary.Text))
            {   // String.IsNullOrEmpty(this.txtIMDB.Text) || String.IsNullOrEmpty(this.txtIncome.Text) ||
                //String.IsNullOrEmpty(this.cmbGenre.Text))
                return false;
            }
            else
                return true;
        }
        private void cmbcate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from Employee  where Name like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtId.Text == "" || txtSalary.Text == "")
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

                var query = "select * from Employee where ID = '" + this.txtId.Text + "';";
                var ds = this.Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    //update operation
                    var sql = @"update Employee
                               set Name = ' " + this.txtName.Text + @"',
                               Position = '" + this.cmbcate.Text + @" ',
                               Joining_Date ='" + this.dtpem.Text + @"', 
                               Salary = " + this.txtSalary.Text + @" 
                                where ID = '" + this.txtId.Text + " '; ";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data updated properly");
                    else
                        MessageBox.Show("Data upgradation failed");
                }
                else
                {
                    //insert operation
                    var sql = @"insert into Employee  values('" + this.txtId.Text + "', '" + this.txtName.Text + "', '" + this.cmbcate.Text + " '  '" + this.dtpem.Text + "', " + this.txtSalary.Text + ");";
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
        private void ClearAll()
        {
            this.txtId.Clear();
            this.txtName.Clear();
            this.cmbcate.SelectedIndex = -1;
         //   this.dtpem=
            this.txtSalary.Clear();
           // this.txtQuant.Clear();

            this.txtAutoSearch.Clear();
            // this.cmbcategory.SelectedIndex = -1;

            //this.txtId.ReadOnly = false;
            this.dgvemployee.ClearSelection();

            this.AutoIDgenerate();
        }
        private void dgvemployee_DoubleClick(object sender, EventArgs e)
        {
            this.txtId.Text = this.dgvemployee.CurrentRow.Cells["ID"].Value.ToString();
            this.txtName.Text = this.dgvemployee.CurrentRow.Cells["Name"].Value.ToString();
            this.cmbcate.Text = this.dgvemployee.CurrentRow.Cells[2].Value.ToString();
            this.dtpem.Text = this.dgvemployee.CurrentRow.Cells[3].Value.ToString();
            this.txtSalary.Text = this.dgvemployee.CurrentRow.Cells[4].Value.ToString();
           

        }


        private void btncleiear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

    

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvemployee.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Please select a row first to delete.");
                    return;
                }

                var id = this.dgvemployee.CurrentRow.Cells[0].Value.ToString();
                var Name = this.dgvemployee.CurrentRow.Cells["Name"].Value.ToString();
                //MessageBox.Show(id + title);
                var sql = "delete from Employee where ID = '" + id + "';";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(Name.ToUpper() + " has been removed properly");
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

        private void UserControlEmployee_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btncleiear_Click_1(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
