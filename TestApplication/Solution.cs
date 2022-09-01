using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace TestApplication
{
    public class Solution
    {
        // public int LengthOfLongestSubstring(string s) {
        //     int maxLen = 0;
        //     int i = 0;
        //     var map = new Dictionary<char, int>();
        //     
        //     for (var j = 0; j < s.Length; j++)
        //     {
        //         if (map.TryGetValue(s[j], out var result) && result > i)
        //         {
        //             i = map.GetValueOrDefault(s[j]) + 1;
        //         } 
        //         map.Add(s[j], j);
        //         maxLen = Math.Max(maxLen, j - i + 1);
        //     }
        //
        //     return maxLen;
        // }
        //
        // public int findLucky(List<int> arr)
        // {
        //     Dictionary<int, int> map = new Dictionary<int, int>();
        //     foreach (var i in arr)
        //     {
        //         if (!map.ContainsKey(i))
        //         {
        //             map.Add(i, 1);
        //         }
        //         else
        //         {
        //             map[i] += 1;
        //         }
        //     }
        //     map.Count()
        //
        //     var luckyNumbers = map.Where(i => i.Key == i.Value).ToList();
        //     if (luckyNumbers.Count() == 1) return luckyNumbers.First().Value;
        //
        //     return luckyNumbers.Max(i => i.Key);
        // }

        // public int Solution1(int X, int[] B, int Z)
        // {
        //     int aggregatedBytes = B.Sum();
        //     if (ValidateInput(X, B, Z, aggregatedBytes)) return -1;
        //     
        //     var remainingBytes = X - aggregatedBytes;
        //
        //     if (X == aggregatedBytes)
        //     {
        //         // file download is completed
        //         return 0;
        //     }
        //
        //     decimal average;
        //     if (Z < B.Length)
        //     {
        //         int sumOfSample = B.Skip(Math.Max(0, B.Length - Z)).Sum();
        //         //average = Math.Ceiling((decimal)sumOfSample / Z);
        //         average = (decimal)sumOfSample/Z;
        //     }
        //     else
        //     {
        //         //average = Math.Ceiling((decimal)sumOfDownloadedBytes / B.Length);
        //         average = (decimal)aggregatedBytes/B.Length;
        //     }
        //
        //     var estimate = (int)decimal.Ceiling(remainingBytes / average);
        //     return estimate;
        // }
        //
        // private static bool ValidateInput(int X, int[] B, int Z, int sumOfDownloadedBytes)
        // {
        //     return B.Length < 1 || sumOfDownloadedBytes == 0 || Z < 1 || X < 1 || sumOfDownloadedBytes > X;
        // }
        
        // public int solution(string[] T, string[] R)
        // {
        //     var map = new Dictionary<string, bool>();
        //     
        //     for (int i = 0; i < T.Length; i++)
        //     {
        //         var groupNumber = Regex.Match(T[i], @"\d+").Value;
        //         var isOkResult = R[i] == "OK";
        //
        //         if (map.ContainsKey(groupNumber))
        //         {
        //             map[groupNumber] = map[groupNumber] && isOkResult;
        //         }
        //         else
        //         {
        //             map[groupNumber] = isOkResult;
        //         }
        //     }
        //
        //     var totalGroups = map.Count;
        //     var groupsWithOkResult = map.Count(b => b.Value);
        //     var result = Math.Floor((decimal)(groupsWithOkResult * 100 / totalGroups));
        //     return (int)result;
        // }
        //
        // public void Test()
        // {
        //     List<int> l = new List<int>();
        //     
        //     Console.WriteLine(l.Sum());
        // }

        public void closestNumbers(List<int> numbers)
        {
            numbers.Sort();
            var lowestDiff = Math.Abs(numbers[1] - numbers[0]);
            List<int> result = new List<int> {numbers[0], numbers[1]};

            for (int i = 1; i < numbers.Count-1; i++)
            {
                if (Math.Abs(numbers[i + 1] - numbers[i]) < lowestDiff)
                {
                    result.RemoveAll(x => true);
                    result.Add(numbers[i]);
                    result.Add(numbers[i + 1]);
                    lowestDiff = Math.Abs(numbers[i + 1] - numbers[i]);
                } else if (Math.Abs(numbers[i + 1] - numbers[i]) == lowestDiff)
                {
                    result.Add(numbers[i]);
                    result.Add(numbers[i + 1]);
                }
            }

            var index = 0;
            while (index < result.Count-1)
            {
                if (index % 2 == 0)
                {
                    Console.WriteLine($"{result[index]} {result[index + 1]}");
                }
                index++;
            }
        }
    }
}