namespace ConsoleApp.Problems.LeetCode;

/// <summary>
/// Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.
/// </summary>
public class GenerateParentheses
{
    /// <summary>
    /// 1. In order to generate valid combinations of parentheses, we need to make sure that
    /// there is a closing parentheses for every open parentheses. This can be achieved by
    /// taking care of the following points: <br/>
    /// - At any point, no. of open parentheses > no. of closing parentheses <br/>
    /// - If no. of open parentheses == no. of closing parentheses, we have obtained a valid pattern <br/>
    /// <br/>
    /// 2. We can repeat the process in point 1, until we have obatained all the possible combinations.
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public List<string> Solve(int n)
    {
        var results = new List<string>();

        if (n == 0) return results;
        
        BackTrack(results, "", 0, 0, n);
        
        return results;
    }

    private void BackTrack(List<string> results, string current, int numOfOpen, int numOfClose, int n)
    {
        // if no. of open and closing parentheses is equal to n, add the combination to the list and return
        if (numOfOpen == n && numOfClose == n) 
        {
            results.Add(current);
            return;
        }
        
        // if no. of open parentheses is equal to n, it means we can add another '(' to the current pattern
        if (numOfOpen < n)
        {
            BackTrack(results, current + "(", numOfOpen + 1, numOfClose, n);
        }

        // If no. of closing parentheses is less than the no. of  open parentheses is equal to n,  
        // it means we can add another ')' to the current pattern.
        // The second if block will be executed after the recursion from the first if block ends
        // In this way, we would have tried all possible combinations possible at this stage by BACKTRACKING.
        if (numOfClose < numOfOpen)
        {
            BackTrack(results, current + ")", numOfOpen, numOfClose + 1, n);   
        }
    }
}