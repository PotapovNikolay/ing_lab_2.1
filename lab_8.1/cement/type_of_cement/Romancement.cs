using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8._1
{
    sealed class Romancement:Cement
    {

        public Romancement(string name,string nameOfCement, int brand, string manufacturer, int clas, double price) : 
            base(name, nameOfCement,brand, manufacturer,clas, price){}

        public Romancement() { }

    }
}
