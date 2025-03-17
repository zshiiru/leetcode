public class Solution
{
    public bool UniqueOccurrences(int[] arr)
    {
        Dictionary<int, int> counterDictionary = new();

        foreach (int value in arr)
        {
            if (counterDictionary.ContainsKey(value))
            {
                counterDictionary[value]++;
            }
            else
            {
                counterDictionary.Add(value, 1);
            }
        }

        foreach (KeyValuePair<int, int> keyValuePair in counterDictionary)
        {
            counterDictionary.Remove(keyValuePair.Key);
            
            if (counterDictionary.ContainsValue(keyValuePair.Value))
                return false;
        }

        return true;
    }
}
