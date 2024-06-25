namespace ConsoleApp.Problems.LeetCode.PascalTriangle;

public class PascalTriangleSolution
{
    public IList<IList<int>> Solve(int numRows)
    {
        var memoized = new IList<int>[numRows + 1];
        memoized[1] = new List<int>()
        {
            1
        };
        
        Dp(numRows, memoized);

        var result = new List<IList<int>>();

        for (int i = 1; i <= numRows; i++)
        {
            result.Add(memoized[i]);
        }
        
        return result;
    }

    private IList<int> Dp(int input, IList<int>[] memoized)
    {
        if (memoized[input] != null)
        {
            return memoized[input];
        }
        
        var prev = Dp(input - 1, memoized);

        var list = new List<int>();
        list.Add(1);
        for (var i = 0; i < prev.Count - 1; i++)
        {
            list.Add(prev[i] + prev[i + 1]);
        }

        list.Add(1);
        memoized[input] = list;
        return list;
    }
}