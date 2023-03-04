namespace Algorithms.Sorting;

public class InsertionSort
{
    public int[] Sort(int[] arr)
    {
        for (var i = 1; i < arr.Length; i++)
        {
            var value = arr[i];

            var j = i - 1;
            while (j >= 0 && arr[j] > value)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }

            arr[j + 1] = value;
        }
        
        return arr;
    }
}