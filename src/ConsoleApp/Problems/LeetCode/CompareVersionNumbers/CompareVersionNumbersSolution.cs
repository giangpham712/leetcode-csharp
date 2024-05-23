namespace ConsoleApp.Problems.LeetCode.CompareVersionNumbers;

public class CompareVersionNumbersSolution
{
    public object Solve(string version1, string version2)
    {
        var versions1 = version1.Split(".").Select(int.Parse).ToArray();
        var versions2 = version2.Split(".").Select(int.Parse).ToArray();

        for (var i = 0; i < Math.Max(versions1.Length, versions2.Length); i++)
        {
            var difference = (versions1.Length > i ? versions1[i] : 0) - (versions2.Length > i ? versions2[i] : 0);
            if (difference != 0)
            {
                return difference > 0 ? 1 : -1;
            }
        }
        
        return 0;
    }
}