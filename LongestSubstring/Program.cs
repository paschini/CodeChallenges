namespace LongestSubstring;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Length of longest substring, without repeating chacters: {Solution.LengthOfLongestSubstring("abcabcbb").ToString()}"); // abc or cba cab
        Console.WriteLine($"Length of longest substring, without repeating chacters: {Solution.LengthOfLongestSubstring("bbbbb").ToString()}"); // b
        Console.WriteLine($"Length of longest substring, without repeating chacters: {Solution.LengthOfLongestSubstring("pwwkew").ToString()}"); // wke
        Console.WriteLine($"Length of longest substring, without repeating chacters: {Solution.LengthOfLongestSubstring("dvdf").ToString()}"); //vdf
    }

    public static class Solution
    {
        public static int LengthOfLongestSubstring(string s)
        {
            string uniques = "";
            string result = "";
            string[] found = {};
            
            //find uniques
            for (int i = 0; i < s.Length; i++)
            {
                uniques = uniques.Contains(s[i]) ? uniques : uniques + s[i];
            }
            
            Console.WriteLine($"uniques: {uniques}");
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = uniques.Length; j > 0; j--)
                {
                    string next = s.Substring(i, j );
                    // Console.WriteLine(next);
                    Console.WriteLine($"i: {i} j: {j} next: {next}");
                    
                    // Console.WriteLine($"found: {next}");
                    found = found.Append(next).ToArray();
                    result = next;
                }

                if (s.Substring() > 0)
                {
                    
                }
                // if (s.Contains(result)) break;
            }
            
            string bigger = found.MaxBy(x => x.Length);
            Console.WriteLine($"result: {result}");
            return bigger.Length;
        }
    }
}