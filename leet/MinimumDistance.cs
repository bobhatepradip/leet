using System;
using System.Collections.Generic;
using System.Text;

namespace leet
{
    static class MinimumDistance
    {
        public static int solve(string A)
        {
            int x = -1;
            int y = -1;
            int minD = int.MaxValue;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 'x')
                {
                    x = i;
                }
                else if (A[i] == 'o')
                {
                    y = i;
                }
                //Console.WriteLine("{0}-{1}={2}-{3}  Len:{4}", minD, Math.Abs(x - y), x, y, A.Length);
                if (x > 0 && y > 0 && minD > Math.Abs(x - y))
                {
                    minD = Math.Abs(x - y);
                }
            }
            
            if (minD == 999999)
            {
                //Console.WriteLine("$$$$ Output:{0}       -1", minD);
                return -1;
            }
           // Console.WriteLine("****Output:{0}", minD);
            return minD;
        }
    }
}
