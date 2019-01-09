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
            var across = 5;
            var down = 5;
            var f = 0;
            for (var i = 0; i < across; i++)
            {
                Console.Write(" |");
                if (i == across - 1)
                {
                    Console.WriteLine("");
                    if (f == down)
                    {
                        break;
                    }
                    for (var j = 0; j < across; j++)
                    {
                        Console.Write("-+");
                        if (j == across - 1)
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
