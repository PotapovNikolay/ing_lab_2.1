using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public delegate double Operation( double x );

    class Deleg
    {
        private double x;
        private double E = 0.001;

        public Deleg( double x )
        {

            //this.x = x;
            

        }

        public Deleg()
        {

        }

        //public override string ToString()
        //{
        //    return "Резлуьтат выражения" + x;
        //}

        public double middle_result( double x )
        {

            double middle_rez = ( Math.Pow( x, 3 ) - ( 4 * Math.Pow( x, 2 ) ) + x - 1 );

            return middle_rez;

        }

        public double result_proisv()
        {
            double a = -10;
            double b = 10;
            double midl_of_x = 0;
            double F_a = 0;
            double F_x = 0;
            
            Operation op1 = new Operation( middle_result );

            //int count_iter = Convert.ToInt32( Math.Log( ( ( b - a ) / E ), 2 ) + 1 );

            //if (b-a > E )
            //{
            while ( b - a > E )//for ( int i = 0; i <= count_iter; i++ )
            {
                F_a = op1(a);

                midl_of_x = ( a + b ) / 2;

                F_x = op1( midl_of_x );

                
                if ( F_x * F_a > 0 )
                {
                    a = midl_of_x;
                    F_a = F_x;
                }
                else
                {
                    b = midl_of_x;
                }
            }
            

            return midl_of_x;

        }
    }
}
