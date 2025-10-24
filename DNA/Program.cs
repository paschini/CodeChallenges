using System.Diagnostics;
using System.Text;

namespace DNA;

class Program
{
    static void Main(string[] args)
    {
        Solution.FindRepeatedDnaSequences("AAAAACCCCCAAAAACCCCCCAAAAAGGGTTT");
        // Solution.FindRepeatedDnaSequences("AAAAAAAAAAAAA");
        // Solution.FindRepeatedDnaSequences("AAAAAAAAAA");
        // Solution.FindRepeatedDnaSequences("GATGGATACTGCATTCGAACCAGAGCCGGCTTTTGCGGGACTAGCATGAGGGACTTGGCTGTTGAGGCTGTACGAGGTCAGTCCTCCGGCAGTGCTATCGCAGGAATTTTTGCAACTCCACTGCTTATAATCCACCAAGTCCAGACTCAAAGCTCAACTCGGGGATCGCACGGTATGGTCACTGTCGCGCATGCAGTAATAGTCCAGACGAACGCACATTGGTCGTCCCCTGAGCCCGTGCCAGCCTAATACTTCTTATGCCTGCGTAAGTAGACTTTGCCAACGTAATCTCATCCTTATGCCAGATTATTAGTTCATTGAATGTCGGTCGCCGGCGCTCCCGCATTTCTTATCCGCGTATCTTGGGGTCAAGACGTCCCCAGCTTGTTAATACAAGCTACTTTCCCTCGCAATTACTAAGTTCGTGACAAGCGAATCACGCTAAGATGTTATTGGACTCTACAGAAATATTGAATTGACAACATTCGTCTGTTCAGATCGTCGTTCACGCCACTGATAGCGCAGCTCGAGCACTCTGGAGCCACAATGCGGAATGTCCAGAACCTTTGCGCAAGAGTCCGTGGAAAGCATAATCGTGAACAGAATGGCTAGCCGAGGTGCGCAAGGATAGGACCGTCTACACAAAGTATGGGCACCACGCACATCGACACCCCGTAGTGTGTCAGTCGGCTCAGCGGCTAATGGGTTCGGCGTGAGGAATAGAAATAATAGGCAGTGGTGCCAATTGTGGGGTCTTCTTTTGACTTTCTCATCTCTCTATGAATCAGATCGGCCTCTCGCCCCCGCCGGCCCTCTGGCTTTTTTAAATCCTAGATTGTGCACGTGCCCCGGTTTCCTTCAAGGCAAGTGAAGCGCGTCTTTGCTCTAAACCCACGGCCGTTGCACGGCGCCGAACAGGTGTCTCGGTGCGACCGGAGTGAGCAAGTTCTGTCCGCATCGTATGATTATACCCCCTCCTGTCACGGCTCGGGACTTATCGCACCACAGATCAGCTCGCAGCCCCGCGCGAGTACTAGGGACGGGAGGGAAACCAAAGATAATCGTCTTTGCATGGGCCGGCATGTGAATCATTCGTATCATCTTCTGGAGTCTTGTCACGACGATTTTCGATACAGACTGTTGACCCATCTAATCGTGTTGTCAGTCTGGGAACCGTACTTTTTAACCCGTCGTTCGAGCGGCCCGATCAGGGATGCCCGCAGTGTACGGGCACATCGTCGTCTTGGGAACAAAAGCTTGACGGACACCTCTATGCAGACATGAGACGTGAGGCCCCTGCAATAGTGCGGTCACAGGGACCGGCTGTCGATCAGTAGGTATAATCTTGATGTTTGCTGGGAGATTAACAGAGGGCGGAGTTCCGCATCGCCTAACCACTGACAGTCATTGATAGACGCCTAAGTTTGTCCCTGTAGCTACAGTGGTGGCAAAGTGGCCTTGGACGGTTCTGCGCTTGTCAATAAGTCTGTCCCAATCACGAGTGAAAAACTAGCTAGGGTCGGTGATGTGTTTTCAATCATATTTCTCCATCCATCCGGGGCTCCCTAGTACGGAGGAAATCTCCGGGTAACTCTGGATCTCCAGCATTGCGTAAGCAAACCGCCAATCGGGCCGCAGTGAGTTCTTAAACTACGGTTTGGCCCTAATCGCACTATTGGGTGTTGTAGATACGATAGCAAGGTGATTATGAAATCAAGGCACGCACGACCTGTACGTTGATCGTCGAGTGCTCTCGAGTTACTTCATGGGTCAGCCATGCGATTGTCCAAATGGACCGGAAAGTACACTACAAATTGTACCACTGTGCGTTGTACCTCACAAGAACTGTTTGGGTCTACTTACTTTTTACTTGGATCTTTCCTGGTCTCCCTCAGCGTAATTATTCGACACAATGCTGCAGCTGCGTTGTAGTTTTGGCGGTACAGGAAAAATTCTTGTGAGCAACCAGGCCATTCCCTGGAAGGCAGTCCTTGCGAGTATGTTGAGATATATGCTGGGGATGAATTAGAACATTATGCCATCTAAAGTTTGGATTACCGGGGATTCGGCATACCAAATGGATTCGTTGATTATAGCCCCCCCACCTCCTTTTAGGTAAAATGCCCAATCCTGGCGCTGAGCAGGAGGCATGTTGGCCTCTTGTCCGGTAGTACGCTTGACTAGTTCCTAGCGGCGCAAATCACTTGGTCTCTGTCCGTCCTGAATGTTACAAAGCCATATACATGTGTGGAGGTCAAGACATTCCTTATCCGCCCCCCTCGCGATGCAGTTAGATTCGCATTCAAGGTTGAGACCGGAGACCTTCTAACCGGATTTTGGAGTATAGCCCCTTGATAAGAGAAGGAACCATGCTGGGTCTCACGACTATTGAGTTCGGGAAAAGGTGAATGCTCAACGCTAACGCAGTTTGTTACGCCTGGCGGAATAACGTCAGGGACAAACTATATTCTGGCGCCCCAGTGTGGGCTCTTTGACGACATAGGACGGATTAGGCCGGTCTCAACCGCCTCGTAACCCAGGAAGCGGTTCTACTCCCGGCTACTTTTTTGGAGTGTGCAAGGACGTTGCACACAGTGGGTGTCAGATCTAGCCCGTCACATGCAAGTGGTCATATGGATCCCATAATACTCACTGAGTGTCTCGCCAACGGGACTATTAATAGACACGGTGATAGACGGTAGGAATTGTGAGATTCATAATTAGTAACAGTAGGAGCGCCGTAGGCCACGGACCGATACATCGGAACCCTTCGCCGAATACGTTAAGGGTTTGCAACCGGGGGTGCATCTAATCCTTGGGGCTGATCTGTCAAAGGCGTCTCATGCGTGATTATATTAGCGAGAACCTGCATCAATGCTTTAAATAGACAAACCGGTTAATTTGCCAAGAGTTGGGACTACCTGACGGCAAGAGATGGTTAATTGGGCGATTACTTCACGGGTTTGTCTCGATTAAAGAACTAGGATTGCTGTTGTCTTACAAGTTCAGTCATTATCCTTCTGCTATAGCTCTGGATTAGCAATTGGTTTGGGGAAAACCTTTCTCCGTACGAGTAAGGCTGTCGGTAGCCATACTGACTGATCCCGAACACAAAACACTATTCTGTGGAACCAGCAGGTATTAGCATACTGCCCAGTATTCCCGAGTTACGGTTGACTCGGGTCTTAAGCATTTTAAACTGTCCCGATAACCCATTGACTAAGTCCATACATCAGACAAGCTCATGCATCCACTTATACCCGGTGAGAGTAGTTTATGACCAGTAACCGTTACCGAGCCACAGCCACCGCGTGGTGTTGCGGCGCTGTACTATATTATTACTGATGCGGTCCCTAGAGGACTACGCTCCAAGCAAACTTATCTTATTGAAAGTATACACCTAGCAACCTGGGCCGGATTCAATCCGGGATCTGCTCCCCTAGAGCGTTTAATTCGGACCCCTAGTACATAACATTCGGAAATTGGTTCTGGCTTTATGTGGCAATCTGTAATGCAGAAAACATGCTATCGCGCATAAAACCAGTTAAGCTTGATCTCAGATAGTAAAATTCCTGTACCCTCTACAATCCCCCAGAGAAGCTCAGTATACGAACGGAGGAGTAGACTTCGTTACTTGATTCTGGCTACCTCAAAGTCCTCCCTCGAGTTAGAACATGGTGCTCCGTCAGAGGGTTCATTATGGCCGACACGCGAGCTTGCGCTCTGTATGTATGCCGGGGTCCTCTGTCCTGGTGGAGACTGACCATGTACCCCTTATGCCCGGAGAATACCACCTGCTCCACGTGATGCAGCACTGATTGCTCATGGGCGCTCAGCATAGAGATATCTGAGTAGTCCGATACACTTACAGACCGTAAATGCCACTCGGGTTCCTAGCAGAGTGAGGGGTTGCGAATTTTCTGCACATGTAAATTGGGCGTAGACACAACTGTAAAATGCGTCGTAAAAATACAGCTAAGCACCGAACAACGGGATAGGTATTTAGCTAACGTAATTAGTTGTAGAGACACGTAAGCATCCTAGGTCTGACGCTCCCACTATTACGGTGAGTTTGACGCAGAAGTCTTGGTTATGATGCCCTGGATCTGTGAGCTCGGCCTTCCCTGTACAGTGG");
    }

    public static class Solution
    {
        private static int Encode(char c) => c switch
        {
            'A' => 0b00,
            'C' => 0b01,
            'G' => 0b10,
            'T' => 0b11,
            _   => 0
        };
        
        public static IList<string> FindRepeatedDnaSequences(string s)
        {
            // First accepted solution
            // HashSet<string> result = [];
            // IList<Int32> seen = [];
            // Int32 looking = 0;
            
            // for (int left = 0; left < s.Length; left++)
            // {
            //     if (s.Length - left >= 10)
            //     {
            //         foreach (var c in s.Substring(left, 10))
            //         {
            //             // remove the leftmost 2 bits, shift left, and add a new rightmost base
            //             looking = ((looking << 2) & ((1 << 20) - 1)) | Encode(c);
            //         }
            //         
            //         if (seen.Contains(looking)) result.Add(s.Substring(left, 10)); else seen.Add(looking);
            //         looking = 0;
            //     }
            // }
            
            var result = new HashSet<string>();
            var seen = new HashSet<int>();
            
            if (s.Length < 10) return result.ToList();

            int hash = 0;
            // build first 10-char window
            for (int i = 0; i < 10; i++)
                hash = (hash << 2) | Encode(s[i]);

            seen.Add(hash);

            for (int i = 10; i < s.Length; i++)
            {
                // slide window: shift left 2 bits, add new char, mask 20 bits
                hash = ((hash << 2) & 0xFFFFF) | Encode(s[i]);

                if (!seen.Add(hash)) // already seen → repeated
                    result.Add(s.Substring(i - 9, 10));
            }
            
            // close, I thought I had to care about when the letters change
            // then I saw a test where the letter would change all the time, and confirmed I was on the wrong track here
            // var seen = new HashSet<string>();
            // string looking = "";
            // int right = 0;
            // int[] indexOfChange = [];
            // 
            // for (int left = 0; left < s.Length; left++)
            // {
            //     right = indexOfChange.Length > 0 ? indexOfChange.Min() : 0;
            //     while (looking.Length < 10 && right < s.Length && s.Length - left >= 10)
            //     {
            //         looking += s[right];

            //         if (looking.Length > 1 && looking[^1] != looking[^2])
            //         {
            //             indexOfChange = indexOfChange.Append(looking.Length - 1).ToArray();
            //         }
            //         right++;
            //     }
            //     
            //     if (looking.Length == 10) seen.Add(looking);
            //     looking = "";
            // }

            // return seen.ToArray();
            
            // close agaain, but time limit exceeded
            // HashSet<string> result = [];
            // IList<string> seen = [];
            // string looking = "";
            // int right = 0;

            // for (int left = 0; left < s.Length; left++)
            // {
            //     right = left;
            //     while (looking.Length < 10 && right < s.Length && s.Length - left >= 10)
            //     {
            //         looking += s[right];

            //         right++;
            //     }

            //     if (looking.Length == 10)
            //     {
            //         if (seen.Contains(looking))
            //         {
            //             result.Add(looking);
            //             seen.Add(looking);
            //         }
            //         else
            //         {
            //             seen.Add(looking);
            //         }
            //         looking = "";
            //     }
            // }

            // return result.ToArray();

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