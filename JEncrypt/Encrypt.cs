using JEncrypt.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEncrypt
{
    public struct EncryptType
    {
        public static string FileEncrypt = "FileEncrypt";
    }

    public class Encrypt
    {
        public static IJEncrypt GetEncryptInstance(string encryptType)
        {
            EncryptFactory ef = new EncryptFactory();
            return ef.GetEncryptInstance(encryptType);
        }
    }
}
