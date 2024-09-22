namespace ConsoleApp.Problems.LeetCode.GreatestCommonDivisorOfStrings;

public class ProblemSolution
{
    public string Solve(string str1, string str2)
    {
        string longer, shorter;
        if (str1.Length > str2.Length)
        {
            longer = str1;
            shorter = str2;
        }
        else
        {
            longer = str2;
            shorter = str1;
        }

        var gcdOfLength = FindGcd(longer.Length, shorter.Length);
        
        var gcd = shorter.Substring(0, gcdOfLength);

        if (longer == Repeat(gcd, longer.Length / gcdOfLength) &&
            shorter == Repeat(gcd, shorter.Length / gcdOfLength))
        {
            return gcd;
        }
        
        return "";
    }

    private static int FindGcd(int big, int small)
    {
        var remainder = small;
        small = big;
        do
        {
            (big, small) = (small, remainder);
            remainder = big % small;
        } while (remainder > 0);

        return small;
    }
    
    private static string Repeat(string s, int count)
    {
        return new System.Text.StringBuilder().Insert(0, s, count).ToString();
    }
}