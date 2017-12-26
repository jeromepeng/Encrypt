using JEncrypt.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEncrypt
{
    public class Encrypt
    {
        public static IJEncrypt GetEncryptInstance(string encryptType)
        {
            return EncryptFactory.GetEncryptInstance(encryptType);
        }
    }
}
