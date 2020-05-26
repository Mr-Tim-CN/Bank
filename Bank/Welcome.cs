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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register insert = new Register();
            insert.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login insert = new Login();
            insert.Show();
            this.Hide();
        }
    }
}
