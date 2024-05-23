namespace ConsoleApp.Problems.LeetCode.MyAtoi;

public class MyAtoiSolution2
{
    public int Solve(string s)
    {
        var result = 0;
        var sign = ' ';
        var digitStarted = false;

        s = s.TrimStart();
        
        foreach (var c in s)
        {
            if (!char.IsNumber(c))
            {
                if (!digitStarted && sign == ' ' && c is '-' or '+')
                {
                    sign = c;
                }
                else
                {
                    break;
                }
            }
            else
            {
                if (sign != '-' && result > (int.MaxValue - (c - '0')) / 10)
                {
                    return int.MaxValue;
                }
                
                if (sign == '-' && -result < (int.MinValue + (c - '0')) / 10)
                {
                    return int.MinValue;
                }
                
                result = result * 10 + (c - '0');
                digitStarted = true;
            }
        }
        
        return sign == '-' ? -result : result;
    }
}