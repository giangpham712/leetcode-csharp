namespace Algorithms.Sorting;

/// <summary>
/// 1. Initialize minimum value(min_idx) to location 0. <br/>
/// 2. Traverse the array to find the minimum element in the array. <br/>
/// 3. While traversing if any element smaller than min_idx is found then swap both the values. <br/>
/// 4. Then, increment min_idx to point to the next element. <br/>
/// 5. Repeat until the array is sorted. <br/>
///
/// Time complexity: <br/>
/// - Best: n <br/>
/// - Average: n^2 <br/>
/// - Worst: n^2 <br/>
/// </summary>
public class BubbleSort
{
    public int[] Sort(int[] arr)
    {
        for (var i = 0; i < arr.Length; i++)
        {
            for (var j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                }
            }
        }
        
        return arr;
    }
}