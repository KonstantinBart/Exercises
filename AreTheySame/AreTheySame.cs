using System;
using System.Linq;

namespace AreTheySame
{
    public class AreTheySame
    {
        public static bool comp(int[] a, int[] b)
        {
            if (a == null || b == null) return false;
            if (!a.Any() || !b.Any()) return false;
            a = a.OrderBy(x => x).Select(x => x * x).ToArray();
            b = b.OrderBy(x => x).ToArray();
            return a.SequenceEqual(b);
        }
    }
}
