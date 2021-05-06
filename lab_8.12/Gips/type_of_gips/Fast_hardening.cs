using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8._2
{
    sealed class Fast_hardening : Gypsum
    {
        public int setting_time;

        public override int Setting_time
        {
            set =>
                setting_time = value < 2 || value > 15
                    ? throw new ArgumentOutOfRangeException("Время введено неверно")
                    : value;
        }


        public Fast_hardening(int setting_time, string manufacturer) : base(manufacturer, setting_time)
        { }
    }
}

