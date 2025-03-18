public class Solution {
    public int[] SortedSquares(int[] nums) {
        int left = 0;
        int right = nums.Length - 1;

        int[] results = new int[nums.Length];
        int index = results.Length - 1;

        while (left <= right) {
            if (Math.Abs(nums[left]) > Math.Abs(nums[right])) {
                results[index--] = nums[left] * nums[left];
                left++;
            } else
            {
                results[index--] = nums[right] * nums[right];
                right--;
            }
        }

        return results;
    }
}
