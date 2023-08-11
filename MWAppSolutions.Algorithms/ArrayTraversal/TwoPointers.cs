using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWAppSolutions.Algorithms.ArrayTraversal
{
    public static class TwoPointers
    {
        /// <summary>
        /// Tests if the characters in a string are a valid palindrome.
        /// Ignores non-alphanumeric charecters
        /// Runtime of O(n/2)
        /// </summary>
        /// <param name="s">The string to test</param>
        /// <returns>The boolean result indicating if it's a valid palindrome</returns>
        public static bool ValidPalindrome(string s)
        {
            int a = 0;
            int z = s.Length - 1;
            while (a < z)
            {
                // Skip over characters that are not letters or numbers
                if (!char.IsLetterOrDigit(s[a]))
                {
                    a++;
                    continue;
                }
                if (!char.IsLetterOrDigit(s[z]))
                {
                    z--;
                    continue;
                }
                // Characters have to match for it to be a palendrome
                if (char.ToLower(s[a]) != char.ToLower(s[z]))
                {
                    return false;
                }
                // Move to what should be the next matching pair
                // Becuase we have half as many iterations as chars our runtime will be O(n/2)
                a++;
                z--;
            }
            return true;
        }

        /// <summary>
        /// Checks is the substring can be built from the in order letters of myString
        /// </summary>
        /// <param name="myString">The string to examine for substrings</param>
        /// <param name="substring">The substring to search for</param>
        /// <returns>A boolean for is found</returns>
        public static bool IsSubsequence(string myString, string substring)
        {
            if (substring.Length == 0) return true;
            int pointer2 = 0;
            for (int i = 0; i < myString.Length; i++)
            {
                if (myString[i] == substring[pointer2])
                {
                    pointer2++;
                }
                if (pointer2 > substring.Length - 1) return true;
            }
            return false;
        }
    }
}
