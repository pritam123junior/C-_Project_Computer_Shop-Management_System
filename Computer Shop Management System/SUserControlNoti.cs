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
    public partial class SUserControlNoti : UserControl
    {
        private DataAccess Da { get; set; }
        public SUserControlNoti()
        {
            InitializeComponent();

            this.Da = new DataAccess();


            this.PopulateGridView();

        }
        private void PopulateGridView(string sql = "select * from Notification;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvNoti.AutoGenerateColumns = true;
            this.dgvNoti.DataSource = ds.Tables[0];
        }
    }
}
