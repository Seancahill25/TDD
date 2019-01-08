using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            var f = 0;
            for(var i = 0; i < 30; i++)
            {
                Console.Write(" |");
                if(i == 29)
                {
                    Console.WriteLine("");
                    if(f == 8)
                    {
                        break;
                    }
                    for(var j = 0; j < 30; j++)
                    {
                        Console.Write("-+");
                        if(j == 29)
                        {
                            Console.WriteLine("-");
                        }
                    }
                    i = -1;
                    f++;
                    
                }
            }
        }
    }
}
