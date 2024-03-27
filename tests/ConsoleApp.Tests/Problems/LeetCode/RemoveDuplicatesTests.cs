using ConsoleApp.Problems.LeetCode;

namespace ConsoleApp.Tests.Problems.LeetCode;

public class RemoveDuplicatesTests
{
    [Theory]
    [MemberData(nameof(CreateTestData))]
    public void Solve(int[] nums, int expected)
    {
        var solution = new RemoveDuplicates();
        var actual = solution.Solve(nums);
        
        Assert.Equal(expected, actual);
    }
    
    public static IEnumerable<object[]> CreateTestData()
    {
        {
            yield return new object[]
            {
                new[] {1,1,2},
                2
            };
            
            yield return new object[]
            {
                new[] {0,0,1,1,1,2,2,3,3,4},
                5
            };
        }
    }
}