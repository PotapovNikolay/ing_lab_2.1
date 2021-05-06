using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_7._1
{


    public class Vector3D: IComparable
    {

        public double c;

        public double b;

        public double a;


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



        public int CompareTo( object obj )
        {
            Vector3D v = obj as Vector3D;

            if ( v != null )
            {
                if ( this.a < v.a && this.b < v.b && this.c < v.c )
                {
                    return 1;
                }
                else if ( this.a > v.a && this.b > v.b && this.c > v.c )
                {
                    return -1;
                }
                else
                {
                    return 0;
                }

            }
            else
            {
                throw new Exception();
            }
        }

        
    }
}
