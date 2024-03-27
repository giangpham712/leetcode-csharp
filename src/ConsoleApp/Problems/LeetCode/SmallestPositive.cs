namespace ConsoleApp.Problems.LeetCode;

/// <summary>
/// Given an array of size N, find the smallest positive integer value that
/// is either not presented in the array or cannot be represented as a
/// sum(coz sum means you are adding two or more elements) of some elements
/// from the array.
/// </summary>
public class SmallestPositive
{
    public int Solve(int[] arr)
    {
        int res = 1, sum = 0;
        Array.Sort(arr);
        
        foreach (int l in arr) {
            sum = sum + l;
            if (l <= res)
                res = res + l;
        }
        return res;
        
        
    }
}