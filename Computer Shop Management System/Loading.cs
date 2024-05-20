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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pnlLoadingmini.Width += 2;
            if (pnlLoadingmini.Width >= 299)
            {
                timer1.Stop();
                Login lg = new Login();
                lg.Show();
                this.Hide();
            }
        }
    }
}
