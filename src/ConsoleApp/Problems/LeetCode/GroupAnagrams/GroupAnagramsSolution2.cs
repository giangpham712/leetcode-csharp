namespace ConsoleApp.Problems.LeetCode.GroupAnagrams;

public class GroupAnagramsSolution2
{
    private static Dictionary<char, int> _letterDict = new Dictionary<char, int>()
    {
        { 'a', 0 }, { 'b', 1 }, { 'c', 2 }, { 'd', 3 }, { 'e', 4 }, { 'f', 5 },
        { 'g', 6 }, { 'h', 7 }, { 'i', 8 }, { 'j', 9 }, { 'k', 10 }, { 'l', 11 },
        { 'm', 12 }, { 'n', 13 }, { 'o', 14 }, { 'p', 15 }, { 'q', 16 }, { 'r', 17 },
        { 's', 18 }, { 't', 19 }, { 'u', 20 }, { 'v', 21 }, { 'w', 22 }, { 'x', 23 },
        { 'y', 24 }, { 'z', 25 }
    };
    
    public IList<IList<string>> Solve(string[] strs)
    {
        var groups = strs.GroupBy(Hash);
        return groups.Select(x => (IList<string>)x.ToList()).ToList();
    }

    private static string Hash(string str)
    {
        var map = new int[26];
        for (var i = 0; i < str.Length; i++) {
            map[_letterDict[str[i]]]++;
        }
        
        var hash = "";
        for (var i = 0; i < map.Length; i++) 
        {
            if (map[i] > 0)
            {
                hash += $"{i}:{map[i]}_";
            }    
        }
        
        return hash;
    }
}