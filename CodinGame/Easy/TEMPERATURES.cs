using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 *URL: https://www.codingame.com/ide/puzzle/temperatures
 **/
class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        string[] inputs = Console.ReadLine().Split(' ');
        int[] tempValues = new int[n];
        int nearest = int.MaxValue;
        for (int i = 0; i < n; i++)
        {
            int t = int.Parse(inputs[i]);// a temperature expressed as an integer ranging from -273 to 5526
            tempValues[i] = t;
        }
        if (tempValues.Length != 0)
        {
            foreach (int t in tempValues)
            {
                if (t == nearest) nearest = t;
                else if (t == -nearest) nearest = Math.Abs(t);
                else if (Math.Abs(t) < Math.Abs(nearest)) nearest = t;
            }
        }
        else nearest = 0;

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(nearest);
    }
}