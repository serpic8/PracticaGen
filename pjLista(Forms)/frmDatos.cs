namespace pjLista_Forms_
{
    public partial class frmDatos : Form
    {
        //Lista de tipo objeto
        List<Datos> misDatos = new List<Datos>();
        public frmDatos()
        {
            InitializeComponent();
            //Pa desactivar opciones
            tslConsultar.Enabled = false;
            tslEliminar.Enabled = false;
        }

        private void tslRegistrar_Click(object sender, EventArgs e)
        {
            
        }
        //Validar edad
        private bool ValidarEdad()
        {
            int Edad;
            if (!int.TryParse(txtEdad.Text, out Edad) ||  txtEdad.Text == "")
            {
                erpError.SetError(txtEdad, "Debe ingresar un valor numerico");
                txtEdad.Clear();
                txtEdad.Focus();
                return false;
            }else
            {
                erpError.SetError(txtEdad, "");
                return true;
            }
        }

        //Validar raza
        private bool ValidarRaza()
        {
            if (string.IsNullOrEmpty(cboRaza.Text))
            {
                erpError.SetError(cboRaza, "Debe seleccionar una raza");
                return false;
            }
            else
            {
                erpError.SetError(cboRaza, "");
                return true;
            }
        }

        //Validar el nombre
        private bool ValidarNombre()
        {
            if(string.IsNullOrEmpty(txtNombre.Text))
            {
                erpError.SetError(txtNombre, "Debe ingresar un nombre");
                return false;
            }
            else
            {
                erpError.SetError(txtNombre, "");
                return true;

            }
        }

        private void tslRegistrar_Click_1(object sender, EventArgs e)
        {
            if (ValidarNombre() == false)
            {
                return;
            }
            if (ValidarRaza() == false)
            {
                return;
            }
            if (ValidarEdad() == false)
            {
                return;
            }
            if (Existe(txtNombre.Text))
            {
                erpError.SetError(txtNombre, "Nombre ya registrado");
                txtNombre.Focus();
                return;
            }
            erpError.SetError(txtNombre, "");
            //Luego de validar aqui mandamos la info del formulario para guardar los datos
            Datos dt = new Datos();
            dt.Nombre = txtNombre.Text;
            dt.Edad = int.Parse(txtEdad.Text); 
            dt.Raza = cboRaza.SelectedItem.ToString();

            //Adicionamos el objeto en la lista
            misDatos.Add(dt);
            foreach (Datos item in misDatos)
            {
                ListViewItem fila = new ListViewItem(item.Nombre);
                fila.SubItems.Add(item.Edad.ToString());
                fila.SubItems.Add(item.Raza);
                lvDatos.Items.Add(fila);
            }

            //Para borrar las cajas
            txtNombre.Clear();
            cboRaza.SelectedIndex = -1;
            txtEdad.Clear();

            //Activar opciones al registrar
            tslConsultar.Enabled = true;
        }
        //Mtodo valida q no ingresen con el mismo nombre
        private bool Existe(string nombre)
        {
            foreach (Datos misDts in misDatos)
            {
                if (misDts.Nombre == nombre)
                {
                    return true;
                }
                
            }
            return false; 
        }

        private void tslSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Evento de la opcion consultar (Sirve para que cuando demos en registrar se valieden unos datos)
        private void tslConsultar_Click(object sender, EventArgs e)
        {
            if (ValidarNombre() == false)
            {
                return;
            }
            Datos misDt = GetMascota(txtNombre.Text);
            if (misDt == null)
            {
                erpError.SetError(txtNombre, "No esta registrada en la lista");
                txtNombre.Clear();
                txtEdad.Clear();
                cboRaza.SelectedIndex = -1;
                txtNombre.Focus();
                return;
            }
            else
            {
                erpError.SetError(txtNombre, "");
                txtNombre.Text = misDt.Nombre;
                txtEdad.Text = misDt.Edad.ToString();
                cboRaza.SelectedItem = misDt.Raza;
            }
        }

        //Metodo consultar mascota
        private Datos GetMascota(string nombre)
        {
            return misDatos.Find(mascota => mascota.Nombre.Contains(nombre));
        }

        //Evento de la opcion eliminar
        private void tslEliminar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == null)
            {
                erpError.SetError(txtNombre, "No esta registrada en la lista");
                txtNombre.Clear();
                txtEdad.Clear();
                cboRaza.SelectedIndex = -1;
                txtNombre.Focus();
                
                return;
            }
            else
            {
                erpError.SetError(txtNombre, "");

                DialogResult Respuesta = MessageBox.Show("Esta seguro de eliminar?", "Confirmacion", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (Respuesta == DialogResult.Yes)
                {
                    foreach (Datos miDato in misDatos)
                    {
                        if (miDato.Nombre == txtNombre.Text)
                        {
                            misDatos.Remove(miDato);
                            break;
                        }
                        txtNombre.Clear();
                        txtEdad.Clear();
                        cboRaza.SelectedItem = -1;
                        //Aqui se borra del listview pero ni idea jaja
                    }
                }
            }
        }
    }
}