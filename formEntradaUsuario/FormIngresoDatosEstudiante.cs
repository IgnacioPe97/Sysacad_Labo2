using CapaDatos;
using EntidadesSysacad;
using LogicaDeNegocio;
using System.Security.Policy;

namespace formEntradaUsuario
{
    public partial class FormIngresoDatosEstudiante : Form
    {
        ValidacionDeDatos validacion = new ValidacionDeDatos();
        List<Estudiante> lista;

        private string nombre;
        private string apellido;
        private string direccion;
        private int dni;
        private int telefono;
        private string correo;
        private string contrasena;
        private Carreras carrera;
        private bool cambiaContrasenia;
        private Turnos  turnoSeleccionado;
        
        public FormIngresoDatosEstudiante()
        {
            InitializeComponent();
            
        }
        private void CargarComboBoxDeCarreras()
        {
            comboBox_Carrera.Items.Add(Carreras.TecnicaturaEnProgramacion);
            comboBox_Carrera.Items.Add(Carreras.Enfermeria);
            comboBox_Carrera.Items.Add(Carreras.Administracion);
            comboBox_Carrera.Items.Add(Carreras.LiquidacionDeSueldos);
            comboBox_Carrera.Items.Add(Carreras.Contabilidad);
            comboBox_Carrera.Items.Add(Carreras.Periodismo);
            comboBox_Carrera.Items.Add(Carreras.AnalistaDeRedes);

            comboBox_Turno.Items.Add(Turnos.Maniana);
            comboBox_Turno.Items.Add(Turnos.Tarde);
            comboBox_Turno.Items.Add(Turnos.Noche);
        }

        private void txt_Nombre_TextChanged(object sender, EventArgs e)
        {


        }

        private void txt_Apellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Correo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Telefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_DNI_TextChanged(object sender, EventArgs e)
        {

        }


        private void FormIngresoDatosEstudiante_Load(object sender, EventArgs e)
        {
            CargarComboBoxDeCarreras();
            lista = GestorEstudiantes.ObtenerListaDeEstudiante();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            
            cambiaContrasenia = checkBox_cambiaContraseña.Checked;
            if (nombre is not null && apellido is not null && dni > 0 && direccion is not null && telefono > 0 && correo is not null && contrasena is not null
                && validacion.EsDniUnico(lista, dni) && carrera > 0)
            {
                Estudiante estudiante = new Estudiante(nombre, apellido, correo, contrasena, dni, telefono, direccion,  cambiaContrasenia,turnoSeleccionado,carrera);
                EstudianteDB est = new EstudianteDB();
                est.Add(estudiante);
                estudiante.CargarDeuda();
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Ingrese todos los datos correspondientes");
            }
        }

        private void txt_Nombre_Leave(object sender, EventArgs e)
        {
            if (!validacion.ValidaNombre(txt_Nombre.Text))
            {
                MessageBox.Show("Ingrese nombre correcto");
                txt_Nombre.Focus();
            }
            else
            {
                nombre = txt_Nombre.Text;
            }
        }

        private void txt_Apellido_Leave(object sender, EventArgs e)
        {
            if (!validacion.ValidaNombre(txt_Apellido.Text))
            {
                MessageBox.Show("Ingrese apellido correcto");
                txt_Apellido.Focus();
            }
            else
            {
                apellido = txt_Apellido.Text;
            }
        }

        private void txt_Correo_Leave(object sender, EventArgs e)
        {
            if (!validacion.ValidacionDeCorreo(txt_Correo.Text))
            {
                MessageBox.Show("Ingrese correo valido");
                txt_Correo.Focus();
            }
            else
            {
                correo = txt_Correo.Text;
            }
        }

        private void txt_Telefono_Leave(object sender, EventArgs e)
        {
            if (!validacion.EsTelefonoValido(txt_Telefono.Text))
            {
                MessageBox.Show("Ingrese solo numeros ");
            }
            else
            {
                if (int.TryParse(txt_Telefono.Text, out int numero))
                {
                    telefono = numero;
                }

            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (txt_direccion.Text is not null)
            {
                direccion = txt_direccion.Text;
            }
            else
            {
                MessageBox.Show("Ingrese una direccion");
                txt_direccion.Focus();

            }
        }

        private void txt_DNI_Leave(object sender, EventArgs e)
        {
            if (!validacion.EsDNIValido(txt_DNI.Text))
            {
                MessageBox.Show("Ingrese dni valido");
                txt_DNI.Focus();
            }
            else
            {
                if (int.TryParse(txt_DNI.Text, out int id))
                {
                    dni = id;
                }
            }
        }

        private void comboBox_Carrera_Leave(object sender, EventArgs e)
        {
            if (comboBox_Carrera.SelectedIndex >= 0)
            {
                Carreras valorSeleccionado = (Carreras)comboBox_Carrera.SelectedIndex;
                carrera = valorSeleccionado;
            }
            else
            {
                MessageBox.Show("Ingrese una carrera");
                comboBox_Carrera.Focus();
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txt_contrasenia.Text is not null)
            {
                contrasena = LogicaDeNegocio.Hash.ObtenerHash(txt_contrasenia.Text);
            }
            else
            {
                MessageBox.Show("Ingrese una contraseña antes de continuar");
                txt_contrasenia.Focus();
            }
        }

        private void comboBox_Turno_Leave(object sender, EventArgs e)
        {
            if (comboBox_Turno.SelectedIndex >= 0)
            {
                Turnos valorSeleccionado = (Turnos)comboBox_Turno.SelectedIndex ;
                turnoSeleccionado = valorSeleccionado;
            }
            else
            {
                MessageBox.Show("Ingrese un horario");
                comboBox_Turno.Focus();
            }
        }
    }
}
