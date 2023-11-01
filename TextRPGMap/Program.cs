using System;
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
        {'^','^','^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','`','`','^','^','^'},
        {'^','^','`','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`','^','^'},
        {'^','`','`','`','`','*','*','`','`','`','`','`','`','*','`','`','`','`','`','`','`','`','~','~','~','`','`','`','`','`','`','^'},
        {'^','`','`','`','`','`','`','`','`','`','`','`','*','*','*','`','`','`','`','`','`','~','~','`','`','`','`','`','`','`','`','^'},
        {'^','`','`','`','~','~','~','`','`','`','`','*','*','*','*','*','*','`','`','`','~','~','`','`','`','`','`','`','`','`','`','^'},
        {'^','`','`','`','~','~','~','`','`','`','`','`','*','*','*','*','`','`','`','`','~','~','`','`','`','`','`','`','`','`','`','^'},
        {'^','`','`','~','~','~','~','`','`','`','`','`','`','*','*','*','*','`','`','`','~','~','^','^','`','`','`','`','`','`','`','^'},
        {'^','`','`','`','~','~','~','~','`','`','`','`','*','*','*','*','`','`','`','`','~','^','^','^','^','`','`','`','`','`','`','^'},
        {'^','`','`','`','~','~','~','~','~','`','`','`','`','`','*','*','`','`','`','`','`','`','^','^','^','^','^','`','`','`','`','^'},
        {'^','`','`','`','~','~','~','~','`','`','`','`','`','`','*','*','`','`','`','`','`','`','`','^','`','`','`','`','`','`','`','^'},
        {'^','`','`','`','`','`','~','~','`','`','`','`','`','*','*','*','`','`','`','`','`','`','^','`','`','`','`','`','`','`','`','^'},
        {'^','`','`','`','`','`','`','~','`','`','`','`','`','*','*','*','`','`','`','`','`','`','^','`','`','`','`','`','`','`','`','^'},
        {'^','`','`','`','`','`','`','~','`','`','`','`','~','~','*','*','`','`','`','`','`','`','`','^','`','`','`','`','`','`','`','^'},
        {'^','`','`','`','`','`','`','`','~','`','`','~','~','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^'},
        {'^','`','`','`','`','`','`','`','~','~','~','~','`','`','`','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^'},
        {'^','`','`','`','`','`','`','~','`','~','`','`','`','`','`','`','`','`','`','^','`','`','`','`','`','`','`','`','`','`','`','^'},
        {'^','`','`','`','`','`','~','`','`','`','`','`','`','`','`','`','`','`','^','^','^','`','`','`','`','`','`','`','*','`','`','^'},
        {'^','`','`','`','`','~','`','`','`','`','`','`','`','`','`','`','`','`','^','^','`','`','`','`','`','`','`','*','*','`','`','^'},
        {'^','`','`','`','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','*','*','*','*','^'},
        {'^','^','`','`','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','*','*','*','^','^'},
        {'^','^','^','^','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','*','*','^','^','^','^'},
        };

        static bool gameOver;
        static int loopIndex;
        static int mapX;
        static int mapY;
        static int sizeX;
        static int sizeY;
        static char border;
        static void Main()
        {
            sizeX = map.GetLength(1) - 1;
            sizeY = map.GetLength(0) - 1;
            gameOver = false;
            border = '#'; //Dark red
            DisplayMap();
            DisplayMap(1);
            DisplayMap(2);
            DisplayMap(3);
            DisplayMap(-5);
            Console.ReadKey();
        }
        static void ShowLegend()
        {
            Console.WriteLine("\n");
            Console.WriteLine("map legend:");
            Console.WriteLine("^ = mountain"); //gray
            Console.WriteLine("` = grass"); //green
            Console.WriteLine("~ = water"); //blue
            Console.WriteLine("* = trees"); //dark green
            Console.WriteLine("\n");
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
            for(int k = 0; k < (sizeX + 2); k++)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Write(border);
            }
            Console.Write("\n");
            for(mapY = 0; mapY <= sizeY; mapY++)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Write(border);
                for(mapX = 0; mapX <= sizeX; mapX++)
                {
                    //Console.SetCursorPosition(mapX, mapY); //brute force method
                    if(map[mapY,mapX] == '`')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write(map[mapY,mapX]);
                    }
                    if(map[mapY,mapX] == '*')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.Write(map[mapY,mapX]);
                    }
                    if(map[mapY,mapX] == '~')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.Write(map[mapY,mapX]);
                    }
                    if(map[mapY,mapX] == '^')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.Write(map[mapY,mapX]);
                    }
                }
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Write(border);
                Console.Write("\n");
            }
            for(int k = 0; k < (sizeX + 2); k++)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.BackgroundColor = ConsoleColor.DarkRed;
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
                scale = 1;
            }
            Console.WriteLine("Scale has been set to {0}", scale);
            ShowLegend();
            for(int k = 0; k < (sizeX + 2); k++)
            {
                for(int l = 0; l < scale; l++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Write(border);
                }
            }
            Console.Write("\n");
            for(mapY = 0; mapY <= sizeY; mapY++)
            {
                for(int j = 0; j < scale; j++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Write(border);
                    for(mapX = 0; mapX <= sizeX; mapX++)
                    {
                        for(int i = 0; i < scale; i++)
                        {
                            if(map[mapY,mapX] == '`')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write(map[mapY,mapX]);
                    }
                    if(map[mapY,mapX] == '*')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.Write(map[mapY,mapX]);
                    }
                    if(map[mapY,mapX] == '~')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.Write(map[mapY,mapX]);
                    }
                    if(map[mapY,mapX] == '^')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.Write(map[mapY,mapX]);
                    }
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Write(border);
                    Console.Write("\n");
                }
            }
            for(int k = 0; k < (sizeX + 2); k++)
            {
                for(int l = 0; l < scale; l++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Write(border);
                }
            }
            Console.Write("\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("\n");
        }
    }
}
