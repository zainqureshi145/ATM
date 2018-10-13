using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace ATM
{
    public partial class LogIn : Form
    {
        User UO = new User();
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User UO = new User();
            UO.PinCode = textBox1.Text;
            //Authenticate User
            Manager MO = new Manager();
            Object Result = MO.Authenticate(UO.PinCode);
            int value = Convert.ToInt32(Result);
            if (value > 0)
            {
                Welcome WC = new Welcome();
                this.Hide();
                WC.Show();
            }
            else
            {
                this.Close();
            }
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UO.PinCode = textBox1.Text;
        }
    }
}
