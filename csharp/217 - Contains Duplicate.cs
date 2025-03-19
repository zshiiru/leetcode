public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        Dictionary<int, bool> DuplicateMap = [];

        foreach (int num in nums)
        {
            if (!DuplicateMap.TryAdd(num, true))
                return true;
        }

        return false;
    }
}
