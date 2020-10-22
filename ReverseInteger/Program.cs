using System;
using System.Globalization;
using System.Linq;

namespace ReverseInteger
{
    class Program
    {
		static void Main(string[] args)
		{
			Console.WriteLine(Reverse(123));
			Console.WriteLine(Reverse(-123));
			Console.WriteLine(Reverse(120));
			Console.ReadLine();
		}

		public static int Reverse(int x)
		{
			var isNegative = x < 0;
			var numberAsString = x.ToString(CultureInfo.InvariantCulture)
				.TrimEnd('0')
				.TrimStart('-')
				.Reverse();
			var resultString = string.Empty;
			for (int i = 0; i < numberAsString.Count(); i++)
			{
				resultString += numberAsString.ElementAt(i);
			}
			var resultInt = 0;
			try
			{
				resultInt = Convert.ToInt32(resultString);
			}
			catch { }
			return isNegative ? resultInt * -1 : resultInt;
		}
	}
}
