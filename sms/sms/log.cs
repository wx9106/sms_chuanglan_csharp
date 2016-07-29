using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace sms
{
    class log
    {
        public static String init()
        {
            string sPath = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\smslog";
            if (!Directory.Exists(sPath))
            {
                Directory.CreateDirectory(sPath);
            }
            string path = sPath + @"\runinfo.log";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(Environment.UserName);
                    sw.WriteLine(DateTime.Now);
                    //系统标识符和版本号 
                    sw.WriteLine( Environment.OSVersion.ToString());
                    //获取映射到进程上下文的物理内存量 
                    sw.WriteLine(Environment.WorkingSet.ToString());
                    //获取系统启动后经过的毫秒数 
                    sw.WriteLine(Environment.TickCount / 60000);
                    //系统目录的完全限定路径 
                    sw.WriteLine(Environment.SystemDirectory);
                    //获取此本地计算机的 NetBIOS 名称 
                    sw.WriteLine( Environment.MachineName);
                    //获取与当前用户关联的网络域名 
                    sw.WriteLine( Environment.UserDomainName); 
                    sw.Close();
                }
            }
            return path;
        }
        
        public static void write(string s)
        {
            string path = init();
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(DateTime.Now+"-----"+s);
                sw.Close();
            }
        }

        public static String getIP()
        {
            string ip = null;
            IPAddress[] arrIPAddresses = Dns.GetHostAddresses ( Dns.GetHostName ( ) );
            foreach ( IPAddress index in arrIPAddresses )
            {
                if ( index.AddressFamily.Equals ( AddressFamily.InterNetwork ) )
                {
                    ip = index.ToString();
                }
            }
            return ip;
        }
    }
}
