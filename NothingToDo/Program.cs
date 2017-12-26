using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NothingToDo
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "abcdefghijklmnopqrstuvwxyz啊喔额衣乌鱼";
            byte[] encryptBytes = JEncrypt.Encrypt.GetEncryptInstance(string.Empty).Encrypt(test, "123");
            Console.WriteLine(Encoding.Unicode.GetString(encryptBytes));
            object exData;
            Console.WriteLine(Encoding.Unicode.GetString(JEncrypt.Encrypt.GetEncryptInstance(string.Empty).Decrypt(encryptBytes, "123", out exData)));
        }
    }
}
