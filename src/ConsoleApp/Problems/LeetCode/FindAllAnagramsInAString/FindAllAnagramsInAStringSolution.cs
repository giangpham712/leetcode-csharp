using System.Text;

namespace ConsoleApp.Problems.LeetCode.FindAllAnagramsInAString;

public class FindAllAnagramsInAStringSolution
{
    private static Dictionary<char, int> _letterDict = new Dictionary<char, int>()
    {
        { 'a', 0 }, { 'b', 1 }, { 'c', 2 }, { 'd', 3 }, { 'e', 4 }, { 'f', 5 },
        { 'g', 6 }, { 'h', 7 }, { 'i', 8 }, { 'j', 9 }, { 'k', 10 }, { 'l', 11 },
        { 'm', 12 }, { 'n', 13 }, { 'o', 14 }, { 'p', 15 }, { 'q', 16 }, { 'r', 17 },
        { 's', 18 }, { 't', 19 }, { 'u', 20 }, { 'v', 21 }, { 'w', 22 }, { 'x', 23 },
        { 'y', 24 }, { 'z', 25 }
    };
    
    #region Solve
    
    public IList<int> Solve(string s, string p)
    {
        if (p.Length > s.Length)
        {
            return new List<int>();
        }
        
        var pMap = new int[26];
        for (var i = 0; i < p.Length; i++) {
            pMap[_letterDict[p[i]]]++;
        }

        var pHash = Hash(pMap);

        var result = new List<int>();

        var sMap = new int[26];

        for (int i = 0; i < p.Length; i++)
        {
            sMap[_letterDict[s[i]]]++;
        }

        if (Hash(sMap) == pHash)
        {
            result.Add(0);
        }

        for (var i = 1; i <= s.Length - p.Length; i++)
        {
            if (pMap[_letterDict[s[i + p.Length - 1]]] == 0)
            {
                //
            }
            
            sMap[_letterDict[s[i - 1]]]--;
            sMap[_letterDict[s[i + p.Length - 1]]]++;
            if (Hash(sMap) == pHash)
            {
                result.Add(i);
            }
        }
        
        return result;
    }
    
    private static string Hash(int[] map)
    {
        var hash = new StringBuilder();
        for (var i = 0; i < map.Length; i++) 
        {
            if (map[i] > 0)
            {
                hash.Append($"{i}:{map[i]}_");
            }    
        }
        
        return hash.ToString();
    }
    
    #endregion

    #region Solve2

    public IList<int> Solve2(string s, string p)
    {
        if (p.Length > s.Length)
        {
            return new List<int>();
        }

        var pFrequencies = new Dictionary<char, int>();

        foreach (var c in p)
        {
            if (pFrequencies.ContainsKey(c))
            {
                pFrequencies[c]++;
            }
            else
            {
                pFrequencies[c] = 1;
            }
        }
        
        var result = new List<int>();

        var sSubFrequencies = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            
        }
        
        return result;
    }

    #endregion
}