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
        public DebitCard()
        {
            InitializeComponent();
            textBox1.Text = getBalance().ToString();
            label1.Text = "你好，" + Login.Getname();
        }

        decimal Balance;
        public decimal getBalance()
        {
            return Balance;
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
            decimal depositacc = decimal.Parse(textBox3.Text);
            decimal newBalance = getBalance() + depositacc;
            //Update Balance to DB
            //把新的余额的值写入数据库
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal withdrawacc = decimal.Parse(textBox2.Text);
            decimal newBalance = getBalance() - withdrawacc;
            //Update Balance to DB
            //把新的余额的值写入数据库
        }

    }
}
