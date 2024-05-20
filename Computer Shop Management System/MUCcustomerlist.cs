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
    public partial class MUCcustomerlist : UserControl
    {
        private DataAccess Da { get; set; }
        public MUCcustomerlist()
        {
            InitializeComponent();


            this.Da = new DataAccess();


            this.PopulateGridView();
          //  this.AutoIDgenerate();
        }




    private void PopulateGridView(string sql = "select * from CustomerInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvCustomer.AutoGenerateColumns = true;
            this.dgvCustomer.DataSource = ds.Tables[0];
        }

        private void btnShowCustomer_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

       


        private void txtCASearch_TextChanged_1(object sender, EventArgs e)
        {
            var sql = "select * from CustomerInfo where Customer_Name like '" + this.txtCASearch.Text + "%';";
            this.PopulateGridView(sql);
        }

      
    }
}
