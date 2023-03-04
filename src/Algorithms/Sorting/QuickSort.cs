namespace Algorithms.Sorting;

/// <summary>
/// Time complexity: <br/>
/// - Best: n log(n)
/// - Average: n log(n)
/// - Worst: n^2
/// </summary>
public class QuickSort
{
    public int[] Sort(int[] arr)
    {
        Sort(arr, 0, arr.Length - 1);
        
        return arr;
    }
    
    private void Sort(int[] arr, int left, int right)
    {
        if (left >= right)
        {
            return;
        }

        var p = Partition(arr, left, right);
        Sort(arr, left, p - 1);
        Sort(arr, p + 1, right);
    }

    /// <summary>
    /// The target of partitions is, given an array and an element x of an array as the pivot,
    /// put x at its correct position in a sorted array and put all smaller elements (smaller than x)
    /// before x, and put all greater elements (greater than x) after x. All this should be done in linear time.
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    private int Partition(int[] arr, int left, int right)
    {
        // Always pick the last element as a pivot
        var p = arr[right];
        var i = (left - 1);

        for (var j = left; j < right; j++)
        {
            if (arr[j] < p)
            {
                i++;
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }
        }

        (arr[i + 1], arr[right]) = (arr[right], arr[i + 1]);
        return i + 1;
    }
}

public class AnotherQuickSort
{
    public int[] Sort(int[] arr)
    {
        DoQuickSort(arr, 0, arr.Length - 1, arr.Length - 1);
        
        return arr;
    }

    public int[] DoQuickSort(int[] arr, int left, int right, int pivot)
    {
        if (left >= right)
        {
            return arr;
        }
        
        var j = left - 1;

        for (var i = left; i <= pivot; i++)
        {
            if (arr[i] <= arr[pivot])
            {
                j++;
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }
        }

        DoQuickSort(arr, left, j - 1, j - 1);
        DoQuickSort(arr, j + 1, right, right);

        return arr;
    }
}