using System;
using System.Collections.Generic;

namespace TestApplication
{
    public class LongestSubString
    {
        // abcdaef
        
        // a=0, b = 1, c= 2, d = 3,  a = 4
        // result = 0
        public int LengthOfLongestSubstring(string str)
        {
            int n = str.Length;
            int res = 0; // result
            int NO_OF_CHARS = 256;
 
            // last index of all characters is initialized
            // as -1
            int [] lastIndex = new int[NO_OF_CHARS];
            Array.Fill(lastIndex, -1);
 
            // Initialize start of current window
            int i = 0;
 
            // Move end of current window
            for (int j = 0; j < n; j++)
            {
 
                // Find the last index of str[j]
                // Update i (starting index of current window)
                // as maximum of current value of i and last
                // index plus 1
                i = Math.Max(i, lastIndex[str[j]] + 1);
 
                // Update result if we get a larger window
                res = Math.Max(res, j - i + 1);
 
                // Update last index of j.
                lastIndex[str[j]] = j;
            }
            return res;
        }
    }
}