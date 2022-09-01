using System;
using System.Collections.Generic;

namespace TestApplication
{
    public class FindLongestSubStr
    {
        public int LengthOfLongestSubstring(string s)
        {
            var maxLen = 0;
            var map = new Dictionary<char, int>();
            var i = 0;

            for (int j = 0; j < s.Length; j++)
            {
                if (map.ContainsKey(s[j]) && map[s[j]] >= i)
                {
                    maxLen = Math.Max(maxLen, j - i);
                    i = j;
                    map[s[j]] = j;
                }
                else
                {
                    map[s[j]] = j;
                    maxLen = Math.Max(maxLen, j - i + 1);
                }
            }

            return maxLen;
        }
    }
}