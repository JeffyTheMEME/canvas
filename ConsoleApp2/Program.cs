using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {   static int height = 10;
        static int width = 10;
        static int[,] canvas = new int[height,width];
        static void Main(string[] args)
        {
            Console.WriteLine("zandej mem xd");

            Console.ReadKey();



            {
                for (int x = 0; x < height; x++)
                {
                    for (int y = 0; y < width; y++)
                    {
                        
                     Console.Write(canvas[x, y].ToString());
                        {
                            canvas[x, y] = 0;
                        }
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}