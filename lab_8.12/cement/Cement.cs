using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8._2
{
    abstract class Cement : IComparable<Cement>
    {

        public int brand;
        public string Manufacturer;
        public int clas;
        public double price;
        public string Name;


        public Cement(string name, int brand, string manufacturer, int clas, double price)
        {
            Name = name;
            //Name_of_cement = name_of_cement;
            Brand = brand;
            Manufacturer = manufacturer;
            Clas = clas;
            this.price = price;

        }

        public Cement() { }



        public int Brand
        {
            get { return brand; }
            set
            {
                brand = value < 200 || value > 600 || value % 100 != 0
                    ? throw new ArgumentOutOfRangeException("Марка набрана неверно")
                    : value;
            }
        }


        public int Clas
        {
            get { return clas; }
            set
            {
                clas = value < 30 || value > 60 || value % 10 != 0
                    ? throw new ArgumentOutOfRangeException("класс набран неверно")
                    : value;
            }
        }


        protected double Found_total_price() => Brand * Clas * price;



        public int CompareTo(Cement other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            return price.CompareTo(other.price);
        }




        //public int CompareTo(Cement other)
        //{
        //    if (ReferenceEquals(this, other)) return 0;
        //    if (ReferenceEquals(null, other)) return 1;
        //    return brand.CompareTo(other.brand);
        //}


    }
}