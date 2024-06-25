namespace ConsoleApp.Problems.LeetCode.ValidParenthesisString;

public class ValidParenthesisStringSolution
{
    public bool Solve(string s)
    {
        var leftMin = 0;
        var leftMax = 0;

        foreach (var c in s)
        {
            if (c == '(')
            {
                leftMax++;
                leftMin++;
            }
            else if (c == ')')
            {
                leftMax--;
                leftMin--;
            }
            else
            {
                leftMin--;
                leftMax++;
            }

            if (leftMin < 0)
            {
                leftMin = 0;
            }

            if (leftMax < 0)
            {
                return false;
            }
        }
        
        return leftMin == 0;
    }

    public bool Solve2(string s)
    {
        return default;
    }
}