using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Com.Grooveip.Sdk.Utils
{
    public class HashGenerator
    {
        public static string CreateSHA256(string input)
        {
            SHA256Managed hasher = new SHA256Managed();
            
            byte[] buffer = hasher.ComputeHash(Encoding.ASCII.GetBytes(input), 0, Encoding.ASCII.GetByteCount(input));

            StringBuilder sb = new StringBuilder();

            foreach(byte b in buffer)
            {
                sb.Append(b.ToString("x2"));
            }

            return sb.ToString();

        }
    }
}
