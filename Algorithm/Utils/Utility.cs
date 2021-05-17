using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Utils
{
    public class Utility
    {
        public static Stack<byte> SplitNums(long numbers)
        {
            var results = new Stack<byte>();
            while (numbers > 0)
            {
                var num = (byte)(numbers % 10);
                results.Push(num);
                System.Console.WriteLine("{0}", num);
                numbers /= 10;
            }
            return results;
        }
    }
}
