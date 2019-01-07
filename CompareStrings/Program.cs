using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var string1 = "this";
            var string2 = "that";
            int[] total = new int[string1.Length];

            string1.ToCharArray();
            string2.ToCharArray();

            for(var i = 0; i < string1.Length; i++)
            {
                total[i] = string1[i] - string2[i];
            }
            Console.WriteLine(total);
            foreach(var i in total)
            {
                Console.WriteLine(i);
            }
        }
    }
}
