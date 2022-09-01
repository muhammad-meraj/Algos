using System;
using System.Collections.Generic;

namespace TestApplication
{
    public class ShortestVacation
    {
        public int Solution(int[] A) {
            var unique = new HashSet<int>();
            var arr = new int[100000];
            var min = A.Length;

            foreach (var k in A)
            {
                unique.Add(k);
            }

            for (int i=0, j=0; i<=j && j<A.Length; ){

                if(unique.Count > 0) {
                    arr[A[j]]++;
                    unique.Remove(A[j++]);
                }
                else {
                    if(arr[A[i]] == 1){
                        unique.Add(arr[A[i]]);
                        min = Math.Min(min,j-i);
                    }
                    arr[A[i]]--;
                    i++;
                }
            }
            return min;
        }
    }
}