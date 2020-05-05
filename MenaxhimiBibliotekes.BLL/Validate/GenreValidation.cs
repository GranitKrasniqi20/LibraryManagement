using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BLL.Validate
{
    public class GenreValidation : Validation<string>
    {

        public bool ValidateGenre(string text) {

            if (AllowedObj(text) && ValidateStringLength(text, 30))
            {
                return true;

            }
            return false;
        }
        public override bool AllowedObj(string text)
        {
            Regex re = new Regex("^[a-zA-Z]+( [a-zA-Z]+)*$");
            if (re.IsMatch(text))
            {
                return true;
            }
            return false;
        }

        public override bool ValidateStringLength(string text, int Length)
        {
            if (text.Length >= 2 && text.Length < Length)
            {
                return true;
            }
            return false;
        }
    }
}
