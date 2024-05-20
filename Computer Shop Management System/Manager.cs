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
    public partial class Manager : Form
    {
        //public string name = "{?}";

        public Manager()
        {
            InitializeComponent();
            MUserControlDash uc = new MUserControlDash();
            addUserControl(uc);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnl3.Controls.Clear();
            pnl3.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnCustomerlist_Click(object sender, EventArgs e)
        {
            MUCcustomerlist uc = new MUCcustomerlist();
            addUserControl(uc);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            MUCProductlist uc = new MUCProductlist();
            addUserControl(uc);
        }

       /* private void btnCategory_Click(object sender, EventArgs e)
        {
            MUCategory uc = new UCCategory();
            addUserControl(uc);
        }*/

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            MUserControlDash uc = new MUserControlDash();
            addUserControl(uc);
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            MUCbills1 uc = new MUCbills1();
            addUserControl(uc);
        }

        private void btnOrderList_Click(object sender, EventArgs e)
        {
            MUCorderlist uc = new MUCorderlist();
            addUserControl(uc);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Do you want LOGOUT ?", "Qusestion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                // MovePanal(btnlogout);
                new Login().Visible = true;
                this.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            bell.Image = Properties.Resources.Bell;
            MUserControlNoti mn = new MUserControlNoti();   
            addUserControl(mn);
        }

        private void pnl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Exit Application", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
       