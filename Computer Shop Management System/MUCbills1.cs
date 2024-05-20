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
    public partial class MUCbills1 : UserControl
    {
        private DataAccess Da { get; set; }
        public MUCbills1()
        {
            InitializeComponent();
            this.Da = new DataAccess();



            this.PopulateGridView();
        }
        private void PopulateGridView(string sql = "select * from Sells ;")
        {
            var ds = this.Da.ExecuteQuery(sql);



            this.dgvbills.AutoGenerateColumns = true;
            this.dgvbills.DataSource = ds.Tables[0];

        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {

            var sql = "select * from Sells where Customer_Name like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);
        }
    }
}
