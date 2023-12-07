using EntidadesSysacad;
using LogicaDeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formEntradaUsuario
{
    public partial class FormIngresoDatosProfesor : Form
    {
        ValidacionDeDatos validacion = new ValidacionDeDatos();
        private string nombre;
        private string apellido;
        private string direccion;
        private int telefono;
        private string correo;
        private string contrasena;
        private int modifica;
        Profesores profeParaModificar;

        public FormIngresoDatosProfesor(int modificar)
        {
            InitializeComponent();
            modifica = modificar;
        }
        public FormIngresoDatosProfesor(int modificar,Profesores unProfe)
        {
            InitializeComponent();
            modifica = modificar;
            profeParaModificar = unProfe;
        }

        private void FormIngresoDatosProfesor_Load(object sender, EventArgs e)
        {
            if (modifica == 2)
            {
                CargaDatosModificacion();
            }
        }
        private void CargaDatosModificacion()
        {

            txt_Apellido.Text = profeParaModificar.Apellido;
            txt_Nombre.Text = profeParaModificar.Nombre;
            txt_Telefono.Text = profeParaModificar.Telefono.ToString();
            txt_Correo.Text = profeParaModificar.Correo;
            txt_contrasenia.Text = profeParaModificar.Contrasenia; 
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
            if (!validacion.ValidacionDeCorreo(txt_Correo.Text) && !GestorProfesores.VerificaCorreoDuplicado(txt_Correo.Text))
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

        private void txt_contrasenia_Leave(object sender, EventArgs e)
        {
            if (txt_contrasenia.Text is not null)
            {
                contrasena = Hash.ObtenerHash(txt_contrasenia.Text);
            }
            else
            {
                MessageBox.Show("Ingrese una contraseña antes de continuar");
                txt_contrasenia.Focus();
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (nombre is not null && apellido is not null  && telefono > 0 && correo is not null && contrasena is not null)
            {
                Profesores nuevoProfe = new Profesores(nombre, apellido, correo, contrasena, telefono);
                bool retorno;
                retorno = GestorProfesores.AgregaProfesor(nuevoProfe);
                if (retorno)
                {
                    MessageBox.Show("Profesor Agregado Correctamente");
                    DialogResult = DialogResult.OK;
                    Close();
                }
               
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
