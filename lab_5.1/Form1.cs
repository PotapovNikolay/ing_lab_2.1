using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_5._1
{
    
    public partial class Form1 : Form
    {
        double eps { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load( object sender, EventArgs e )
        {

            toolTip1.SetToolTip( button2, "получить значение первого выражения " );
            toolTip1.SetToolTip( button1, "получить значение второго выражения " );

            MessageBox.Show( "Вы в моей программе!" );
        }


        private void button1_Click( object sender, EventArgs e )
        {
            try
            {
                eps = Convert.ToDouble(textBox_e.Text);
            }
            catch
            {
                Form2 newform = new Form2();

                newform.Show();
            }
            Deleg try1 = new Deleg(eps);

            Func<double,double> second_ex = try1.second_expression;

            Func<double, double> second_df = try1.df2;


            textBox_x.Text = Convert.ToString(try1.half_division_method(second_ex));

            textBox_ex1.Text = Convert.ToString(try1.second_expression(try1.half_division_method(second_ex)));

            textBox_derived_ex_half_division.Text = Convert.ToString(try1.derived_expression_half_division_method(eps ) );

            textBox_x_N.Text = Convert.ToString(try1.method_N(second_ex,second_df));

            textBox_derided_ex_N.Text = Convert.ToString( try1.derived_expression_method_N( eps, second_ex, second_df ) );

            chart2.Series [ 0 ].Points.Clear();


            for (int i = -5; i <= 10 ; i ++)
            {

                chart2.Series [ 0 ].Points.AddXY( i, second_ex(i));

            }

        }

        private void button2_Click( object sender, EventArgs e )
        {

            eps = Convert.ToDouble( textBox_e.Text );

            Deleg try2 = new Deleg( eps );

            Func<double, double> first_ex = try2.first_expression;

            Func<double, double> first_df = try2.df1;

            textBox12.Text = Convert.ToString( try2.half_division_method( first_ex ) );

            textBox10.Text = Convert.ToString( try2.first_expression( try2.half_division_method( first_ex ) ) );

            textBox9.Text = Convert.ToString( try2.derived_expression_half_division_method( eps ) );

            textBox8.Text = Convert.ToString( try2.method_N( first_ex, first_df ) );

            textBox7.Text = Convert.ToString( try2.derived_expression_method_N( eps, first_ex, first_df ) );

            chart2.Series[0].Points.Clear();

            for ( double i = -5; i <= 10; i += 0.1 )
            {
                chart2.Series [ 0 ].Points.AddXY( i, first_ex( i ) );
            }

        }



        private void textBox10_TextChanged( object sender, EventArgs e )
        {

        }

        private void chart1_Click( object sender, EventArgs e )
        {

        }

        private void button1_Hover( object sender, EventArgs e )
        {

        }

        private void button_help_MouseHover( object sender, EventArgs e )
        {
            label1.Visible = true;
        }

        private void button_help_MouseLeave( object sender, EventArgs e )
        {
            label1.Visible = false;
        }

        private void button_help_Click( object sender, EventArgs e )
        {
            panel1.Visible = true;
        }

        private void button3_Click( object sender, EventArgs e )
        {
            panel1.Visible = false;
        }

        private void textBox1_TextChanged_1( object sender, EventArgs e )
        {

        }

        private void textBox3_TextChanged( object sender, EventArgs e )
        {

        }

        private void chart2_Click( object sender, EventArgs e )
        {

        }

        private void textBox2_TextChanged( object sender, EventArgs e )
        {

        }

        private void textBox6_TextChanged( object sender, EventArgs e )
        {

        }

        private void textBox_e_TextChanged( object sender, EventArgs e )
        {

        }

        private void textBox_x_TextChanged( object sender, EventArgs e )
        {

        }

        private void textBox10_TextChanged_1( object sender, EventArgs e )
        {

        }
    }
}
