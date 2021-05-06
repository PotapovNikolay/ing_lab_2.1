using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8._2
{
    abstract class Wooden_building_structures
    {

        public abstract int Lenght { get; set; }

        public abstract int Width { get; set; }
        
        public abstract int Thickness { get; set; }

        public string type_of_wood,Name;


        protected Wooden_building_structures(int Length, int Width, int Thickness, string Name, string type_of_wood )
        {
            this.Lenght = Length;
            this.Width = Width;
            this.Thickness = Thickness;
            this.Name = Name;
            this.type_of_wood = type_of_wood;
        }

        public abstract int V();
    }
}
