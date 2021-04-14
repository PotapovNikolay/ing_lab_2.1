using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8._1
{
    sealed class Parquet_board:Parquet
    {

        public int Stripes;

        
        public override int Lenght
        {
            get => Lenght;
            set => Lenght = value < 110 || value > 250 ? throw new NotImplementedException() : value;
        }

        public override int Width
        {
            get => Width;
            set => Width = value < 12 || value >20 ? throw new NotImplementedException() : value;
        }

        public override int Thickness
        {
            get => Thickness; 
            set => Thickness = value < 1 || value > 3 ? throw new NotImplementedException() : value;
        }

        public override int V()
        {
            throw new NotImplementedException();
        }

        public Parquet_board(int Length, int Width, int Thickness, string Name, string type_of_wood, int stripes) : base(Length, Width, Thickness, Name, type_of_wood)
        {
            Stripes = stripes;
        }
    }
}
