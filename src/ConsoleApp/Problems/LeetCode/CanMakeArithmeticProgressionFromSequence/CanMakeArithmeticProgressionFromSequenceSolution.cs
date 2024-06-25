namespace ConsoleApp.Problems.LeetCode.CanMakeArithmeticProgressionFromSequence;

public class ProblemSolution
{
    public bool Solve(int[] arr)
    {
        var min = int.MaxValue;
        var min2 = int.MaxValue;
        
        var set = new HashSet<int>();
        foreach (var num in arr)
        {
            if (num < min)
            {
                min2 = min;
                min = num;
            }
            else if (num < min2)
            {
                min2 = num;
            }

            set.Add(num);
        }
        
        var step = min2 - min;
        if (step == 0)
        {
            return arr.All(x => x == min);
        }

        for (var i = min; i < min + arr.Length * step; i += step)
        {
            if (!set.Remove(i))
            {
                return false;
            }
        }

        return set.Count == 0;
    }
}