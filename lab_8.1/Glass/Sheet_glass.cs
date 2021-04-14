using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8._1
{
    abstract class Sheet_glass
    {
        public double Lenght, Whidth;

        public int Strength, Hardness;

        public Sheet_glass(double lenght, double whidth, int strength, int hardness)
        {
            Lenght = lenght;
            Whidth = whidth;
            Strength = strength;
            Hardness = hardness;
        }

        public Sheet_glass() { }

        //public static implicit operator Sheet_glass(double x) => new Sheet_glass;

        public static bool operator false(Sheet_glass x)
        {
            if (x.Hardness > 1000)
            {
                return false;
            }

            return true;
        }

        public static bool operator true(Sheet_glass x)
        {
            if (1000 < x.Hardness && x.Hardness < 2000)
            {
                return true;
            }

            return false;
        }
    }
}
