using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8._3
{
    public sealed class Parquet_board:Parquet
    {

        public int Stripes;

        public override int V() => Lenght * Width * Thickness;

        public Parquet_board(int Length, int Width, int Thickness, string Name, string type_of_wood, int stripes)
            : base(Length, Width, Thickness, Name, type_of_wood)
        {
            Stripes = stripes;
        }

        public Parquet_board() { }
    }
}
