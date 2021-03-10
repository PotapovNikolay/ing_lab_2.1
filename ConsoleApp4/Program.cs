using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main( string [] args )
        {
            double df1( double x ) => -(6 * Math.Pow( x, 2 ) + Math.Cos( x - 1 ));

            Console.WriteLine(df1(0.789));

        }
    }
}
