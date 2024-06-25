namespace ConsoleApp.Problems.LeetCode.CountNumberOfTeams;

public class CountNumberOfTeamsSolution
{
    public int Solve(int[] rating)
    {
        var total = 0;
        for (int i = 0; i < rating.Length - 2; i++)
        {
            for (int j = i + 1; j < rating.Length - 1; j++)
            {
                if (rating[j] > rating[i])
                {
                    for (int k = j + 1; k < rating.Length; k++)
                    {
                        if (rating[k] > rating[j])
                        {
                            total++;
                        }
                    }
                }
                else
                {
                    for (int k = j + 1; k < rating.Length; k++)
                    {
                        if (rating[k] < rating[j])
                        {
                            total++;
                        }
                    }
                }
            }    
        }
        return total;
    }

    public int Solve2(int[] rating)
    {
        return default;
    }
}