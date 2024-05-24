namespace ConsoleApp.Problems.LeetCode.MinimumNumberOfFoodBucketsToFeedTheHamsters;

public class MinimumNumberOfFoodBucketsToFeedTheHamstersSolution2
{
    public int Solve(string hamsters)
    {
        var total = 0;
        
        for (var i = 0; i < hamsters.Length; i++)
        {
            if (hamsters[i] == 'H')
            {
                if (i < hamsters.Length - 1 && hamsters[i + 1] == '.')
                {
                    total++;
                    
                    if (i < hamsters.Length - 2 && hamsters[i + 2] == 'H')
                    {
                        
                        i = i + 2;
                    }
                }
                else if (i > 0 && hamsters[i - 1] == '.')
                {
                    total++;
                    
                }
                else
                {
                    return -1;
                }
            }
        }
        
        return total;
    }
}