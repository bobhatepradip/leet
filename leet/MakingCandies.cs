using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'minimumPasses' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts following parameters:
     *  1. LONG_INTEGER m
     *  2. LONG_INTEGER w
     *  3. LONG_INTEGER p
     *  4. LONG_INTEGER n
     */

    public static long minimumPasses(long m, long w, long p, long n)
    {
        long outOut = 0;
        long pCount = 0;
        long pass = 0;
        while (m * w <= n)
        {
            pass++;
            Console.WriteLine("m:{0} w:{1}", m, w);
            outOut = m * w;
            Console.WriteLine("outOut:{0}", outOut);
            pCount = outOut / p;
            Console.WriteLine("pCount:{0}-{1}-{2}---{3}-{4}---{5}-{6}", pCount, Math.Round((decimal)(m / (m + w))), Math.Round((decimal)(m / (m + w))), (long)(m / (m + w)), (long)(w / (m + w)), (m * 100 / (m + w)), (w * 100 / (m + w)));
            Console.WriteLine("new m:{0} w:{1} =={2}-{3}", m, w, ((m * 100 / (m + w)) * pCount), ((w * 100 / (m + w)) * pCount));
            w = w + (long) Math.Round(((decimal)m / (m + w)) * pCount);
            m = m + (long) Math.Round(((decimal)w / (m + w)) * pCount);
            Console.WriteLine("new m:{0} w:{1}", m, w);
        }
        return pass;
    }

}

class Solution
{
    public static void Mainsdadfasdf(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        //long m = Convert.ToInt64(firstMultipleInput[0]);

        //long w = Convert.ToInt64(firstMultipleInput[1]);

        //long p = Convert.ToInt64(firstMultipleInput[2]);

        //long n = Convert.ToInt64(firstMultipleInput[3]);

        //long result = Result.minimumPasses(m, w, p, n);
       // long result = Result.minimumPasses(3, 1, 2, 12);

        //textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
