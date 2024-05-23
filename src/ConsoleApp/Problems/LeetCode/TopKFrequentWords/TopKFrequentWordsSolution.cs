namespace ConsoleApp.Problems.LeetCode.TopKFrequentWords;

public class TopKFrequentWordsSolution
{
    public IList<string> Solve(string[] words, int k)
    {
        var results = new List<string>();

        var frequencies = new Dictionary<string, int>();

        var highestFrequency = 0;
        foreach (var word in words)
        {
            if (frequencies.TryGetValue(word, out var frequency))
            {
                frequencies[word] = frequency + 1;
            }
            else
            {
                frequencies[word] = 1;
            }

            highestFrequency = Math.Max(highestFrequency, frequencies[word]);
        }

        var buckets = new PriorityQueue<string, string>?[highestFrequency];

        foreach (var frequency in frequencies)
        {
            if (buckets[frequency.Value - 1] == null)
            {
                buckets[frequency.Value - 1] = new PriorityQueue<string, string>(new WordComparer());
            }
            
            buckets[frequency.Value - 1]!.Enqueue(frequency.Key, frequency.Key);
        }

        foreach (var bucket in buckets.Reverse())
        {
            while (k > 0 && bucket != null && bucket.TryDequeue(out var word, out var priority))
            {
                results.Add(word);
                k--;
            }
        }
        
        return results;
    }

    private class WordComparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            return -string.Compare(y, x, StringComparison.Ordinal);
        }
    }
}