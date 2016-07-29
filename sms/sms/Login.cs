using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sms
{
    public partial class Login : Form
    {
        private int count = 0;

        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:wx@momfo.com?subject=%e7%be%a4%e5%8f%91%e5%b0%8f%e5%8a%a9%e6%89%8b%e9%97%ae%e9%a2%98%e5%8f%8d%e9%a6%88");
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usernameTxt.Text.Equals("admin") && passwordTxt.Text.Equals("momfo"))
            {
                if (clnameTxt.Text.Equals("") || clpwdTxt.Text.Equals(""))
                {
                    MessageBox.Show("请输入创蓝短信群发用户名或密码！","登录失败");
                    log.write("login failure, wrong chuanglan name or passsowrd " + log.getIP());
                }
                else
                {
                    log.write("login success,"+ log.getIP());
                    SmsInfo s = new SmsInfo();
                    s.set(clnameTxt.Text, clpwdTxt.Text);
                    Send send = new Send();
                    send.set(s);
                    this.Hide();
                    send.Show();
                }
            }
            else
            {
                MessageBox.Show("用户名或密码错误！", "登录失败");
                count++;
                if (count >= 3)
                {
                    MessageBox.Show("错误次数过多，将自动关闭客户端", "登录失败");
                    log.write("try too much wrong exit," + log.getIP());
                    System.Environment.Exit(0);
                }
            }
        }

        private void passwordTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginBtn_Click(sender,e);
            }
        }


    }
}
