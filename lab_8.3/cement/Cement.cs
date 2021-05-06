using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8._3
{
    public abstract class Cement : IComparable<Cement>
    {
        public string Name { get; set; }
        public string NameOfCement { get; set; }
        protected int brand;
        public string Manufacturer { get;  set; }
        protected int clas;
        public double price { get; set; }
        


        protected Cement(string name,string NameOfCement, int brand, string manufacturer, int clas, double price)
        {
            Name = name;
            this.NameOfCement = NameOfCement;
            Brand = brand;
            Manufacturer = manufacturer;
            Clas = clas;
            this.price = price;

        }

        protected Cement() { }


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


        public abstract double Found_total_price();


        public int CompareTo(Cement other)
        {
            if (this.price > other.price) return -1;
            if (this.price < other.price) return 1;
            else return 0;
        }


    }

}