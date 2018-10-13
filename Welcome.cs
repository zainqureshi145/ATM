using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Balance B = new Balance();
            this.Hide();
            B.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Withdraw W = new Withdraw();
            this.Hide();
            W.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Deposit D = new Deposit();
            this.Hide();
            D.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
