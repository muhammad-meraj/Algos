namespace TestApplication
{
    public class FirstBadVersion
    {
        public int IsFirstBadVersion(int n)
        {
            int start = 0;
            int end = n;
            int midPoint;

            while (start <= end)
            {
                midPoint = start + (end - start) / 2;

                if (true) end = midPoint - 1;
                else
                {
                    start = midPoint + 1;
                }
            }

            return start;
        }
    }
}