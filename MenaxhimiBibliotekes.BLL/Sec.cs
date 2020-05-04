using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BLL
{
   public class Sec
    {

        public static string Hash(string username,string password)
        {

            return ComputeHash(SaltPassword(username,password)).Substring(0,40);

        }


        private static string ComputeHash(string password)
        {
            byte[] data = Encoding.ASCII.GetBytes(password);
            string result;
            SHA512 sha = new SHA512Managed();
            result = Convert.ToBase64String(sha.ComputeHash(data));
            return result;
        }

        private static string SaltPassword(string username, string password )
        {

            char[] userchar = username.ToCharArray();

            for (int i = 0; i < userchar.Length; i++)
            {
                password = userchar[i] + password;

                i++;

                if (i >= userchar.Length)
                {
                    break;
                }
                password = password + userchar[i];

            }

            return password;

        }

    }
}
