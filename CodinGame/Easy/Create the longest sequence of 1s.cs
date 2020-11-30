using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 * URL: https://www.codingame.com/ide/puzzle/create-the-longest-sequence-of-1s
 **/
class Solution
{
    static void Main(string[] args)
    {
        string bit = Console.ReadLine();
        int longest = int.MinValue;

        string[] b = bit.Split('0');

        for (int i = 0; i < b.Length - 1; i++)
        {
            longest = longest < b[i].Length + b[i + 1].Length + 1 ? b[i].Length + b[i + 1].Length + 1 : longest;
        }
        Console.WriteLine(longest);
    }
}