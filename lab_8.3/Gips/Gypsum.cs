using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8._3
{
    public abstract class Gypsum
    {
        public abstract int Setting_time { get; set; }
        public string Name { get; set; }
        public string nameofgips { get; set; }
        public string Manufacturer { get; set; }

        protected Gypsum(string Name, string nameofgips, string manufacturer, int setting_time)
        {
            this.Name = Name;
            this.nameofgips = nameofgips;
            Manufacturer = manufacturer;
            Setting_time = setting_time;
        }
        protected Gypsum() { }
    }
}
