using System;
using System.Collections.Generic;


namespace ing_lab_2._2
{
    class Program
    {
        struct Vote
        {
            public string Name;
            public int Number_area;
            public int Res_vote;

            public Vote(string Name, int Number_area, int Res_vote)
            {

                this.Name = Name;
                this.Number_area = Number_area;
                this.Res_vote = Res_vote;

            }
        }

        public static int count = 1;
        public static int c_count = 1;

        static List<Vote> creature_s(List<Vote> vote)
        {
            string line;
            string v_name;
            int v_number_area;
            int v_res_vote;
            

            Console.WriteLine("Введите колличество считываемых строк");
            int q_string = Convert.ToInt32(Console.ReadLine());

            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\npota\source\repos\ing_lab_2.1\TextFile.txt");

            while ((line = file.ReadLine()) != null & count <= q_string)
            {

                v_name = line.Substring(0, line.IndexOf(" "));
                v_number_area = Convert.ToInt32(line.Substring(line.IndexOf(" ") + 1, (line.LastIndexOf(" ")) - line.IndexOf(" ")));
                v_res_vote = Convert.ToInt32(line.Substring(line.LastIndexOf(" ") + 1, (line.Length - (line.LastIndexOf(" ") + 1))));

                vote.Add(new Vote() { Name = v_name, Number_area = v_number_area, Res_vote = v_res_vote });

                count++;

            }

            file.Close();

            return vote;
        }

        
        static void print_s( List<Vote> vote) {

            
            String printFormat = "{0,-20} {1,-20} {2,-20}";
            String[] strHeader = { "название партии", "номер участка", "колличество голосов" };
            String strFormatHeader = String.Format(printFormat, strHeader);

            Console.WriteLine();
            Console.WriteLine(strFormatHeader);
            Console.WriteLine();


            foreach (Vote vt in vote)
            {
                Console.WriteLine(String.Format(printFormat, vt.Name, vt.Number_area, vt.Res_vote));
            }

        }

        static void ex(List<Vote> vote)
        {
            bool f_first = true;
            string no_name;
            string n_name;
            
            vote.Sort(delegate (Vote vt1, Vote vt2) { return -vt1.Res_vote.CompareTo(vt2.Res_vote); });

            

        foreach (Vote p in vote)
        {
            Console.WriteLine("{0}-е место: {1} ", c_count, p.Name);
            
            if (c_count == 3) break;
            c_count++;
        }
                
            
        }

        static void Main(string[] args)
        {
            List<Vote> vote = new List<Vote>(10);

            creature_s(vote);
            print_s(vote);
            Console.WriteLine("*************************************************");
            ex(vote);
            
        }

        
    }
}
