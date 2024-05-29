namespace ConsoleApp.Problems.LeetCode.CountNumberOfSpecialChars2;

public class CountNumberOfSpecialChars2Solution
{
    public int Solve(string word)
    {
        var count = 0;
        var letterSet = "abcdefghijklmnopqrstuvwxyz".ToDictionary(c => c, c => true);
        
        var candidates = new Dictionary<char, bool>();
        
        foreach (var c in word)
        {
            if (char.IsUpper(c) && !candidates.ContainsKey(c))
            {
                letterSet.Remove(char.ToLower(c));
            }
            else if (letterSet.TryGetValue(c, out var allowed))
            {
                if (!allowed) {
                    letterSet.Remove(c);
                    candidates.Remove(char.ToUpper(c));
                    count--;
                }
                else if (!candidates.ContainsKey(char.ToUpper(c)))
                {
                    candidates.Add(char.ToUpper(c), false);
                }
            } 
            else if (candidates.TryGetValue(c, out var special) && !special)
            {
                candidates[c] = true;
                letterSet[char.ToLower(c)] = false;
                count++;
            }
        }
        
        return count;
    }
}