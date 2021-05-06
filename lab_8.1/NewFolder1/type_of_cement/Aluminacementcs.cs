using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8._1
{
    sealed class Aluminacementcs:Cement
    {

        public Aluminacementcs(string name, int brand, string manufacturer, int clas, double price) :
            base(name, brand, manufacturer, clas, price)
        { }

    }
}
