﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPGMap
{
    internal class Program
    {
        static char[,] map = new char[,] // dimensions defined by following data:
        {
        {(char)30,(char)30,(char)30,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)187,(char)187,(char)15,(char)15,(char)30,(char)30},
        {(char)30,(char)30,(char)15,(char)15,(char)15,(char)15,(char)23,(char)23,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)187,(char)187,(char)187,(char)15,(char)15,(char)15,(char)30},
        {(char)30,(char)15,(char)15,(char)15,(char)15,(char)23,(char)23,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)23,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)187,(char)187,(char)187,(char)15,(char)15,(char)15,(char)15,(char)15,(char)30},
        {(char)30,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)23,(char)23,(char)23,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)187,(char)187,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)30},
        {(char)30,(char)15,(char)15,(char)15,(char)187,(char)187,(char)187,(char)15,(char)15,(char)15,(char)15,(char)23,(char)23,(char)23,(char)23,(char)23,(char)23,(char)15,(char)15,(char)15,(char)187,(char)187,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)30},
        {(char)30,(char)15,(char)15,(char)15,(char)187,(char)187,(char)187,(char)15,(char)15,(char)15,(char)15,(char)15,(char)23,(char)23,(char)23,(char)23,(char)15,(char)15,(char)15,(char)15,(char)187,(char)187,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)30},
        {(char)30,(char)15,(char)15,(char)187,(char)187,(char)187,(char)187,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)23,(char)23,(char)23,(char)23,(char)15,(char)15,(char)15,(char)187,(char)187,(char)30,(char)30,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)30},
        {(char)30,(char)15,(char)15,(char)15,(char)187,(char)187,(char)187,(char)187,(char)15,(char)15,(char)15,(char)15,(char)23,(char)23,(char)23,(char)23,(char)15,(char)15,(char)15,(char)15,(char)187,(char)30,(char)30,(char)30,(char)30,(char)15,(char)15,(char)15,(char)15,(char)15,(char)30},
        {(char)30,(char)15,(char)15,(char)15,(char)187,(char)187,(char)187,(char)187,(char)187,(char)15,(char)15,(char)15,(char)15,(char)15,(char)23,(char)23,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)30,(char)30,(char)30,(char)30,(char)30,(char)15,(char)15,(char)15,(char)30},
        {(char)30,(char)15,(char)15,(char)15,(char)187,(char)187,(char)187,(char)187,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)23,(char)23,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)30,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)30},
        {(char)30,(char)15,(char)15,(char)15,(char)15,(char)15,(char)187,(char)187,(char)15,(char)15,(char)15,(char)15,(char)15,(char)23,(char)23,(char)23,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)30,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)30},
        {(char)30,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)187,(char)15,(char)15,(char)15,(char)15,(char)15,(char)23,(char)23,(char)23,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)30,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)30},
        {(char)30,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)187,(char)15,(char)15,(char)15,(char)15,(char)187,(char)187,(char)23,(char)23,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)30,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)30},
        {(char)30,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)187,(char)15,(char)15,(char)187,(char)187,(char)15,(char)23,(char)23,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)30},
        {(char)30,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)187,(char)187,(char)187,(char)187,(char)15,(char)15,(char)15,(char)23,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)30},
        {(char)30,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)187,(char)15,(char)187,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)30,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)30},
        {(char)30,(char)15,(char)15,(char)15,(char)15,(char)15,(char)187,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)30,(char)30,(char)30,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)23,(char)15,(char)30},
        {(char)30,(char)15,(char)15,(char)15,(char)15,(char)187,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)30,(char)30,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)23,(char)23,(char)15,(char)30},
        {(char)30,(char)15,(char)15,(char)15,(char)187,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)23,(char)23,(char)23,(char)30},
        {(char)30,(char)30,(char)15,(char)15,(char)187,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)23,(char)23,(char)23,(char)30},
        {(char)30,(char)30,(char)30,(char)30,(char)187,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)15,(char)23,(char)23,(char)30,(char)30,(char)30},
        };
        static bool gameOver;
        static int loopIndex;
        static int mapX;
        static int mapY;
        static int sizeX;
        static int sizeY;
        static char border;
        static int borderSize;
        static void Main()
        {
            Console.WriteLine("Press any key to start drawing maps.");
            Console.ReadKey(true);
            sizeX = map.GetLength(1) - 1;
            sizeY = map.GetLength(0) - 1;
            borderSize = map.GetLength(1) + 2;
            gameOver = false;
            border = ((char)166); //Dark red
            DisplayMap();
            DisplayMap(1);
            DisplayMap(2);
            DisplayMap(3);
            DisplayMap(-5);
            DisplayMap(5);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey(true);
        }
        static void ShowLegend()
        {
            Console.WriteLine("\n");
            Console.WriteLine("map legend:");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(string.Format("{0} = mountains",(char)30)); //gray
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(string.Format("{0} = grass",(char)15)); //dark green
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(string.Format("{0} = water",(char)187)); //blue
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(string.Format("{0} = trees",(char)23)); //green
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void CountUp()
        {
            // for loop
            for (loopIndex = 1; loopIndex <= 10; loopIndex++)
            {
                Console.Write(loopIndex + " ");
            }
        }
        static void GameLoop()
        {
            //While loop
            while(gameOver != true)
            {
                CountUp();
                if(loopIndex >= 10)
                {
                    gameOver = true;
                }
            }
        }
        static void DisplayMap()
        {
            Console.WriteLine("Basic method with no scaling");
            ShowLegend();
            for(int k = 0; k < (sizeX + 3); k++)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write(border);
            }
            Console.Write("\n");
            for(mapY = 0; mapY <= sizeY; mapY++)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write(border);
                for(mapX = 0; mapX <= sizeX; mapX++)
                {
                    //Console.SetCursorPosition(mapX, mapY); //brute force method added before loops.
                    if(map[mapY,mapX] == (char)15)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write(map[mapY,mapX]);
                    }
                    if(map[mapY,mapX] == (char)23)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.Write(map[mapY,mapX]);
                    }
                    if(map[mapY,mapX] == (char)187)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write(map[mapY,mapX]);
                    }
                    if(map[mapY,mapX] == (char)30)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.Write(map[mapY,mapX]);
                    }
                }
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write(border);
                Console.Write("\n");
            }
            for(int k = 0; k < (sizeX + 3); k++)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write(border);
            }
            Console.Write("\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("\n");
        }
        static void DisplayMap(int scale)
        {
            if(scale <= 0)
            {
                Console.WriteLine("Scale cannot be less than 1. It was set to {0}.", scale);
                borderSize = map.GetLength(1) + 2;
                scale = 1;
            }
            if(scale == 2)
            {
                borderSize--;
            }
            if(scale == 3)
            {
                borderSize = map.GetLength(1);
            }
            if(scale > 3)
            {
                Console.WriteLine("Scale cannot be more than 3. It was set to {0}.", scale);
                scale = 3;
                borderSize = map.GetLength(1);
            }
            Console.WriteLine("The method with scaling");
            Console.WriteLine("Scale has been set to {0}", scale);
            ShowLegend();
            for(int k = 0; k < borderSize; k++)
            {
                for(int l = 0; l < scale; l++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write(border);
                }
            }
            if(scale >= 3)
            {
                Console.Write(border);
                Console.Write(border);
            }
            Console.Write("\n");
            for(mapY = 0; mapY <= sizeY; mapY++)
            {
                for(int j = 0; j < scale; j++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write(border);
                    for(mapX = 0; mapX <= sizeX; mapX++)
                    {
                        for(int i = 0; i < scale; i++)
                        {
                            if(map[mapY,mapX] == (char)15)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write(map[mapY,mapX]);
                    }
                    if(map[mapY,mapX] == (char)23)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.Write(map[mapY,mapX]);
                    }
                    if(map[mapY,mapX] == (char)187)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write(map[mapY,mapX]);
                    }
                    if(map[mapY,mapX] == (char)30)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.Write(map[mapY,mapX]);
                    }
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write(border);
                    Console.Write("\n");
                }
            }
            for(int k = 0; k < borderSize; k++)
            {
                for(int l = 0; l < scale; l++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write(border);
                }
            }
            if(scale >= 3)
            {
                Console.Write(border);
                Console.Write(border);
            }
            Console.Write("\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("\n");
        }
    }
}
