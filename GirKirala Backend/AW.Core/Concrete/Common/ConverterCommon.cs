using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace AW.Core.Concrete.Common
{
    public class ConverterCommon
    {
        private static MD5CryptoServiceProvider md5 = null;
        public static string MD5Convert(string text)
        {
            md5 = new MD5CryptoServiceProvider();
            byte[] array = Encoding.UTF8.GetBytes(text);
            array = md5.ComputeHash(array);
            StringBuilder sb = new StringBuilder();
            foreach (var item in array)
            {
                sb.Append(item.ToString("x2").ToLower());
            }
            return sb.ToString();
        }
    }
}