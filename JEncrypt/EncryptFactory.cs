using JEncrypt.Implemention;
using JEncrypt.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEncrypt
{
    public class EncryptFactory
    {
        static public IJEncrypt GetEncryptInstance(string encryptName)
        {
            if (string.IsNullOrEmpty(encryptName))
            {
                return new DefaultJEncrypt();
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
