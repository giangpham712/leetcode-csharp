using Algorithms.Sorting;

namespace Algorithms.Tests.Sorting;

public class SelectionSortTests
{
    [Theory]
    [InlineData(new [] { 64, 25, 12, 22, 11 }, new [] { 11, 12, 22, 25, 64 })]
    public void Sort_ShouldSortArrayCorrectly(int[] arr, int[] expected)
    {
        var selectionSort = new SelectionSort();
        var actual = selectionSort.Sort(arr);
        
        Assert.Equal(expected, actual);
    }
}