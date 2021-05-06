using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8._3
{
    public class List_of_Gips
    {
        public List<Fast_hardening> list_of_fast = new List<Fast_hardening>();

        public List<Normally_hardening> list_of_norm = new List<Normally_hardening>();

        public List<Slowly_hardening> list_of_slow = new List<Slowly_hardening>();

        public void add_fast(string Name, string nameofgips, string manufacturer, int setting_time)
        {

            list_of_fast.Add(new Fast_hardening(Name, nameofgips, setting_time, manufacturer));

        }

        public void add_norm(string Name, string nameofgips, string manufacturer, int setting_time)
        {

            list_of_norm.Add(new Normally_hardening(Name, nameofgips, setting_time, manufacturer));

        }

        public void add_slow(string Name, string nameofgips, string manufacturer, int setting_time)
        {

            list_of_slow.Add(new Slowly_hardening(Name, nameofgips, setting_time, manufacturer));

        }

    }
}
