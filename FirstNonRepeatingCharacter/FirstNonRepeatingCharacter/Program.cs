using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstNonRepeatingCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            string Input = "ABCABD";
            var place = 0;
            string firstdifferent = "_";

            for (var i = 1; i < Input.Length && Input.Length > 0;)
            {
                if (Input[place] == Input[i])
                {
                    Input = Input.Replace(Input[place].ToString(), "");
                    Console.WriteLine(Input);
                    i = 1;
                }
                else
                {
                    i++;
                }
            }
            if (Input.Length == 1)
            {
                firstdifferent = Input;
            }
            Console.WriteLine(firstdifferent);
        }
    }
}
