namespace ConsoleApp.Problems.LeetCode;

/// <summary>
/// Given an integer array coins[ ] of size N representing different denominations of currency and an integer sum,
/// find the number of ways you can make sum by using different combinations from coins[ ]. <br/>  
/// Note: Assume that you have an infinite supply of each type of coin. 
/// </summary>
public abstract class CoinChange
{
    public abstract long Solve(int[] coins, int amount);

    public class BottomUp : CoinChange
    {
        public override long Solve(int[] coins, int amount)
        {
            var m = new long[coins.Length + 1, amount + 1];

            for (var i = 0; i < coins.Length + 1; i++)
            {
                m[i, 0] = 1;
            }

            for (var i = 1; i < coins.Length + 1; i++)
            {
                for (var j = 0; j < amount + 1; j++)
                {
                    // if the coin (i - 1) cannot be used
                    if (coins[i - 1] > j)
                        m[i, j] = m[i - 1, j];
                    else
                    {
                        
                        m[i, j] = m[i, j - coins[i - 1]] + m[i - 1, j];
                    }
                }
            }

            return m[coins.Length, amount];
        }
    }
}