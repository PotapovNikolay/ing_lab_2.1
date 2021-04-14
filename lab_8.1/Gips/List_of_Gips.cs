using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8._1.Gips
{
    class List_of_Gips
    {
        private List<Fast_hardening> list_of_fast = new List<Fast_hardening>();

        private List<Normally_hardening> list_of_norm = new List<Normally_hardening>();

        private List<Slowly_hardening> list_of_slow = new List<Slowly_hardening>();

        public void add_fast( string manufacturer, int setting_time)
        {

            list_of_fast.Add(new Fast_hardening(setting_time, manufacturer));

        }

        public void add_norm(string manufacturer, int setting_time)
        {

            list_of_norm.Add(new Normally_hardening(setting_time, manufacturer));

        }

        public void add_slow(string manufacturer, int setting_time)
        {

            list_of_slow.Add(new Slowly_hardening(setting_time, manufacturer));

        }



    }
}
