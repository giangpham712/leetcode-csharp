namespace ConsoleApp.Problems.LeetCode.CinemaSeatAllocation;

public class CinemaSeatAllocationSolution
{
    public int Solve(int n, int[][] reservedSeats)
    {
        var map = Enumerable.Range(0, n).ToDictionary(x => x + 1, x => new bool[10]);

        foreach (var reservedSeat in reservedSeats)
        {
            map[reservedSeat[0]][reservedSeat[1] - 1] = true;
        }

        var families = 0;
        foreach (var row in map)
        {
            var allocated = false;
            if (!row.Value[1] && !row.Value[2] && !row.Value[3] && !row.Value[4])
            {
                families++;
                allocated = true;
            }
            
            if (!row.Value[5] && !row.Value[6] && !row.Value[7] && !row.Value[8])
            {
                families++;
                allocated = true;
            }

            if (!allocated && (!row.Value[3] && !row.Value[4] && !row.Value[5] && !row.Value[6]))
            {
                families++;
            }
        }
        
        return families;
    }
}