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
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
         int count = arr.Count();
            double MaxSum = 0;
            double Minsum = 0;

            int Max = arr.Max();
            int Min = arr.Min();
            int maxIndex = arr.ToList().IndexOf(Max);
            int minIndex = arr.ToList().IndexOf(Min);

            for (int i = 0; i <= count - 1; i++)
            {
                if (i != maxIndex)
                {
                    MaxSum = MaxSum + Convert.ToDouble((arr[i]));
                }
                if (i != minIndex)
                {
                    Minsum = Minsum + Convert.ToDouble((arr[i]));
                }
            }


            System.Console.WriteLine("{0} {1}", MaxSum, Minsum);
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
