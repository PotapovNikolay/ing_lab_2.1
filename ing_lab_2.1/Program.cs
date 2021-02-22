using System;
using System.Collections.Generic;

namespace ing_lab_2._1
{
    class Program
    {
        struct Vote
        {
            public string Name;
            public int Number_area;
            public int Res_vote;

            public Vote ( string Name, int Number_area, int Res_vote)
            {

                this.Name = Name;
                this.Number_area = Number_area;
                this.Res_vote = Res_vote;

            }

            public void WriteVote()
            {

                Console.WriteLine("за партию {0} на участке {1} проголосовало избирателей {2}", Name, Number_area, Res_vote);

            }
        }
        static void Main(string[] args)
        {
            string line;
            string name;
            int number_area;
            int res_vote;
            int count = 1;
            int c_count = 0;

            List<Vote> new1 = new List<Vote>(10);

            Console.WriteLine("Введите колличество партий");
            int q_string = Convert.ToInt32(Console.ReadLine());

            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\npota\source\repos\ing_lab_2.1\TextFile.txt");

            while ((line = file.ReadLine()) != null & count<=q_string) 
            {

                name = line.Substring(0, line.IndexOf(" "));
                number_area = Convert.ToInt32(line.Substring(line.IndexOf(" ") + 1, (line.LastIndexOf(" ")) - line.IndexOf(" ")));
                res_vote = Convert.ToInt32(line.Substring(line.LastIndexOf(" ") + 1, (line.Length - (line.LastIndexOf(" ") + 1))));

                Vote new2 = new Vote(name, number_area, res_vote);
                new1.Add(new2);
                count++;
            }
            file.Close();


            // красивый вывод

            String printFormat = "{0,-20} {1,-20} {2,-20}";

            String[] strHeader = { "название партии", "номер участка", "колличество голосов" };
            String strFormatHeader = String.Format(printFormat, strHeader);

            Console.WriteLine();
            Console.WriteLine(strFormatHeader);
            Console.WriteLine();

            foreach (Vote p in new1)
            {
                
                Console.WriteLine(String.Format(printFormat,p.Name, p.Number_area, p.Res_vote));
                
            }

            Console.WriteLine("\n****************************************************\n");

            new1.Sort(delegate (Vote vt1, Vote vt2) { return -vt1.Res_vote.CompareTo(vt2.Res_vote); });

            foreach (Vote p in new1)
            {

                Console.WriteLine(String.Format(printFormat, p.Name, p.Number_area, p.Res_vote));
                c_count++;
                if (c_count == 3) break;

            }
        }
    }
}
