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

namespace Bank
{
    public partial class ForeignExchange : Form
    {
        int nowExc = 0;
        public ForeignExchange()
        {
            InitializeComponent();
            holdExc.Text = nowExc.ToString();
        }

        private void currencyChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            int nowexc = 0;         //需要数据库提供数据（当前币种拥有的货币量）（币种：excKey)
            holdExc.Text = nowexc.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(excToRmbBtn.Checked)
            {
                int excToRmb = int.Parse(excNum.Text);
                string excKey = currencyChoose.Text;
                int nowexc = 0;         //需要数据库提供数据（当前币种拥有的货币量）（币种：excKey)
                if(excToRmb>nowexc)
                {
                    MessageBox.Show("您拥有的货币量不足");
                }
                else
                {
                    //更新数据库(减少该种货币量以及增加人民币储蓄)
                    //返回上一界面
                }
            }
            if (rmbToExcBtn.Checked)
            {
                int rmbToExc = int.Parse(excNum.Text);
                string excKey = currencyChoose.Text;
                int nowrmb = 0;     //需要数据库提供数据（人民币储蓄）（币种：excKey）
                if(rmbToExc>nowrmb)
                {
                    MessageBox.Show("您的人民币储蓄不足");
                }
                else
                {
                    //更新数据库(减少人民币储蓄以及增加该种货币量)（币种：excKey）
                    //返回上一界面
                }
            }
        }
    }
}
