using System.Runtime.InteropServices;

namespace LongestSubstring;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Length of longest substring, without repeating chacters: {Solution.LengthOfLongestSubstring("abcabcbb").ToString()}"); // abc or cba cab
        Console.WriteLine($"Length of longest substring, without repeating chacters: {Solution.LengthOfLongestSubstring("bbbbb").ToString()}"); // b
        Console.WriteLine($"Length of longest substring, without repeating chacters: {Solution.LengthOfLongestSubstring("pwwkew").ToString()}"); // wke
        Console.WriteLine($"Length of longest substring, without repeating chacters: {Solution.LengthOfLongestSubstring("dvdf").ToString()}"); //vdf
        Console.WriteLine($"Length of longest substring, without repeating chacters: {Solution.LengthOfLongestSubstring("ghifk").ToString()}"); //vdf
        Console.WriteLine($"Length of longest substring, without repeating chacters: {Solution.LengthOfLongestSubstring("").ToString()}"); //vdf
    }

    public static class Solution
    {
        public static int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0) return 0;
            
            var charset = new HashSet<char>(s);
            string uniques =  string.Join("", charset);
            string[] found = {};
            
            for (int x = 0; x < s.Length; x++)
            {
                for (int i = 0; i < s.Length - uniques.Length + 1; i++)
                {
                    for (int j = uniques.Length; j > 0 ; j -= uniques.Length)
                    {
                        string next = s.Substring(i, j);
                        charset = new HashSet<char>(next);
                        string deduped = string.Join("", charset);

                        found = s.Contains(deduped) && !found.Contains(deduped) ? found.Append(deduped).ToArray() : found;
                    }
                }

                if (uniques.Length > 1)
                {
                    uniques = uniques.Remove(0, 1);
                }
                else
                {
                    break;
                }
            }
            
            return found.MaxBy(x => x.Length).Length;
        }
    }
}