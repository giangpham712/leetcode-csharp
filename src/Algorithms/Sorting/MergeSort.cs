namespace Algorithms.Sorting;

/// <summary>
/// - Find the middle point to divide the array into two halves <br/>
/// - Call mergeSort for first half <br/>
/// - Call mergeSort for second half <br/>
/// - Merge the two halves sorted in steps 2 and 3 <br/>
/// </summary>
public class MergeSort
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

        var middle = (right + left) / 2;
        Sort(arr, left, middle);
        Sort(arr, middle + 1, right);
        Merge(arr, left, right);
    }

    private void Merge(int[] arr, int left, int right)
    {
        var middle = (right + left) / 2;

        var leftIndex = left;
        var rightIndex = middle + 1;
        
        var temp = new int[right - left + 1];
        var index = 0;
        while (leftIndex <= middle && rightIndex <= right)
        {
            if (arr[leftIndex] < arr[rightIndex])
            {
                temp[index] = arr[leftIndex];
                leftIndex++;
            }
            else
            {
                temp[index] = arr[rightIndex];
                rightIndex++;
            }

            index++;
        }

        for (var i = leftIndex; i <= middle; i++)
        {
            temp[index] = arr[i];
            index++;
        }
        
        for (var i = rightIndex; i <= right; i++)
        {
            temp[index] = arr[i];
            index++;
        }

        for (var i = 0; i < temp.Length; i++)
        {
            arr[i + left] = temp[i];
        }
    }
}