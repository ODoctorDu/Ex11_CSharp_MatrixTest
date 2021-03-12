using System;

namespace Ex06Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("This is a Square Matrix. Please, enter a number for the Rows and Lines: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the numbers of the #" + (i+1) + " Line");
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++ )
                {
                    matriz[i, j] = int.Parse(values[j]);
                }
            }
            Console.WriteLine("\n--------------------\nMain Diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(matriz[i, i] + " ");
            }
            Console.WriteLine("\n--------------------\nSearching for Negative Numbers...");
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i,j] < 0)
                    {
                        sum++;
                    }
                }
            }
            Console.WriteLine("There is " + sum + " negative numbers in the array");
        }
    }
}
