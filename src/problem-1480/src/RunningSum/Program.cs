using System.Globalization;

public class Solution {

    public int[] RunningSum(int[] nums) {

        int[] runningArray = [];
        
        for(int i = 0; i < nums.Length; i++)
        {
            runningArray = nums[i];
        }

        return nums;
    }

    public static void Main()
    {
        Console.WriteLine("I am running....");

        int[] array = [1, 2, 3, 4, 5]; // [1, 3, 6, 10, 15]

        Solution solution = new Solution();
        solution.RunningSum(array);
    }
}