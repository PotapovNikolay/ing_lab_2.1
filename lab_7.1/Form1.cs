using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_7._1
{

    public partial class Form1 : Form
    {

        public VectorAll new_vector = new VectorAll();

        public Form1()
        {

            InitializeComponent();

        }

        public void Clear_f()
        {

            if ( dataGridView1.DataSource != null )
            {
                dataGridView1.DataSource = null;
            }
            else
            {
                dataGridView1.Rows.Clear();
            }

        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear_f();

            dataGridView1.Visible = true;

            dataGridView1.AllowUserToResizeRows = true;
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.AllowUserToDeleteRows = true;
        }

        private void просмотретьToolStripMenuItem_Click( object sender, EventArgs e )
        {
            
            int rows = 0;

            dataGridView1.Visible = true;


            foreach ( Vector3D v in new_vector.list )
            {
                dataGridView1 [ 0, rows ].Value = v.a;
                dataGridView1 [ 1, rows ].Value = v.b;
                dataGridView1 [ 2, rows ].Value = v.c;
                rows++;
            }


            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

        }

        private void сохранитьToolStripMenuItem_Click( object sender, EventArgs e )
        {

            MessageBox.Show( "Вы добавили вектор!" );


            for ( int rows = 0; rows < dataGridView1.Rows.Count - 1; rows++ )
            {

                new_vector.add_vector(
                    Convert.ToDouble( dataGridView1 [ 0, rows ].Value ),
                    Convert.ToDouble( dataGridView1 [ 1, rows ].Value ),
                    Convert.ToDouble( dataGridView1 [ 2, rows ].Value ) );

            }


            dataGridView1.Visible = false;


        }

        private void редактироватьToolStripMenuItem_Click( object sender, EventArgs e )
        {

            dataGridView1.AllowUserToResizeRows = true;
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.AllowUserToDeleteRows = true;

        }


        private void сортировкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear_f();

            new_vector.sort_vectors();


            foreach (Vector3D v in new_vector.list)
            {
                dataGridView1.Rows.Add(v.a, v.b, v.c);
            }


            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Visible = true;
        }

        private void загрузитьToolStripMenuItem_Click( object sender, EventArgs e )
        {

            Clear_f();


            int count = System.IO.File.ReadAllLines( "TextFile.txt" ).Length;

            string line;
            int i = 0;
            string [] arrString = new string [ count ];

            System.IO.StreamReader file = new System.IO.StreamReader( @"C:\Users\npota\source\repos\ing_lab_2.1\lab_7.1\TextFile.txt" );

            while ((line = file.ReadLine())!= null & i < count )
            {
                arrString = line.Split(' ');
                dataGridView1.Rows.Add(arrString[0], arrString [ 1 ], arrString [ 2 ] ); 
                i++;
            }

            dataGridView1.Rows.Add(null, null, null);
            
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;


            MessageBox.Show( "Вектор загружен!" );
        }


        private void линейныйToolStripMenuItem_Click( object sender, EventArgs e )
        {
            dataGridView1.Visible = true;


            Clear_f();
            new_vector.line_search();


            int i = 0;

            foreach (Vector3D VARIABLE in new_vector.list)
            {
                if (i == new_vector.index)
                {
                    dataGridView1.Rows.Add(VARIABLE.a, VARIABLE.b, VARIABLE.c);

                }

                i++;
            }


            MessageBox.Show( "Вектор найден!" );

        }

        private void бинарныйToolStripMenuItem_Click( object sender, EventArgs e )
        {
            dataGridView1.Visible = true;
            
            Clear_f();

            int ind = new_vector.BinarySearch();

            int i = 0;

            foreach ( Vector3D VARIABLE in new_vector.list )
            {
                if ( i == ind )
                {
                    dataGridView1.Rows.Add( VARIABLE.a, VARIABLE.b, VARIABLE.c );

                }

                i++;
            }
        }

        private void заданиеToolStripMenuItem_Click( object sender, EventArgs e )
        {
            ArrayList new_array_of_vectors = new ArrayList();

            foreach (Vector3D v in new_vector.list)
            {
                new_array_of_vectors.Add(v);
            }

            MessageBox.Show( "Новая коллекция создана!" );
        }

        private void выходToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Application.Exit();
            this.Close();
        }
    }
}
