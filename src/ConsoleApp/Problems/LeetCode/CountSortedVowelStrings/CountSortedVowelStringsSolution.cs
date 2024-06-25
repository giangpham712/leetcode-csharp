namespace ConsoleApp.Problems.LeetCode.CountSortedVowelStrings;

public class CountSortedVowelStringsSolution
{
    public int Solve(int n)
    {
        var vowelPossibilities = new int[n + 1, 5];

        for (int i = 0; i < 5; i++)
        {
            vowelPossibilities[1, i] = 1;
        }
        
        for (int i = 2; i <= n; i++)
        {
            var current = 0;
            for (int j = 0; j < 5; j++)
            {
                current += vowelPossibilities[i - 1, j];
                vowelPossibilities[i, j] = current;
            }
        }

        var total = 0;
        
        for (int i = 0; i < 5; i++)
        {
            total += vowelPossibilities[n, i];
        }
        
        return total;
    }

    public int Solve2(int n)
    {
        return ((n + 1) * (n + 2) * (n + 3) * (n + 4)) / 24;
    }
}