using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BLL.Validate
{
    public class GenreValidation : Validation
    {

        public bool ValidateGenre(string text) {

            if (AllowedString(text) && ValidateStringLength(text))
            {
                return true;

            }
            return false;
        }
        public override bool AllowedString(string text)
        {
            Regex re = new Regex("^[a-zA-Z]+( [a-zA-Z]+)*$");
            if (re.IsMatch(text))
            {
                return true;
            }
            return false;
        }

        public override bool ValidateStringLength(string text)
        {
            if (text.Length >= 2 && text.Length < 30)
            {
                return true;
            }
            return false;
        }
    }
}
