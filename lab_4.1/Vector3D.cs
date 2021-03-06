﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4._1
{
    class Vector3D
        {
            private double c { get; set; }

            private double b { get; set; }

            private double a;

            public double A
            {
                get { return a; }
                set
                {
                    if ( value is double )
                    {
                        a = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
            }


            public Vector3D()
            {
                this.a = 0;
                this.b = 0;
                this.c = 0;
            }

            public Vector3D( double a, double b, double c )
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            /*
            public void Print(string vv)
            {
                return $"a = {a}, b = {b}, c = {c}";

            }
            */
            public override string ToString()
            {
                return $"a = { a}, b = { b}, c = {c}";
            }


            public static Vector3D operator +( Vector3D d1, Vector3D d2 )
            {

                return new Vector3D( d1.a + d2.a, d1.b + d2.b, d1.c + d2.c );

            }

            public static Vector3D operator -( Vector3D d1, Vector3D d2 )
            {

                return new Vector3D( d1.a - d2.a, d1.b - d2.b, d1.c - d2.c );

            }

            public static Vector3D operator *( Vector3D d1, Vector3D d2 )
            {

                return new Vector3D( d1.a * d2.a, d1.b * d2.b, d1.c * d2.c );

            }

            public Vector3D Сomposition( Vector3D d, double scalar )
            {
                return new Vector3D( scalar * d.a, scalar * d.b, scalar * d.c );

            }

            public string Compare_vectors( Vector3D d1, Vector3D d2 )
            {
                string ttru = "векторы равны";
                string ffal = "векторы не равны";
                if ( d1.a == d2.a && d1.b == d2.b && d1.c == d2.c )
                {
                    return ttru;

                }
                else
                {
                    return ffal;
                }

            }

            public double vector_lenght( Vector3D d )
            {

                double lenght_vector = Math.Sqrt( Math.Pow( d.a, 2 ) + Math.Pow( d.b, 2 ) + Math.Pow( d.c, 2 ) );

                 return Math.Round( lenght_vector, 2 );

            }

            public void vectors_lenght( Vector3D d )
            {

                double lenght_vector = Math.Sqrt( Math.Pow( d.a, 2 ) + Math.Pow( d.b, 2 ) + Math.Pow( d.c, 2 ) );

                Console.WriteLine( "длина двух векторов = " + Math.Round( lenght_vector, 2 ) );

            }

        
    }

}
