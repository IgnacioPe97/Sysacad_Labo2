using LogicaDeNegocio;
using NPOI.SS.Formula.Functions;
using static formEntradaUsuario.Form1;
using System.Runtime.ConstrainedExecution;
using EntidadesSysacad;
using System.Net.Http.Headers;

namespace formEntradaUsuario
{

    public partial class Form1 : Form
    {
        ValidacionDeDatos validacion = new ValidacionDeDatos();
        List<Administrador> listaAdmin;
        private string mail;
        private string contrasenia;
        Administrador administrador;
        Estudiante estudianteInicio;

        public Form1()
        {
            InitializeComponent();
            //listaAdmin = archivo.DeserializarUnaLista<Administrador>("Administradores.json");
            administrador = new Administrador("ignacio", "Pereyra", "q@gmail.com", "hola");


        }


        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            mail = txt_Usuario.Text;
            contrasenia = txt_Contrasenia.Text;
            estudianteInicio = GestorEstudiantes.AutenticaEstudiante(mail,contrasenia);
            if (estudianteInicio is not null)
            {
                     Sistema sist = new Sistema();
                    FormEstudiante formEstudiante = new FormEstudiante(estudianteInicio,sist);
                    formEstudiante.Owner = this;
                    this.Hide();
                    formEstudiante.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No hay estudiante registrado");
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GestorAdministrador.CargaListaGestor(listaAdmin);
        }

        private void btn_Administrador_Click(object sender, EventArgs e)
        {
            try
            {

                if (administrador is not null)
                {
                    txt_Usuario.Text = administrador.Correo;
                    txt_Contrasenia.Text = administrador.Contrasenia;
                    FormAdministrador formAdmin = new FormAdministrador(administrador);
                    formAdmin.Owner = this;
                    this.Hide();
                    formAdmin.ShowDialog();

                }
                else
                {
                    MessageBox.Show("No hay administrador registrado");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }



    }
}