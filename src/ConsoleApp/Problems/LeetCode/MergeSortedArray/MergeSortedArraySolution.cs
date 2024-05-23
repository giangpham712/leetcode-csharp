namespace ConsoleApp.Problems.LeetCode.MergeSortedArray;

/*
 * Use Two Pointer approach
 */
public class MergeSortedArraySolution
{
    public object Solve(int[] nums1, int m, int[] nums2, int n)
    {
        m--;
        n--;
        
        var cursor = nums1.Length - 1;
        while (n >= 0)
        {
            if (m < 0 || nums1[m] < nums2[n])
            {
                nums1[cursor] = nums2[n];
                n--;
            }
            else
            {
                nums1[cursor] = nums1[m];
                m--;
            }

            cursor--;
        }

        return nums1;
    }
}