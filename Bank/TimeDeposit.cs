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

namespace Bank
{
    public partial class TimeDeposit : Form
    {
        /*string[] Num = { "1000","2000" };       //用户的定期存款额度
        string[] Year = { "1","3" };      //用户的定期存款类型
        int Balance = 0;               //用户的储蓄卡余额
        */
        string phonenumber = Login.Getphonenum();       //获取本次登录账户的手机号
        public TimeDeposit()
        {
            InitializeComponent();
            /*cardBalance.Text = Balance.ToString();
            string planDis = "" ;
            int index = 0;
            foreach(string num in Num)
            {
                planDis = planDis.Insert(0,num+"元    "+Year[index]+"年    ");
                index++;
            }
            holdPlan.Text = planDis; //
            */
            //根据本次登录账户的手机号查询timedeposit表信息
            string sql = "Select * from timedeposit where 手机号='" + phonenumber + "'";
            DB.MySqlDataBase mdb = new DB.MySqlDataBase();
            MySqlDataReader rd = mdb.read(sql);
            //将timedeposit表信息“额度”“存期”读取到dataGridView中显示
            while (rd.Read())
            {
                string a, b;
                a = rd["额度"].ToString();
                b = rd["存期"].ToString();
                string[] str = { a, b };
                dataGridView1.Rows.Add(str);

            }
            rd.Close();                             //关闭连接

            //根据手机号查询debitcardinfo表，获取此账户目前的储蓄卡余额
            string sql2 = "Select * from debitcardinfo where 手机号='" + phonenumber + "'";
            DB.MySqlDataBase db = new DB.MySqlDataBase();
            MySqlDataReader mdr = db.read(sql2);
            mdr.Read();
            string Balance = mdr["活期存款余额"].ToString();      //用户的储蓄卡余额
            cardBalance.Text = Balance;
            mdr.Close();                                          //关闭连接
        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            //string[] save;      //数据库更新字符数组
            //string save;
            string plan = (String)planChoose.SelectedItem;          //存放用户选择的存期方案
            double buyPlan = 0;                                     //存放用户输入的购买金额
            double debitsum = double.Parse(cardBalance.Text);       //存放当前储蓄卡余额
            if (plan == null)
            {
                MessageBox.Show("请选择您的存款方案");
            }
            else
            {
                try
                {
                    buyPlan = double.Parse(buyNum.Text);
                    if (buyPlan > debitsum)
                    {
                        MessageBox.Show("您的可用余额不足");
                    }
                    else
                    {
                        //向数据库更新购买信息（额度，方案以及储蓄卡余额）
                        //界面转场
                        //newdebitsum存放支付后储蓄卡的余额
                        double newdebitsum = debitsum - buyPlan;
                        //向timedeposit表插入本次购买方案
                        //向debitcardinfo表进行储蓄卡余额更新
                        string sql3 = "INSERT INTO timedeposit VALUES('" + phonenumber + "','" + buyNum.Text + "','" + plan + "')";
                        string sql4 = "UPDATE debitcardinfo SET 活期存款余额 = '" + newdebitsum + "' where 手机号='" + phonenumber + "'";
                        DB.MySqlDataBase db3 = new DB.MySqlDataBase();
                        int ext3 = db3.Excute(sql3);
                        int ext4 = db3.Excute(sql4);
                        if (ext3 > 0)
                        {
                            MessageBox.Show("购买成功！");
                            TimeDeposit insert = new TimeDeposit();
                            insert.Show();
                            
                            this.Close();
                            //更新此窗口
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("请输入购买金额");
                }
            }
            
            
        }
    }
}
