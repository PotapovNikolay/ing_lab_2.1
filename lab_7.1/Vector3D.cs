using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7._1
{


    class Vector3D
    {

        public double c;

        public double b;

        public double a;

        //public double A
        //{
        //    get { return a; }
        //    set
        //    {
        //        if ( value is double )
        //        {
        //            a = value;
        //        }
        //        else
        //        {
        //            throw new ArgumentOutOfRangeException();
        //        }
        //    }
        //}

        public Vector3D(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public Vector3D() { }

        public double vector_lenght( Vector3D d )
        {

            double lenght_vector = Math.Sqrt( Math.Pow( d.a, 2 ) + Math.Pow( d.b, 2 ) + Math.Pow( d.c, 2 ) );

            return Math.Round( lenght_vector, 2 );

        }
    }
}
