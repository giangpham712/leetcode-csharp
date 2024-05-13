namespace ConsoleApp.Problems.LeetCode.CinemaSeatAllocation;

public class CinemaSeatAllocationSolution2
{
    public int Solve(int n, int[][] reservedSeats)
    {
        var map = new Dictionary<int, bool[]>();

        foreach (var reservedSeat in reservedSeats)
        {
            if (!map.TryGetValue(reservedSeat[0], out var seats))
            {
                seats = map[reservedSeat[0]] = new bool[10];
            }

            seats[reservedSeat[1] - 1] = true;
        }

        var count = (n - map.Count) * 2;
        foreach (var row in map)
        {
            var allocated = false;
            if (!row.Value[1] && !row.Value[2] && !row.Value[3] && !row.Value[4])
            {
                count++;
                allocated = true;
            }
            
            if (!row.Value[5] && !row.Value[6] && !row.Value[7] && !row.Value[8])
            {
                count++;
                allocated = true;
            }

            if (!allocated && (!row.Value[3] && !row.Value[4] && !row.Value[5] && !row.Value[6]))
            {
                count++;
            }
        }
        
        return count;
    }
}