using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8._3
{
    public sealed class DSP:Wooden_building_structures
    {
        public DSP(int Length, int Width, int Thickness, string Name, string type_of_wood) 
            : base(Length, Width, Thickness, Name, type_of_wood)
        { }


        public DSP() { }

        public override int V() => Lenght * Width * Thickness;
    }
}
