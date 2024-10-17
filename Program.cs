using System;
using System.ComponentModel;
using System.Diagnostics;

namespace LCTesting {
    public class Program {
        static void Main(string[] args) {
            Stopwatch stopWatch = Stopwatch.StartNew();
            // int[] nums1 = [1, 2];
            // int[] nums2 = [3, 4];
            // int[] nums3 = nums1.Concat(nums2).ToArray(); // Can also be  = [.. nums1, .. nums2];
            // stopWatch.Stop();
            // Console.WriteLine($"Time so far: {stopWatch.Elapsed}");
            
            // stopWatch.Restart();
            // int[] nums4 = [.. nums1, .. nums2];
            // stopWatch.Stop();
            // Console.WriteLine($"Time for that other one: {stopWatch.Elapsed}");

            // // We have determined list comprehensions are better in terms of speed.
            // stopWatch.Restart();
            // var nums5 = nums4.ToList<int>();
            // nums5.Sort();
            // stopWatch.Stop();
            // Console.WriteLine($"To sort: {stopWatch.Elapsed}");

            // foreach (int num in nums5) {
            //     Console.Write($" {num}");
            // }
            // Console.WriteLine(" ");
            
            // it's still faster to use list comp 
            // AND sort than to just do the concat opertation and get into an array.

            Console.WriteLine("");

            // Palindromer problem from leetcode
            Palindromer p = new();
            Console.WriteLine("PALINDROMER:");
            // Console.WriteLine(p.LongestPalindrome("babad"));
            // Console.WriteLine(p.LongestPalindrome("cbbd"));
            stopWatch.Restart();
            Console.WriteLine(Palindromer.LongestPalindrome("abba"));
            Console.WriteLine(Palindromer.LongestPalindrome("gaabaag"));
            Console.WriteLine(Palindromer.LongestPalindrome("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaabcaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"));
            stopWatch.Stop();
            Console.WriteLine($"Naive approach: {stopWatch.Elapsed}");
            stopWatch.Restart();
            Console.WriteLine(Palindromer.LongestPalindrome2D("abba"));
            Console.WriteLine(Palindromer.LongestPalindrome2D("gaabaag"));
            Console.WriteLine(Palindromer.LongestPalindrome2D("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaabcaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"));
            stopWatch.Stop();
            Console.WriteLine($"2D approach: {stopWatch.Elapsed}");
        }
    }
}