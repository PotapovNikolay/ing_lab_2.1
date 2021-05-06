using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_8._3
{
    [Serializable]
    public class List_Of_Cements
    {

        public List<Portlandcementcs> list_of_port = new List<Portlandcementcs>();

        public List<Romancement> list_of_roman = new List<Romancement>();

        public List<Aluminacementcs> list_of_aluma = new List<Aluminacementcs>();

        public void add_roman(string name , string NameOfCement, int brand, string manufacturer, int clas, double price)
        {
            list_of_roman.Add(new Romancement(name, NameOfCement, brand, manufacturer, clas, price));
        }

        public void add_aluma(string name, string NameOfCement, int brand, string manufacturer, int clas, double price)
        {
            list_of_aluma.Add(new Aluminacementcs(name, NameOfCement, brand, manufacturer, clas, price));
        }

        public void add_port(string name, string NameOfCement, int brand, string manufacturer, int clas, double price, int idhl, string types)
        {
            list_of_port.Add(new Portlandcementcs(name,NameOfCement, brand,manufacturer,clas,price,idhl,types));
        }

    }
}
