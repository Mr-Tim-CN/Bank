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
    public partial class CreditCard : Form
    {
        public CreditCard()
        {
            InitializeComponent();
        }

        public double usedCrd;
        public double usableCrd;
        public double defaultCrd = 3000;

        public double draw;
        public double pay;

        public double getUsed()
        {
            //………… get "已用额度" from DB
            return usedCrd; 
        }

        public double getUsable()
        {
            //………… get "可用额度" from DB
            return usableCrd;   
        }
  

        private void UsableCrd_TextChanged(object sender, EventArgs e)
        {
            UsableCrdTBox.Text = getUsable().ToString();
        }

        private void UsedCrd_TextChanged(object sender, EventArgs e)
        {
            UsedCrdTBox.Text = getUsed().ToString();
        }

        private void PayBtn_Click(object sender, EventArgs e)
        {
            double pay = System.Convert.ToDouble(PayTBox.Text);
            if (pay <= getUsed())
            {
                UsedCrdTBox.Text = (getUsed() - pay).ToString();   // Update "已用额度" text
                UsableCrdTBox.Text = (getUsable() + pay).ToString();   // Update "可用额度" text
                //Update DB
            }
            else MessageBox.Show("超出需还额度！");
        }

        private void DrawBtn_Click(object sender, EventArgs e)
        {
            double draw = System.Convert.ToDouble(DrawTbox.Text);
            if (draw <= getUsable())
            {
                UsedCrdTBox.Text = (getUsed() + draw).ToString();   // Update "已用额度" text
                UsableCrdTBox.Text = (getUsable() - draw).ToString();   // Update "可用额度" text
                //Update DB
            }
            else MessageBox.Show("超出可用额度！");
        }
    }
}
