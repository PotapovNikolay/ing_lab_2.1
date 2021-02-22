using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace lab_4._1
{

    public partial class Form1 : Form
    {
        double a1 { get; set; }
        double b1 { get; set; }
        double c1 { get; set; }
        double a2 { get; set; }
        double b2 { get; set; }
        double c2 { get; set; }

        

        public Form1()
        {
            InitializeComponent();
        }

        public void ini()
        {
            
            a1 = Convert.ToDouble( textBox2.Text );
            b1 = Convert.ToDouble( textBox4.Text );
            c1 = Convert.ToDouble( textBox5.Text );

            a2 = Convert.ToDouble( textBox8.Text );
            b2 = Convert.ToDouble( textBox7.Text );
            c2 = Convert.ToDouble( textBox6.Text );

        }
        //сложение
        private void button1_Click( object sender, EventArgs e )
        {
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;

            ini();
            Vector3D vector_1 = new Vector3D( a1, b1, c1 );
            Vector3D vector_2 = new Vector3D( a2, b2, c2 );

            Vector3D sum_vector = vector_2 + vector_1;


            Form2 fm2 = new Form2();

            fm2.textBox1.Text = sum_vector.ToString();


            fm2.ShowDialog();

            
        }
        

        private void buttondif_Click(object sender, EventArgs e)
        {
            ini();

            Vector3D vector_1 = new Vector3D( a1, b1, c1 );
            Vector3D vector_2 = new Vector3D( a2, b2, c2 );

            Vector3D dif_vector = vector_2 - vector_1;

            Form2 fm2 = new Form2();

            fm2.textBox1.Text = dif_vector.ToString();


            fm2.ShowDialog();

        }

        private void buttonscalar_Click( object sender, EventArgs e )
        {
            ini();

            Vector3D vector_1 = new Vector3D( a1, b1, c1 );
            Vector3D vector_2 = new Vector3D( a2, b2, c2 );

            Vector3D product_of_vectors = vector_1 * vector_2;
            

            Form2 fm2 = new Form2();

            fm2.textBox1.Text = product_of_vectors.ToString();


            fm2.ShowDialog();

        }

        private void buttonmutliscalar_Click( object sender, EventArgs e)
        {
            double scalar;

            scalar = Convert.ToDouble(textBox11.Text);
            
            ini();

            Vector3D vector_1 = new Vector3D( a1, b1, c1 );
            Vector3D vector_3 = vector_1.Сomposition( vector_1, scalar ); ;

            Form2 fm2 = new Form2();

            fm2.textBox1.Text = vector_3.ToString();


            fm2.ShowDialog();
        }

        private void buttoncompare_Click(object sender, EventArgs e)
        {

            ini();

            Vector3D vector_1 = new Vector3D( a1, b1, c1 );
            Vector3D vector_2 = new Vector3D( a2, b2, c2 );


            Form2 fm2 = new Form2();

            fm2.textBox1.Text = vector_1.Compare_vectors( vector_1, vector_2 );


            fm2.ShowDialog();
        }

        private void button_lenght_Click( object sender, EventArgs e )
        {

            ini();

            Vector3D vector_1 = new Vector3D( a1, b1, c1 );
            Vector3D vector_2 = new Vector3D( a2, b2, c2 );

            Vector3D dif_vector = vector_2 - vector_1;
            Vector3D vector_length = new Vector3D();

            

            Form2 fm2 = new Form2();

            fm2.textBox1.Text = Convert.ToString( vector_length.vector_lenght( dif_vector ) );


            fm2.ShowDialog();
        }

        private void groupBox1_Enter( object sender, EventArgs e )
        {
            

        }

        private void buttonrslt_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox1.Controls)
            {
                c.ForeColor = Color.FromArgb( 189, 224, 254 );
            }
        }


        private void textBox3_TextChanged( object sender, EventArgs e )
        {

        }


        private void textBox2_TextChanged( object sender, EventArgs e )
        {

        }

        private void textBox9_TextChanged( object sender, EventArgs e )
        {

        }

        private void label1_Click( object sender, EventArgs e )
        {

        }

        private void textBox6_TextChanged( object sender, EventArgs e )
        {

        }

        private void textBox10_TextChanged( object sender, EventArgs e )
        {

        }
    }
}
