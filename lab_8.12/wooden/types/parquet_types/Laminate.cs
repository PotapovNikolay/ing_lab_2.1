using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8._2
{
    sealed class Laminate : Parquet
    {


        public int Coating_classes {
            get=>Coating_classes;
            set => Coating_classes = value < 31 || value > 34 ? throw new NotImplementedException() : value;
        }
    


    public Laminate(int Length, int Width, int Thickness, string Name, string type_of_wood, int Coating_classes) : base(Length, Width, Thickness, Name, type_of_wood)
        {
            this.Coating_classes = Coating_classes;
        }


        public override int Lenght { get; set; }
        public override int Width { get; set; }
        public override int Thickness { get; set; }


        public static explicit operator string(Laminate x) => "Информация о классе покрытия"+x.Coating_classes;



        public override int V() => Lenght * Width * Thickness;
    }
}
