using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_8._2.cement
{
    class List_Of_Cements
    {
        public List<Cement> list_of_cement = new List<Cement>();

        public List<Portlandcementcs> list_of_port = new List<Portlandcementcs>();

        public List<Romancement> list_of_roman = new List<Romancement>();

        public List<Aluminacementcs> list_of_aluma = new List<Aluminacementcs>();

        public void add_roman(string name , string nameOfCement, int brand, string manufacturer, int clas, double price)
        {
            list_of_roman.Add(new Romancement(name, brand, manufacturer, clas, price));
        }

        public void add_aluma(string name, string nameOfCement, int brand, string manufacturer, int clas, double price)
        {
            list_of_aluma.Add(new Aluminacementcs(name, brand, manufacturer, clas, price));
        }

        public void add_port(string name, string nameOfCement, int brand, string manufacturer, int clas, int idhl, string type_of_use, string types, double price)
        {
            list_of_port.Add(new Portlandcementcs(name, brand,manufacturer,clas,idhl,type_of_use,types,price));
        }

        

        
        

        public void fnd_roman (int b, string m, int c )
        {
            list_of_roman.Find(x => x.brand.Equals(b)&&x.Manufacturer.Contains(m)&&x.clas.Equals(c));

        }

        public void fnd_aluma(int b, string m, int c)
        {
            list_of_aluma.Find(x => x.brand.Equals(b) && x.Manufacturer.Contains(m) && x.clas.Equals(c));

        }

        public void fnd_port(int b, string m, int c)
        {
            list_of_port.Find(x => x.brand.Equals(b) && x.Manufacturer.Contains(m) && x.clas.Equals(c));

        }

        public void fillTreeNode()
        {
            Form1 fm = new Form1();

        }
    }
}
