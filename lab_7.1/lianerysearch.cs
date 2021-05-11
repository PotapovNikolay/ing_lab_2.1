using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7._1
{
    class lianerysearch: IComparer<Vector3D>
    {
        public VectorAll line_s = new VectorAll();

        

        public int Compare( Vector3D x, Vector3D y )
        {
            double rez = 0;


            if ( line_s.Middle_sum_vectors < y.vector_lenght( y ) || line_s.Middle_sum_vectors > x.vector_lenght( x ) )
            {
                if ( y.vector_lenght( y ) - line_s.Middle_sum_vectors > line_s.Middle_sum_vectors - x.vector_lenght(x))
                {
                    rez = y.vector_lenght(y);
                }
                else
                {
                    rez = x.vector_lenght(x);
                }

                return 1;
            }
            else if ( x.vector_lenght( x ) > y.vector_lenght( y ) )
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
