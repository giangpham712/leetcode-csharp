using Algorithms.Sorting;

namespace Algorithms.Tests.Sorting;

public class QuickSortTests
{
    [Theory]
    [InlineData(new [] { 5, 1, 4, 2, 8 }, new [] { 1, 2, 4, 5, 8 })]
    [InlineData(new [] { 12, 11, 13, 5, 6 }, new [] { 5, 6, 11, 12, 13 })]
    public void QuickSort_Sort(int[] arr, int[] expected)
    {
        var sort = new QuickSort();
        var actual = sort.Sort(arr);
        
        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData(new [] { 5, 1, 4, 2, 8 }, new [] { 1, 2, 4, 5, 8 })]
    [InlineData(new [] { 12, 11, 13, 5, 6 }, new [] { 5, 6, 11, 12, 13 })]
    [InlineData(new [] { 3, 7, 1, 8, 2, 5, 9, 4, 6 }, new [] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })]
    public void AnotherQuickSort_Sort(int[] arr, int[] expected)
    {
        var sort = new AnotherQuickSort();
        var actual = sort.Sort(arr);
        
        Assert.Equal(expected, actual);
    }
}