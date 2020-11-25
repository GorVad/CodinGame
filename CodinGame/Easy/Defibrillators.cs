using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 * URL: https://www.codingame.com/ide/puzzle/defibrillators
 **/
class Solution
{
    static void Main(string[] args)
    {
        double LON = Convert.ToDouble(Console.ReadLine().Replace(',', '.'));
        double LAT = Convert.ToDouble(Console.ReadLine().Replace(',', '.'));
        int N = int.Parse(Console.ReadLine());
        double nearest = double.MaxValue;
        string answer = "";
        for (int i = 0; i < N; i++)
        {
            string DEFIB = Console.ReadLine();
            string[] defibInfo = DEFIB.Split(";");
            string name = defibInfo[1];
            double defLON = Convert.ToDouble(defibInfo[4].Replace(',', '.'));
            double defLAT = Convert.ToDouble(defibInfo[5].Replace(',', '.'));

            double x = (defLON - LON) * Math.Cos((defLON + LON) / 2);
            double y = defLAT - LAT;

            double d = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) * 6371;

            nearest = d <= nearest ? d : nearest;
            answer = d <= nearest ? name : answer;
        }

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(answer);
    }
}