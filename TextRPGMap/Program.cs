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
        {'^','^','^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','`','`','^','^'},
        {'^','^','`','`','`','`','^','^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`','^'},
        {'^','`','`','`','`','^','^','`','`','`','`','`','`','*','`','`','`','`','`','`','`','`','~','~','~','`','`','`','`','`','^'},
        {'^','`','`','`','`','`','`','`','`','`','`','`','*','*','*','`','`','`','`','`','`','~','~','`','`','`','`','`','`','`','^'},
        {'^','`','`','`','~','~','~','`','`','`','`','*','*','*','*','*','^','`','`','`','~','~','`','`','`','`','`','`','`','`','^'},
        {'^','`','`','`','~','~','~','`','`','`','`','`','*','*','*','*','`','`','`','`','~','~','`','`','`','`','`','`','`','`','^'},
        {'^','`','`','~','~','~','~','`','`','`','`','`','`','*','*','^','^','`','`','`','~','~','^','^','`','`','`','`','`','`','^'},
        {'^','`','`','`','~','~','~','~','`','`','`','`','*','*','*','^','`','`','`','`','~','^','^','^','^','`','`','`','`','`','^'},
        {'^','`','`','`','~','~','~','~','~','`','`','`','`','`','*','^','`','`','`','`','`','`','^','^','^','^','^','`','`','`','^'},
        {'^','`','`','`','~','~','~','~','`','`','`','`','`','`','*','*','`','`','`','`','`','`','`','^','`','`','`','`','`','`','^'},
        {'^','`','`','`','`','`','~','~','`','`','`','`','`','^','*','*','`','`','`','`','`','`','^','`','`','`','`','`','`','`','^'},
        {'^','`','`','`','`','`','`','~','`','`','`','`','`','*','*','*','`','`','`','`','`','`','^','`','`','`','`','`','`','`','^'},
        {'^','`','`','`','`','`','`','~','`','`','`','`','~','~','*','*','`','`','`','`','`','`','`','^','`','`','`','`','`','`','^'},
        {'^','`','`','`','`','`','`','`','~','`','`','~','~','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^'},
        {'^','`','`','`','`','`','`','`','~','~','~','~','`','`','`','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^'},
        {'^','`','`','`','`','`','`','~','`','~','`','`','`','`','`','`','`','`','`','*','`','`','`','`','`','`','`','`','`','`','^'},
        {'^','`','`','`','`','`','~','`','`','`','`','`','`','`','`','`','`','`','*','*','*','`','`','`','`','`','`','`','^','`','^'},
        {'^','`','`','`','`','~','`','`','`','`','`','`','`','`','`','`','`','`','*','*','`','`','`','`','`','`','`','^','^','`','^'},
        {'^','`','`','`','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^'},
        {'^','^','`','`','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^'},
        {'^','^','^','^','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','^'},
        };
        static bool gameOver;
        static int loopIndex;
        static int mapX;
        static int mapY;
        static int sizeX;
        static int sizeY;
        static char border;
        static int borderSize;
        static char mountain = (char)30;
        static char grass = (char)15;
        static char water = (char)187;
        static char trees = (char)23;
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
            SetColorMountain();
            Console.Write(mountain);
            SetColorDefault();
            Console.WriteLine(" = mountains"); //gray
            SetColorGrass();
            Console.Write(grass);
            SetColorDefault();
            Console.WriteLine(" = grass"); //dark green
            SetColorWater();
            Console.Write(water);
            SetColorDefault();
            Console.WriteLine(" = water"); //blue
            SetColorTrees();
            Console.Write(trees);
            SetColorDefault();
            Console.WriteLine(" = trees"); //green
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
            for(int k = 0; k < (sizeX + 3); k++)
            {
                SetColorBorder();
                Console.Write(border);
            }
            Console.Write("\n");
            for(mapY = 0; mapY <= sizeY; mapY++)
            {
                SetColorBorder();
                Console.Write(border);
                for(mapX = 0; mapX <= sizeX; mapX++)
                {
                    //Console.SetCursorPosition(mapX, mapY); //brute force method added before loops.
                    if(map[mapY,mapX] == '`')
                    {
                        SetColorGrass();
                        Console.Write(grass);
                    }
                    if(map[mapY,mapX] == '*')
                    {
                        SetColorTrees();
                        Console.Write(trees);
                    }
                    if(map[mapY,mapX] == '~')
                    {
                        SetColorWater();
                        Console.Write(water);
                    }
                    if(map[mapY,mapX] == '^')
                    {
                        SetColorMountain();
                        Console.Write(mountain);
                    }
                }
                SetColorBorder();
                Console.Write(border);
                Console.Write("\n");
            }
            for(int k = 0; k < (sizeX + 3); k++)
            {
                SetColorBorder();
                Console.Write(border);
            }
            Console.Write("\n");
            SetColorDefault();
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
                    SetColorBorder();
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
                    SetColorBorder();
                    Console.Write(border);
                    for(mapX = 0; mapX <= sizeX; mapX++)
                    {
                        for(int i = 0; i < scale; i++)
                        {
                            if(map[mapY,mapX] == '`')
                    {
                        SetColorGrass();
                        Console.Write(grass);
                    }
                    if(map[mapY,mapX] == '*')
                    {
                        SetColorTrees();
                        Console.Write(trees);
                    }
                    if(map[mapY,mapX] == '~')
                    {
                        SetColorWater();
                        Console.Write(water);
                    }
                    if(map[mapY,mapX] == '^')
                    {
                        SetColorMountain();
                        Console.Write(mountain);
                    }
                        }
                    }
                    SetColorBorder();
                    Console.Write(border);
                    Console.Write("\n");
                }
            }
            for(int k = 0; k < borderSize; k++)
            {
                for(int l = 0; l < scale; l++)
                {
                    SetColorBorder();
                    Console.Write(border);
                }
            }
            if(scale >= 3)
            {
                Console.Write(border);
                Console.Write(border);
            }
            Console.Write("\n");
            SetColorDefault();
            Console.Write("\n");
        }
        static void SetColorDefault()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
        static void SetColorMountain()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.BackgroundColor = ConsoleColor.Gray;
        }
        static void SetColorGrass()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.Green;
        }
        static void SetColorTrees()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
        }
        static void SetColorWater()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Blue;
        }
        static void SetColorBorder()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Red;
        }
    }
}
