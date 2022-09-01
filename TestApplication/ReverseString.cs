namespace TestApplication
{
    public class ReverseString
    {
        public char[] ReverseStr(char[] s) {
            var start = 0;
            var end = s.Length - 1;

            while (start < end)
            {
                (s[start], s[end]) = (s[end], s[start]);
                start++;
                end--;
            }

            return s;
        }
        
        public string ReverseWords(string s)
        {
            var words = s.Split(" ");
            var i = 0;
            var result = "";
            
            while (i < words.Length)
            {
                result += new string(ReverseStr(words[i].ToCharArray()));
                if (i < words.Length - 1)
                {
                    result += " ";
                }

                i++;
            }
            return result;
        }
    }
}