namespace PalindromeNumber
{
    public class Solution
    {
        public static bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            var sourceValue = x;
            int result = 0;
            while(x > 0)
            {
                result = result * 10 + x % 10;
                x /= 10;
            }
            return sourceValue == result;
        }
    }
}
