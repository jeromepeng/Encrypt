using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace JEncrypt.Tool
{
    public class CommonTools
    {
        public static byte[] GetPasswordBytes(string pw)
        {
            byte[] result = null;
            MD5 md5 = new MD5CryptoServiceProvider();
            result = md5.ComputeHash(Encoding.Unicode.GetBytes(pw));
            return result;
        }

        public static byte[] GetEncryptPassword(byte[] pwByte)
        {
            byte[] result = null;
            MD5 md5 = new MD5CryptoServiceProvider();
            result = md5.ComputeHash(pwByte);
            return result;
        }

        public static byte[] LowEncrypt(byte[] oriStr, byte[] pw)
        {
            byte[] result = new byte[oriStr.Length];
            int pwIndex = 0;
            for (int i = 0; i < oriStr.Length; i++)
            {
                result[i] = oriStr[i] == 0 ? (byte)0:(byte)(oriStr[i] ^ pw[pwIndex]);
                if (pwIndex < pw.Length - 1)
                {
                    pwIndex++;
                }
                else
                {
                    pwIndex = 0;
                }
            }
            return result;
        }

        public static string ByteToBinaryString(byte[] bytes)
        {
            string result = "";
            for (int i = 0; i < bytes.Length; i++)
            {
                result += System.Convert.ToString(bytes[i], 2).PadLeft(8, '0');
            }
            return result;
        }

        public static byte[] BinaryStringToByte(string biString)
        {
            byte[] result = null;
            if (biString.Length % 8 == 0)
            {
                int length = biString.Length / 8;
                for (int i = 0; i < length; i++)
                {

                }
            }
            return result;
        }
    }
}
