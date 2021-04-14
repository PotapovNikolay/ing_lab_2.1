using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8._1
{
    sealed class Massive_parquet:Parquet
    {
        public string Coating;

        public override int Lenght
        {
            get => Lenght;
            set { Lenght = value < 500 ? throw new NotImplementedException() : value; }
        }

        public override int Width
        {
            get => Width;
            set { Width = value < 80 || value >120 ? throw new NotImplementedException() : value; }
        }

        public override int Thickness
        {
            get => Thickness;
            set { Thickness = value < 32 ? throw new NotImplementedException() : value; }
        }

        public override int V()
        {
            throw new NotImplementedException();
        }


        public Massive_parquet(int Length, int Width, int Thickness, string Name, string type_of_wood, string Coating) : base(Length, Width, Thickness, Name, type_of_wood)
        {
            this.Coating = Coating;
        }
    }
}
