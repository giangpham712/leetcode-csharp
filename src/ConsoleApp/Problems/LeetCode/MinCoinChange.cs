namespace ConsoleApp.Problems.LeetCode;

/// <summary>
/// You are given an integer array coins representing coins of different denominations
/// and an integer amount representing a total amount of money. <br/>
/// Return the fewest number of coins that you need to make up that amount.
/// If that amount of money cannot be made up by any combination of the coins, return -1. <br/>
/// You may assume that you have an infinite number of each kind of coin.
/// </summary>
public abstract class MinCoinChange
{
    public abstract int Solve(int[] coins, int amount);

    public class TopDown : MinCoinChange
    {
        public override int Solve(int[] coins, int amount)
        {
            if (amount == 0)
            {
                return 0;
            }

            var memoized = new int[amount + 1];
            memoized[0] = 0;
            return Solve(coins, amount, memoized);
        }

        public int Solve(int[] coins, int amount, int[] memoized)
        {
            if (amount < 0) return -1;
            if (amount == 0) return 0;
            if (memoized[amount] != 0) return memoized[amount];

            var min = int.MaxValue;
            foreach (var coin in coins)
            {
                var sub = Solve(coins, amount - coin, memoized);
                if (sub >= 0 && sub < min)
                {
                    min = 1 + sub;
                }
            }
            memoized[amount] = min == int.MaxValue ? -1 : min;
            return memoized[amount];
        }
}
    
    public class BottomUp : MinCoinChange
    {
        public override int Solve(int[] coins, int amount)
        {
            var tabular = new int[amount + 1];
            tabular[0] = 0;

            for (var i = 1; i < amount + 1; i++)
            {
                var minimum = int.MaxValue;
                for (var j = 0; j < coins.Length; j++)
                {
                    if (i >= coins[j] && tabular[i - coins[j]] != int.MaxValue)
                    {
                        minimum = Math.Min(minimum, 1 + tabular[i - coins[j]]);
                    }
                }

                tabular[i] = minimum;
            }
            
            return tabular[amount] == int.MaxValue ? -1 : tabular[amount];
        }
    }
}