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
    public partial class UserControlnotify : UserControl
    {
        private DataAccess Da { get; set; }
        public UserControlnotify()
        {
            InitializeComponent();
            this.Da = new DataAccess();


            this.AutoIDgenerate();
        }

        public void AutoIDgenerate()
        {
            SqlConnection Con = new SqlConnection("Data Source=LAPTOP-RGV87R9G\\SQLEXPRESS01;Initial Catalog=\"Company DATA\";Persist Security Info=True;User ID=ADITYO;Password=1111");
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select isnull(max(cast( Serialno as int)),0)+1 from Notification;", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);


           lbln.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void lblmessage_Click(object sender, EventArgs e)
        {

        }
        
        private void btnsend_Click(object sender, EventArgs e)
        {
           

            var sql = @"insert into Notification (Serialno, Messages)values(" +this.lbln.Text + ",'" + this.txtMessage.Text + "');";
            int count = this.Da.ExecuteDMLQuery(sql);

            if (count == 1)
                MessageBox.Show("Message SEND Successfully");
            else
                MessageBox.Show("Please fill the messagebox");
            
        }
    }
}
