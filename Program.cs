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
using System.Numerics;

class Solution
{

    // Complete the extraLongFactorials function below.
    static BigInteger extraLongFactorials(int n)
    {
        int num = n - 1;
        long resFinal = n;
        var resultFinal = new BigInteger(resFinal);

        while (num > 0)
        {
            resultFinal = resultFinal * num;
            n--;
            num--;
        }
        return resultFinal;
        
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());


        var result = extraLongFactorials(n);


        Console.WriteLine(result);
        Console.ReadKey();

    }
}
