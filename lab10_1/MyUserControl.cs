using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10_1
{
    public partial class MyUserControl : UserControl
    {
        public MyUserControl()
        {
            InitializeComponent();
        }

        private void textBox3_DoubleClick(object sender, EventArgs e)
        {
            string[] words = textBox3.Text.Split(' ');

            textBox3.Clear();

            textBox3.Text = words.OrderByDescending(n => n.Length).First();
        }

    }
}
