using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_7._1
{
    

    public class VectorAll
    {
        private double middle_sum_vectors { get; set; }

        public double Middle_sum_vectors
        {
            get { return middle_sum_vectors; }
            set { middle_sum_vectors = value; }
        }

        private int index { get; set; }

        public double Index
        {
            get { return index; }
            set { middle_sum_vectors = index; }
        }

        private double rez { get; set; }

        public List<Vector3D> list = new List<Vector3D>();
        public ArrayList sum_vector_arr = new ArrayList();

        
        public void add_vector(double a1, double b1, double c1)
        {

            list.Add(new Vector3D(a1, b1, c1));

        }


        public void line_search()
        {


            int j = 0;

            foreach (Vector3D v in list)
            {
                sum_vector_arr.Add(v.vector_lenght(v));
                middle_sum_vectors += v.vector_lenght(v);
                if (j == list.Count)
                {
                    break;
                }

                j++;
            }

            middle_sum_vectors = middle_sum_vectors / sum_vector_arr.Count;
            
            
            Compa();
            index = sum_vector_arr.IndexOf(rez);

            
        }

        public void Compa()
        {
            
            foreach ( double x in sum_vector_arr )
            {
                foreach ( double y in sum_vector_arr )
                {
                    if ( middle_sum_vectors < y|| middle_sum_vectors > x )
                    {
                        if ( y -middle_sum_vectors > middle_sum_vectors - x )
                        {
                            rez = y;
                        }
                        else
                        {
                            rez = x;
                        }

                    }
                }
            }

        }

        public int BinarySearch()
        {
            line_search();
            sum_vector_arr.Sort();
            
            int ind = sum_vector_arr.BinarySearch(rez);

            return ind;

        }

        public void sort_vectors()
        {

            list.Sort();

        } 
        
        
    }
}
