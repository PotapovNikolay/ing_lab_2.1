using System;

namespace Лаб_1

{

    class Program

    {

        static void VVODM(double[,] array)

        {

            for (int i = 0; i < 20; i++)

            {

                for (int j = 0; j < 15; j++)

                {

                    array[i, j] = (1 + Math.Cos(j)) * Math.Log(1 + (Math.Cos(i) / 2));

                }

            }

        }

        static void Main(string[] args)

        {

            double[,] array = new double [20, 15];

            VVODM(array);

            double S = 0f;
            int kol = 0;

            for (int i = 0; i < 20; i++)

            {

                for (int j = 0; j < 15; j++)

                {

                    if (array[i, j] > 0)

                    {

                        S += array[i, j];
                        kol++;

                    }

                }

                int zs = i + 1;
                Console.WriteLine("В строке № " + zs + " " + S + " " + kol);

                S = 0;
                kol = 0;

            }

        }
    }
}