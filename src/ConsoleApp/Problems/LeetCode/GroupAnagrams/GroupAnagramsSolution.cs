namespace ConsoleApp.Problems.LeetCode.GroupAnagrams;

public class GroupAnagramsSolution
{
    public IList<IList<string>> Solve(string[] strs)
    {
        var results = strs.GroupBy(str => Hash(str)).Select(x => (IList<string>)x.ToList()).ToList();

        return results;
    }

    private object Hash(string str)
    {
        return new object();
    }
}