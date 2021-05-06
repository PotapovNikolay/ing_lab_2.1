using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8._3
{
    public sealed class Block_parquet:Parquet
    {

        public override int V() => Lenght * Width * Thickness;


        public Block_parquet(int Length, int Width, int Thickness, string Name, string type_of_wood) : base(Length, Width, Thickness, Name, type_of_wood)
        {
        }

        public Block_parquet()
        {
            
        }
    }
}
