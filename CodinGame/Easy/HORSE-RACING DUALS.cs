using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 * URL: https://www.codingame.com/ide/puzzle/horse-racing-duals
 **/
class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] mass = new int[N];
        int lowest = 10000000;
        int res;
        for (int i = 0; i < N; i++)
        {
            int pi = int.Parse(Console.ReadLine());
            mass[i] = pi;
        }

        Array.Sort(mass);

        for (int i = 0; i < mass.Length - 1; i++)
        {
            res = Math.Abs(mass[i] - mass[i + 1]);
            if (res < lowest) lowest = res;
        }

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(lowest);
    }
}