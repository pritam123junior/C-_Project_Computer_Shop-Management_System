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
    public partial class SUserControlBills : UserControl
    {


        private DataAccess Da { get; set; }
        public SUserControlBills()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.PopulateGridView();
        }
        private void PopulateGridView(string sql = "select * from Sells;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvsells.AutoGenerateColumns = true;
            this.dgvsells.DataSource = ds.Tables[0];
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Computer Shop", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Black, new Point(230));
            e.Graphics.DrawString("Seller Name : " + this.dgvsells.SelectedRows[0].Cells[6].Value.ToString(), new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Black, new Point(50, 120));
            e.Graphics.DrawString("Total Amount : " + this.dgvsells.SelectedRows[0].Cells[5].Value.ToString(), new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Black, new Point(50, 170));
            e.Graphics.DrawString("Product : " + this.dgvsells.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Black, new Point(50, 220));
        }
    }
}
