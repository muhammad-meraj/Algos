using System;
using System.Linq;
using System.Text;

namespace TestApplication
{
    public class FindWords
    {
        // public void findWord(string[] words)
        // {
        //     var letterCount = words.Length + 1;
        //     var result = "";
        //
        //     for(var i = 0; i < words.Length; i++)
        //     {
        //         var rule = words[i];
        //         var firstChar = rule[0];
        //         var secondChar = rule[2];
        //
        //         if (!result.Contains(secondChar))
        //         {
        //             result = result.Insert(i, firstChar.ToString());
        //             result = result.Insert(i+1, secondChar.ToString());
        //         } else if (result.Contains(secondChar))
        //         {
        //             if(result.Contains(firstChar)) continue;
        //             //var index = Array.IndexOf(result, secondChar);
        //             var index = result.IndexOf(secondChar);
        //             result = RightShiftArray(result, index);
        //             result.Insert(index, firstChar.ToString());
        //         }
        //     }
        //     Console.WriteLine(result);
        // }
        //
        // string RightShiftArray(string arr, int i)
        // {
        //     for (int j = arr.Length - 2; j <= i; j--)
        //     {
        //         arr.Insert(j+1, arr[j].ToString());
        //     }
        //
        //     return arr;
        // }

        public void MakeWord(string[] words)
        {
            var result = new StringBuilder();
            
            foreach (var word in words)
            {
                var firstLetter = word[0];
                var secondLetter = word[2];

                var resultStr = result.ToString();

                if (!resultStr.Contains(firstLetter) && !resultStr.Contains(secondLetter))
                {
                    result.Append(firstLetter);
                    result.Append(secondLetter);
                } else if (!resultStr.Contains(firstLetter) && resultStr.Contains(secondLetter))
                {
                    var index = resultStr.IndexOf(secondLetter);
                    RightShiftArray(result, index);
                    result[index] = firstLetter;
                } else if (resultStr.Contains(firstLetter) && !resultStr.Contains(secondLetter))
                {
                    var index = resultStr.IndexOf(firstLetter);
                    RightShiftArray(result, index+1);
                    result[index+1] = secondLetter;
                }
            }
            
            Console.WriteLine(result.ToString());
        }

        void RightShiftArray(StringBuilder str, int i)
        {
            str.Length += 1;
            for (int j = str.Length - 2; j >= i; j--)
            {
                str[j+1] = str[j];
            }
        }
    }
}