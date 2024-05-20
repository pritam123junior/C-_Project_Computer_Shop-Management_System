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
    public partial class UserCustomer : UserControl
    {
        public UserCustomer()
        {
            InitializeComponent();
            this.Da = new DataAccess();



            this.PopulateGridView();
        }

        private DataAccess Da { get; set; }

        private void PopulateGridView(string sql = "select * from CustomerInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);



            this.dgvcus.AutoGenerateColumns = true;
            this.dgvcus.DataSource = ds.Tables[0];
           
        }

        private void UserProduct_Load(object sender, EventArgs e)
        {

        }

        private void dgvpro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbcategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtAutosearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from CustomerInfo where Customer_Name like '" + this.txtAutosearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from CustomerInfo where Customer_Name = '" + this.txtAutosearch.Text + "';";
            this.PopulateGridView(sql);
        }
    }
}
