using System;

namespace ChessAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
           // int num = 0;
            for (int i = 0; i<8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (((i+j) % 2) == 1)
                        Console.Write("O");
                    else
                        Console.Write("X");
                }

                Console.Write("\n");

            }
        }
    }
}
