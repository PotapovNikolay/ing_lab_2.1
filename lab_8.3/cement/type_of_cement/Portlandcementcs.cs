using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8._3
{
    public sealed class Portlandcementcs:Cement
    {
        


        public Portlandcementcs(string name, string NameOfCement , int brand, string manufacturer, int clas, double price, int idhl, string types) 
            : base(name,NameOfCement, brand, manufacturer, clas, price)
        {

            IDHL = idhl;
            this.types = types;

        }
        public int idhl;


        public string types { get; set; }
        public Portlandcementcs()
        {
           
        }

        public int IDHL
        {
            get { return idhl; }
            set
            {
                idhl = value > 6000 || value < 4000 || value % 1000 != 0
                    ? throw new ArgumentOutOfRangeException("Марка набрана неверно")
                    : value;
            }
        }


        public static bool operator false(Portlandcementcs x) => x.IDHL == 0;

        public static bool operator true(Portlandcementcs x) => x.IDHL != 0;

        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3},{4},{5},{6},{7}", Name, NameOfCement, Brand, Manufacturer, Clas, price,IDHL,types);
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
                tot_price = price * 1.2;
            }
            else
            {
                tot_price = price * 2;
            }


            return tot_price;
        }
    }
}
