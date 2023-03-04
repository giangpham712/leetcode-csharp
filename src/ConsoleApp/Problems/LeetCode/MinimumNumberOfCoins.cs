namespace ConsoleApp.Problems.LeetCode;

/// <summary>
/// Given an infinite supply of each denomination of Indian currency { 1, 2, 5, 10, 20, 50, 100, 200, 500, 2000 } and a target value N. <br/>
/// Find the minimum number of coins and/or notes needed to make the change for Rs N. You must return the list containing the value of coins required. 
/// </summary>
public class MinimumNumberOfCoins
{
    private static int[] _coins = {1, 2, 5, 10, 20, 50, 100, 200, 500, 2000};
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public List<int> Solve(int n)
    {
        // code here

        var result = new List<int>();
        
        int coinIndex = _coins.Length - 1;
        while (n > 0) {
            if (n >= _coins[coinIndex]) {
                result.Add(_coins[coinIndex]);
                n -= _coins[coinIndex];
            } else {
                coinIndex--;
            }
        }
        
        return result;
    }
}