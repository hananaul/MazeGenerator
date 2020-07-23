using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            //int s = 4*n-1;
            int door = 0;

            for (int r = 0; r < n; r++)
            {
                if (isOdd(r))
                {
                    //ganjil
                    for (int c = 0; c < n; c++)
                    {
                        //mencetak @ di awal dan akhir saja
                        if (c == 0 || c == n - 1)
                        {
                            Console.Write("@");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                else
                {
                    //genap
                    for (int c = 0; c < n; c++)
                    {

                        if (c == 1 && door == 0)
                        {
                            //buat jalan di kiri
                            Console.Write(" ");
                        }
                        else if (c == n - 2 && door == 1)
                        {
                            //buat jalan di kanan
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("@");
                        }
                    }

                    if (door == 0)
                    {
                        door = 1;
                    }
                    else
                    {
                        door = 0;
                    }
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }

        public static bool isOdd(int input)
        {
            if (input % 2 == 1)
            {
                return true;
            }
            return false;
        }
    }
}
