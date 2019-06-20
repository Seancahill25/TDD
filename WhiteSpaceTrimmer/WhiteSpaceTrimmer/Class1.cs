using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Services
{
    public class TrimSpaces
    {
        public static string CheckForWhiteSpace(string input)
        {
            StringBuilder newstring = new StringBuilder(input);
            bool firstLetterFound = false;
            if (input == null)
                throw new NullReferenceException();

            if (input == string.Empty)
                throw new ArgumentException();

            for(var i = 0; i < newstring.Length; i++)
            {
                if (firstLetterFound == false && !Char.IsWhiteSpace(newstring[i]))
                    firstLetterFound = true;
                
                if (firstLetterFound == true && newstring[i] == ' ' || newstring[i] == '\t')
                    newstring[i] = 'x';
            }
            return newstring.Replace("x","").ToString();
        }
    }
}