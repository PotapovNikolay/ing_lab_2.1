﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8._2
{
    sealed class DVP:Wooden_building_structures
    {
        public DVP(int Length, int Width, int Thickness, string Name, string type_of_wood) 
            : base(Length, Width, Thickness, Name, type_of_wood)
        {
        }


        public override int Lenght { get; set; }
        public override int Width { get; set; }
        public override int Thickness { get; set; }

        public override int V() => Lenght * Width * Thickness;
    }
}
