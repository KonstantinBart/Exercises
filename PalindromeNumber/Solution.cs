using System.Collections.Generic;
using System.Linq;

namespace PalindromeNumber
{
    public class Solution
    {
        public static bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            var array = new List<int>();
            while(x != 0)
            {
                array.Add(x % 10);
                x /= 10;
            }
            if(!array.Any() || array.Count <= 2)
            {
                return false;
            }
            while(array.Count > 2)
            {
                var firstElement = array.First();
                var lastElement = array.Last();
                if (firstElement != lastElement)
                    return false;
                array.RemoveAt(0);
                array.RemoveAt(array.Count - 1);
            }
            return true;
        }
    }
}
