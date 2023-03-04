namespace ConsoleApp.Problems.LeetCode;

public class FindMostFrequentElements
{
    public int[] Solve(int[] arr, int k)
    {
        var dict = new Dictionary<int, int>();
        
        int maxFreq = 0;
        for (var i = 0; i < arr.Length; i++) {
            if (!dict.ContainsKey(arr[i])) {
                dict.Add(arr[i], 0);
            }
            
            dict[arr[i]] = dict[arr[i]] + 1;
            maxFreq = dict[arr[i]] > maxFreq ? dict[arr[i]] : maxFreq;
        }
        
        var frequencies = new List<int>[maxFreq];
        foreach (var entry in dict) {
            if (frequencies[entry.Value - 1] == null)
                frequencies[entry.Value - 1] = new List<int> { entry.Key };
            else 
                frequencies[entry.Value - 1].Add(entry.Key);
        }
        
        var result = new List<int>();

        int count = 0;
        for (var i = frequencies.Length - 1; i >= 0; i--) {
            if (frequencies[i] != null) {
                foreach (var num in frequencies[i]) {
                    result.Add(num);
                    count++;
                    if (count == k) {
                        return result.ToArray();
                    }
                }
            }
        }
        
        return result.ToArray();
    }
}