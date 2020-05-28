using Org.BouncyCastle.Math.EC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class UserCenter : Form
    {
        
        public UserCenter()
        {
            InitializeComponent();
            label1.Text = "你好，" + Login.Getname();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //System.Environment.Exit(0);
            //Application.Exit();
            Welcome insert = new Welcome();
            insert.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChangePassword insert = new ChangePassword();
            insert.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DebitCard insert = new DebitCard();
            insert.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreditCard insert = new CreditCard();
            insert.Show();
        }
    }
}
