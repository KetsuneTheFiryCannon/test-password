using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTester
{
    public class StringTester
    {
        public int Complete(string password)
        {
            int gg = 0;

            if (password.Length > 6)
            {
                gg++;
            }
            for (int i = 0; i < password.Length; i++)
            {
                if (int.TryParse(password[i].ToString(), out int result))
                {
                    gg++;
                    break;
                }
            }
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLower(password[i]))
                {
                    gg++;
                    break;
                }
            }
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsUpper(password[i]))
                {
                    gg++;
                    break;
                }
            }
            for (int i = 0; i < password.Length; i++)
            {
                if (!char.IsLetterOrDigit(password[i]))
                {
                    gg++;
                    break;
                }
            }
            return gg;
            //return true;
        }
    }
}