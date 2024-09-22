namespace ConsoleApp.Problems.LeetCode.SumOfTwoIntegers;

public class SumOfTwoIntegersSolution
{
    public int Solve(int a, int b)
    {
        do
        {
            (a, b) = (a ^ b, a & b);
            b = b << 1;
        } while (b != 0);
        
        return a;
    }
}