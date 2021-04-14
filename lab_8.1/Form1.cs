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
using lab_8._1.cement;

namespace lab_8._1
{


    public partial class Form1 : Form
    {
       

        public ArrayList all_cem = new ArrayList();

        public ArrayList all_clas = new ArrayList();

        public TreeNode root = new TreeNode("frirst");
        public TreeNode root1 = new TreeNode();

        private List_Of_Cements list_of_cement = new List_Of_Cements();

        public Form1()
        {
            InitializeComponent();


            Cement_group.Visible = true;

            //list_of_cement.add_roman("Сибирь","Романцем",300, "Евроцемент груп", 40,3000);
            //list_of_cement.add_roman("Смирновцемент","Романцемент", 300, "Евроцемен", 40, 5000);

            //list_of_cement.add_port("port", 400, "dsads", 40, 5000, "dsa", "dasda", 5000);

            int i = 0;

            //foreach (Romancement r in list_of_cement.list_of_roman)
            //{

            //    treeView1.Nodes[0].Nodes.Add(r.Name_of_cement);
            //    treeView1.Nodes[0].Nodes[0].Nodes.Add(r.Name);
            //}

            //treeView1.EndUpdate();

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Cement_group.Visible = true;

            name.Visible = true;

            //foreach (Romancement r in list_of_cement.list_of_roman)
            //{
            //    name.Text = r.


            //}
        }

        private void treeView1_Click(object sender, EventArgs e)
        {
            Cement_group.Visible = true;
        }

        //private void trre()
        //{
        //    treeView1.Nodes.Clear();
        //    root.Nodes.Clear();

        //    list_of_cement.add_port("port",400,"dsads",40,5000,"dsa","dasda",5000);

        //    foreach (Portlandcementcs p in list_of_cement.list_of_port)
        //    {
        //        root1 = root.Nodes.Add(p.Name_of_cement);
        //        root1.Tag = p.IDHL;
        //    }

        //    treeView1.Nodes.Add(root);
        //}
    }
}
