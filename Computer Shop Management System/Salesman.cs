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
    public partial class Salesman : Form
    {
        public Salesman()
        {
            InitializeComponent();

            SUserControlProduct uc = new SUserControlProduct();
            addUserControl(uc);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlShow.Controls.Clear();
            pnlShow.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void btnProducts_Click(object sender, EventArgs e)
        {
            SUserControlProduct uc = new SUserControlProduct();
            addUserControl(uc);
        }

        private void btnbills_Click(object sender, EventArgs e)
        {
            SUserControlBills uc = new SUserControlBills();
            addUserControl(uc);
        }

        

        private void button1_Click(object sender, EventArgs e)
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
            SUserControlNoti sUserControlNoti= new SUserControlNoti();
            addUserControl(sUserControlNoti);     }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SUserControlCart uc = new SUserControlCart();
            addUserControl(uc);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Exit Application", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
