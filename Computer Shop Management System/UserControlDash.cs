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
    public partial class UserControlDash : UserControl
    {
        public UserControlDash()
        {
            InitializeComponent();
        }
            SqlConnection Con = new SqlConnection("Data Source=LAPTOP-RGV87R9G\\SQLEXPRESS01;Initial Catalog=\"Company DATA\";Persist Security Info=True;User ID=ADITYO;Password=1111");
        private void UserControlDash_Load(object sender, EventArgs e)
        {
            Con.Open();

            SqlDataAdapter sda1 = new SqlDataAdapter("select SUM(Quantity) from Product", Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            lblpro.Text = dt1.Rows[0][0].ToString();

            SqlDataAdapter sda2 = new SqlDataAdapter("select count (*) from OrderList", Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            lblOrder.Text = dt2.Rows[0][0].ToString();

            SqlDataAdapter sda3 = new SqlDataAdapter("select count (*) from Sells", Con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            lbtsells.Text = dt3.Rows[0][0].ToString();


            SqlDataAdapter sda4 = new SqlDataAdapter("select Sum(Product_Price) from Sells", Con);
            DataTable dt4 = new DataTable();
            sda4.Fill(dt4);
            lblreve.Text = dt4.Rows[0][0].ToString();


            SqlDataAdapter sda5 = new SqlDataAdapter("select count (*) from Employee", Con);
            DataTable dt5 = new DataTable();
            sda5.Fill(dt5);
            lblem.Text = dt5.Rows[0][0].ToString();



            SqlDataAdapter sda6 = new SqlDataAdapter("select count (*) from CustomerInfo", Con);
            DataTable dt6 = new DataTable();
            sda6.Fill(dt6);
            lbiCustomer.Text = dt6.Rows[0][0].ToString();


            Con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
