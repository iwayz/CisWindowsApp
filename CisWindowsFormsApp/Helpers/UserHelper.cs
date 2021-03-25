using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace CisWindowsFormsApp
{
    public class UserHelper
    {
        public string HashPassword(string passwordToHash)
        {
            // key CAPUNG-MAGELANG in SHA256
            var securityKey = "593EEAE7AB51FF5D64B8D45FFDF1EC4B2D2A31E58CBD97E68A6FD706AAACB661";
            var pwdBytes = Encoding.UTF8.GetBytes(passwordToHash);
            var secretKeyBytes = Encoding.UTF8.GetBytes(securityKey);
            var hmacSha512 = new HMACSHA512(secretKeyBytes);
            var hashBytes = hmacSha512.ComputeHash(pwdBytes);
            var hashedPassword = new StringBuilder();

            //format each byte as a hexadecimal string.
            for (int i = 0; i < hashBytes.Length; i++)
            {
                hashedPassword.Append(hashBytes[i].ToString("x2"));
            }
            return hashedPassword.ToString();
        }

    }
}
