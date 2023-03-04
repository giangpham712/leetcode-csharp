namespace ConsoleApp.Problems.LeetCode;

/// <summary>
/// For an integer N find the number of trailing zeroes in N!.
/// </summary>
public class TrailingZeroes
{
    public int Solve(int n)
    {
        var result = 0;
        
        while (n > 0) {
            result += n/5;
            n = n/5;
        }
        
        return result;
    }
}