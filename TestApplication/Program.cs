using System;
using System.Collections.Generic;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // var a = new List<int>() {1, 2, 3, 4, 5};
            // var sum = 8;
            // Solution s = new Solution();
            //
            // var p = new FindPDrome();
            // Console.WriteLine(p.IsPalindrome("A man, a plan, a canal: Panama"));

            // int[] bytes = new[] {10, 6, 6, 8};
            // Console.WriteLine($"Result : {s.Solution1(100, bytes, 2)}");
            //
            // int[] bytes2 = Array.Empty<int>();
            // Console.WriteLine($"Result : {s.Solution1(100, bytes2, 2)}");
            //
            // int[] bytes3 = new[] {100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,100000, 6, 6, 84,5,6,7,8,9,1,2,3,4,5,6,7,8,9,};
            // Console.WriteLine($"Result : {s.Solution1(2000000, bytes3, 1)}");
            //
            // int[] bytes4 = new[] {10, 6, 6, 8};
            // Console.WriteLine($"Result : {s.Solution1(200, bytes4, 2)}");
            //
            // int[] bytes5 = Array.Empty<int>();
            // Console.WriteLine($"Result : {s.Solution1(100000, bytes5, 0)}");
            //
            // int[] bytes6 = Array.Empty<int>();
            // Console.WriteLine($"Result : {s.Solution1(-1, bytes6, 2)}");
            //
            // int[] bytes7 = Array.Empty<int>();
            // Console.WriteLine($"Result : {s.Solution1(100, bytes7, -2)}");
            //
            // int[] bytes9 = {-10, -6, -6, -8};
            // Console.WriteLine($"Result : {s.Solution1(100, bytes9, -2)}");
            //
            // int[] bytes8 = {10, 6, 6, 8};
            // Console.WriteLine($"Result : {s.Solution1(100, bytes8, 2000)}");


            // T[0] = "codility1"   R[0] = "Wrong answer"
            // T[1] = "codility3"   R[1] = "OK"
            // T[2] = "codility2"   R[2] = "OK"
            // T[3] = "codility4b"  R[3] = "Runtime error"
            // T[4] = "codility4a"  R[4] = "OK"

            // string[] T1 = {"codility1", "codility3", "codility2", "codility4b", "codility4a"};
            // string[] R1 = {"Wrong answer", "OK", "OK", "Runtime error", "OK"};
            // Console.WriteLine($"Result : {s.solution1(T1, R1)}");

            // T[0] = "test1a"  R[0] = "Wrong answer"
            // T[1] = "test2"   R[1] = "OK"
            // T[2] = "test1b"  R[2] = "Runtime error"
            // T[3] = "test1c"  R[3] = "OK"
            // T[4] = "test3"   R[4] = "Time limit exceeded"

            // string[] T2 = {"test1a", "test2", "test1b", "test1c", "test3"};
            // string[] R2 = {"Wrong answer", "OK", "Runtime error", "OK", "Time limit exceeded"};
            // Console.WriteLine($"Result : {s.solution1(T2, R2)}");

            // var n1 = new List<int>() {4, -2, -1, 3};
            // s.closestNumbers(n1);
            //
            // Console.WriteLine("__________________________");
            //
            // var n2 = new List<int>() {4, 2, 1, 3};
            // s.closestNumbers(n2);


            // var longestSubString = new LongestSubString();
            // const string str = "pwwkew";
            // Console.WriteLine(longestSubString.LengthOfLongestSubstring(str));

            // int[] arr = new int[]{1,3,5,6};
            // int target = 7;
            // SearchInsertPosition bSearch = new SearchInsertPosition();
            // Console.WriteLine(bSearch.SearchInsert(arr, target));

            // var arr = new[] {-7, -3, 2, 3, 11};
            // var sq = new SquareOfSortedArray();
            // var res = sq.SortedSquares(arr);
            // foreach (var r in res)
            // {
            //     Console.WriteLine(r);
            // }

            // var shortestVacation = new ShortestVacation();
            // var a = new[] {7, 5, 2, 7, 2, 7, 4, 7};
            // //var a = new[] {7,7,7,7,7,5};
            // Console.WriteLine(shortestVacation.Solution(a));

            // var mv = new MoveZeroes();
            // //var a = new[] {0, 1, 0, 3, 12};
            // var a = new[] {0,0,1};
            // mv.Solution2(a);

            // CarryForward cf = new CarryForward();
            // Console.WriteLine(cf.CountCarryForward(189, 209));

            // FindWords w = new FindWords();
            // string[] words = {"P>E", "E>R", "R>U"};
            // var word2 = new[] {"U>N", "G>A", "R>Y", "H>U", "N>G", "A>R"};
            // var word3 = new[] {"I>F", "W>I", "S>W", "F>T"};
            // var word4 = new[] {"R>T", "A>L", "P>O", "O>R", "G>A", "T>U", "U>G"};
            // var word5 = new[] {"W>T", "R>L", "T>Z", "Z>E", "S>W", "E>R", "L>A", "A>N", "N>D", "I>T"};
            // w.MakeWord(words);
            // w.MakeWord(word2);
            // w.MakeWord(word3);
            // w.MakeWord(word4);
            // w.MakeWord(word5);


            // TwoSum t = new TwoSum();
            // int[] nums = {2, 7, 11, 15};
            // var target = 9;
            // var result = t.Solution(nums, target);
            // foreach (var i in result)
            // {
            //     Console.Write($" {i}");
            // }

            // var t = new ReverseString();
            // var str = "Let's take LeetCode contest";
            // var result = t.ReverseWords(str);
            //
            // foreach (var c in result)
            // {
            //     Console.Write(c);
            // }

            // FindLongestSubStr f = new FindLongestSubStr();
            // Console.WriteLine(f.LengthOfLongestSubstring("dvdf"));

            // var p = new PermutationInString();
            // Console.WriteLine(p.CheckInclusion2("adc", "dcda"));

            var packets = new List<int> {1,9,1,10};
            //var channels = 3;
            Console.WriteLine(FindMaxQualityOfPacket.findMaxProducts(packets));

        }
    }
}