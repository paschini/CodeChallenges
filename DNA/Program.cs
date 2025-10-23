using System.Text.Json.Serialization;

namespace DNA;

class Program
{
    static void Main(string[] args)
    {
        Solution.FindRepeatedDnaSequences("AAAAACCCCCAAAAACCCCCCAAAAAGGGTTT");
        Solution.FindRepeatedDnaSequences("AAAAAAAAAAAAA");
        Solution.FindRepeatedDnaSequences("AAAAAAAAAA");
    }

    public static class Solution
    {
        public static IList<string> FindRepeatedDnaSequences(string s)
        {
            HashSet<string> result = [];
            IList<string> seen = [];
            string looking = "";
            int right = 0;

            for (int left = 0; left < s.Length; left++)
            {
                right = left;
                while (looking.Length < 10 && right < s.Length && s.Length - left >= 10)
                {
                    looking += s[right];

                    right++;
                }

                if (looking.Length == 10)
                {
                    if (seen.Contains(looking))
                    {
                        result.Add(looking);
                        seen.Add(looking);
                    }
                    else
                    {
                        seen.Add(looking);
                    }
                    looking = "";
                }
            }

            Console.WriteLine($"Result: ");
            foreach (var item in result)
            {
                Console.WriteLine($"[{item} ]");
            }

            Console.WriteLine($"Seen: ");
            foreach (var item in seen)
            {
                Console.WriteLine($"[{item} ]");
            }

            return result.ToArray();
        }
    }
}