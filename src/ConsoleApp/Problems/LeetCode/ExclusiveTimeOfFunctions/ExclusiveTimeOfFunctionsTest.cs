namespace ConsoleApp.Problems.LeetCode.ExclusiveTimeOfFunctions;

public class ExclusiveTimeOfFunctionsTest
{
    [Theory]
    [InlineData(2, new[] {"0:start:0","1:start:2","1:end:5","0:end:6"}, new[] {3,4})]
    [InlineData(1, new[] {"0:start:0","0:start:2","0:end:5","0:start:6","0:end:6","0:end:7"}, new[] {8})]
    [InlineData(2, new[] {"0:start:0","0:start:2","0:end:5","1:start:6","1:end:6","0:end:7"}, new[] {7,1})]
    [InlineData(8, new[] {"0:start:0","1:start:5","2:start:6","3:start:9","4:start:11","5:start:12","6:start:14","7:start:15","1:start:24","1:end:29","7:end:34","6:end:37","5:end:39","4:end:40","3:end:45","0:start:49","0:end:54","5:start:55","5:end:59","4:start:63","4:end:66","2:start:69","2:end:70","2:start:74","6:start:78","0:start:79","0:end:80","6:end:85","1:start:89","1:end:93","2:end:96","2:end:100","1:end:102","2:start:105","2:end:109","0:end:114"}, new[] {20,14,35,7,6,9,10,14})]
    [InlineData(3, new[] {"1:start:0","0:start:2","1:start:3","2:start:4","2:end:4","0:end:6","1:end:7","1:end:8"}, new[] {2,6,1})]
    public void TestSolve(int n, IList<string> logs, int[] expected)
    {
        var solution = new ExclusiveTimeOfFunctionsSolution();
        var actual = solution.Solve(n, logs);

        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData(2, new[] {"0:start:0","1:start:2","1:end:5","0:end:6"}, new[] {3,4})]
    [InlineData(1, new[] {"0:start:0","0:start:2","0:end:5","0:start:6","0:end:6","0:end:7"}, new[] {8})]
    [InlineData(2, new[] {"0:start:0","0:start:2","0:end:5","1:start:6","1:end:6","0:end:7"}, new[] {7,1})]
    [InlineData(8, new[] {"0:start:0","1:start:5","2:start:6","3:start:9","4:start:11","5:start:12","6:start:14","7:start:15","1:start:24","1:end:29","7:end:34","6:end:37","5:end:39","4:end:40","3:end:45","0:start:49","0:end:54","5:start:55","5:end:59","4:start:63","4:end:66","2:start:69","2:end:70","2:start:74","6:start:78","0:start:79","0:end:80","6:end:85","1:start:89","1:end:93","2:end:96","2:end:100","1:end:102","2:start:105","2:end:109","0:end:114"}, new[] {20,14,35,7,6,9,10,14})]
    public void TestSolve2(int n, IList<string> logs, int[] expected)
    {
        var solution = new ExclusiveTimeOfFunctionsSolution();
        var actual = solution.Solve2(n, logs);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}