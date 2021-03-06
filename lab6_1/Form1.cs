﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6_1
{
    public partial class Form1 : Form
    {


        public Form1()
        {

            InitializeComponent();

        }



        private void Form1_Load( object sender, EventArgs e ) { }
        private void button1_Click(object sender, EventArgs e)
        {

            //string[] row1 = new string[] { text1.Text, textBox2.Text, textBox3.Text };

            //string[] row2 = new string[] { textBox5.Text, textBox4.Text, textBox1.Text };

            //string[] row3 = new string[] { textBox8.Text, textBox7.Text, textBox6.Text };

            //object[] rows = new Object[] { row1, row2, row3 };

            //foreach (string[] r in rows)
            //{
            //    dataGridView1.Rows.Add(r);
            //}
        }


        public delegate float Del(int x);

        private void button2_Click( object sender, EventArgs e )
        {

            Massiv m = new Massiv();

            for ( int rows = 0; rows < dataGridView1.Rows.Count-1; rows++ )
            {
                for ( int col = 0; col < dataGridView1.Rows [ rows ].Cells.Count; col++ )
                {
                    m.my_mass [ col, rows ] = (float)(Convert.ToDouble( dataGridView1.Rows [ rows ].Cells [ col ].Value ));
                }
            }

            //for (int rows = 0; rows < dataGridView1.Rows.Count - 1; rows++)
            //{
            //    m.my_mass[rows, col] = (float) Convert.ToDouble(dataGridView1[0, rows].Value);
            //}

            HatchBrush hbr = new HatchBrush( HatchStyle.ForwardDiagonal, Color.Black, Color.White );
            HatchBrush hbr1 = new HatchBrush( HatchStyle.Divot, Color.Black, Color.White );
            HatchBrush hbr2 = new HatchBrush( HatchStyle.Trellis, Color.Black, Color.White );

            Bitmap image = new Bitmap( pictureBox1.Width, pictureBox1.Height );
            Graphics g = Graphics.FromImage(image);

            Pen pen = new Pen( Color.Black, 1 );


            for (int i = 0; i < 240; i+=80)
            {
                int c = i;
                g.DrawRectangle( pen, 0, i, 100, 30 );
            }

            g.DrawLine(pen,0,0,0,200);
            g.DrawLine(pen,0,200,200,200);

            for (int i = 0; i < 3;i++)
            {
                m.rez_row(i);

                Func<int, float> X = m.rez_row;

                float x1 = m.X1(X, i,0);

                float x2 = m.X1(X, i, 1) + x1;

                float x3 = m.X1(X, i, 2) + x2;


                g.FillRectangle( hbr1, 1, i * 80, x1 - 1, 30);

                g.FillRectangle( hbr2, x1, i * 80, ( x2 - x1 ), 30 );

                g.FillRectangle( hbr, x2, i * 80-1, ( x3 - x2 ), 30 );

                g.DrawLine( pen, x1, i * 80, x1, i*80 );
                g.DrawLine( pen, x2, i * 80, x2, i* 80 );
                g.DrawLine( pen, x3, i * 80, x3, i*80 );

            }

            

            pictureBox1.Image = image;
        }

        private void btn_Hover( object sender, EventArgs e )
        {
            button1.BackColor = Color.FromArgb( 237, 242, 251);
        }

        private void textBox4_TextChanged( object sender, EventArgs e )
        {

        }

        private void pictureBox1_Click( object sender, EventArgs e )
        {

        }

        private void text1_TextChanged( object sender, EventArgs e )
        {

        }

        private void textBox2_TextChanged( object sender, EventArgs e )
        {

        }
    }
}
