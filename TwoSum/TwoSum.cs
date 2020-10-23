using System;

namespace TwoSum
{
	public class TwoSum
	{
		public static int[] GetTwoSum(int[] nums, int target)
		{
			for (int i = 0; i <= nums.Length - 1; i++)
			{
				for (int j = i + 1; j < nums.Length; j++)
				{
					if (nums[i] + nums[j] == target)
						return new[] { i, j };
				}
			}
			throw new InvalidOperationException("There is no decision for number " + target);
		}
	}
}
