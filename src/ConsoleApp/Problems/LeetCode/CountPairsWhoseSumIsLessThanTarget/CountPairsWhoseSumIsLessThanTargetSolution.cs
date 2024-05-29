namespace ConsoleApp.Problems.LeetCode.CountPairsWhoseSumIsLessThanTarget;

public class CountPairsWhoseSumIsLessThanTargetSolution
{
    public int Solve(IList<int> nums, int target)
    {
        var array = nums.ToArray();
        Array.Sort(array);

        var first = array[0];

        var max = target - first - 1;

        var left = 0;
        var right = BinarySearch(array, 0, array.Length, max);

        while (right < array.Length - 1)
        {
            if (array[right] >= array[right + 1])
            {
                right++;
            }
            else
            {
                break;
            }
        }
        
        if (right == left)
        {
            return 0;
        }

        var total = 0;
        while (left < right)
        {
            if (array[left] + array[right] < target)
            {
                total += (right - left);
                left++;
            }
            else
            {
                right--;
            }
        }
        
        return total;
    }

    private int BinarySearch(int[] array, int start, int end, int target)
    {
        var mid = (end + start) / 2;

        if (mid == start || target == array[mid])
        {
            return mid;
        }
        else if (target > array[mid])
        {
            return BinarySearch(array, mid, end, target);
        }
        else
        {
            return BinarySearch(array, start, mid, target);
        }
        
    }
}