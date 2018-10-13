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
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Welcome W = new Welcome();
            W.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User UO = new User();
            string Pincode = UO.PinCode;
            int Pin = Convert.ToInt32(Pincode);
            Manager MO = new Manager();
            DataSet ds = new DataSet();
            ds = MO.CheckBalance(Pin);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Show();
            //double Bal = Convert.ToDouble(Balance);
            //MO.CheckBalance(Pin);
            //Balance...
           // MessageBox.Show("Balance is "+Balance.ToString());
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            //textBox1.AppendText("");
        }

        public string Bal { get; set; }
    }
}
