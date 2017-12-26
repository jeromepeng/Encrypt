using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEncrypt.Interface
{
    public interface IJEncrypt
    {
        byte[] Encrypt(byte[] content, string password);
        byte[] Encrypt(string content, string password);
        byte[] Decrypt(byte[] encryptContent, string password);
        byte[] Decrypt(string encryptContent, string password);
    }
}
