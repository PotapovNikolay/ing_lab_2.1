using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5._1
{

    public delegate double Operation( double x );



    class Deleg
    {

        public delegate void MethodContainer();

        public event MethodContainer onzero;

        private double x;
        private double E;

        public double e
        {
            get { return E; }
            set
            {
                if ( value is double )
                {
                    E = value;
                }
                else
                {
                    throw new Exception( "Погрешность задана неправильно" );
                }
            }
        }

        public Deleg(double E)
        {
            this.E = E;
        }

        //второе выражение
        public double second_expression(double x)=> (2* Math.Pow( x, 3 ) -  4 * Math.Pow( x, 2 )  + x - 1 );
        
        //производная второго выражения
        public double df2( double x )=> 6 * Math.Pow( x, 2 ) - 8 * x + 1;

        //первое выражение
        public double first_expression(double x)=> Math.Sin(x-1) - 2 * Math.Pow(x, 3);

        // производная первого выражения
        public double df1(double x) => -(6 * Math.Pow(x, 2) + Math.Cos(x - 1));


        //метод ньютона
        public double method_N(Func<double,double> EX, Func<double, double> DF )
        {

            double a = -10;
            double b = 10;

            int n = 1; 
            double X = b;
            double en = Math.Abs(a - b);

            Operation f = new Operation( EX);
            Operation df = new Operation(DF);



            if (f(a) * f(b) > 0)
            {
                onzero();
            }
            else
            {
                while ( Math.Abs(en) > E ) 
                {

                    X = X - f(X) / df(X);
                    en = Math.Abs(X - b);
                    b = X;

                }
            }

            return X;
        }

        
        // производная от метода ньютона
        public double derived_expression_method_N(double E, Func<double, double> EX, Func<double, double> DF )
        {

            Operation Y = new Operation( EX );

            double X = method_N(EX,DF);

            double result = ( Y( X + E ) - Y( X ) ) / E;

            return result;

        }

        

        // производная от метода половинного деления
        public double derived_expression_half_division_method(double E)
        {

            Operation y = new Operation(second_expression);

            double X = half_division_method(second_expression);


            double result = (y(X + E) - y(X)) / E;

            return result;

        }

        // метод половинного деления
        public double half_division_method( Func<double, double> EX )
        {
            double a = -10;
            double b = 10;
            double midl_of_x = 0;
            double F_a = 0;
            double F_x = 0;

            Operation op1 = new Operation( EX );

            while ( b - a > E )
            {
                F_a = op1( a );

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
