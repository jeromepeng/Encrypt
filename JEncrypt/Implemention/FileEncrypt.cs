using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JEncrypt.Interface;
using JEncrypt.Common;

namespace JEncrypt.Implemention
{
    public class FileEncrypt : IJEncrypt
    {
        public FileEncrypt()
        {

        }
        public byte[] Encrypt(byte[] content, string password, object exData = null)
        {
            Dictionary<string, string> headData = exData as Dictionary<string, string>;
            if (exData != null)
            {
                byte[] encryptStr = Tool.CommonTools.LowEncrypt(content, Tool.CommonTools.GetPasswordBytes(password));
                RawDataParser rdp = new RawDataParser(headData, encryptStr);
                return rdp.RawBytes;
            }
            else
            {
                return null;
            }
        }
        public byte[] Encrypt(string content, string password, object exData = null)
        {
            return Encrypt(Encoding.Unicode.GetBytes(content.ToCharArray()), password, exData);
        }
        public byte[] Decrypt(byte[] encryptContent, string password, out object exData)
        {
            RawDataParser rdp = new RawDataParser(encryptContent);
            exData = rdp;
            return Tool.CommonTools.LowEncrypt(rdp.BodyBytes, Tool.CommonTools.GetPasswordBytes(password));
        }
        public byte[] Decrypt(string encryptContent, string password, out object exData)
        {
            return Decrypt(Encoding.Unicode.GetBytes(encryptContent), password, out exData);
        }
    }
}
