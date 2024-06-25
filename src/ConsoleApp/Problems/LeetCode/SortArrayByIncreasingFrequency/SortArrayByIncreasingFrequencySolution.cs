namespace ConsoleApp.Problems.LeetCode.SortArrayByIncreasingFrequency;

public class ProblemSolution
{
    public int[] Solve(int[] nums)
    {
        var result = new List<int>();
        
        var frequencies = new Dictionary<int, int>();

        var maxFrequency = 0;
        foreach (var num in nums)
        {
            if (frequencies.ContainsKey(num))
            {
                frequencies[num]++;
            }
            else
            {
                frequencies[num] = 1;
            }

            maxFrequency = Math.Max(maxFrequency, frequencies[num]);
        }

        var buckets = new SortedSet<int>[maxFrequency + 1];

        foreach (var frequency in frequencies)
        {
            if (buckets[frequency.Value] == null)
            {
                buckets[frequency.Value] = new SortedSet<int>(new MyComparer());
            }

            buckets[frequency.Value].Add(frequency.Key);
        }

        for (var index = 0; index < buckets.Length; index++)
        {
            var bucket = buckets[index];
            if (bucket == null)
            {
                continue;
            }

            foreach (var item in bucket)
            {
                for (int i = 0; i < index; i++)
                {
                    result.Add(item);
                }
            }
        }

        return result.ToArray();
    }
    
    class MyComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return -x.CompareTo(y);
        }
    }
}