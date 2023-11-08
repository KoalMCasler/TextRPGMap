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
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','#','#','#','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','#','#','#','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','#','#','#','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','^','^','^','^','^','^','^','^','^','^','`','`','~','~','~','~','~','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','^','`','`','`','`','`','`','^','^','^','`','`','~','~','~','~','~','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','^','`','`','`','`','`','`','^','^','^','`','`','~','~','~','~','~','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','~','~','~','~','~','`','`','`','`','^','^','^','`','`','`','~','#','~','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','~','~','~','~','^','`','`','`','`','^','^','^','`','`','`','`','^','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','~','~','~','~','^','`','`','`','`','^','^','^','`','`','`','`','^','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','~','~','~','~','^','^','^','^','^','^','^','^','^','^','^','^','^','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','~','~','~','~','^','`','`','`','`','^','^','^','`','`','`','`','^','@','@','@','@','`','`','`','`','`','`'},
        {'`','`','`','`','~','~','~','~','^','`','`','`','`','^','^','^','`','`','`','`','^','@','@','@','@','`','`','`','`','`','`'},
        {'`','`','`','`','~','~','~','~','~','`','`','`','`','^','^','^','`','`','`','`','^','@','@','@','@','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','*','*','*','*','*','@','@','@','@','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','*','*','*','*','*','@','@','@','@','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','`','*','*','*','*','*','@','@','@','@','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','`','*','*','*','*','*','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','`','*','*','*','*','*','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        };
        //now a Sci-fi station map. 
        static bool gameOver;
        static int loopIndex;
        static int mapX;
        static int mapY;
        static int sizeX;
        static int sizeY;
        static char border;
        static int borderSize;
        static char hallway = (char)30;
        static char space = (char)247;
        static char habitation = (char)127;
        static char power = (char)164;
        static char engineering = (char)29;
        static char command = (char)199;
        static void Main()
        {
            Console.WriteLine("Press any key to start drawing maps.");
            Console.ReadKey(true);
            sizeX = map.GetLength(1) - 1;
            sizeY = map.GetLength(0) - 1;
            borderSize = map.GetLength(1) + 2;
            gameOver = false;
            border = ((char)4); //Dark red
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
            SetColorHallway();
            Console.Write(hallway);
            SetColorDefault();
            Console.WriteLine(" = hallways"); //gray
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(space);
            SetColorDefault();
            Console.WriteLine(" = space"); //dark green
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(habitation);
            SetColorDefault();
            Console.WriteLine(" = habitation"); //blue
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(power);
            SetColorDefault();
            Console.WriteLine(" = power"); //green
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(command);
            SetColorDefault();
            Console.WriteLine(" = command"); //green
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(engineering);
            SetColorDefault();
            Console.WriteLine(" = engineering"); //green
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
                SetColorDefault();
            }
            Console.Write("\n");
            for(mapY = 0; mapY <= sizeY; mapY++)
            {
                SetColorBorder();
                Console.Write(border);
                SetColorDefault();
                for(mapX = 0; mapX <= sizeX; mapX++)
                {
                    //Console.SetCursorPosition(mapX, mapY); //brute force method added before loops.
                    if(map[mapY,mapX] == '`')
                    {
                        SetColorSpace();
                        Console.Write(space);
                        SetColorDefault();
                    }
                    if(map[mapY,mapX] == '*')
                    {
                        SetColorPower();
                        Console.Write(power);
                        SetColorDefault();
                    }
                    if(map[mapY,mapX] == '~')
                    {
                        SetColorHabitation();
                        Console.Write(habitation);
                        SetColorDefault();
                    }
                    if(map[mapY,mapX] == '^')
                    {
                        SetColorHallway();
                        Console.Write(hallway);
                        SetColorDefault();
                    }
                    if(map[mapY,mapX] == '#')
                    {
                        SetColorCommand();
                        Console.Write(command);
                        SetColorDefault();
                    }
                    if(map[mapY,mapX] == '@')
                    {
                        SetColorEngineering();
                        Console.Write(engineering);
                        SetColorDefault();
                    }
                }
                SetColorBorder();
                Console.Write(border);
                SetColorDefault();
                Console.Write("\n");
            }
            for(int k = 0; k < (sizeX + 3); k++)
            {
                SetColorBorder();
                Console.Write(border);
                SetColorDefault();
            }
            Console.Write("\n");
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
                    SetColorDefault();
                }
            }
            if(scale >= 3)
            {
                SetColorBorder();
                Console.Write(border);
                Console.Write(border);
                SetColorDefault();
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
                        SetColorSpace();
                        Console.Write(space);
                        SetColorDefault();
                    }
                    if(map[mapY,mapX] == '*')
                    {
                        SetColorPower();
                        Console.Write(power);
                        SetColorDefault();
                    }
                    if(map[mapY,mapX] == '~')
                    {
                        SetColorHabitation();
                        Console.Write(habitation);
                        SetColorDefault();
                    }
                    if(map[mapY,mapX] == '^')
                    {
                        SetColorHallway();
                        Console.Write(hallway);
                        SetColorDefault();
                    }
                    if(map[mapY,mapX] == '#')
                    {
                        SetColorCommand();
                        Console.Write(command);
                        SetColorDefault();
                    }
                    if(map[mapY,mapX] == '@')
                    {
                        SetColorEngineering();
                        Console.Write(engineering);
                        SetColorDefault();
                    }
            }
                    }
                    SetColorBorder();
                    Console.Write(border);
                    SetColorDefault();
                    Console.Write("\n");
                }
            }
            for(int k = 0; k < borderSize; k++)
            {
                for(int l = 0; l < scale; l++)
                {
                    SetColorBorder();
                    Console.Write(border);
                    SetColorDefault();
                }
            }
            if(scale >= 3)
            {
                SetColorBorder();
                Console.Write(border);
                Console.Write(border);
            }
            SetColorDefault();
            Console.Write("\n");
            Console.Write("\n");
        }
        static void SetColorDefault()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
        static void SetColorHallway()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Gray;
        }
        static void SetColorSpace()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.BackgroundColor = ConsoleColor.Black;
        }
        static void SetColorPower()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Gray;
        }
        static void SetColorHabitation()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Gray;
        }
        static void SetColorBorder()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Black;
        }
        static void SetColorCommand()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.Gray;
        }
        static void SetColorEngineering()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Gray;
        }
    }
}
