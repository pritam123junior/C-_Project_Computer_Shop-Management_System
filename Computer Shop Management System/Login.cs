using Computer_Shop_Management_System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void lblPass_Click(object sender, EventArgs e)
        {

        }

        private void btnlog_Click(object sender, EventArgs e)
        {


            try
            {
                string sql = "select * from UserInfoData where UserName = '" + this.txtID.Text + "' and Password = '" + this.txtPass.Text + "';";
                SqlConnection sqlcon = new SqlConnection("Data Source=LAPTOP-RGV87R9G\\SQLEXPRESS01;Initial Catalog=\"Company DATA\";Persist Security Info=True;User ID=ADITYO;Password=1111");
                sqlcon.Open();
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
                DataSet ds = new DataSet();
                sda.Fill(ds);


                if (txtID.Text == "" || txtPass.Text == "")
                {
                    MessageBox.Show("PLease provide Username a n d Password");
                    return;
                }

                if (ds.Tables[0].Rows.Count == 1)
                {
                    {
                        MessageBox.Show("Login successful");

                    }


                    if (ds.Tables[0].Rows[0][2].ToString() == "Admin")
                    {
                        new Admin().Show();
                        this.Hide();
                    }
                    else if (ds.Tables[0].Rows[0][2].ToString() == "Manager")
                    {
                        new Manager().Show();
                        this.Hide();
                    }
                    else if (ds.Tables[0].Rows[0][2].ToString() == "SalesMan")
                    {
                        new Salesman().Show();
                        this.Hide();
                    }




                }
                else
                {

                    MessageBox.Show("Invalid Username or Password");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error, Please try gain later\n" + exc.Message);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Exit Application", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void btnab_Click(object sender, EventArgs e)
        {
            new About().Show();
            this.Hide();
        }
    }
}

