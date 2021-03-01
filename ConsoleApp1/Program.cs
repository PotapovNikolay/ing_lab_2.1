using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main( string [] args )
        {
            int [,] a = new int [ 3, 4 ] { { 0, -1,2,3}, { -2, -3,2,2}, { 0,0,0,6} }; 
                int j, k;
                for (int i = 0; i < 3; i++)
                {
                    k = 0;
                    for (j = 0; j < 4; j++)
                    {
                        if (a[i, j] > 0) ++k;
                    }

                    Console.WriteLine(k);
                }
        }
    }
}
