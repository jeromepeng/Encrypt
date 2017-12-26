using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEncrypt.Interface
{
    public interface IJEncrypt
    {
        byte[] Encrypt(byte[] content, string password, object exData = null);
        byte[] Encrypt(string content, string password, object exData = null);
        byte[] Decrypt(byte[] encryptContent, string password, out object exData);
        byte[] Decrypt(string encryptContent, string password, out object exData);
    }
}
