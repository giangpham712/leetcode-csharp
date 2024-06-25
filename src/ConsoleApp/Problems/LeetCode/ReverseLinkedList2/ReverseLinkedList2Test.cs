using DataStructures.Extensions;
using DataStructures.LeetCode;
using FluentAssertions;

namespace ConsoleApp.Problems.LeetCode.ReverseLinkedList2;

public class ReverseLinkedList2Test
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve(ListNode head, int left, int right, ListNode expected)
    {
        var solution = new ReverseLinkedList2Solution();
        var actual = solution.Solve(head, left, right);

        actual.IsEquivalentTo(expected).Should().BeTrue();
    }
    
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve2(ListNode head, int left, int right, ListNode expected)
    {
        var solution = new ReverseLinkedList2Solution();
        var actual = solution.Solve2(head, left, right);

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
                        {
                            next = new ListNode(5)
                        }
                    }
                }
            },
            2, 4,
            new ListNode(1)
            {
                next = new ListNode(4)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(2)
                        {
                            next = new ListNode(5)
                        }
                    }
                }
            }
        };

        yield return new object[]
        {
            new ListNode(5),
            1, 1,
            new ListNode(5)
        };
        
        yield return new object[]
        {
            new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(5)
                        }
                    }
                }
            },
            3, 4,
            new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(4)
                    {
                        next = new ListNode(3)
                        {
                            next = new ListNode(5)
                        }
                    }
                }
            }
        };
    }
}