using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralConverter
{
    class Converter
    {
       public static Dictionary<char, int> romanValues = new Dictionary<char, int>()
       {
           {'I', 1 },
           {'V', 5 },
           {'X', 10},
           {'L', 50},
           {'C', 100},
           {'D', 500},
           {'M', 1000}
       };
        public int ConvertNumerals(string romanNumerals)
        {   
            int Converted = 0;  
            for(var i = 0; i < romanNumerals.Length; i++)
            {
                if(i + 1 < romanNumerals.Length  && romanValues[romanNumerals[i]] < romanValues[romanNumerals[i + 1]])
                {
                    Converted -= romanValues[romanNumerals[i]];
                } else
                {
                    Converted += romanValues[romanNumerals[i]];
                }
            }
            return Converted;
        }
    }
}
