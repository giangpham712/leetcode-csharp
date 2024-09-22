namespace ConsoleApp.Problems.LeetCode.MeetingRoom;

public class MeetingRoomTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve(int[][] input, bool expected)
    {
        var solution = new MeetingRoomSolution();
        var actual = solution.Solve(input);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
            new int[][]
            {
                [0,30],[5,10],[15,20]
            },
            false
        };
        
        yield return new object[]
        {
            new int[][]
            {
                [7,10],[2,4]
            },
            true
        };
    }
}