using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace Bank
{
    public partial class ForeignExchange : Form
    {
        //int nowExc = 0;
        double nowExc;
        double sellprice1, buyprice1;
        string phonenumber = Login.Getphonenum();
        public ForeignExchange()
        {
            InitializeComponent();
            //holdExc.Text = nowExc.ToString();
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_CLOSE = 0xF060;

            if (m.Msg == WM_SYSCOMMAND && ((int)m.WParam == SC_CLOSE))
            {
                DebitCard.debit.Show();
                this.Close();

                return;
            }
            base.WndProc(ref m);
        }
        private void currencyChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            double sellprice2, buyprice2;
            String excKey = currencyChoose.Text;
            string url = @"https://www.boc.cn/sourcedb/whpj/";
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            string pagehtml = client.DownloadString(url);
            pagehtml = pagehtml.Replace("\t", "");
            pagehtml = pagehtml.Replace("\t", "");
            string []words = pagehtml.Split('\n');
            int count = 0;
            foreach (string word in words)
            {
                string pattern = "<td></td>$";
                pattern = pattern.Insert(4, excKey);
                Regex rx = new Regex(pattern);
                Match m = rx.Match(word);
                if (m.Success)
                    break;
                count++;
            }
            string pricePattern = "[0-9.]+";
            Regex rx1 = new Regex(pricePattern);
            Match m1 = rx1.Match(words[count+1]);
            if (m1.Success)
                buyPrice.Text = m1.Value;
            Regex rx2 = new Regex(pricePattern);
            Match m2 = rx1.Match(words[count + 3]);
            if (m2.Success)
                sellPrice.Text = m2.Value;

            sellprice2 = double.Parse(sellPrice.Text);
            buyprice2 = double.Parse(buyPrice.Text);

            string sql = "Select * from foreignexchange where 手机号='" + phonenumber + "'AND 货币种类='" + excKey + "'";
            DB.MySqlDataBase mdb = new DB.MySqlDataBase();
            MySqlDataReader rd = mdb.read(sql);

            rd.Read();
            
            string a;
            a = rd["货币持有量"].ToString();
            nowExc = double.Parse(a);
            
            rd.Close();                             //关闭连接


            //int nowexc = 0;         //需要数据库提供数据（当前币种拥有的货币量）（币种：excKey)
            holdExc.Text = nowExc.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(excToRmbBtn.Checked)
            {
                double excToRmb;
                try
                {
                    excToRmb = double.Parse(excNum.Text);
                    double sellprice3 = double.Parse(sellPrice.Text);
                    double exc_excToRmb = (excToRmb / sellprice3) * 100;
                    //因为用户输入的是人民币，这里把人民币换成对应货币在比较是否会发生"您拥有的货币量不足"

                    string excKey = currencyChoose.Text;
                    //int nowexc = 0;         //需要数据库提供数据（当前币种拥有的货币量）（币种：excKey)

                    double nowrmb;
                    string sql = "Select * from foreignexchange where 手机号='" + phonenumber + "'AND 货币种类='" + excKey + "'";
                    string sql2 = "Select * from debitcardinfo where 手机号='" + phonenumber + "'";
                    DB.MySqlDataBase mdb = new DB.MySqlDataBase();
                    MySqlDataReader rd = mdb.read(sql);
                    MySqlDataReader rd2 = mdb.read(sql2);

                    rd.Read();

                    string a;
                    a = rd["货币持有量"].ToString();
                    nowExc = double.Parse(a);

                    rd2.Read();

                    string b;
                    b = rd2["活期存款余额"].ToString();       //读出此时储蓄卡的余额到string型变量b
                    nowrmb = double.Parse(b);

                    rd.Close();                             //关闭连接
                    rd2.Close();

                    if (exc_excToRmb > nowExc)
                    {
                        MessageBox.Show("您拥有的货币量不足");
                    }
                    else
                    {
                        //更新数据库(减少该种货币量以及增加人民币储蓄)
                        //返回上一界面

                        double newexc, newrmb;   //兑换后的外币和人民币
                        //double sellprice3 = double.Parse(sellPrice.Text);
                        //计算公式 
                        newexc = nowExc - (excToRmb / sellprice3) * 100;
                        newrmb = nowrmb + excToRmb;
                        string sql3 = "UPDATE debitcardinfo SET 活期存款余额 = '" + newrmb + "' where 手机号='" + phonenumber + "'";
                        string sql4 = "UPDATE foreignexchange SET 货币持有量 = '" + newexc + "' where 手机号='" + phonenumber + "'AND 货币种类='" + excKey + "'";
                        DB.MySqlDataBase db3 = new DB.MySqlDataBase();
                        int ext3 = mdb.Excute(sql3);
                        int ext4 = mdb.Excute(sql4);
                        if (ext4 > 0)
                        {
                            MessageBox.Show("兑换成功！");
                            ForeignExchange insert = new ForeignExchange();
                            insert.Show();
                            this.Close();
                            //更新界面
                        }

                        //更新数据库(减少该种货币量以及增加人民币储蓄)



                    }


                }
                catch
                {
                    MessageBox.Show("请输入数字");
                }
                
            }

            else if (rmbToExcBtn.Checked)
            {
                double rmbToExc;
                try
                {
                    rmbToExc = double.Parse(excNum.Text);

                    //int rmbToExc = int.Parse(excNum.Text);
                    string excKey = currencyChoose.Text;
                    //int nowrmb = 0;     //需要数据库提供数据（人民币储蓄）（币种：excKey）

                    double nowrmb;
                    string sql = "Select * from foreignexchange where 手机号='" + phonenumber + "'AND 货币种类='" + excKey + "'";
                    string sql2 = "Select * from debitcardinfo where 手机号='" + phonenumber + "'";
                    DB.MySqlDataBase mdb = new DB.MySqlDataBase();
                    MySqlDataReader rd = mdb.read(sql);
                    MySqlDataReader rd2 = mdb.read(sql2);
                    
                    rd.Read();
                    string a;
                    a = rd["货币持有量"].ToString();
                    nowExc = double.Parse(a);

                    rd2.Read();
                    string b;
                    b = rd2["活期存款余额"].ToString();       //读出此时储蓄卡的余额到string型变量b
                    nowrmb = double.Parse(b);

                    rd.Close();                             //关闭连接


                    if (rmbToExc > nowrmb)
                    {
                        MessageBox.Show("您的人民币储蓄不足");
                    }
                    else
                    {
                        //更新数据库(减少人民币储蓄以及增加该种货币量)（币种：excKey）
                        //返回上一界面

                        double newexc, newrmb;   //兑换后的外币和人民币 
                        double buyprice4 = double.Parse(buyPrice.Text);
                        //计算公式
                        newexc = nowExc + (rmbToExc / buyprice4) * 100;
                        newrmb = nowrmb - rmbToExc;
                        string sql3 = "UPDATE debitcardinfo SET 活期存款余额 = '" + newrmb + "' where 手机号='" + phonenumber + "'";
                        string sql4 = "UPDATE foreignexchange SET 货币持有量 = '" + newexc + "' where 手机号='" + phonenumber + "'AND 货币种类='" + excKey + "'";
                        //更新数据库(减少人民币储蓄以及增加该种货币量)（币种：excKey）

                        DB.MySqlDataBase db3 = new DB.MySqlDataBase();
                        int ext3 = mdb.Excute(sql3);
                        int ext4 = mdb.Excute(sql4);
                        if (ext4 > 0)
                        {
                            MessageBox.Show("兑换成功！");
                            ForeignExchange insert = new ForeignExchange();
                            insert.Show();
                            this.Close();
                            //更新此界面
                        }
                        

                    }


                }
                catch
                {
                    MessageBox.Show("请输入数字");
                }

               
            }

            else
            {
                MessageBox.Show("请选择交易类型");
            }
        }
    }
}
