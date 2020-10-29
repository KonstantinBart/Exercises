using System;

namespace SquareEveryDigit
{
    public class SquareEveryDigit
    {
        public static int SquareDigits(int n)
        {
            int result = 0;
            SumOfDigits(n, ref result);
            return result;
        }

        private static int SumOfDigits(int n, ref int res)
        {
            if (n == 0)
                return 0;
            var stepValue = n % 10;
            var squareValue = stepValue * stepValue;
            res = Convert.ToInt32(squareValue * Math.Pow(10, GetIntegerNumberLength(res))) + res;
            return SumOfDigits(n / 10, ref res);
        }

        private static int GetIntegerNumberLength(int number)
        {
            int result = 0;
            while (number != 0)
            {
                ++result;
                number /= 10;
            }
            return result;
        }
    }
}
