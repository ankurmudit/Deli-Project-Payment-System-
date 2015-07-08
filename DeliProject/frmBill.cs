using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliProject
{
    public partial class frmBill : Form
    {
        public bool isRestart = false;
        public frmBill()
        {
            InitializeComponent();
        }

        private void frmBill_Load(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString();
            Random rnd = new Random();
            lblRand.Text = ( rnd.Next(10000000,100000000)).ToString();
            lblrand2.Text = lblRand.Text;
        }

        private void frmBill_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(MessageBox.Show("Do you want to place another order?","New Order?",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
               
                isRestart = true;
                Program.myMenu.isRestart = this.isRestart;
                this.Close();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
