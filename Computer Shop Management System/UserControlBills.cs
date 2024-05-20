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
    public partial class UserControlBills : UserControl
    {
        private DataAccess Da { get; set; }
        public UserControlBills()
        {
            InitializeComponent();
            this.Da = new DataAccess();



            this.PopulateGridView();
        }
        private void PopulateGridView(string sql = "select * from Sells;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvbills.AutoGenerateColumns = true;
            this.dgvbills.DataSource = ds.Tables[0];

        }

        private void dgvbills_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {

            var sql = "select * from Sells where Customer_Name like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
