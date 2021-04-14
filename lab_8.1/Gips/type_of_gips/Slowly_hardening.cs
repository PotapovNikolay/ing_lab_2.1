using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8._1
{
    sealed class Slowly_hardening:Gypsum
    {

        public int setting_time;

        public override int Setting_time
        {
            set =>
                setting_time = value < 30 || value > 120
                    ? throw new ArgumentOutOfRangeException("Время введено неверно")
                    : value;
        }


        public Slowly_hardening(int setting_time, string manufacturer) : base(manufacturer, setting_time)
        { }

    }
}
