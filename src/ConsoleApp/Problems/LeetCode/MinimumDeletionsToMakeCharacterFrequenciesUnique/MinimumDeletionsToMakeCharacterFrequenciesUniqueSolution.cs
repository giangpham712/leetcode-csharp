namespace ConsoleApp.Problems.LeetCode.MinimumDeletionsToMakeCharacterFrequenciesUnique;

public class MinimumDeletionsToMakeCharacterFrequenciesUniqueSolution
{
    public int Solve(string s)
    {
        var frequencies = new Dictionary<char, int>();

        foreach (var c in s)
        {
            if (!frequencies.TryGetValue(c, out var frequency))
            {
                frequencies[c] = 1;
            }
            else
            {
                frequencies[c] += 1;
            }
        }

        var toRemove = 0;
        var prev = int.MaxValue;

        foreach (var frequency in frequencies.Values.OrderDescending())
        {
            if (frequency>= prev)
            {
                prev = Math.Max(0, prev - 1);
                toRemove += frequency - prev;
            }
            else
            {
                prev = frequency;
            }
        }

        return toRemove;
    }
}
