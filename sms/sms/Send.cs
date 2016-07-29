using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace sms
{
    public partial class Send : Form
    {
        private SmsInfo smsInfo = new SmsInfo();
        private int num = 0;
        private int snum = 0;
        public void set(SmsInfo s)
        {
            this.smsInfo=s;
        }
        private List<String> mobiles = new List<String>();

        public Send()
        {
            InitializeComponent();
            string dir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            openFileDialog1.InitialDirectory = dir;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            log.write("normal exit "+log.getIP());
            System.Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "用户信息";
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            String filePath = openFileDialog1.FileName;
            openFileDialog1.InitialDirectory = filePath;
            mobiles.Clear();
            listBox1.Items.Clear();
            if (File.Exists(filePath)){              
                using (StreamReader sr = File.OpenText(filePath))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        System.Text.RegularExpressions.Regex rex = new System.Text.RegularExpressions.Regex(@"^\d+$");
                        if (s.Length == 11&& rex.IsMatch(s))
                        {
                            if (!mobiles.Contains(s))
                            {
                                mobiles.Add(s);
                                listBox1.Items.Add(s);
                            }
                        }
                    }
                }
            }
            msgLab.Text = "你将给 " + mobiles.Count + " 个人群发信息，短信字数共计为 " + contentTxt.Text.Length + " 个";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mobiles.Clear();
            listBox1.Items.Clear();
            msgLab.Text = "你将给 " + mobiles.Count + " 个人群发信息，短信字数共计为 " + contentTxt.Text.Length + " 个";
        }

        private void contentTxt_TextChanged(object sender, EventArgs e)
        {
            msgLab.Text = "你将给 " + mobiles.Count + " 个人群发信息，短信字数共计为 " + contentTxt.Text.Length + " 个";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (contentTxt.Text.Length > 0)
            {
                if (mobiles.Count > 0)
                {
                    DialogResult dr = MessageBox.Show(msgLab.Text + "\n\n短信内容如下:\n" + contentTxt.Text + "\n\n确定吗？", "发送确认", MessageBoxButtons.OKCancel);
                    if (dr == DialogResult.OK)
                    {
                        int sc = 0, fc = 0;
                        foreach (String mobile in mobiles)
                        {
                            String r = SmsSend.send(smsInfo, mobile, contentTxt.Text);
                            if (r.Equals("0"))
                            {
                                sc++;
                                log.write(mobile + "," + 0 + " " + "成功");
                            }
                            else
                            {
                                fc++;
                                log.write(mobile + "," + 0 + " " + "失败");
                            }
                        }
                        snum += sc;
                        num += sc + fc;
                        string b = "发送成功：" + sc + "人\n发送失败：" + fc + "人";
                        log.write(b);
                        MessageBox.Show(b, "发送状态");
                    }
                    else
                    {
                        MessageBox.Show("短信未发送！");
                    }
                }
                else
                {
                    MessageBox.Show("没有用户，请检查后重试！");
                }
            }
            else
            {
                MessageBox.Show("请输入短信内容！");
            }
            sumLab.Text = "登录成功后，你已发送了 "+num+" 条信息，成功了 "+snum+" 条";
            log.write(sumLab.Text);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://222.73.117.158/msg");
        }
    }
}
