using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BLL
{
    class Sec
    {
        public string Hash(string password, string username)
        {
            return ComputeHash(SaltPassword(password, username));
        }


        private string ComputeHash(string password)
        {
            byte[] data = Encoding.ASCII.GetBytes(password);
            string result;
            SHA512 sha = new SHA512Managed();
            result = Convert.ToBase64String(sha.ComputeHash(data));
            return result;
        }
        private string SaltPassword(string password, string username)
        {

            char[] userchar = username.ToCharArray();

            for (int i = 0; i < userchar.Length; i++)
            {
                password = userchar[i] + password;

                i++;

                password = password + userchar[i];

            }

            return password;

        }

    }
}
