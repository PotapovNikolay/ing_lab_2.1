using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8._3
{
    public sealed class Romancement:Cement
    {

        public Romancement(string name, string NameOfCement, int brand, string manufacturer, int clas, double price) :
            base(name, NameOfCement, brand, manufacturer,clas, price){}

        public Romancement() { }

        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3},{4},{5}", Name, NameOfCement, Brand,Manufacturer,Clas,price);
        }

        public override double Found_total_price()
        {
            double tot_price = 0;

            if (brand < 400)
            {
                tot_price = price;
            }
            else if (brand == 500)
            {
                tot_price = price * 2;
            }
            else
            {
                tot_price = price * 2.5;
            }


            return tot_price;
        }
    }
}
