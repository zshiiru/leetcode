// not an ideal approach but good enough
public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {

        if (s.Length != t.Length) return false;

        Dictionary<char, char> ReplaceDictionary = new();
        HashSet<char> Mapped = [];

        for (int i = 0; i < s.Length; i++)
        {
            char ch = s[i];

            if (ReplaceDictionary.ContainsKey(ch))
            {
                if (t[i] != ReplaceDictionary[ch])
                    return false;
                continue;
            }

            if (Mapped.Contains(t[i]))
                return false;

            ReplaceDictionary.Add(ch, t[i]);
            Mapped.Add(t[i]);
        }
        return true;
    }
}
