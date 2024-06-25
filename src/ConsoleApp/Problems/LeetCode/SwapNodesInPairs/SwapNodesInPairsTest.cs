using DataStructures.Extensions;
using DataStructures.LeetCode;
using FluentAssertions;

namespace ConsoleApp.Problems.LeetCode.SwapNodesInPairs;

public class SwapNodesInPairsTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve(ListNode input, ListNode expected)
    {
        var solution = new SwapNodesInPairsSolution();
        var actual = solution.Solve(input);

        actual.IsEquivalentTo(expected).Should().BeTrue();
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
            new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                    }
                }
            },
            new ListNode(2)
            {
                next = new ListNode(1)
                {
                    next = new ListNode(4)
                    {
                        next = new ListNode(3)
                    }
                }
            }
        };
        
        yield return new object[]
        {
            new ListNode(1)
            {
                
            },
            new ListNode(1)
            {
                
            }
        };
    }
}