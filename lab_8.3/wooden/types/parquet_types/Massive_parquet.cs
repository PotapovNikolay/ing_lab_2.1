using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8._3
{
    public sealed class Massive_parquet:Parquet
    {
        public int Coating;

        public override int V() => Lenght * Width * Thickness;


        public Massive_parquet(int Length, int Width, int Thickness, string Name, string type_of_wood, int Coating) : base(Length, Width, Thickness, Name, type_of_wood)
        {
            this.Coating = Coating;
        }

        public Massive_parquet() { }
    }
}
