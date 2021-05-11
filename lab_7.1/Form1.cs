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

        public string[] find_vector_arr = new string[3];
        public ArrayList new_array_of_vectors = new ArrayList();

        DataTable table = new DataTable();

        public Form1()
        {

            InitializeComponent();



            table.Columns.Add("a");
            table.Columns.Add("b");
            table.Columns.Add("c");



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

        private void addd(List<Vector3D> p)
        {
            object[] array = new object[3];

            foreach (Vector3D v in p)
            {
                array[0] = v.A;
                array[1] = v.B;
                array[2] = v.C;
                table.Rows.Add(array);
            }
        }

        private void просмотретьToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Clear_f();

            int rows = 0;

            addd(new_vector.list);


            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = table;


            dataGridView1.Visible = true;


            //foreach ( Vector3D v in new_vector.list )
            //{
            //    dataGridView1 [ 0, rows ].Value = v.a;
            //    dataGridView1 [ 1, rows ].Value = v.b;
            //    dataGridView1 [ 2, rows ].Value = v.c;
            //    rows++;
            //}


            dataGridView1.ReadOnly = true;
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

            table.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            addd(new_vector.list);

            dataGridView1.DataSource = table;

            


            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Visible = true;
            dataGridView1.ReadOnly = true;
        }

        private void загрузитьToolStripMenuItem_Click( object sender, EventArgs e )
        {
            var filePath = string.Empty;

            Clear_f();
             
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; 

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filePath = ofd.FileName;
                MessageBox.Show("Вектор загружен!");
            }

            int count = System.IO.File.ReadAllLines( filePath ).Length;

            string line;
            int i = 0;
            string [] arrString = new string [ count ];

            System.IO.StreamReader file = new System.IO.StreamReader(filePath);

            while ((line = file.ReadLine())!= null & i < count )
            {
                arrString = line.Split(' '); 
                new_vector.add_vector(Convert.ToDouble(arrString[0]),Convert.ToDouble( arrString[1]), Convert.ToDouble(arrString[2]));

                i++;


            }


            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            


        }

        

        private void линейныйToolStripMenuItem_Click( object sender, EventArgs e )
        {

            dataGridView1.Visible = true;


            Clear_f();
            new_vector.line_search();


            

            int i = 0;

            foreach (Vector3D VARIABLE in new_vector.list)
            {
                if (i == new_vector.Index)
                {
                    dataGridView1.Rows.Add(VARIABLE.A, VARIABLE.B, VARIABLE.C);

                }

                i++;
            }


            MessageBox.Show( "Вектор найден!" );
            dataGridView1.ReadOnly = true;

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
                    dataGridView1.Rows.Add( VARIABLE.A, VARIABLE.B, VARIABLE.C );

                }

                i++;
            }
            dataGridView1.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            groupBox1.Visible = false;

            find_vector_arr = textBox1.Text.Split(' ');
            Vector3D find_v = new Vector3D(
                Convert.ToDouble(find_vector_arr[0]),
                Convert.ToDouble(find_vector_arr[1]),
                Convert.ToDouble(find_vector_arr[2])
            );
            foreach (Vector3D v in new_vector.list)
            {
                if (v.vector_lenght(v) < find_v.vector_lenght(find_v))
                {
                    new_array_of_vectors.Add(v);
                }
            }
            foreach (Vector3D VARIABLE in new_array_of_vectors)
            {
                dataGridView1.Rows.Add(VARIABLE.A, VARIABLE.B, VARIABLE.C);
            }

            dataGridView1.Visible = true;
        }

        private void заданиеToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Clear_f();
            groupBox1.Visible = true;

            dataGridView1.ReadOnly = true;
        }

        private void выходToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Application.Exit();
            this.Close();
        }

        
    }
}
