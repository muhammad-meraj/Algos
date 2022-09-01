using System;

namespace TestApplication
{
    public class CarryForward
    {
        public int CountCarryForward(int a, int b)
        {
            if (a == 0 || b == 0) return 0;

            var aLen = a.ToString().Length;
            var bLen = b.ToString().Length;

            var count = Math.Max(aLen, bLen);

            var num1 = aLen > bLen ? a : b;
            var num2 = aLen < bLen ? b : a;

            var carryForwards = 0;

            while (count > 0)
            {
                var i = num1 % 10;
                var j = num2 % 10;
                
                // if(num1 > 10) i = num1 % 10;
                // if(num2 > 10) j = num2 % 10;

                if (i + j >= 10)
                {
                    carryForwards++;
                }

                if(num1 >= 10) num1 = (num1 - i) / 10;
                if(num2 >= 10) num2 = (num2 - j) / 10;
                count--;
            }

            return carryForwards;

        }
    }
}

//     1
// 99999

//1234
//  66
//-------

// 1234%10 = 4
// 66 % 10 
//
// 1234 - 4 = 1230/10 123


// 999
//  88
//   7

