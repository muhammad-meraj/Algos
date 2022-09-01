using System.Text.RegularExpressions;

namespace TestApplication
{
    public class FindPDrome
    {
        public bool IsPalindrome(string s)
        {
            var cleanedString = CleanString(s).ToLower();

            var start = 0;
            var end = cleanedString.Length - 1;

            while (start != end)
            {
                if (cleanedString[start] != cleanedString[end]) return false;
                start += 1;
                end -= 1;
            }

            return true;
        }

        public string CleanString(string s)
        {
            var rgx = new Regex("[^a-zA-Z0-9]");
            return rgx.Replace(s, "");
        }
    }
}