using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace lab_8._3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            Program.f1 = this;
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            setToolStripMenuItem.Size = new Size(5,5);
            Color new1 = new Color();
            new1 = Color.FromArgb(33, 37, 41);
            setToolStripMenuItem.BackColor = new1;
            menuStrip1.Size = new Size(5,5);
            menuStrip1.Left = 1475;
            menuStrip1.Top = 5;
            menuStrip1.BackColor = new1;
            button2.Size = new Size(20,20);
            button2.Left = 1505;
            button2.Top = 7;

            treeView1.ContextMenuStrip = contextMenuStrip1;

            delToolStripMenuItem.Click += cf.Del_Click;


        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();

            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(this.button1, "Показывает иерархию классов");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Size Screen = SystemInformation.PrimaryMonitorSize;
            Location = new Point(Screen.Width - Width, Screen.Height - Height);
        }



        public Wood_F wf = new Wood_F();

        public Cement_F cf = new Cement_F();

        public Gips_F gf = new Gips_F();


        public DataTable table = new DataTable();

        public DataTable table2 = new DataTable();

        public DataTable table3 = new DataTable();

        public TreeNode node = new TreeNode();


        public List_Of_Cements list_of_cemetns = new List_Of_Cements();
        public List_of_wood list_of_wood = new List_of_wood();
        public List_of_Gips list_of_gips = new List_of_Gips();


        public int ind { get; set; }

        public void nodes(int index, DataTable y)
        {
            string x = " ";

            foreach (DataRow v in y.Rows)
            {
                node.Nodes[index].Nodes.Add(v[0].ToString());
            }


            for (int k = 0; k < node.Nodes[index].Nodes.Count; k++)
            {

                if (x.Contains(node.Nodes[index].Nodes[k].Text) /*node.Nodes[index].Nodes[k].Text != x*/)
                {
                    node.Nodes[index].Nodes.Remove(node.Nodes[index].Nodes[k]);
                    k--;
                }
                else
                {

                    x += node.Nodes[index].Nodes[k].Text;

                }
            }

            foreach (DataColumn col in y.Columns)
            {
                if (col.ColumnName == "Name")
                {
                    foreach (DataRow row in y.Rows)
                    {
                        switch (row[col.ColumnName].ToString())
                        {
                            case "Портланд":
                                node.Nodes[index].Nodes[0].Nodes.Add(row[1].ToString());
                                break;
                            case "Романцемент":
                                node.Nodes[index].Nodes[1].Nodes.Add(row[1].ToString());
                                break;
                            case "Алумацемент":
                                node.Nodes[index].Nodes[2].Nodes.Add(row[1].ToString());
                                break;
                            case "Блок-паркет":
                                node.Nodes[index].Nodes[0].Nodes.Add(row[0].ToString());
                                node.Nodes[index].Nodes.RemoveAt(3);
                                break;
                            case "Ламинат":
                                node.Nodes[index].Nodes[0].Nodes.Add(row[0].ToString());
                                node.Nodes[index].Nodes.RemoveAt(3);
                                break;
                            case "Цельный паркет":
                                node.Nodes[index].Nodes[0].Nodes.Add(row[0].ToString());
                                node.Nodes[index].Nodes.RemoveAt(3);
                                break;
                            case "Паркетная доска":
                                node.Nodes[index].Nodes[0].Nodes.Add(row[0].ToString());
                                node.Nodes[index].Nodes.RemoveAt(3);
                                break;
                        }
                    }
                }
            }
        }



        public DataTable todada<T>(IList<T> data, string[] str, DataTable x)
        {

            PropertyDescriptorCollection props =
                TypeDescriptor.GetProperties(typeof(T));

            props = props.Sort(str);

            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                if (x.Columns.Contains(prop.Name))
                {
                }
                else
                {
                    x.Columns.Add(prop.Name, typeof(string));
                }

            }


            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }

                x.Rows.Add(values);
            }

            return x;
        }

        public void clear_table()
        {
            table.Clear();
            table.Columns.Clear();
        }
 

        private void button1_Click(object sender, EventArgs e)
        {
            panel7.Visible = true;
            button1.BackgroundImage = Image.FromFile(@"C:\Users\npota\OneDrive\Рабочий стол\гамно\4-й сем\ПИ\9\toggle_on1600.png", false);


            string[] x1 = new string[]
            {
                "Name", "NameOfCement", "Brand", "Manufacturer", "Clas", "price", "IDHL", "types"
            };

            string[] x2 = new string[]
            {
                "Name", "type_of_wood", "Lenght", "Width", "Thickness"
            };

            string[] x3 = new string[]
            {
                "nameofgips", "Name", "setting_time", "manufacturer"

            };


            node.Text = "Строительные материалы";

            node.Nodes.Add("Цемент");
            node.Nodes.Add("Древесина");
            node.Nodes.Add("Гипс");

            //цемент
            list_of_cemetns.add_roman("Романцемент", "Сибирь", 500, "Сибирцемент", 40, 5000);
            list_of_cemetns.add_roman("Романцемент", "Вихрь", 600, "РосЦемент", 50, 3000);
            list_of_cemetns.add_port("Портланд", "Прой", 500, "Востокцемент", 50, 4500, 5000, "быстро");
            list_of_cemetns.add_aluma("Алумацемент", "Метель", 600, "РосЦемент", 50, 5500);
            list_of_cemetns.add_aluma("Алумацемент", "Смаи", 600, "Альфацемент", 50, 2000);
            list_of_cemetns.add_aluma("Алумацемент", "Пробой", 600, "Морото", 40, 6500);

            switch (cf.textBox3.Text)
            {
                case "Портланд":
                    list_of_cemetns.list_of_port.RemoveAt(Convert.ToInt32(cf.textBox2.Text));
                    list_of_cemetns.add_port("Портланд", cf.textBox1.Text, Convert.ToInt32(cf.Brand.Text),
                        cf.Manufactur.Text, Convert.ToInt32(cf.Clas.Text), Convert.ToInt32(cf.Price.Text),
                        Convert.ToInt32(cf.IDHL.Text), cf.types.Text);
                    break;
                case "Романцемент":
                    list_of_cemetns.list_of_roman.RemoveAt(Convert.ToInt32(cf.textBox2.Text));
                    list_of_cemetns.add_roman("Романцемент", cf.textBox1.Text, Convert.ToInt32(cf.Brand.Text),
                        cf.Manufactur.Text, Convert.ToInt32(cf.Clas.Text), Convert.ToInt32(cf.Price.Text));
                    break;
                case "Алумацемент":
                    list_of_cemetns.list_of_aluma.RemoveAt(Convert.ToInt32(cf.textBox2.Text));
                    list_of_cemetns.add_aluma("Алумацемент", cf.textBox1.Text, Convert.ToInt32(cf.Brand.Text),
                        cf.Manufactur.Text, Convert.ToInt32(cf.Clas.Text), Convert.ToInt32(cf.Price.Text));
                    break;
            }



            //привязка к датагрид
            todada(list_of_cemetns.list_of_port, x1, table);
            todada(list_of_cemetns.list_of_roman, x1, table);
            todada(list_of_cemetns.list_of_aluma, x1, table);

            nodes(0, table);

            //серриализация

            //SerializeXML(list_of_cemetns.list_of_roman);
            //SerializeXML(list_of_cemetns.list_of_port);


            //древесина

            list_of_wood.add_plywood(200, 40, 50, "Фанера", "целый", 2);
            list_of_wood.add_dvp(2350, 60, 20, "ДBП", "не целый");
            list_of_wood.add_dsp(250, 50, 20, "ДCП", "не целый");

            list_of_wood.add_blockparquet(300, 70, 16, "Блок-паркет", "целый");
            list_of_wood.add_laminate(500, 55, 25, "Ламинат", "целый", 2);
            list_of_wood.add_massive_parquet(300, 70, 16, "Цельный паркет", "целый", 2);
            list_of_wood.add_pqruet_board(200, 100, 23, "Паркетная доска", "целый", 2);

            if (cf.textBox3.Text == "Фанера")
            {
                switch (cf.textBox1.Text)
                {
                    case "Блок-паркет":
                        list_of_wood.list_of_blockparguet.RemoveAt(Convert.ToInt32(cf.textBox2.Text));
                        list_of_wood.add_blockparquet(Convert.ToInt32(wf.Lenght.Text), Convert.ToInt32(wf.Widt.Text),
                            Convert.ToInt32(wf.Thicnes.Text), cf.textBox1.Text, wf.type_of_wood.Text);
                        break;
                    case "Ламинат":
                        list_of_wood.list_of_laminate.RemoveAt(Convert.ToInt32(cf.textBox2.Text));
                        list_of_wood.add_laminate(Convert.ToInt32(wf.Lenght.Text), Convert.ToInt32(wf.Widt.Text),
                            Convert.ToInt32(wf.Thicnes.Text), cf.textBox1.Text,
                            wf.type_of_wood.Text, Convert.ToInt32(wf.coating));
                        break;

                    case "цельный паркет":
                        list_of_wood.list_massive_parguet.RemoveAt(Convert.ToInt32(cf.textBox2.Text));
                        list_of_wood.add_massive_parquet(Convert.ToInt32(wf.Lenght.Text), Convert.ToInt32(wf.Widt.Text),
                            Convert.ToInt32(wf.Thicnes.Text), cf.textBox1.Text, wf.type_of_wood.Text,
                            Convert.ToInt32(wf.coating));
                        break;

                    case "Паркетная доска":
                        list_of_wood.list_of_parquet_board.RemoveAt(Convert.ToInt32(cf.textBox2.Text));
                        list_of_wood.add_pqruet_board(Convert.ToInt32(wf.Lenght.Text), Convert.ToInt32(wf.Widt.Text),
                            Convert.ToInt32(wf.Thicnes.Text), cf.textBox1.Text,
                            wf.type_of_wood.Text, Convert.ToInt32(wf.coating));
                        break;
                }
            }

            switch (cf.textBox1.Text)
            {
                case "Фанера":
                    list_of_wood.list_of_plywood.RemoveAt(Convert.ToInt32(cf.textBox2.Text));
                    list_of_wood.add_plywood(Convert.ToInt32(wf.Lenght.Text), Convert.ToInt32(wf.Widt.Text),
                        Convert.ToInt32(wf.Thicnes.Text), cf.textBox1.Text,
                        wf.type_of_wood.Text, Convert.ToInt32(wf.coating));

                    break;

                case "ДВП":
                    list_of_wood.list_of_dvp.RemoveAt(Convert.ToInt32(cf.textBox2.Text));
                    list_of_wood.add_dvp(Convert.ToInt32(wf.Lenght.Text), Convert.ToInt32(wf.Widt.Text),
                        Convert.ToInt32(wf.Thicnes.Text), cf.textBox1.Text, wf.type_of_wood.Text);
                    break;

                case "ДСП":
                    list_of_wood.list_of_dsp.RemoveAt(Convert.ToInt32(cf.textBox2.Text));
                    list_of_wood.add_dsp(Convert.ToInt32(wf.Lenght.Text), Convert.ToInt32(wf.Widt.Text),
                        Convert.ToInt32(wf.Thicnes.Text), cf.textBox1.Text, wf.type_of_wood.Text);
                    break;


            }

            //привязка к датагрид
            todada(list_of_wood.list_of_plywood, x2, table2);
            todada(list_of_wood.list_of_dvp, x2, table2);
            todada(list_of_wood.list_of_dsp, x2, table2);

            todada(list_of_wood.list_of_blockparguet, x2, table2);
            todada(list_of_wood.list_of_laminate, x2, table2);
            todada(list_of_wood.list_massive_parguet, x2, table2);
            todada(list_of_wood.list_of_parquet_board, x2, table2);

            nodes(1, table2);


            // Гипс

            list_of_gips.add_fast("Гипс", "Быстротвердеющий", "Гипстрой", 10);
            list_of_gips.add_norm("Гипс", "Нормальнотвердеющий", "УралГипс", 20);
            list_of_gips.add_slow("Гипс", "Медленнотвердеющий", "Минерал-хорс", 100);


            switch (cf.textBox1.Text)
            {
                case "Быстротвердеющий":
                    list_of_gips.list_of_fast.RemoveAt(Convert.ToInt32(cf.textBox2.Text));
                    list_of_gips.add_fast(gf.nam.Text,gf.type_gips.Text, gf.manufactur.Text, Convert.ToInt32(gf.tim));
                    break;
                case "Нормальнотвердеющий":
                    list_of_gips.list_of_norm.RemoveAt(Convert.ToInt32(cf.textBox2.Text));
                    list_of_gips.add_norm(gf.nam.Text, gf.type_gips.Text, gf.manufactur.Text, Convert.ToInt32(gf.tim));
                    break;
                case "Медленнотвердеющий":
                    list_of_gips.list_of_slow.RemoveAt(Convert.ToInt32(cf.textBox2.Text));
                    list_of_gips.add_slow(gf.nam.Text, gf.type_gips.Text, gf.manufactur.Text, Convert.ToInt32(gf.tim));
                    break; ;
            }



            //привязка к датагрид

            todada(list_of_gips.list_of_fast, x3, table3);
            todada(list_of_gips.list_of_norm, x3, table3);
            todada(list_of_gips.list_of_slow, x3, table3);

            nodes(2, table3);


            treeView1.Nodes.Add(node);

        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {


        }

        public void cler()
        {
            Program.f1.table.Clear();
            Program.f1.table2.Clear();
            Program.f1.table3.Clear();

            Program.f1.treeView1.Nodes[0].Nodes[0].Nodes.Clear();
            Program.f1.treeView1.Nodes[0].Nodes.Clear();
            Program.f1.node.Nodes.Clear();
            Program.f1.treeView1.Nodes.Clear();


            Program.f1.list_of_cemetns.list_of_port.Clear();
            Program.f1.list_of_cemetns.list_of_aluma.Clear();
            Program.f1.list_of_cemetns.list_of_roman.Clear();
            Program.f1.list_of_wood.list_of_blockparguet.Clear();
            Program.f1.list_of_wood.list_of_parquet_board.Clear();
            Program.f1.list_of_wood.list_of_dvp.Clear();
            Program.f1.list_of_wood.list_of_laminate.Clear();
            Program.f1.list_of_wood.list_of_plywood.Clear();
            Program.f1.list_of_wood.list_of_dsp.Clear();
            Program.f1.list_of_wood.list_massive_parguet.Clear();


            Program.f1.list_of_gips.list_of_norm.Clear();
            Program.f1.list_of_gips.list_of_slow.Clear();
            Program.f1.list_of_gips.list_of_fast.Clear();


        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                cf.textBox1.Text = treeView1.SelectedNode.Text;
                ind = treeView1.SelectedNode.Nodes.IndexOf(treeView1.SelectedNode);
                cf.textBox2.Text = treeView1.SelectedNode.Index.ToString();
                cf.textBox3.Text = treeView1.SelectedNode.Parent.Text;
            }
            catch 
            {
                MessageBox.Show("выберите ветвь");
            }


            foreach (DataRow rows in table2.Rows)
            {
                if (treeView1.SelectedNode.Text == rows[0].ToString())
                {
                    wf.Lenght.Text = rows[2].ToString();
                    wf.Widt.Text = rows[3].ToString();
                    wf.Thicnes.Text = rows[4].ToString();
                    wf.type_of_wood.Text = rows[1].ToString();
                    if (rows[5] != null)
                    {
                        wf.coating.Text = rows[5].ToString();
                    }
                }

            }

            foreach (DataRow rows in table.Rows)
            {

                if (treeView1.SelectedNode.Text == rows[1].ToString())
                {
                    
                    
                    cf.Brand.Text = rows[2].ToString();
                    cf.Manufactur.Text = rows[3].ToString();
                    cf.Clas.Text = rows[4].ToString();
                    cf.Price.Text = rows[5].ToString();

                    if (treeView1.SelectedNode.Text=="Прой")
                    {
                        cf.IDHL.Text = rows[6].ToString();
                        cf.types.Text = rows[7].ToString();
                        cf.IDHL.Visible = true;
                        cf.types.Visible = true;
                        
                    }
                    else
                    {
                        cf.IDHL.Visible = false;
                        cf.types.Visible = false;
                    }

                    if (flag1 == true)
                    {

                    }

                }
            }

            foreach (DataRow rows in table3.Rows)
            {
                if (treeView1.SelectedNode.Text == rows[0].ToString())
                {
                    gf.manufactur.Text = rows[2].ToString();
                    gf.tim.Text = rows[3].ToString();
                }

            }

            switch (treeView1.SelectedNode.Text)
            {
                case "Древесина":
                    
                    cf.Hide();
                    gf.Hide();
                    wf.Show();
                    wf.Owner = this;
                    break;
                case "Цемент":
                    gf.Hide();
                    wf.Hide();
                    cf.Show();
                    cf.Owner = this;
                    break;
                case "Гипс":
                    cf.Hide();
                    wf.Hide();
                    gf.Show();
                    gf.Owner = this;
                    break;
                    ;
            }

        }

        public bool flag1 = false;

        private Point MouseDownLocation;

        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }
        

        private void treeView1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                treeView1.Left = e.X + treeView1.Left - MouseDownLocation.X;
                treeView1.Top = e.Y + treeView1.Top - MouseDownLocation.Y;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void delToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }

        private void свернутьВетвьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            treeView1.SelectedNode.Collapse();
            
            
        }

        private void развернутьВетвьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Expand();

            
        }


        private void SerializeXM(List_Of_Cements list, List_of_Gips list1, List_of_wood list2)
        {
            XmlSerializer xml = new XmlSerializer(typeof(List_Of_Cements));


            using (FileStream fs = new FileStream("cemnt.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, list);
            }

            XmlSerializer xml1 = new XmlSerializer(typeof(List_of_Gips));

            using (FileStream fs1 = new FileStream("gips.xml", FileMode.OpenOrCreate))
            {
                xml1.Serialize(fs1, list1);
            }

            XmlSerializer xml2 = new XmlSerializer(typeof(List_of_wood));

            using (FileStream fs2 = new FileStream("wood.xml", FileMode.OpenOrCreate))
            {
                xml2.Serialize(fs2, list2);
            }
        }



        private void записьВXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SerializeXM(list_of_cemetns,list_of_gips,list_of_wood);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void setToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
