using LogicaDeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formEntradaUsuario
{
    public partial class FormEstudiante : Form
    {
        Estudiante unEstudiante;
        private const string rutaImagen = @"C:\Users\Ignacio Pereyra\Desktop\Solution C#\formEntradaUsuario\Imagenes\estudiante.png";
        public FormEstudiante(Estudiante estudiante)
        {
            InitializeComponent();
            unEstudiante = estudiante;
        }

        private void btn_Inscripcion_Click(object sender, EventArgs e)
        {
            FormMuestraMaterias formInscripcion = new FormMuestraMaterias(unEstudiante);
            formInscripcion.ShowDialog();
            if (formInscripcion.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Inscripcion exitosa");
            }
        }

        private void FormEstudiante_Load(object sender, EventArgs e)
        {

            if (unEstudiante.CambiarContrasenia)
            {
                FormCambiaContrasenia formCambiaContrasenia = new FormCambiaContrasenia(unEstudiante);
                formCambiaContrasenia.Owner = this;
                DialogResult result = formCambiaContrasenia.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.Activate();
                }
            }


            label1.Text = unEstudiante.Nombre + " " + unEstudiante.Apellido;
            CambiarTamanioImagen();
        }
        private void CambiarTamanioImagen()
        {
            Image imagenEstudiante = Image.FromFile(rutaImagen);
            picture_Estudiante.SizeMode = PictureBoxSizeMode.CenterImage;
            int ancho = 50;
            int alto = 50;
            imagenEstudiante = new Bitmap(imagenEstudiante, ancho, alto);
            picture_Estudiante.Image = imagenEstudiante;
            picture_Estudiante.Size = new Size(ancho, alto);

        }

        private void FormEstudiante_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form1)this.Owner).Show();
            //this.Close();
        }

        private void btn_Horarios_Click(object sender, EventArgs e)
        {
            if (unEstudiante.MateriasAnotadas.Count > 0)
            {
                List<Curso> cursos = unEstudiante.MateriasAnotadas;
                Turnos numeroTurno = unEstudiante.TurnoSeleccionado;
                foreach (Curso item in cursos)
                {
                    if (item.Horario.Count == 0)
                    {
                        item.AsignaAulaParaCurso(item);
                        item.AsignaHorarioParaCurso(item, numeroTurno);
                    }
                }
                MessageBox.Show(unEstudiante.MuestraMateriasConHorarios());
            }
            else
            {
                MessageBox.Show("No hay materias anotadas");
            }
        }

        private void btn_RealizarPagos_Click(object sender, EventArgs e)
        {
            FormMuestraCuotas muestraCuotas = new FormMuestraCuotas(unEstudiante);
            DialogResult dialog = muestraCuotas.ShowDialog();

        }

        private void FormEstudiante_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show($"¿Confirma los cambios? ", "Confirmación de eliminación", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                GestorEstudiantes.GuardarListaEstudiantesEnArchivos();
                GestorCursos.GuardaListaCursosEnArchivo();
            }
          

        }
    }
}
