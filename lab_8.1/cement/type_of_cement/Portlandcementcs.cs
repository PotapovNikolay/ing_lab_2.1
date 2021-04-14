using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8._1
{
    sealed class Portlandcementcs:Cement
    {
        public int idhl;

        public string type_of_use { get; set; }

        public string types { get; set; }


        public Portlandcementcs(string name, string nameOfCement,int brand, string manufacturer, int clas, int idhl, string type_of_use, string types, double price) 
            : base(name, nameOfCement, brand, manufacturer, clas, price)
        {

            IDHL = idhl;
            this.type_of_use = type_of_use;
            this.types = types;

        }

        public Portlandcementcs()
        {
            throw new NotImplementedException();
        }

        public int IDHL
        {
            get { return idhl; }
            set
            {
                idhl = value < 6000 || value > 4000 || value % 1000 != 0
                    ? throw new ArgumentOutOfRangeException("Марка набрана неверно")
                    : value;
            }
        }


        public static bool operator false(Portlandcementcs x) => x.IDHL == 0;

        public static bool operator true(Portlandcementcs x) => x.IDHL != 0;


    }
}
