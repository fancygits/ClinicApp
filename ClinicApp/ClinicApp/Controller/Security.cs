using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Controller
{
    /// <summary>
    /// This is the security class. It holds a static method used to hash passwords
    /// 
    /// password hash citations - https://stackoverflow.com/questions/17292366/hashing-with-sha1-algorithm-in-c-sharp
    /// </summary>
    public class Security
    {
        public static string Hash(string value)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.Default.GetBytes(value));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("X2"));
                }

                return sb.ToString();
            }        
        }
    }
}
