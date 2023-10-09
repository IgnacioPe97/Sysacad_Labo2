using LogicaDeNegocio;

namespace formEntradaUsuario
{
    public partial class FormAdministrador : Form
    {
        Administrador administrador;
        private const string rutaImagen = @"C:\Users\Ignacio Pereyra\Desktop\Solution C#\formEntradaUsuario\Imagenes\admin.png";

        public FormAdministrador(Administrador elAdmin)
        {
            InitializeComponent();
            administrador = elAdmin;
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            FormIngresoDatosEstudiante ingresoEstudiante = new FormIngresoDatosEstudiante();
            ingresoEstudiante.ShowDialog();
            if (ingresoEstudiante.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Estudiante registrado correctamente");
            }
            else
            {
                MessageBox.Show("Error en el registro");
            }
        }

        private void btn_GestionarCursos_Click(object sender, EventArgs e)
        {
            FormABMCursos formABMCursos = new FormABMCursos();
            formABMCursos.ShowDialog();
            if (formABMCursos.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Gestion realizada");
            }
        }
        private void FormAdministrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form1)this.Owner).Show();
        }

        private void FormAdministrador_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show($"¿Confirma los cambios? ", "Confirmación de eliminación", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                GestorEstudiantes.GuardarListaEstudiantesEnArchivos();
                GestorCursos.GuardaListaCursosEnArchivo();
            }
        }

        private void FormAdministrador_Load(object sender, EventArgs e)
        {
            txt_nombreUsuario.Text = administrador.Nombre + administrador.Apellido;
            CambiarTamanioImagen();
        }
        private void CambiarTamanioImagen()
        {
            Image imagenAdmin = Image.FromFile(rutaImagen);
            picture_Admin.SizeMode = PictureBoxSizeMode.CenterImage;
            int ancho = 50;
            int alto = 50;
            imagenAdmin = new Bitmap(imagenAdmin, ancho, alto);
            picture_Admin.Image = imagenAdmin;
            picture_Admin.Size = new Size(ancho, alto);

        }
    }
}
