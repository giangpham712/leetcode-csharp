namespace Algorithms.Sorting;

public class SelectionSort
{
    public int[] Sort(int[] arr)
    {
        for (var i = 0; i < arr.Length - 1; i++)
        {
            var idxOfMin = i;
            for (var j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[idxOfMin])
                {
                    idxOfMin = j;
                }
            }

            // Swap the found minimum element with the first element
            (arr[idxOfMin], arr[i]) = (arr[i], arr[idxOfMin]);
        }

        return arr;
    }
}