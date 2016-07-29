using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.IO;


namespace sms
{
    class SmsSend
    {
        public static String send(SmsInfo s, String mobile, String content)
        {
            try
            {
                //String url = s.url+"?account=" + s.account + "&pswd=" + s.pswd + "&mobile=" + mobile + "&msg=" + System.Web.HttpUtility.UrlEncode(content) + "&needstatus=" + s.needstatus;
                String newContent = SmsSend.toUrlString(content);
                String url = s.url + "?account=" + s.account + "&pswd=" + s.pswd + "&mobile=" + mobile + "&msg=" + newContent + "&needstatus=" + s.needstatus;
                Uri uri = new Uri(url);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
                request.Method = "GET";
                request.ContentType = "text/html;charset=UTF-8";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream myResponseStream = response.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
                string retString = myStreamReader.ReadToEnd();
                myStreamReader.Close();
                myResponseStream.Close();
                log.write(mobile + "--" + content.Trim());
                log.write(retString);
                return retString.Split(',')[1];
            }
            catch
            {
                return "wrong";
            }
        }

        public static String toUrlString(String s)
        {
            StringBuilder sb = new StringBuilder(s.Trim());
            /*
             * +    URL 中+号表示空格             %2B   
             * 空格 URL中的空格可以用+号或者编码  %20 
             * /   分隔目录和子目录               %2F 
             * ?    分隔实际的URL和参数           %3F     
             * %    指定特殊字符                  %25     
             * #    表示书签                      %23     
             * &    URL 中指定的参数间的分隔符    %26     
             * =    URL 中指定参数的值            %3D
             */
            sb.Replace("+", "%2B");
            sb.Replace(" ", "+");
            sb.Replace("#", "%23");
            sb.Replace("&", "%26");
            sb.Replace("=", "%3D");
            return sb.ToString();
        }
    }
}
