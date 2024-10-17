using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCTesting
{
    /**
    * Leetcode: Longest Palindrominc Substring
    *
    * given: a string s with len 1 <= s.Length <= 1000
    * 
    * find the longest palindrome within the substring.
    * 
    * e.g. LongestPalindrome("abba") = "abba" 
    * LongestPalindrome("gabba") = "abba" 
    * LongestPalindrome("massachusetts") = "ss" or "tt"
    * LongestPalindrome("hi") = "h" or "i" 
    */
    public class Palindromer
    {
        /*** The Naive Approach ***/
        public static bool IsPalindrome(string s){
            if (s.Length % 2 == 0) {
                string s1 = s.Substring(0, s.Length / 2);
                char[] s2_array = s.Substring(s.Length / 2, s.Length / 2).ToCharArray();
                Array.Reverse(s2_array);
                string s2 = new string(s2_array);
                if (s1 == s2){
                    return true;
                }
                else {
                    return false;
                }
            }
            else {
                string s1 = s.Substring(0, (s.Length)/2);
                char[] s2_array = s.Substring((s.Length+1)/2, (s.Length)/2).ToCharArray();
                Array.Reverse(s2_array);
                string s2 = new string(s2_array);
                if (s1 == s2){
                    return true;
                }
                else {
                    return false;
                }
            }
        }

        public static string LongestPalindrome(string s){
            int c1 = 0;
            string current_longest = s.Substring(c1, 1);
            for (c1 = 0; c1 < s.Length; ++c1) {
                int c2 = s.Length;
                if (c2 - c1 <= current_longest.Length) {
                    continue;
                }
                for (c2 = s.Length; c2 > c1; --c2) {
                    string s2 = s.Substring(c1, c2 - c1);
                    if (s2.Length > current_longest.Length && IsPalindrome(s2)) {
                        current_longest = s2;
                        break;
                    }
                }
            }
            return current_longest;            
        }


        /**** 2D array approach
        from: https://www.geeksforgeeks.org/longest-palindromic-substring/#using-dynamic-programming
         ****/
        public static string LongestPalindrome2D(string s) {
            int len = s.Length;
            bool [,] arr = new bool[len, len];

            // s[i] == s[i], so make all them true
            for (int i = 0; i < len; ++i) {
                arr[i, i] = true;
            }

            int maxLen = 1;
            int start = 0;
            // Check s[i] == s[i+1]
            for (int i = 0; i < len - 1; ++i) {
                if (s[i] == s[i+1]){
                    arr[i, i+1] = true;
                    start = i;
                    maxLen = 2;
                }
            }
            
            // Check lengths greater than 2
            for (int k = 3; k <= len; ++k) {
                for(int i = 0; i < len - k + 1; ++i) {
                    int j = i + k - 1;
                    if (arr[i+1, j-1] && s[i] == s[j]) {
                        arr[i, j] = true;
                        if (k > maxLen) {
                            start = i;
                            maxLen = k;
                        }
                    }
                }
            }

            return s.Substring(start, maxLen);
        }
    }
}