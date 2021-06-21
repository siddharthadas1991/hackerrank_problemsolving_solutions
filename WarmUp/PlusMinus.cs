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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
         int count = arr.Count;
            int positive = 0;
            int negative = 0;
            int zeros = 0;
            double posproportion =0;
            double negproportion=0;
            double zeroproportion=0;
            foreach (var k in arr)
            {
                if (k > 0 && k !=0)
                {
                    positive += 1;
                }
                else if (k < 0 && k !=0)
                {
                    negative += 1;
                }
                else if (k == 0)
                {
                    zeros += 1;
                }
            }

             posproportion = (double)positive / (double)count;
             negproportion = (double)negative / (double)count;
             zeroproportion = (double)zeros / (double)count;

            Console.WriteLine(" {0} \n{1} \n {2}" , posproportion, negproportion,                               zeroproportion);

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
