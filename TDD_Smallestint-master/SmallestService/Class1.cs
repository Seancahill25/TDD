using System;
using System.Linq;

namespace SmallestService
{
    public class Finder
    {
        public int FindSmallestInt(int[] array)
        {   
           if(array.Length > 0)
            {
                Array.Sort(array);
                return array[0];
            }
           throw new ArgumentException("array is empty");
        }

        public int FindClosestIntToZero(int[] input)
        {
            if (input.Length > 1)
            {
                Array.Sort(input);
                var i = 0;
                if (Math.Abs(input[i]) > Math.Abs(input[i + 1])) i++;
                return input[i];
            }
            else if (input.Length == 1) return input[0];
            throw new ArgumentException("array is empty");
        }
    }
}
