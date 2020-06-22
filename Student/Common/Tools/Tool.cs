using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Common.Tools
{
    class Tool
    {
        

        public static string getHostName()
        {
            return Dns.GetHostName();
        }

        public static string getLocalHostName()
        {
            return Dns.GetHostEntry("localhost").HostName;
        }

        /// <summary>
        /// 解析数据库字段名称转为驼峰式命名法，
        /// brand_id --> BrandId
        /// hello_ni_hao --> HelloNiHao
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string analysisFieldName(string name)
        {
            string[] splits = name.Split(new char[]{'_'});
            ////前半部分
            //string prefix = splits[0].Substring(0, 1).ToUpper() + splits[0].Substring(1, splits[0].Length - 1);
            ////后半部分
            //string suffix = splits[1].Substring(0, 1).ToUpper() + splits[1].Substring(1, splits[1].Length - 1);
            string _name = "";
            for (int i = 0; i < splits.Length; i++)
            {
                _name += splits[i].Substring(0, 1).ToUpper() + splits[i].Substring(1, splits[i].Length - 1);
            }
            

            return _name;
        }

        /// <summary>
        /// 随机8位数
        /// </summary>
        /// <returns></returns>
        public static string randomNumber(int Digit)
        {
            var chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            var result = new string(
               Enumerable.Repeat(chars, Digit)
                         .Select(s => s[random.Next(s.Length)])
                         .ToArray());

            return result;
        }

        public static void show(string message)
        {
        }

    }
}
