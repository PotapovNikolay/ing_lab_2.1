using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_7._1
{
    

    public class VectorAll
    {
        

        public ArrayList list = new ArrayList();

        //private Vector3D new_vector = new Vector3D();

        public ArrayList list_sort = new ArrayList();

        public ArrayList list_sort_s = new ArrayList();

        public void add_vector(double a1, double b1, double c1)
        {

            list.Add(new Vector3D(a1, b1, c1));

        }

        public void Compareto(double x, double y)
        {



        }

        public void sort_vectors()
        {

            list.Sort((Vector3D v1, Vector3D v2)=>v1.a.CompareTo(v2.a));

            list.Reverse();
            //double max = 0;

            //foreach (Vector3D v in list)
            //{

            //    max = v.vector_lenght(v);

            //    if (max > v.vector_lenght(v))
            //    {
            //        list_sort.Add(v);

            //    }

            //}
            // list.Sort( delegate ( Vector3D vt1, Vector3D vt2 ) { return vt1.Res_vote.CompareTo( vt2.Res_vote ); } );

        }

        

        //public void sort_vectors()
        //{
        //    list.Sort( delegate ( Vector3D vt1, Vector3D vt2 ) { return vt1.Res_vote.CompareTo( vt2.Res_vote ); } )

        //}

        //public void get_vector()
        //{
        //    foreach (Vector3D v in list)
        //    {
        //        v.ToString();
        //    }
        //}

        //public ArrayList get_vectors()
        //{
        //    return list;
        //}

        //public void get_v()
        //{
        //    Form1 form = new Form1();

        //    foreach (Vector3D v in list)
        //    {
        //        form.dataGridView1.Rows.Add(v.ToString());
        //    }

        //}
    }
}
