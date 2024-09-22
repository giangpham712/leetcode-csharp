using DataStructures.LeetCode;

namespace ConsoleApp.Problems.LeetCode.RotateList;

public class RotateListTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve(ListNode head, int k, ListNode expected)
    {
        var solution = new RotateListSolution();
        var actual = solution.Solve(head, k);

        Assert.Equal(expected, actual);
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
                            {
                    
                            }
                        }
                    }
                }
            },
            2,
            new ListNode(4)
            {
                next = new ListNode(5)
                {
                    next = new ListNode(1)
                    {
                        next = new ListNode(2)
                        {
                            next = new ListNode(3)
                            {
                    
                            }
                        }
                    }
                }
            },
        };

        yield return new object[]
        {
            new ListNode(0)
            {
                next = new ListNode(1)
                {
                    next = new ListNode(2)
                    {
                    }
                }
            },
            4,
            new ListNode(2)
            {
                next = new ListNode(0)
                {
                    next = new ListNode(1)
                    {
                    }
                }
            },
        };
    }
}