using Algorithms.Sorting;

namespace Algorithms.Tests.Sorting;

public class BubbleSortTests
{
    [Theory]
    [InlineData(new [] { 64, 25, 12, 22, 11 }, new [] { 11, 12, 22, 25, 64 })]
    [InlineData(new [] { 5, 1, 4, 2, 8 }, new [] { 1, 2, 4, 5, 8 })]
    public void Sort_ShouldSortArrayCorrectly(int[] arr, int[] expected)
    {
        var bubbleSort = new BubbleSort();
        var actual = bubbleSort.Sort(arr);
        
        Assert.Equal(expected, actual);
    }
}