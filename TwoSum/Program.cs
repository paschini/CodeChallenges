namespace TwoSum;

internal class Program
{
    private static void Main(string[] args)
    {
        // Solution.TestWithInputAndTarget([3,3], 6);
        // Solution.TestWithInputAndTarget([3, 2, 3], 6);
        Solution.TestWithInputAndTarget([-3, 4, 3, 90], 0);
    }

    public static class Solution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            // Follow up Solution
            Dictionary<int, int> seen = new(); // value → index

            for (int i = 0; i < nums.Length; i++)
            {
                int needed = target - nums[i];

                // If I've seen the number that matches this one's difference, we're done
                if (seen.TryGetValue(needed, out int matchIndex)) return new[] { matchIndex, i };

                // Otherwise, remember this one for later
                seen[nums[i]] = i;
            }

            return Array.Empty<int>(); // fallback, shouldn't happen per problem constraints

            // First solution, brute force O(n^2) --- slooooow
            // int[] result = {};
            //
            // foreach(int num in nums) {
            //     foreach(int pair in nums) {
            //         if (Array.IndexOf(nums, num) != Array.IndexOf(nums, pair)) {
            //             if (num + pair == target)
            //             {
            //                 result = result.Append(Array.IndexOf(nums, num)).ToArray();
            //             }
            //         }
            //     }
            // }
            //
            // return result;
        }

        public static string OutputArray(int[] arr)
        {
            string output = "";
            foreach (int num in arr) output = $"{output} {num} ";

            return output;
        }

        public static void TestWithInputAndTarget(int[] input, int target)
        {
            int[] result = TwoSum(input, target);

            Console.WriteLine($"Input: {OutputArray(input)} Target: {target}");
            Console.WriteLine($"Result: {OutputArray(result)}");
        }
    }
}