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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            UserControlDash ud = new UserControlDash() ;
           addUserControl(ud);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlShow.Controls.Clear();

            pnlShow.Controls.Add(userControl);
            userControl.BringToFront();
        }


     

    
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            UserOrder userOrder= new UserOrder();
            addUserControl(userOrder); 
            
        }

        private void button7_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Do you want LOGOUT ?", "Qusestion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
               // MovePanal(btnlogout);
                new Login().Visible = true;
                this.Close();
            }
        }

        private void pnlShow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            UserCustomer userCustomer= new UserCustomer();
            addUserControl(userCustomer);   
        }

     
        private void btndash_Click(object sender, EventArgs e)
        {
            UserControlDash ud = new UserControlDash();
            addUserControl(ud);
        }


        private void btnbill_Click(object sender, EventArgs e)
        {
            UserControlBills userControlBills= new UserControlBills();
            addUserControl(userControlBills);
        }

        private void btnproduct_Click_1(object sender, EventArgs e)
        {
            UserControlProduct ucc = new UserControlProduct();
            addUserControl(ucc);
        }

        private void btnem_Click(object sender, EventArgs e)
        {
            UserControlEmployee em= new UserControlEmployee();  
            addUserControl(em);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UserOrder userOrderuser= new UserOrder();   
            addUserControl(userOrderuser);
        }

        private void btnBell_Click(object sender, EventArgs e)
        {
            UserControlnotify ucn = new UserControlnotify();
            addUserControl(ucn);
        }

        private void btnnotify_Click(object sender, EventArgs e)
        {
            UserControlnotify un= new UserControlnotify();
            addUserControl(un);
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
