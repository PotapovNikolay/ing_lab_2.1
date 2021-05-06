using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_8._3
{
    public partial class Wood_F : Form
    {
        public Wood_F()
        {
            InitializeComponent();
            //groupBox1.Font = new Font("Impact", 12, FontStyle.Bold);
            //this.groupBox1.ForeColor = "233; 196; 106";
            //Wood_F wf = new Wood_F();

            //wf.Size = new Size(300, 300);

            del.Size = new Size(20, 20);
            del.Left = 180;
            del.Top = 10;
            ad.Size = new Size(20, 20);
            ad.Left = 100;
            ad.Top = 10;
            re.Size = new Size(20, 20);
            re.Left = 20;
            re.Top = 10;
            textBox8.Clear();
        }
        private void Wood_F_Load(object sender, EventArgs e)
        {
            

            Rectangle screen = Screen.PrimaryScreen.Bounds;
            int height = screen.Height;
            int width = screen.Width;

            StartPosition = FormStartPosition.Manual;

            Location = new Point(300, 40);

            this.Font = new Font("Leelawadee UI", 9);

            button2.Text = "Колличество слоев";
        }

        private void del_Click(object sender, EventArgs e)
        {
            Program.f1.treeView1.SelectedNode.Remove();
        }

        public void ad_Click(object sender, EventArgs e)
        {
            Program.f1.button1.BackgroundImage = Image.FromFile(@"C:\Users\npota\OneDrive\Рабочий стол\гамно\4-й сем\ПИ\9\pngwing.com.png", false);


            Program.f1.cler();

            switch (nam.Text)
            {
                case "Фанера":
                    Program.f1.list_of_wood.add_plywood(Convert.ToInt32(Lenght.Text), Convert.ToInt32(Widt.Text), Convert.ToInt32(Thicnes.Text), nam.Text,
                        type_of_wood.Text, Convert.ToInt32(coating));
                    break;
                case "ДВП":
                    Program.f1.list_of_wood.add_dvp(Convert.ToInt32(Lenght.Text), Convert.ToInt32(Widt.Text), Convert.ToInt32(Thicnes.Text), nam.Text,
                        type_of_wood.Text);
                    break;
                case "ДСП":
                    Program.f1.list_of_wood.add_dsp(Convert.ToInt32(Lenght.Text), 
                        Convert.ToInt32(Widt.Text), Convert.ToInt32(Thicnes.Text),
                        nam.Text, type_of_wood.Text);
                    break;
            }
        }

        private void re_Click(object sender, EventArgs e)
        {
            Program.f1.button1.BackgroundImage = Image.FromFile(@"C:\Users\npota\OneDrive\Рабочий стол\гамно\4-й сем\ПИ\9\pngwing.com.png", false);


            Program.f1.cler();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Thicnes_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (Program.f1.cf.textBox1.Text)
            {
                case "Фанера":
                    textBox7.Clear();
                    foreach (Plywood v in Program.f1.list_of_wood.list_of_plywood)
                    {
                        textBox7.Text += "Объем изделия: " + v.V()+ " кубических милиметров";
                    }
                    break;
                case "ДВП":
                    textBox7.Clear();
                    foreach (DVP v in Program.f1.list_of_wood.list_of_dvp)
                    {
                        textBox7.Text += "Объем изделия: " + v.V()+ " кубических милиметров";
                    }
                    break;
                case "ДСП":
                    textBox7.Clear();
                    foreach (DSP v in Program.f1.list_of_wood.list_of_dsp)
                    {
                        textBox7.Text += "Объем изделия: " + v.V()+ " кубических милиметров";
                    }
                    break;
                case "Блок-паркет":
                    textBox7.Clear();
                    foreach (Block_parquet v in Program.f1.list_of_wood.list_of_blockparguet)
                    {
                        textBox7.Text += "Объем изделия: " + v.V() + " кубических милиметров";
                    }
                    break;
                case "Ламинат":
                    textBox7.Clear();
                    foreach (Laminate v in Program.f1.list_of_wood.list_of_laminate)
                    {
                        textBox7.Text += "Объем изделия: " + v.V() + " кубических милиметров";
                    }

                    break;
                case "Цельный паркет":
                    textBox7.Clear();
                    foreach (Massive_parquet v in Program.f1.list_of_wood.list_massive_parguet)
                    {
                        textBox7.Text += "Объем изделия: " + v.V() + " кубических милиметров";
                    }
                    break;
                case "Паркетная доска":
                    textBox7.Clear();
                    foreach (Parquet_board v in Program.f1.list_of_wood.list_of_parquet_board)
                    {
                        textBox7.Text += "Объем изделия: " + v.V() + " кубических милиметров";
                    }
                    break;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (Program.f1.cf.textBox1.Text)
            {
                case "Фанера":
                    textBox8.Clear();
                    foreach (Plywood v in Program.f1.list_of_wood.list_of_plywood)
                    {
                        if (v)
                        {
                            textBox8.Text += "колличество слоев: "+v.count_of_layers;
                        }
                        
                    }
                    break;
                case "Ламинат":
                    textBox8.Clear();
                    foreach (Laminate v in Program.f1.list_of_wood.list_of_laminate)
                    {
                        if (v)
                        {
                            textBox8.Text += "колличество слоев: " + v.Coating_classes;
                        }

                    }
                    break;
                case "Паркетная доска":
                    textBox8.Clear();
                    break;
                case "Цельный паркет":
                    textBox8.Clear();
                    break;
                case "Блок-паркет":
                    textBox8.Clear();
                    break;
                case "ДВП":
                    textBox8.Clear();
                    break;
                case "ДСП":
                    textBox8.Clear();
                    break;
            }
        }
    }
    }
