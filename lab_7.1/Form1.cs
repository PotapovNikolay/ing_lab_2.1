using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_7._1
{

    public partial class Form1 : Form
    {

        public delegate void Show();

        //double a1 { get; set; }
        //double b1 { get; set; }
        //double c1 { get; set; }

        public VectorAll new_vector = new VectorAll();

        public Form1()
        {
            InitializeComponent();

        }

        //public void ini()
        //{

        //    a1 = Convert.ToDouble(textBox1.Text);
        //    b1 = Convert.ToDouble(textBox2.Text);
        //    c1 = Convert.ToDouble(textBox3.Text);
        //}

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( dataGridView1.DataSource != null )
            {
                dataGridView1.DataSource = null;
            }
            else
            {
                dataGridView1.Rows.Clear();
            }

            dataGridView1.Visible = true;

            dataGridView1.AllowUserToResizeRows = true;
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.AllowUserToDeleteRows = true;
        }



        private void просмотретьToolStripMenuItem_Click( object sender, EventArgs e )
        {
            //for ( int i = 0; i < dataGridView1.Columns.Count; i++ )
            //{
            //    for ( int j = 0; j < dataGridView1.Rows.Count; j++ )
            //    {
            //        dataGridView1.Rows [ j ].Cells [ i ].Value = DBNull.Value;
            //    }
            //}


            for (int rows = 0; rows < dataGridView1.Rows.Count; rows++)
            {
                foreach (Vector3D v in new_vector.list)
                {
                    dataGridView1.Rows[rows].Cells[0].Value = v.a;
                    dataGridView1.Rows[rows].Cells[1].Value = v.b;
                    dataGridView1.Rows[rows].Cells[2].Value = v.c;


                }
            }

            textBox1.Text = Convert.ToString( new_vector.list.Count );

            dataGridView1.Visible = true;

            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

        }

        private void сохранитьToolStripMenuItem_Click( object sender, EventArgs e )
        {


            MessageBox.Show( "Вы добавили вектор!" );

            for ( int rows = 0; rows < dataGridView1.Rows.Count; rows++ )
            {
                new_vector.add_vector( Convert.ToDouble( dataGridView1.Rows[ rows ].Cells [ 0 ].Value ), Convert.ToDouble( dataGridView1.Rows [ rows ].Cells [ 1 ].Value), Convert.ToDouble( dataGridView1.Rows [ rows ].Cells [ 2 ].Value ));
            }

            dataGridView1.Visible = false;

            textBox1.Text = Convert.ToString( new_vector.list.Count );
        }

        private void редактироватьToolStripMenuItem_Click( object sender, EventArgs e )
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Visible = true;
        }


        private void сортировкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( dataGridView1.DataSource != null )
            {
                dataGridView1.DataSource = null;
            }
            else
            {
                dataGridView1.Rows.Clear();
            }


            new_vector.sort_vectors();
            textBox1.Text = Convert.ToString( new_vector.list.Count );
           


            //dataGridView1.DataSource = new_vector.list_sort;
            foreach (Vector3D v in new_vector.list)
            {
                dataGridView1.Rows.Add(v.a, v.b, v.c);
            }

            

            //for ( int rows = 0; rows < dataGridView1.Rows.Count; rows++ )
            //{
            //    foreach ( Vector3D v in new_vector.list_sort )
            //    {
            //        dataGridView1.Rows [ rows ].Cells [ 0 ].Value = v.a;
            //        dataGridView1.Rows [ rows ].Cells [ 1 ].Value = v.b;
            //        dataGridView1.Rows [ rows ].Cells [ 2 ].Value = v.c;


            //    }

            //}

            dataGridView1.AllowUserToResizeRows = true;
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.AllowUserToDeleteRows = true;
            dataGridView1.Visible = true;
        }

        private void загрузитьToolStripMenuItem_Click( object sender, EventArgs e )
        {
            string line;

            string[] arrString = new string [ dataGridView1.Rows.Count ];

            System.IO.StreamReader file = new System.IO.StreamReader( @"C:\Users\npota\source\repos\ing_lab_2.1\TextFile.txt" );

            while ((line = file.ReadLine())!= null)
            {
                arrString = line.Split(' ');

            }

        }
    }
}
