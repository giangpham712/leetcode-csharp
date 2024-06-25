namespace ConsoleApp.Problems.LeetCode.SortAnArray;

public class ProblemSolution
{
    
    #region Quick sort
    
    public class QuickSort
    {
        public int[] Solve(int[] nums)
        {
            Sort(nums, 0, nums.Length - 1);

            return nums;
        }

        private void Sort(int[] nums, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            
            var pivot = Partition(nums, start, end);

            Sort(nums, start, pivot - 1);
            Sort(nums, pivot + 1, end);
        }

        private int Partition(int[] nums, int start, int end)
        {
            var pivot = nums[end];

            var i = start - 1;

            for (var j = start; j < end; j++)
            {
                if (nums[j] < pivot)
                {
                    i++;
                    (nums[i], nums[j]) = (nums[j], nums[i]);
                }
            }

            (nums[i + 1], nums[end]) = (nums[end], nums[i + 1]); 

            return (i + 1);
        }
    }
    
    #endregion

    #region Merge sort

    public class MergeSort
    {

        public int[] Solve(int[] nums)
        {
            Sort(nums, 0, nums.Length - 1);
            return nums;
        }

        private void Sort(int[] nums, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            
            var mid = (start + end) / 2;
            Sort(nums, start, mid);
            Sort(nums, mid + 1, end);
            Merge(nums, start, end);
        }

        private void Merge(int[] nums, int start, int end)
        {
            var mid = (start + end) / 2;

            var temp = new int[end - start + 1];

            var p1 = start;
            var p2 = mid + 1;

            var pTemp = 0;
            while (p2 <= end && p1 <= mid)
            {
                if (nums[p1] < nums[p2])
                {
                    temp[pTemp] = nums[p1];
                    p1++;
                }
                else
                {
                    temp[pTemp] = nums[p2];
                    p2++;
                }

                pTemp++;
            }

            while (p1 <= mid)
            {
                temp[pTemp] = nums[p1];
                p1++;
                pTemp++;
            }
            
            while (p2 <= end)
            {
                temp[pTemp] = nums[p2];
                p2++;
                pTemp++;
            }
            
            for (int i = 0; i < temp.Length; i++)
            {
                nums[i + start] = temp[i];
            }
        }
    }

    #endregion    
    
    
}