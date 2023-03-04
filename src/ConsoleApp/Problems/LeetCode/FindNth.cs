namespace ConsoleApp.Problems.LeetCode;

/// <summary>
/// Given a positive integer N. You have to find Nth natural number after removing all the numbers containing digit 9.
/// </summary>
public class FindNth
{
    public long Solve(int n)
    {
        var str = "";
        while(n != 0){
            str = (n % 9) + str;
            n = n / 9;
        }
       
        return long.Parse(str);
    }
}