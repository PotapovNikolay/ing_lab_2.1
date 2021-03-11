using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace lab6_1
{
    
    public delegate float Help( int x );
    class Massiv
    {
        public int a { get; set; }
        public float[,] my_mass = new float[3, 3];

        public Massiv()
        {

        }

        public float rez_row(int a) => my_mass[a, 1] + my_mass[a, 2] + my_mass[a, 0];


        public float X1( Func<int,float> x, int a,int b)
        {
            Help h = new Help(x);

            return my_mass[a, b] / h(a)*100;
        }


    }
}
   
