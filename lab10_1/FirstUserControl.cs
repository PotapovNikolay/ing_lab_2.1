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
    public partial class FirstUserControl : UserControl
    {
        public FirstUserControl()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Object selectedItem = comboBox1.SelectedItem;

            switch (selectedItem.ToString())
            {
                case "None":
                    this.BorderStyle = BorderStyle.None;
                    break;
                case "Fixed3D":
                    this.BorderStyle = BorderStyle.Fixed3D;
                    break;
                case "FixedSingle":
                    this.BorderStyle = BorderStyle.FixedSingle;
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Object selectedItem1 = comboBox2.SelectedItem;

            button3.FlatAppearance.BorderSize = Convert.ToInt32(selectedItem1);
         
        }
    }
}
