using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8._1
{
    abstract class Parquet:Wooden_building_structures
    {
        public Parquet(int Length, int Width, int Thickness, string Name, string type_of_wood) : base(Length, Width, Thickness,Name, type_of_wood )
        {
        }

        
    }
}
