using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedString
{
    public class Repeater
    {
        public int RepeatFunction(string input, int num)
        {
            var counter = 0;
            for (int i = 0, j = 0; i < num; i++, j++)
            {
                if (j == input.Length) j = 0;
                if (input[j] == 'a')
                {
                    counter++;
                }
            }
            return counter;
        }
            
    }
}
