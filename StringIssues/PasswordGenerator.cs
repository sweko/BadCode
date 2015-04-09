using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIssues
{
    public class PasswordGenerator
    {
        public string GeneratePassword()
        {
            string guid = Guid.NewGuid().ToString().ToUpper();
            guid = guid.Replace("-", "");

            string guidInt = "";
            int i = 0;
            char c;
            while (i < guid.Length)
            {
                c = guid[i];
                if ((c < '0') || (c > '9'))
                {
                    ++i;
                    continue;
                }
                guidInt += c.ToString();
                ++i;
            }

            int seed = 0;
            if (guidInt != "")
            {
                try
                {
                    guidInt = guidInt.PadRight(9, '0').Substring(0, 9);
                    seed = Convert.ToInt32(guidInt);
                }
                catch
                {
                }
            }
            Random random = new Random(seed);
            string pwd = "";
            while (pwd.Length <= 8)
            {
                c = (char)random.Next(48, 123);
                if ((c < 48) || ((c > 57) && (c < 65)) || ((c > 90) && (c < 97)) || (c > 122))
                    continue;
                pwd += c.ToString();
            }

            // 05.08.2014 sometimes the PW has no number in it and that is required, so add it here if needed
            i = 0;
            bool bNumberFound = false;
            while (i < pwd.Length)
            {
                char x = System.Convert.ToChar(pwd.Substring(i, 1));
                if (Char.IsNumber(x))
                {
                    bNumberFound = true;
                    break;
                }
                i++;
            }
            if (!bNumberFound) { pwd = pwd + "1"; }

            return pwd;

        }

    }
}
