namespace RemoveElement;

internal class Program
{
    private static void Main(string[] args)
    {
        Solution.RemoveElement([1, 2, 3, 4], 3);
        Solution.RemoveElement([3, 3], 3);
        Solution.RemoveElement([2], 3);
        Solution.RemoveElement([4, 5], 4);
        Solution.RemoveElement([3, 3], 3);
        Solution.RemoveElement([3, 2, 2, 3], 3);
        Solution.RemoveElement([0, 1, 2, 2, 3, 0, 4, 2], 2);
    }

    private static class Solution
    {
        public static int RemoveElement(int[] nums, int val)
        {
            
            // first try
            // int k = 0;

            // if (nums.Length == 0) return k;

            //     for (int i = 0; i < nums.Length; i++)
            //     {
            //         if (nums[i] != val)
            //         {
            //             k++;
            //         }
            //     }

            //     if (nums.Length > 2)
            //     {
            //         for (int i = 0; i < nums.Length; i++)
            //         {
            //             if (nums[i] == val)
            //             {
            //                 if (i < k)
            //                 {
            //                     if (k + i < nums.Length - 1)
            //                     {
            //                         (nums[k + i], nums[i]) = (nums[i], nums[k + i]);
            //                     }
            //                     else
            //                     {
            //                         (nums[nums.Length - i], nums[i]) = (nums[i], nums[nums.Length - i]);
            //                     }
            //                 }
            //             }
            //         }
            //     }
            //     else if (nums.Length <= 2)
            //     {
            //         if (nums[0] == val && nums[nums.Length - 1] != 1)
            //         {
            //             (nums[0], nums[1]) = (nums[1], nums[0]);
            //         }
            //         
            //         k = 1;
            //     }
            //     return k;
            
            
            Console.Write("Nums original: ");
            foreach (int num in nums) Console.Write($"{num} ");

            int k = 0;
            for (int i = 0; i < nums.Length; i++)
                if (nums[i] != val)
                {
                    if (k != i) (nums[i], nums[k]) = (nums[k], nums[i]);
                    k++;
                }


            Console.Write("Nums: ");
            foreach (int num in nums) Console.Write($"{num} ");

            Console.WriteLine($"K: {k}");
            return k;
        }
    }
}