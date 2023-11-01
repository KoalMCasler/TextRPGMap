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
        {'^','^','^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'^','^','`','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`'},
        {'^','^','`','`','`','*','*','`','`','`','`','`','`','*','`','`','`','`','`','`','`','`','~','~','~','`','`','`','`','`'},
        {'^','`','`','`','`','`','`','`','`','`','`','`','*','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','~','~','~','`','`','`','`','*','*','*','*','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','~','~','~','`','`','`','`','`','*','*','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','~','~','~','~','`','`','`','`','`','`','*','*','*','*','`','`','`','`','`','^','^','`','`','`','`','`','`'},
        {'`','`','`','`','`','~','~','~','`','`','`','`','*','*','*','*','`','`','`','`','`','^','^','^','^','`','`','`','`','`'},
        {'`','`','`','`','`','~','~','~','~','`','`','`','`','`','`','*','`','`','`','`','`','`','`','^','^','^','^','`','`','`'},
        {'`','`','`','`','`','`','`','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
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
            border = '#';
            DisplayMap();
            DisplayMap(3);
            Console.ReadKey();
        }
        static void ShowLegend()
        {
            Console.WriteLine("\n");
            Console.WriteLine("map legend:");
            Console.WriteLine("^ = mountain");
            Console.WriteLine("` = grass");
            Console.WriteLine("~ = water");
            Console.WriteLine("* = trees");
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
            ShowLegend();
            for(mapY = 0; mapY <= sizeY; mapY++)
            {
                for(mapX = 0; mapX <= sizeX; mapX++)
                {
                    //Console.SetCursorPosition(mapX, mapY); //brute force method
                    Console.Write(map[mapY,mapX]);
                }
                Console.Write("\n");
            }
        }
        static void DisplayMap(int scale)
        {
            if(scale >= 0)
            {
                scale = 1;
            }
            ShowLegend();
            for(mapY = 0; mapY <= sizeY; mapY++)
            {
                for(int j = 0; j < scale; j++)
                {
                    for(mapX = 0; mapX <= sizeX; mapX++)
                    {
                        for(int i = 0; i < scale; i++)
                        {
                            Console.Write(map[mapY,mapX]);
                        }
                    }
                    Console.Write("\n");
                }
            }
        }
    }
}
