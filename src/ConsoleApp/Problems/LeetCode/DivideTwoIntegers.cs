namespace ConsoleApp.Problems.LeetCode;

public class DivideTwoIntegers
{
    public int Solve(int dividend, int divisor)
    {
        var negative = (dividend < 0 && divisor > 0) || (dividend > 0 && divisor < 0);
        
        long longDividend = dividend < 0 ? (0 - (long) dividend) : dividend;
        long longDivisor = divisor < 0 ? (0 - (long) divisor) : divisor;
        
        long longQuotient = 0;
        while (longDividend >= longDivisor) {
            longQuotient++;

            longDividend  = longDividend - longDivisor;
        }
        
        Console.WriteLine(longQuotient);
        
        longQuotient = negative ? (0 - longQuotient) : longQuotient;

        return longQuotient > (long) int.MaxValue ? int.MaxValue : (longQuotient < (long) int.MinValue ? int.MinValue : (int) longQuotient);
    }
}