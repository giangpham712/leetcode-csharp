using Algorithms.Sorting;

namespace Algorithms.Tests.Sorting;

public class HeapSortTests
{
    [Theory]
    [InlineData(new [] { 5, 1, 4, 2, 8 }, new [] { 1, 2, 4, 5, 8 })]
    [InlineData(new [] {12, 11, 13, 5, 6}, new [] { 5, 6, 11, 12, 13 })]
    public void Sort_ShouldSortArrayCorrectly(int[] arr, int[] expected)
    {
        var sort = new HeapSort();
        var actual = sort.Sort(arr);
        
        Assert.Equal(expected, actual);
    }
}