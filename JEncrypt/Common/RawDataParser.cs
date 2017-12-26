using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEncrypt.Common
{
    public struct HeadDataType
    {
        public static string Suffix = "suffix";
        public static string Length = "length";
    }

    public class RawDataParser
    {
        private Dictionary<string, string> head = new Dictionary<string, string>();

        private byte[] headBytes = null;

        private byte[] bodyBytes = null;

        private byte[] rawBytes = null;

        public Dictionary<string, string> Head
        {
            get
            {
                return head;
            }
        }

        public byte[] HeadBytes
        {
            get
            {
                return headBytes;
            }
        }

        public byte[] RawBytes
        {
            get
            {
                return rawBytes;
            }
        }

        public long Length
        {
            get
            {
                if (head.ContainsKey(HeadDataType.Length))
                {
                    return Convert.ToInt64(head[HeadDataType.Length]);
                }
                else
                {
                    return 0;
                }
            }
        }

        public byte[] BodyBytes
        {
            get
            {
                return bodyBytes;
            }
        }

        public string Suffix
        {
            get
            {
                if (head.ContainsKey(HeadDataType.Suffix))
                {
                    return head[HeadDataType.Suffix];
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public RawDataParser(Dictionary<string, string> headData, byte[] bodyData)
        {
           rawBytes = createRawData(headData, bodyData);
        }

        public RawDataParser(byte[] data)
        {
            parseRawData(data);
        }

        private byte[] createRawData(Dictionary<string, string> headData, byte[] bodyData)
        {
            head = headData;
            List<byte> result = new List<byte>();
            string resultString = string.Empty;
            foreach (KeyValuePair<string, string> kvp in head)
            {
                resultString += kvp.Key + ":" + kvp.Value + ";";
            }
            resultString.Substring(0, resultString.Length - 1);
            int length = resultString.Length;
            byte[] intBytes = BitConverter.GetBytes(length);
            result.AddRange(intBytes);
            result.AddRange(Encoding.Unicode.GetBytes(resultString.ToCharArray()));
            result.AddRange(bodyData);
            return result.ToArray();
        }

        private void parseRawData(byte[] data)
        {
            if (data.Length > 5)
            {
                byte[] intBytes = new byte[4];
                Array.Copy(data, intBytes, 4);
                int length = BitConverter.ToInt32(intBytes, 0);
                headBytes = new byte[length];
                Array.Copy(data, 4, headBytes, 0, length);
                if (headBytes.Length > 0)
                {
                    string dataStr = Encoding.Unicode.GetString(headBytes);
                    string[] kvps = dataStr.Split(';');
                    foreach (string kvp in kvps)
                    {
                        string[] kap = kvp.Split(':');
                        head.Add(kap[0], kap[1]);
                    }
                }
                Array.Copy(data, 4 + length, bodyBytes, 0, Length);
            }       
        }
    }
}
