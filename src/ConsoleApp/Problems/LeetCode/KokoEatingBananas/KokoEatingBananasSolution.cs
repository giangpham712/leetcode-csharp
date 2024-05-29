namespace ConsoleApp.Problems.LeetCode.KokoEatingBananas;

public class KokoEatingBananasSolution
{
    public int Solve(int[] piles, int h)
    {
        var maxPile = piles[0];

        foreach (var pile in piles)
        {
            maxPile = Math.Max(maxPile, pile);
        }
        
        if (piles.Length == h)
        {
            return maxPile;
        }

        return BinarySearch(piles, h, 1, maxPile);
    }

    private int BinarySearch(int[] piles, int h, int min, int max)
    {
        while (min < max)
        {
            var mid = (min + max) / 2;
            var hours = CalculateEatingHours(piles, mid);
            
            if (hours > h)
            {
                if (min == mid)
                {
                    return max;
                }
                
                min = mid;
            }
            else
            {
                if (max == mid)
                {
                    return min;
                }
                
                max = mid;
            }
        }

        return min;
    }

    private int CalculateEatingHours(int[] piles, int speed)
    {
        var hours = 0;

        foreach (var pile in piles)
        {
            hours += (pile - 1) / speed + 1;
        }
        
        return hours;
    }
}