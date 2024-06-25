namespace ConsoleApp.Problems.LeetCode.SortIntegersByPowerValue;

public class SortIntegersByPowerValueSolution
{
    public int Solve(int lo, int hi, int k)
    {
        var memoized = new Dictionary<int, int>();
         
        memoized.Add(1, 0);
        memoized.Add(2, 1);

        var priorityQueue = new PriorityQueue<int, (int, int)>(new MyComparer());
        for (int i = lo; i < hi + 1; i++)
        {
            priorityQueue.Enqueue(i,  (Dp(i, memoized), i));
        }

        var value = 0;
        while (k > 0)
        {
            priorityQueue.TryDequeue(out value, out var priority);
            k--;
        }

        return value;
    }

    private int Dp(int n, Dictionary<int, int> memoized)
    {
        if (memoized.TryGetValue(n, out var power))
        {
            return power;
        }
        
        power = n % 2 == 0
            ? 1 + Dp(n / 2, memoized)
            : 1 + Dp(n * 3 + 1, memoized);

        memoized.Add(n, power);
        
        return power;
    }

    class MyComparer : IComparer<(int, int)>
    {
        public int Compare((int, int) x, (int, int) y)
        {
            var item1Comparison = Comparer<int>.Default.Compare(x.Item1, y.Item1);
            if (item1Comparison != 0) return item1Comparison;
            return Comparer<int>.Default.Compare(x.Item2, y.Item2);
        }
    }
}