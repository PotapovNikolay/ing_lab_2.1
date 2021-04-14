
namespace lab_8._1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Цемент");
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.mark = new System.Windows.Forms.TextBox();
            this.manufacturer = new System.Windows.Forms.TextBox();
            this.clas = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.Cement_group = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.Cement_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Марка цемента";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Производитель";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 222);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Класс";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 282);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Цена";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(23, 50);
            this.name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(152, 22);
            this.name.TabIndex = 6;
            this.name.Visible = false;
            // 
            // mark
            // 
            this.mark.Location = new System.Drawing.Point(23, 113);
            this.mark.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mark.Name = "mark";
            this.mark.Size = new System.Drawing.Size(152, 22);
            this.mark.TabIndex = 7;
            // 
            // manufacturer
            // 
            this.manufacturer.Location = new System.Drawing.Point(23, 177);
            this.manufacturer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.manufacturer.Name = "manufacturer";
            this.manufacturer.Size = new System.Drawing.Size(152, 22);
            this.manufacturer.TabIndex = 8;
            // 
            // clas
            // 
            this.clas.Location = new System.Drawing.Point(23, 241);
            this.clas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clas.Name = "clas";
            this.clas.Size = new System.Drawing.Size(152, 22);
            this.clas.TabIndex = 9;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(23, 302);
            this.price.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(152, 22);
            this.price.TabIndex = 10;
            // 
            // Cement_group
            // 
            this.Cement_group.Controls.Add(this.price);
            this.Cement_group.Controls.Add(this.clas);
            this.Cement_group.Controls.Add(this.name);
            this.Cement_group.Controls.Add(this.manufacturer);
            this.Cement_group.Controls.Add(this.mark);
            this.Cement_group.Controls.Add(this.label5);
            this.Cement_group.Controls.Add(this.label4);
            this.Cement_group.Controls.Add(this.label3);
            this.Cement_group.Controls.Add(this.label2);
            this.Cement_group.Controls.Add(this.label1);
            this.Cement_group.Location = new System.Drawing.Point(527, 39);
            this.Cement_group.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cement_group.Name = "Cement_group";
            this.Cement_group.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cement_group.Size = new System.Drawing.Size(215, 345);
            this.Cement_group.TabIndex = 11;
            this.Cement_group.TabStop = false;
            this.Cement_group.Text = "Цемент";
            this.Cement_group.Visible = false;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(16, 53);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Узел0";
            treeNode1.Text = "Цемент";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView1.Size = new System.Drawing.Size(462, 499);
            this.treeView1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 622);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.Cement_group);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Cement_group.ResumeLayout(false);
            this.Cement_group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox mark;
        private System.Windows.Forms.TextBox manufacturer;
        private System.Windows.Forms.TextBox clas;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.GroupBox Cement_group;
        private System.Windows.Forms.TreeView treeView1;
    }
}

