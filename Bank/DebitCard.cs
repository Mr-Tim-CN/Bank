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
    
    public partial class DebitCard : Form
    {
        public static Form debit;
        public DebitCard()
        {
            InitializeComponent();
            debit = this;
        }

        double Balance;
        public double getBalance()
        {
            return Balance;
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_CLOSE = 0xF060;

            if (m.Msg == WM_SYSCOMMAND && ((int)m.WParam == SC_CLOSE))
            {
                UserCenter.user.Show();
                this.Close();

                return;
            }
            base.WndProc(ref m);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TimeDeposit insert = new TimeDeposit();
            insert.Show();
            this.Hide();
        }



        private void button5_Click(object sender, EventArgs e)
        {
            ForeignExchange foreignExchange = new ForeignExchange();
            foreignExchange.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double depositacc = System.Convert.ToDouble(textBox3.Text);
            double newBalance = getBalance() + depositacc;
            //Update Balance to DB
            //把新的余额的值写入数据库
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double withdrawacc = System.Convert.ToDouble(textBox2.Text);
            double newBalance = getBalance() - withdrawacc;
            //Update Balance to DB
            //把新的余额的值写入数据库
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = getBalance().ToString();
        }
    }
}
