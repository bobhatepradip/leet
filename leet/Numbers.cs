using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leet
{
    class Numbers
    {
        static double[] arr = new double[3] { 20, 41, 49, };

        public static int Avg()
        {
            double sum = 0;

            for (int i=0; i< arr.Length; i++)
            {
                sum += arr[i];
            }
            int avg = (int) sum / arr.Length;
            int avgMathCeiling = (int) Math.Ceiling( sum / arr.Length);
            Console.WriteLine("sum / arr.Length: {0}    avg:{1}     Math.Ceiling( sum / arr.Length):{2}     avgMathCeiling:{3}", sum / arr.Length, avg, Math.Ceiling(sum / arr.Length), avgMathCeiling);
            return avg;
        }
    }
}
