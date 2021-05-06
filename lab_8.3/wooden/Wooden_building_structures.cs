using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8._3
{
    public abstract class Wooden_building_structures
    {

        public int Lenght { get; set; }

        public int Width { get; set; }
        
        public int Thickness { get; set; }

        public string type_of_wood { get; set; }

        public string Name { get; set; }
    

        protected Wooden_building_structures(int Length, int Width, int Thickness, string Name, string type_of_wood )
        {
            this.Lenght = Length;
            this.Width = Width;
            this.Thickness = Thickness;
            this.Name = Name;
            this.type_of_wood = type_of_wood;
        }

        protected Wooden_building_structures() { }
        public abstract int V();
    }
}
