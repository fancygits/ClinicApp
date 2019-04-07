using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Controller
{
    public class Security
    {
        public static string HashSHA1(string value)
        {
            var sha1 = System.Security.Cryptography.SHA1.Create();
            var inputBytes = Encoding.ASCII.GetBytes(value);
            var hash = sha1.ComputeHash(inputBytes);

            var builder = new StringBuilder();
            for (int index = 0; index < hash.Length; index++)
            {
                builder.Append(hash[index].ToString("X2"));
            }

            return builder.ToString();
        }
    }
}
