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
    public partial class Cement_F : Form
    {


        public Cement_F()
        {
            InitializeComponent();

            Del.Size = new Size(20, 20);
            Del.Left = 180;
            Del.Top = 10;
            ree.Size = new Size(20, 20);
            ree.Left = 20;
            ree.Top = 10;
            Ad.Size = new Size(20, 20);
            Ad.Left = 100;
            Ad.Top = 10;

        }

        private void Cement_F_Load(object sender, EventArgs e)
        {


            Rectangle screen = Screen.PrimaryScreen.Bounds;
            int height = screen.Height;
            int width = screen.Width;

            StartPosition = FormStartPosition.Manual;

            Location = new Point(300, 40);


            ToolTip toolTip1 = new ToolTip();

            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(this.Ad, "добавить новую ветвь");
            toolTip1.SetToolTip(this.Del, "Удалить выбранную ветвь");
            toolTip1.SetToolTip(this.textBox13, "Нажмите на ветвь, чтобы получить информацию о цементе");

            IDHL.Visible = false;
            types.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;

            this.Font = new Font("Leelawadee UI", 9);

        }

        public void Ad_Click(object sender, EventArgs e)
        {
            Program.f1.button1.BackgroundImage =
                Image.FromFile(@"C:\Users\npota\OneDrive\Рабочий стол\гамно\4-й сем\ПИ\9\pngwing.com.png", false);


            Program.f1.cler();


            switch (Namec.Text)
            {
                case "Портланд":
                    Program.f1.list_of_cemetns.add_port(Namec.Text, Nameofc.Text, Convert.ToInt32(Brand.Text),
                        Manufactur.Text, Convert.ToInt32(Clas.Text), Convert.ToInt32(Price.Text),
                        Convert.ToInt32(IDHL.Text), types.Text);
                    break;
                case "Романцемент":
                    Program.f1.list_of_cemetns.add_roman(Namec.Text, Nameofc.Text, Convert.ToInt32(Brand.Text),
                        Manufactur.Text, Convert.ToInt32(Clas.Text), Convert.ToInt32(Price.Text));
                    break;
                case "Алумацемент":
                    Program.f1.list_of_cemetns.add_aluma(Namec.Text, Nameofc.Text, Convert.ToInt32(Brand.Text),
                        Manufactur.Text, Convert.ToInt32(Clas.Text), Convert.ToInt32(Price.Text));
                    break;
            }
        }

        public void Del_Click(object sender, EventArgs e)
        {
            Program.f1.treeView1.SelectedNode.Remove();
        }

        public void ree_Click(object sender, EventArgs e)
        {
            Program.f1.button1.BackgroundImage =
                Image.FromFile(@"C:\Users\npota\OneDrive\Рабочий стол\гамно\4-й сем\ПИ\9\pngwing.com.png", false);

            Program.f1.cler();

        }

        private void met_Click(object sender, EventArgs e)
        {

            switch (textBox3.Text)
            {
                case "Портланд":
                    textBox4.Clear();
                    foreach (Portlandcementcs v in Program.f1.list_of_cemetns.list_of_port)
                    {
                        textBox4.Text += "Итоговая цена цемента " + textBox1.Text + "=" +
                                         v.Found_total_price().ToString();
                    }

                    break;
                case "Романцемент":

                    foreach (Romancement v in Program.f1.list_of_cemetns.list_of_roman)
                    {
                        if (v.NameOfCement == textBox1.Text && textBox1.Text == "Сибирь")
                        {
                            textBox4.Clear();
                            textBox4.Text = "Итоговая цена цемента " + textBox1.Text + "=" +
                                            v.Found_total_price().ToString() + "\n";
                        }
                        else if (v.NameOfCement == textBox1.Text && textBox1.Text == "Вихрь")
                        {
                            textBox4.Clear();
                            textBox4.Text = "Итоговая цена цемента " + textBox1.Text + "=" +
                                            v.Found_total_price().ToString() + "\n";
                        }

                    }

                    break;
                case "Алумацемент":
                    foreach (Aluminacementcs v in Program.f1.list_of_cemetns.list_of_aluma)
                    {
                        if (v.NameOfCement == textBox1.Text && textBox1.Text == "Метель")
                        {
                            textBox4.Clear();
                            textBox4.Text = "Итоговая цена цемента " + textBox1.Text + "=" +
                                            v.Found_total_price().ToString() + "\n";
                        }
                        else if (v.NameOfCement == textBox1.Text && textBox1.Text == "Смаи")
                        {
                            textBox4.Clear();
                            textBox4.Text = "Итоговая цена цемента " + textBox1.Text + "=" +
                                            v.Found_total_price().ToString() + "\n";
                        }
                        else if (v.NameOfCement == textBox1.Text && textBox1.Text == "Пробой")
                        {
                            textBox4.Clear();
                            textBox4.Text = "Итоговая цена цемента " + textBox1.Text + "=" +
                                            v.Found_total_price().ToString() + "\n";
                        }
                    }

                    break;
            }
        }

        private void Nameofc_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void compa_Click(object sender, EventArgs e)
        {
            switch (textBox1.Text)
            {
                case "Портланд":
                    textBox14.Clear();
                    Program.f1.list_of_cemetns.list_of_port.Sort();
                    foreach (Portlandcementcs v in Program.f1.list_of_cemetns.list_of_port)
                    {
                        textBox14.Text += v.NameOfCement + " " + v.price + " ";
                    }
                    break;
                case "Романцемент":
                    textBox14.Clear();
                    Program.f1.list_of_cemetns.list_of_roman.Sort();
                    foreach (Romancement v in Program.f1.list_of_cemetns.list_of_roman)
                    {
                        textBox14.Text += v.NameOfCement + " " + v.price + " ";
                    }
                    break;
                case "Алумацемент":
                    textBox14.Clear();
                    Program.f1.list_of_cemetns.list_of_aluma.Sort();
                    foreach (Aluminacementcs v in Program.f1.list_of_cemetns.list_of_aluma)
                    {
                        textBox14.Text += v.NameOfCement+" "+v.price+" ";
                    }
                    break;
            }
        }
    }
}
