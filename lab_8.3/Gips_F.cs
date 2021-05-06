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
    public partial class Gips_F : Form
    {
        public Gips_F()
        {
            InitializeComponent();

            del.Size = new Size(20, 20);
            del.Left = 180;
            del.Top = 10;
            ad.Size = new Size(20, 20);
            ad.Left = 100;
            ad.Top = 10;
            re.Size = new Size(20, 20);
            re.Left = 20;
            re.Top = 10;
        }

        private void Gips_F_Load(object sender, EventArgs e)
        {
            Rectangle screen = Screen.PrimaryScreen.Bounds;
            int height = screen.Height;
            int width = screen.Width;

            StartPosition = FormStartPosition.Manual;

            Location = new Point(300, 40);

            this.Font = new Font("Leelawadee UI", 9);
        }

        private void del_Click(object sender, EventArgs e)
        {
            Program.f1.treeView1.SelectedNode.Remove();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ad_Click(object sender, EventArgs e)
        {
            Program.f1.button1.BackgroundImage = Image.FromFile(@"C:\Users\npota\OneDrive\Рабочий стол\гамно\4-й сем\ПИ\9\pngwing.com.png", false);


            Program.f1.cler();


            switch (nam.Text)
            {
                case "Быстротвердеющий":
                    Program.f1.list_of_gips.add_fast
                        ("Гипс",nam.Text,manufactur.Text,Convert.ToInt32(tim.Text));
                    break;
                case "Нормальнотвердеющий":
                    Program.f1.list_of_gips.add_norm
                        ("Гипс", nam.Text, manufactur.Text, Convert.ToInt32(tim.Text));
                    break;
                case "Медленнотвердеющий":
                    Program.f1.list_of_gips.add_slow
                        ("Гипс", nam.Text, manufactur.Text, Convert.ToInt32(tim.Text));
                    break;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void re_Click(object sender, EventArgs e)
        {
            Program.f1.button1.BackgroundImage = Image.FromFile(@"C:\Users\npota\OneDrive\Рабочий стол\гамно\4-й сем\ПИ\9\pngwing.com.png", false);


            Program.f1.cler();

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
