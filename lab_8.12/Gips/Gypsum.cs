using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8._2
{
    abstract class Gypsum
    {
        public abstract int Setting_time { set; }

        public string Manufacturer;

        protected Gypsum(string manufacturer, int setting_time)
        {
            Manufacturer = manufacturer;
            Setting_time = setting_time;
        }
    }
}
