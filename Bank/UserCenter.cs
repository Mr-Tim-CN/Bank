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
        public static UserCenter f2;
        public UserCenter()
        {
            InitializeComponent();
            label1.Text = "你好，" + Login.Getname();
            f2 = this;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //System.Environment.Exit(0);
            //Application.Exit();
            Welcome insert = new Welcome();
            insert.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChangePassword insert = new ChangePassword(f2);
            insert.Show();
        }
    }
}
