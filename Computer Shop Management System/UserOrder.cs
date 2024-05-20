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
    
    public partial class UserOrder : UserControl
    {
        private DataAccess Da { get; set; }
        public UserOrder()
        {
            InitializeComponent();
            this.Da = new DataAccess();



            this.PopulateGridView();
        }
        private void PopulateGridView(string sql = "select * from OrdeRList ;")
        {
            var ds = this.Da.ExecuteQuery(sql);



            this.dgvorder.AutoGenerateColumns = true;
            this.dgvorder.DataSource = ds.Tables[0];

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserOrder_Load(object sender, EventArgs e)
        {

        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {

            var sql = "select * from OrderList where Order_Product like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);
        }
    }
}
