using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sms
{
    public class SmsInfo
    {
        public String url = "http://222.73.117.158/msg/HttpBatchSendSM";// 应用地址
        public String account;// 账号
        public String pswd;// 密码
        public Boolean needstatus = false;// 是否需要状态报告，需要true，不需要false
        public String product = null;// 产品ID
        public String extno = null;// 扩展码

        public void set(String name, String pwd)
        {
            this.account = name;
            this.pswd = pwd;
        }

    }
}
