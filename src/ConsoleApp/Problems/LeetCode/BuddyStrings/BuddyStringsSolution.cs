namespace ConsoleApp.Problems.LeetCode.BuddyStrings;

public class BuddyStringsSolution
{
    public bool Solve(string s, string goal)
    {
        if (s.Length != goal.Length)
        {
            return false;
        }
        
        var frequencies = new Dictionary<char, int>();
        var swapIndex = -1;
        bool swapped = false;
        for (var i = 0; i < s.Length; i++)
        {
            if (frequencies.ContainsKey(s[i]))
            {
                frequencies[s[i]] += 1;
            }
            else
            {
                frequencies[s[i]] = 1;
            }
            
            if (s[i] != goal[i])
            {
                if (swapIndex == -1)
                {
                    if (i == s.Length - 1)
                    {
                        return false;
                    }
                    
                    swapIndex = i;
                }
                else
                {
                    if (swapped)
                    {
                        return false;
                    } 
                    
                    if (s[i] == goal[swapIndex] && s[swapIndex] == goal[i])
                    {
                        swapped = true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        if (swapped)
        {
            return true;
        }
        else if (swapIndex != -1)
        {
            return false;
        }
        
        return frequencies.Any(x => x.Value >= 2);
    }
}