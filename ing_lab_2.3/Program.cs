using System;
using System.Collections.Generic;
using System.IO;


namespace ing_lab_2._2
{
    class Program
    {
        struct Vote
        {
            public string Name;
            public int Number_area;
            public int Res_vote;

            public Vote(string Name, int Res_vote, int Number_area = 0)
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
            string[] arrString;
            bool b = true;
            int max1=0;
            int max2=0;
            int max3=0;
            int a_max1 = 0;
            int a_max2 = 0;
            int a_max3 = 0;
            string n_max1 = " ";
            string n_max2 = " ";
            string n_max3 = " ";

            arrString = new string[3];

            Console.WriteLine("Введите колличество считываемых строк");
            int q_string = Convert.ToInt32(Console.ReadLine());

            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\npota\source\repos\ing_lab_2.1\TextFile.txt");

            while ((line = file.ReadLine()) != null & count <= q_string)
            {

                arrString = line.Split(' ');
                v_name = arrString[0];
                v_number_area = Convert.ToInt32(arrString[1]);
                v_res_vote = Convert.ToInt32(arrString[2]);


                if (max1 < v_res_vote)
                {
                    n_max3 = n_max2;
                    a_max3 = a_max2;
                    max3 = max2;
                    n_max2 = n_max1;
                    max2 = max1;
                    a_max2 = a_max1;
                    max1 = v_res_vote;
                    n_max1 = v_name;
                    a_max1 = v_number_area;



                }
                else
                {
                    if (max2 < v_res_vote)
                    {

                        max3 = max2;
                        n_max3 = n_max2;
                        a_max3 = a_max2;
                        max2 = v_res_vote;
                        n_max2 = v_name;
                        a_max2 = v_number_area;

                    }
                    else
                    {
                        if (max3 < v_res_vote)
                        {
                            max3 = v_res_vote;
                            n_max3 = v_name;
                            a_max3 = v_number_area;

                        }
                    }
                }
                
                count++;

            }

            vote.Add(new Vote() { Name = n_max1, Number_area = a_max1, Res_vote = max1 });
            vote.Add(new Vote() { Name = n_max2, Number_area = a_max2, Res_vote = max2 });
            vote.Add(new Vote() { Name = n_max3, Number_area = a_max3, Res_vote = max3 });

            file.Close();

            return vote;
        }


        static void print_s(List<Vote> vote)
        {


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
            string no_name;
            string n_name;

            //vote.Sort(delegate (Vote vt1, Vote vt2) { return -vt1.Res_vote.CompareTo(vt2.Res_vote); });



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
