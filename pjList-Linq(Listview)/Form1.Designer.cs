namespace pjList_Linq_Listview_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvAutores = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAutoresLibros = new System.Windows.Forms.Label();
            this.lvEl = new System.Windows.Forms.ListView();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.label5 = new System.Windows.Forms.Label();
            this.lvCantidad = new System.Windows.Forms.ListView();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lvAutores
            // 
            this.lvAutores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvAutores.GridLines = true;
            this.lvAutores.Location = new System.Drawing.Point(12, 12);
            this.lvAutores.Name = "lvAutores";
            this.lvAutores.Size = new System.Drawing.Size(371, 121);
            this.lvAutores.TabIndex = 0;
            this.lvAutores.UseCompatibleStateImageBehavior = false;
            this.lvAutores.View = System.Windows.Forms.View.Details;
            this.lvAutores.SelectedIndexChanged += new System.EventHandler(this.lvAutores_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Autores";
            this.columnHeader2.Width = 300;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(490, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(39, 177);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(263, 112);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nombres";
            this.columnHeader3.Width = 200;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(405, 190);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(214, 90);
            this.listView2.TabIndex = 4;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Id";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nombres";
            this.columnHeader5.Width = 180;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "lv con id par";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad Autores";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(405, 83);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(38, 15);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Autor con mas libros";
            // 
            // lblAutoresLibros
            // 
            this.lblAutoresLibros.AutoSize = true;
            this.lblAutoresLibros.Location = new System.Drawing.Point(53, 332);
            this.lblAutoresLibros.Name = "lblAutoresLibros";
            this.lblAutoresLibros.Size = new System.Drawing.Size(38, 15);
            this.lblAutoresLibros.TabIndex = 9;
            this.lblAutoresLibros.Text = "label5";
            // 
            // lvEl
            // 
            this.lvEl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7});
            this.lvEl.GridLines = true;
            this.lvEl.Location = new System.Drawing.Point(39, 397);
            this.lvEl.Name = "lvEl";
            this.lvEl.Size = new System.Drawing.Size(212, 97);
            this.lvEl.TabIndex = 10;
            this.lvEl.UseCompatibleStateImageBehavior = false;
            this.lvEl.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Autor";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Libro";
            this.columnHeader7.Width = 100;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "libros q comienzan por el";
            // 
            // lvCantidad
            // 
            this.lvCantidad.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9});
            this.lvCantidad.GridLines = true;
            this.lvCantidad.Location = new System.Drawing.Point(357, 339);
            this.lvCantidad.Name = "lvCantidad";
            this.lvCantidad.Size = new System.Drawing.Size(173, 162);
            this.lvCantidad.TabIndex = 12;
            this.lvCantidad.UseCompatibleStateImageBehavior = false;
            this.lvCantidad.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Autor";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Cantidad Libros";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 506);
            this.Controls.Add(this.lvCantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lvEl);
            this.Controls.Add(this.lblAutoresLibros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvAutores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lvAutores;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button button1;
        private Label label1;
        private ListView listView1;
        private ColumnHeader columnHeader3;
        private ListView listView2;
        private Label label2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label label3;
        private Label lblCantidad;
        private Label label4;
        private Label lblAutoresLibros;
        private ListView lvEl;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Label label5;
        private ListView lvCantidad;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
    }
}