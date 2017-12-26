using JEncrypt.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEncrypt.Implemention
{
    public class DefaultJEncrypt : IJEncrypt
    {
        public DefaultJEncrypt()
        {
 
        }
        public byte[] Encrypt(byte[] content, string password, object exData = null)
        {
            byte[] encryptStr = Tool.CommonTools.LowEncrypt(content, Tool.CommonTools.GetPasswordBytes(password));
            //byte[] trueEncryptStr = Tool.CommonTools.LowEncrypt(encryptStr, Tool.CommonTools.GetEncryptPassword(Tool.CommonTools.GetPasswordBytes(password)));
            return encryptStr;
        }
        public byte[] Encrypt(string content, string password, object exData = null)
        {
            return Encrypt(Encoding.Unicode.GetBytes(content.ToCharArray()), password);
        }
        public byte[] Decrypt(byte[] encryptContent, string password, out object exData)
        {
            exData = null;
            return Tool.CommonTools.LowEncrypt(encryptContent, Tool.CommonTools.GetPasswordBytes(password));
        }
        public byte[] Decrypt(string encryptContent, string password, out object exData)
        {
            return Decrypt(Encoding.Unicode.GetBytes(encryptContent), password, out exData);
        }
    }
}
