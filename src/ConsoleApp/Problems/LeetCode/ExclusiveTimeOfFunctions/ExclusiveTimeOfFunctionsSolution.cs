namespace ConsoleApp.Problems.LeetCode.ExclusiveTimeOfFunctions;

public class ExclusiveTimeOfFunctionsSolution
{
    public int[] Solve(int n, IList<string> logs)
    {
        var results = new int[n];
        
        var stack = new Stack<(int, int, int)>();

        foreach (var log in logs)
        {
            var parts = log.Split(':');
            var id = int.Parse(parts[0]);
            var timestamp = int.Parse(parts[2]);
            var type = parts[1];

            int parentId;
            if (stack.TryPeek(out var executingLog))
            {
                parentId = executingLog.Item1;
            }
            else
            {
                parentId = -1;
            }
            
            if (type == "start")
            {
                stack.Push((id, timestamp, parentId));
            }
            else
            {
                if (executingLog.Item1 == id)
                {
                    stack.Pop();
                    var time = timestamp - executingLog.Item2 + 1;
                    
                    results[id] += time;

                    if (executingLog.Item3 != -1)
                    {
                        results[executingLog.Item3] -= time;
                    }
                }
            }
        }
        
        return results;
    }

    public int[] Solve2(int n, IList<string> logs)
    {
        return default;
    }
}