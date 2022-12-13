namespace pjLista_Forms_
{
    partial class frmDatos
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
            this.components = new System.ComponentModel.Container();
            this.tsmMenu = new System.Windows.Forms.ToolStrip();
            this.tslRegistrar = new System.Windows.Forms.ToolStripLabel();
            this.tslConsultar = new System.Windows.Forms.ToolStripLabel();
            this.tslEliminar = new System.Windows.Forms.ToolStripLabel();
            this.tslSalir = new System.Windows.Forms.ToolStripLabel();
            this.tslAcerca = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboRaza = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
            this.tsmMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
            this.SuspendLayout();
            // 
            // tsmMenu
            // 
            this.tsmMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslRegistrar,
            this.tslConsultar,
            this.tslEliminar,
            this.tslSalir,
            this.tslAcerca});
            this.tsmMenu.Location = new System.Drawing.Point(0, 0);
            this.tsmMenu.Name = "tsmMenu";
            this.tsmMenu.Size = new System.Drawing.Size(800, 25);
            this.tsmMenu.TabIndex = 0;
            this.tsmMenu.Text = "toolStrip1";
            // 
            // tslRegistrar
            // 
            this.tslRegistrar.Name = "tslRegistrar";
            this.tslRegistrar.Size = new System.Drawing.Size(53, 22);
            this.tslRegistrar.Text = "Registrar";
            // 
            // tslConsultar
            // 
            this.tslConsultar.Name = "tslConsultar";
            this.tslConsultar.Size = new System.Drawing.Size(58, 22);
            this.tslConsultar.Text = "Consultar";
            // 
            // tslEliminar
            // 
            this.tslEliminar.Name = "tslEliminar";
            this.tslEliminar.Size = new System.Drawing.Size(50, 22);
            this.tslEliminar.Text = "Eliminar";
            // 
            // tslSalir
            // 
            this.tslSalir.Name = "tslSalir";
            this.tslSalir.Size = new System.Drawing.Size(29, 22);
            this.tslSalir.Text = "Salir";
            // 
            // tslAcerca
            // 
            this.tslAcerca.Name = "tslAcerca";
            this.tslAcerca.Size = new System.Drawing.Size(59, 22);
            this.tslAcerca.Text = "Acerca de";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Edad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Raza";
            // 
            // cboRaza
            // 
            this.cboRaza.FormattingEnabled = true;
            this.cboRaza.Location = new System.Drawing.Point(197, 198);
            this.cboRaza.Name = "cboRaza";
            this.cboRaza.Size = new System.Drawing.Size(121, 23);
            this.cboRaza.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(197, 94);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 23);
            this.txtNombre.TabIndex = 6;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(197, 147);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(121, 23);
            this.txtEdad.TabIndex = 7;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(74, 276);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(448, 150);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // erpError
            // 
            this.erpError.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cboRaza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tsmMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tsmMenu.ResumeLayout(false);
            this.tsmMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip tsmMenu;
        private ToolStripLabel tslRegistrar;
        private ToolStripLabel tslConsultar;
        private ToolStripLabel tslEliminar;
        private ToolStripLabel tslSalir;
        private ToolStripLabel tslAcerca;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cboRaza;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private ListView listView1;
        private ErrorProvider erpError;
    }
}