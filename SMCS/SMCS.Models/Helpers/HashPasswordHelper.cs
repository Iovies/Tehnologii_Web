using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCS.Models.Helpers
{
    public class HashPasswordHelper
    {
        public static string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
        public static bool VerifyPassword(string password, string hash)
        {
            return HashPassword(password).Substring(0,30) == hash;
        }   
    }
}
