using LogicaDeNegocio;
using NPOI.SS.Formula.Functions;
using static formEntradaUsuario.Form1;
using System.Runtime.ConstrainedExecution;


namespace formEntradaUsuario
{

    public partial class Form1 : Form
    {
        ValidacionDeDatos validacion = new ValidacionDeDatos();
        Serializacion archivo = new Serializacion();
        List<Curso> listaCursos;
        List<Administrador> listaAdmin;
        List<Estudiante> estudiantes;
        private string mail;
        private string contrasenia;
        Administrador administrador;
        Estudiante estudianteInicio;

        public Form1()
        {
            InitializeComponent();
            listaAdmin = archivo.DeserializarUnaLista<Administrador>("Administradores.json");
            listaCursos = archivo.DeserializarUnaDeCursos("Cursos.json");
            estudiantes = archivo.DeserializarUnaListaEstudianteJson<Estudiante>("EstudiantesJson.json", listaCursos);
            administrador = new Administrador("ignacio", "Pereyra", "q@gmail.com", "hola");
            estudianteInicio = new Estudiante("carlo", "sanche", "lool@gmail.ocm", "lolo", 12345678, 112346778, "sss", false, Turnos.Noche);

        }


        private void btn_Ingresar_Click(object sender, EventArgs e)
        {

            try
            {

                if (estudianteInicio is not null)
                {
                    txt_Usuario.Text = estudianteInicio.Correo;
                    txt_Contrasenia.Text = estudianteInicio.Contrasenia;
                    estudianteInicio = Estudiante.DevuelveEstudianteRandomDeLista(estudiantes);
                    FormEstudiante formEstudiante = new FormEstudiante(estudianteInicio);
                    formEstudiante.Owner = this;
                    this.Hide();
                    formEstudiante.ShowDialog();

                }
                else
                {
                    MessageBox.Show("No hay estudiante registrado");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GestorCursos.CargaListaGestor(listaCursos);
            GestorAdministrador.CargaListaGestor(listaAdmin);
            GestorEstudiantes.GuardarListaEstudiantesEnArchivos();
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