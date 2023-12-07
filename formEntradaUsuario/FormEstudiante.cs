using EntidadesSysacad;
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
        private Sistema sistema;
        private const string rutaImagen = @"C:\Users\Ignacio Pereyra\Desktop\Solution C#\formEntradaUsuario\Imagenes\estudiante.png";
        public FormEstudiante(Estudiante estudiante,Sistema sist)
        {
            InitializeComponent();
            unEstudiante = estudiante;
            this.sistema = sist;
            sistema.FechaLimiteInscripcion += ManejarFechaLimiteInscripcion;
            SimularInicioSesion();
        }

        private void SimularInicioSesion()
        {
                       
            DateTime fechaLimiteInscripcion = new DateTime(2023, 12, 9);
            DateTime fechaActual = DateTime.Now;

            int diasRestantes = (fechaLimiteInscripcion - fechaActual).Days;

            if (diasRestantes <= 7) // Puedes ajustar el número de días según tus necesidades
            {
                sistema.OnFechaLimiteInscripcion(new NotificacionEventArgs($"Quedan {diasRestantes} días para la fecha límite de inscripción a cursos."));
            }
            
    }
    private void ManejarFechaLimiteInscripcion(object sender, NotificacionEventArgs e)
        {
           
            
            string mensaje = $"Notificación de Fecha Límite de Inscripción: {e.Mensaje}";
            MessageBox.Show(mensaje, "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void btn_Inscripcion_Click(object sender, EventArgs e)
        {
            FormMuestraMaterias formInscripcion = new FormMuestraMaterias(unEstudiante,1);
            formInscripcion.ShowDialog();
            if (formInscripcion.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Inscripcion exitosa");
            }
        }

        private void FormEstudiante_Load(object sender, EventArgs e)
        {

            if (unEstudiante.CambiarContrasenia == true)
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
                //MessageBox.Show(unEstudiante.MuestraMateriasConHorarios());
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
                List<Curso> cursos = GestorCursos.ObtieneListaCursos();
                GestorEstudiantes.GuardarListaEstudiantesEnArchivos();
                GestorCursos.GuardaListaCursosEnArchivo();
            }
        }
    }
}
