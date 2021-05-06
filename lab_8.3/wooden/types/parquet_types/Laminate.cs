using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8._3
{
    public sealed class Laminate : Parquet
    {

        public int Coating_classes { get; set; }

        
        public Laminate(int Length, int Width, int Thickness, string Name, string type_of_wood, int Coating_classes) 
            : base(Length, Width, Thickness, Name, type_of_wood)
        {
            this.Coating_classes = Coating_classes;
        }

        public Laminate() { }


        public static explicit operator string(Laminate x) => "Информация о классе покрытия"+x.Coating_classes;

        public static bool operator false(Laminate x) => x.type_of_wood != "не целый";

        public static bool operator true(Laminate x) => x.type_of_wood == "целый";

        public override int V() => Lenght * Width * Thickness;
    }
}
