using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8._3
{
    public sealed class Plywood:Wooden_building_structures
    {

        public int? count_of_layers { get; set; }


        public Plywood(int Length, int Width, int Thickness, string Name, string type_of_wood, int count_of_layers) 
            : base(Length, Width, Thickness, Name, type_of_wood)
        {
            this.count_of_layers = count_of_layers;
        }

        public Plywood() { }

        public override int V() => Lenght * Width * Thickness;

        public static bool operator false(Plywood x) => x.type_of_wood != "не целый";

        public static bool operator true(Plywood x) => x.type_of_wood == "целый";
    }
}
