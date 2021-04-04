using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7._1
{
    class vectors_compare : IComparer<Vector3D>
    {

        public int Compare( Vector3D x,Vector3D y )
        {
         
            if ( x.vector_lenght( x ) < y.vector_lenght( y ) )
            {
                return 1;
            }
            else if (x.vector_lenght(x) > y.vector_lenght(y) )
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }
    }

    
}
//Math.Sqrt( Math.Pow( x.a, 2 ) + Math.Pow( x.b, 2 ) + Math.Pow( x.c, 2 ) ) < Math.Sqrt( Math.Pow( y.a, 2 ) + Math.Pow( y.b, 2 ) + Math.Pow( y.c, 2 ) )