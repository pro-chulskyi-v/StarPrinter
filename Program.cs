using System;

namespace StarPrinter
{
    internal class Program
    {
        static void Print_а()
        {
            int matrixSize = 10;

            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    if (j >= i)
                        Console.Write('*');
                    else
                        Console.Write(' ');
                }
                Console.Write('\n');
            }
        }
        static void Print_б()
        {
            int matrixSize = 10;

            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    if (j <= i)
                        Console.Write('*');
                    else
                        Console.Write(' ');
                }
                Console.Write('\n');
            }
        }
        static void Print_в()
        {
            int matrixSize = 10;

            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    if (j >= i && j < matrixSize - i)
                        Console.Write('*');
                    else
                        Console.Write(' ');
                }
                Console.Write("\n");
            }
        }
        static void Print_г()
        {
            int matrixSize = 10;

            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    if (i >= matrixSize / 2 && j <= i && j >= matrixSize - i - 1)
                        Console.Write('*');
                    else
                        Console.Write(' ');
                }
                Console.Write("\n");
            }
        }
        static void Print_д()
        {
            int matrixSize = 10;

            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    if ((j >= i && j < matrixSize - i) || (i >= matrixSize / 2 && j <= i && j >= matrixSize - i - 1))
                        Console.Write('*');
                    else
                        Console.Write(' ');
                }
                Console.Write("\n");
            }
        }
        static void Print_е()
        {
            int matrixSize = 10;

            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    if (j <= i && j <= matrixSize - i - 1 || j >= matrixSize - i - 1 && j >= i)
                        Console.Write('*');
                    else
                        Console.Write(' ');
                }
                Console.Write("\n");
            }
        }
        static void Print_ж()
        {
            int matrixSize = 10;

            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    if (j <= i && j <= matrixSize - i - 1)
                        Console.Write('*');
                    else
                        Console.Write(' ');
                }
                Console.Write("\n");
            }
        }
        static void Print_з()
        {
            int matrixSize = 10;

            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    if (j >= matrixSize - i - 1 && j >= i)
                        Console.Write('*');
                    else
                        Console.Write(' ');
                }
                Console.Write("\n");
            }
        }
        static void Print_и()
        {
            int matrixSize = 10;

            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    if (j <= matrixSize - i - 1)
                        Console.Write('*');
                    else
                        Console.Write(' ');
                }
                Console.Write("\n");
            }
        }
        static void Print_к()
        {
            int matrixSize = 10;

            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    if (j >= matrixSize - i - 1)
                        Console.Write('*');
                    else
                        Console.Write(' ');
                }
                Console.Write("\n");
            }
        }
        static void Main(string[] args)
        {
            Print_а();
            Console.WriteLine(new string('-', 10));
            Print_б();
            Console.WriteLine(new string('-', 10));
            Print_в();
            Console.WriteLine(new string('-', 10));
            Print_г();
            Console.WriteLine(new string('-', 10));
            Print_д();
            Console.WriteLine(new string('-', 10));
            Print_е();
            Console.WriteLine(new string('-', 10));
            Print_ж();
            Console.WriteLine(new string('-', 10));
            Print_з();
            Console.WriteLine(new string('-', 10));
            Print_и();
            Console.WriteLine(new string('-', 10));
            Print_к();
            Console.WriteLine(new string('-', 10));

            Console.ReadKey();
        }
    }
}
