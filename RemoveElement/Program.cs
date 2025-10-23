namespace RemoveElement;

class Program
{
    static void Main(string[] args)
    {
        Solution.RemoveElement([1, 2, 3, 4], 3);
        Solution.RemoveElement([3,3],3);
        Solution.RemoveElement([2], 3);
        Solution.RemoveElement([4, 5], 4);
        Solution.RemoveElement([3, 3], 3);
        Solution.RemoveElement([3, 2, 2, 3], 3);
        Solution.RemoveElement([0, 1, 2, 2, 3, 0, 4, 2], 2);
    }

    static class Solution
    {
        public static int RemoveElement(int[] nums, int val)
        {
            Console.Write("Nums original: ");
            foreach (var num in nums)
            {
                Console.Write($"{num} ");
            }
            
            int k = 0;
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] != val)
                {
                    if (k != i) (nums[i], nums[k]) = (nums[k], nums[i]);
                    k++;
                }
            }
            

            Console.Write("Nums: ");
            foreach (var num in nums)
            {
                Console.Write($"{num} ");
            }

            Console.WriteLine($"K: {k}");
            return k;
        }
    }
}