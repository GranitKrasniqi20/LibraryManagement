using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BLL.Validate
{
    public class LanguageValidation : Validation
    {
        public  bool validateLanguage(string text)
        {
            if (AllowedString(text) && ValidateStringLength(text))
            {
                return true;

            }
            return false;
        }

        public override bool AllowedString(string text)
        {
            Regex re = new Regex("^[a-zA-Z0-9_.\\)\\(-]+( [a-zA-Z0-9_\\)\\(]+)*$");
            if (re.IsMatch(text))
            {
                return true;

            }

            return false;
        }

        public override bool ValidateStringLength(string text)
        {
            if (text.Length >= 3 && text.Length< 30)
            {
                return true;
            }
            return false;
        }



    }
}
