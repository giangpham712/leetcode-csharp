namespace ConsoleApp.Problems.LeetCode.ReverseInteger;

public class ReverseIntegerSolution
{
    public int Solve(int x)
    {
        if (x == int.MinValue)
        {
            return 0;
        }
        
        var result = 0;
        var negative = x < 0;
        x = negative ? x * -1 : x;
        while (x > 0)
        {   
            if (result > int.MaxValue / 10)
            {
                return 0;
            }
            
            result = result * 10 + (x % 10);
            
            x = x / 10;
        }

        return negative ? -result : result;
    }
}