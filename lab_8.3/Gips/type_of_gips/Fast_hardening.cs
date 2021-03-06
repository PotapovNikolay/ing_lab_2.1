﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8._3
{
    public sealed class Fast_hardening : Gypsum
    {
        private int setting_time;

        public override int Setting_time
        {
            get { return setting_time;}
            set =>
                setting_time = value < 2 || value > 15
                    ? throw new ArgumentOutOfRangeException("Время введено неверно")
                    : value;
        }


        public Fast_hardening(string Name, string nameofgips,int setting_time, string manufacturer) : base(Name,nameofgips,manufacturer, setting_time)
        { }

        public Fast_hardening() { }
    }
}

