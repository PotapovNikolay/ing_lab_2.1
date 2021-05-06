using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8._2.wooden
{
    class List_of_wood
    {

        public int filtercoating;

        private List<Plywood> list_of_plywood = new List<Plywood>();

        private List<DVP> list_of_dvp = new List<DVP>();

        private List<DSP> list_of_dsp = new List<DSP>();
        

        public void add_plywood(int Length, int Width, int Thickness, string Name, string type_of_wood, int count_of_layers)
        {
            list_of_plywood.Add(new Plywood(Length, Width, Thickness, Name, type_of_wood,count_of_layers));
        }

        public void add_dvp(int Length, int Width, int Thickness, string Name, string type_of_wood)
        {
            list_of_dvp.Add(new DVP(Length, Width, Thickness, Name, type_of_wood));
        }

        public void add_dsp(int Length, int Width, int Thickness, string Name, string type_of_wood)
        {
            list_of_dsp.Add(new DSP(Length, Width, Thickness, Name, type_of_wood));
        }



        private List<Block_parquet> list_of_blockparguet = new List<Block_parquet>();

        private List<Laminate> list_of_laminate = new List<Laminate>();

        private List<Massive_parquet> list_massive_parguet = new List<Massive_parquet>();

        private List<Parquet_board> list_of_parquet_board = new List<Parquet_board>();


        public void add_blockparquet(int Length, int Width, int Thickness, string Name, string type_of_wood)
        {
            list_of_blockparguet.Add(new Block_parquet(Length, Width, Thickness, Name, type_of_wood));
        }

        public void add_laminate(int Length, int Width, int Thickness, string Name, string type_of_wood, int Coating_classes)
        {
            list_of_laminate.Add(new Laminate(Length, Width, Thickness, Name, type_of_wood,Coating_classes));
        }

        public void add_massive_parquet(int Length, int Width, int Thickness, string Name, string type_of_wood, string Coating)
        {
            list_massive_parguet.Add(new Massive_parquet(Length, Width, Thickness, Name, type_of_wood, Coating));
        }

        public void add_pqruet_board(int Length, int Width, int Thickness, string Name, string type_of_wood, int stripes)
        {
            list_of_parquet_board.Add(new Parquet_board(Length, Width, Thickness, Name, type_of_wood,stripes));
        }

        public List<Laminate> fnd(int coating)
        {
            filtercoating = coating;

            List<Laminate> res = list_of_laminate.FindAll(PredicateCoating);
            return res;
        }
        
        private bool PredicateCoating(Laminate laminate)
        {
            if (laminate.Coating_classes == filtercoating)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
