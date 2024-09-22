namespace ConsoleApp.Problems.LeetCode.LemonadeChange;

public class LemonadeChangeSolution
{
    public bool Solve(int[] bills)
    {
        var fiveNotes = 0;
        var tenNotes = 0;

        foreach (var bill in bills)
        {
            if (bill == 5)
            {
                fiveNotes++;
                continue;
            }
            else if (bill == 10)
            {
                if (fiveNotes == 0)
                {
                    return false;
                }

                fiveNotes--;
                tenNotes++;
            }
            else
            {
                if (tenNotes > 0 && fiveNotes > 0)
                {
                    tenNotes--;
                    fiveNotes--;
                    continue;
                }
                else if (fiveNotes > 2)
                {
                    fiveNotes -= 3;
                    continue;
                }
                else
                {
                    return false;
                }
            }
        }
        
        return true;
    }
}