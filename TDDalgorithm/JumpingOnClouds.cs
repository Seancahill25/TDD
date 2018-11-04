using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDalgorithm
{
    public class JumpingOnClouds
    {
        public static int Calculate(int [] cloudsArray)
        {   
            int jumps = 0;
            
                //for (var i = 0; i < cloudsArray.Length - 1; i++)
                //{
                //    jumps++;
                //    if(cloudsArray[i] == 1 || cloudsArray[i + 2])
                //    {
                //        jumps--;
                //    }
                //}
            
            for (var i = 0; i < cloudsArray.Length - 1; i++)
            {
                if (i < cloudsArray.Length - 2 && cloudsArray[i+2] == 0)
                {
                    i++;
                    jumps++;
                }
                else
                {
                    jumps++;
                }
            }

           

            return jumps;
        }
    }
}
