namespace pjSueldo_Clases_Forms_
{
    public partial class Form1 : Form
    {
        Nomina nm = new Nomina();
        Empleado emp = new Empleado();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            
            
                emp.Nombre = txtNombre.Text;
                emp.Id = txtId.Text;
                emp.AsignacionDia = double.Parse(txtAsignacion.Text);
                nm.DiasLaborados = int.Parse(txtDias.Text);
                MessageBox.Show("Datos Guardados Correctamente");
               
           
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtValor.Text = nm.TotalDevengado(nm.DiasLaborados, emp.AsignacionDia).ToString();
            //los datos nm y emp ya estan convertidos a int,double.  
            // Al final de la linea convertimos el resultado en cadena con .ToString para poder mostrarlo en la caja de texto
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
        //El resultante del dialogo-Mostrar caja-Pregunta caja-Nombre caja
            DialogResult r = MessageBox.Show("¿Esta seguro de salir?","Calculo Nomina",
                                             MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (r == DialogResult.Yes)     //Botones si y no  -  Icono de exclamacion
            {
                this.Close();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtId.Clear();
            txtDias.Clear();
            txtAsignacion.Clear();
            txtValor.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}