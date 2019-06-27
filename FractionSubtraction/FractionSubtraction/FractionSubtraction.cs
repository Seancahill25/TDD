using System;

namespace FractionSubtraction
{
    public class FractionSubtraction
    {
        public static int[] subtractFractions(int[] firstFraction, int[] secondFraction)
        {
            int[] result = new int[2];
            if (firstFraction[1] == secondFraction[1])
            {
                result[0] = firstFraction[0] - secondFraction[0];
                result[1] = firstFraction[1];
            }
            if (firstFraction[1] != secondFraction[1] && firstFraction[1] % secondFraction[1] == 0 || secondFraction[1] % firstFraction[1] == 0)
            {
                int biggestDenominator = Math.Max(firstFraction[1], secondFraction[1]);
                int lowestDenominator = Math.Min(firstFraction[1], secondFraction[1]);
                int toMulitlyBy = biggestDenominator / lowestDenominator;
                result[0] = firstFraction[0] * toMulitlyBy - secondFraction[0];
                result[1] = firstFraction[1] * toMulitlyBy;
            }
            else
            {
                int firstDenominator = firstFraction[1];
                int secondDenominator = secondFraction[1];
                firstFraction[0] *= secondDenominator;
                firstFraction[1] *= secondDenominator;
                secondFraction[0] *= firstDenominator;
                secondFraction[1] *= firstDenominator;
              
                result[0] = firstFraction[0] - secondFraction[0];
                result[1] = secondFraction[1];
            }
            if (result[1] % 2 == 0 && result[0] % 2 == 0)
            {
                result[1] /= 2;
                result[0] /= 2;
            }
            else if (result[1] % result[0] == 0)
            {
                result[1] /= result[0];
                result[0] /= result[0];
            }
            return result;
        }
        
    }
}
