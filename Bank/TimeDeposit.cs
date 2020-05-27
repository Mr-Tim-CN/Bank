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
    public partial class TimeDeposit : Form
    {
        string[] Num = { "1000","2000" };       //用户的定期存款额度
        string[] Year = { "1","3" };      //用户的定期存款类型
        int Balance = 0;               //用户的储蓄卡余额
        public TimeDeposit()
        {
            InitializeComponent();
            cardBalance.Text = Balance.ToString();
            string planDis = "" ;
            int index = 0;
            foreach(string num in Num)
            {
                planDis = planDis.Insert(0,num+"元    "+Year[index]+"年    ");
                index++;
            }
            holdPlan.Text = planDis; //
        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            string[] save;      //数据库更新字符数组
            string plan = (String)planChoose.SelectedItem;
            if(plan!=null)
            {
                save = plan.Split('/');
            }
            else
            {
                MessageBox.Show("请选择您的存款方案");
            }
            int buyPlan = 0;
            try
            {
                buyPlan = int.Parse(buyNum.Text);
            }
            catch
            {
                MessageBox.Show("请输入数字");
            }
            if(buyPlan>Balance)
            {
                MessageBox.Show("您的可用余额不足");
            }
            else
            {
                //向数据库更新购买信息（额度，方案以及储蓄卡余额）
                //界面转场
            }
            
        }
    }
}
