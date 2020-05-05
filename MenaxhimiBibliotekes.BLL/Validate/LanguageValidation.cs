using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BLL.Validate
{
    public class LanguageValidation : Validation<string>
    {
        public  bool validateLanguage(string text)
        {
            if (AllowedObj(text) && ValidateStringLength(text, 30))
            {
                return true;

            }
            return false;
        }

        public override bool AllowedObj(string text)
        {
            Regex re = new Regex("^[a-zA-Z0-9_.\\)\\(-]+( [a-zA-Z0-9_\\)\\(]+)*$");
            if (re.IsMatch(text))
            {
                return true;

            }

            return false;
        }

        public override bool ValidateStringLength(string text, int Length)
        {
            if (text.Length >= 3 && text.Length< Length)
            {
                return true;
            }
            return false;
        }



    }
}
