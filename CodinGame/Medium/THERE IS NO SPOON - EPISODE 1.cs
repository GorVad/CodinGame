using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Don't let the machines win. You are humanity's last hope...
 * URL: https://www.codingame.com/ide/puzzle/there-is-no-spoon-episode-1
 **/
class Player
{
    static void Main(string[] args)
    {
        int width = int.Parse(Console.ReadLine()); // the number of cells on the X axis
        int height = int.Parse(Console.ReadLine()); // the number of cells on the Y axis
        string[,] grid = new string[height, width];
        int xRight = -1, yRight = -1, xBottom = -1, yBottom = -1;
        for (int h = 0; h < height; h++)
        {
            string line = Console.ReadLine(); // width characters, each either 0 or .
            for (int w = 0; w < width; w++)
            {
                grid[h, w] = line[w].ToString();
            }
        }

        for (int h = 0; h < height; h++)
        {
            for (int w = 0; w < width; w++)
            {
                if (grid[h, w] == "0")
                {
                    int right = w;
                    while (++right < width && grid[h, right] == ".") ;
                    xRight = right < width && grid[h, right] == "0" ? right : -1;
                    yRight = right < width && grid[h, right] == "0" ? h : -1;

                    int bottom = h;
                    while (++bottom < height && grid[bottom, w] == ".") ;
                    xBottom = bottom < height && grid[bottom, w] == "0" ? w : -1;
                    yBottom = bottom < height && grid[bottom, w] == "0" ? bottom : -1;

                    // Three coordinates: a node, its right neighbor, its bottom neighbor
                    Console.WriteLine("{0} {1} {2} {3} {4} {5}", w, h, xRight, yRight, xBottom, yBottom);
                }
            }
        }
        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

    }
}