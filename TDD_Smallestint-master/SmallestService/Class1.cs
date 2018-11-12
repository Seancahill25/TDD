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
                return Convert.ToInt32(array[0]);
            }
           throw new ArgumentException("array is empty");
        }

        public int FindClosestIntToZero(int[] input)
        {
            if(input.Length > 0)
            {
                Array.Sort(input);
                var negativeComparer = 0;
                return Convert.ToInt32(input[0]);
            }
            throw new ArgumentException("array is empty");
        }
    }
}
