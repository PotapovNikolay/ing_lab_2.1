using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8._2
{
    sealed class Block_parquet:Parquet
    {
        
        public override int Lenght
        {
            get => Lenght;
            set => Lenght = value > 500 ? throw new NotImplementedException() : value;
        }

        public override int Width
        {
            get => Width;
            set => Width = value > 75 ? throw new NotImplementedException() : value;
        }

        public override int Thickness
        {
            get => Thickness;
            set => Thickness = value < 15 || value > 22 ? throw new NotImplementedException() : value;
        }

        public override int V()
        {
            throw new NotImplementedException();
        }


        public Block_parquet(int Length, int Width, int Thickness, string Name, string type_of_wood) : base(Length, Width, Thickness, Name, type_of_wood)
        {
        }
    }
}
