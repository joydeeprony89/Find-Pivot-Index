// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//https://leetcode.com/problems/find-pivot-index/description/

public class Solution
{
  public int PivotIndex(int[] nums)
  {
    /*
    O(N) run time and O(1) space
    */

    // Step 1 - assing the sum to r and 0 to left
    // Step 2 - at each index, will deduct the current no from the r and add that no to l
    // during array iteration, check at any index l == r, return the current index
    int l = 0; int r = nums.Sum();
    for (int i = 0; i < nums.Length; i++)
    {
      var n = nums[i];
      r = r - n;
      if (l == r) return i;
      l = l + n;
    }

    return -1;
  }
}
