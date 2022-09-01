using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace TestApplication
{
    public class PermutationInString
    {
        public bool CheckInclusion(string s1, string s2)
        {
            if (s1.Length > s2.Length) return false;
            var s1Map = CreateMap(s1, 0, s1.Length);
            var result = false;
            var i = 0;

            while (i + s1.Length <= s2.Length)
            {
                var subStringMap = CreateMap(s2, i, i + s1.Length);
                if (AreMapEqual(s1Map, subStringMap))
                {
                    result = true;
                    break;
                }

                i += 1;
            }

            return result;

        }

        private static bool AreMapEqual(IReadOnlyDictionary<char, int> s1Map, Dictionary<char,int> subStringMap)
        {
            return s1Map.Count == subStringMap.Count && subStringMap.All(i => s1Map.ContainsKey(i.Key) && s1Map[i.Key] == i.Value);
        }


        private static Dictionary<char, int> CreateMap(string s, int start, int end)
        {
            var map = new Dictionary<char, int>();
            for(var i = start; i < end; i++)
                map[s[i]] = map.ContainsKey(s[i]) ? map[s[i]] + 1 : 1;

            return map;
        }

        public bool CheckInclusion2(string s1, string s2)
        {
            var s1Map = CreateMap(s1, 0, s1.Length);
            var s2Map = new Dictionary<char, int>();
            var s1Len = s1.Length;
            var l = 0;

            for(var i = 0; i< s2.Length; i++)
            {
                if (i >= s1Len)
                {
                    if (AreMapEqual(s1Map, s2Map)) return true;
                    if (s2Map.ContainsKey(s2[l]))
                    {
                        s2Map[s2[l]] -= 1;
                        if (s2Map[s2[l]] == 0) s2Map.Remove(s2[l]);
                    }
                    l += 1;
                }
                if(i < s2.Length)
                {
                    s2Map[s2[i]] = s2Map.ContainsKey(s2[i]) ? s2Map[s2[i]] + 1 : 1;
                }
            }

            return AreMapEqual(s1Map, s2Map);
        }
    }
}