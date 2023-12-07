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
    public partial class FormMuestraMaterias : Form
    {
        Estudiante estudiante;
        Profesores unProfesor;
        int numero;
       public List<Curso> listaCurso { get; }
        
        public FormMuestraMaterias(Estudiante estudianteParaInscripcion,int numeroOpcion)
        {
            InitializeComponent();
            estudiante = estudianteParaInscripcion;
            listaCurso = GestorCursos.ObtieneListaCursos();
            dataGridView1.DataSource = listaCurso;
            numero = numeroOpcion;
        }
        public FormMuestraMaterias(int numeroOpcion,Profesores unProfe)
        {
            InitializeComponent();
            numero = numeroOpcion;
              unProfesor = unProfe;
            listaCurso = GestorCursos.ObtieneListaCursos();
            dataGridView1.DataSource = listaCurso;
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Curso unCurso = listaCurso[e.RowIndex];
                if (unCurso is not null && unCurso.CupoMaximo > 0 && numero ==1)
                {
                    DialogResult result = MessageBox.Show($"¿Desea anotarse en este curso?  {unCurso.NombreCurso}", "Confirmación de eliminación", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        if ((estudiante.AgregaMateriaParaAlumno(unCurso) && unCurso.AgregaEstudianteAMateria(estudiante)))
                        {
                           // GestorEstudiantes.ModificaAlumno(estudiante);
                            GestorCursos.ModificaCurso(unCurso);
                            MessageBox.Show("Se ingreso correctamente");
                            DialogResult = DialogResult.OK;

                        }
                        else
                        {
                            MessageBox.Show("Cupo lleno, se anoto a una lista de espera");
                            ListaEsperaDeCurso estudianteParaLista = GestorEstudiantes.ObtieneListaDeEspera(unCurso.CodigoListaEspera); //new EstudianteEnListaEsperaParaCurso(estudiante.Dni,unCurso.CodigoCurso);
                            estudianteParaLista.AgregaEstudianteAListaEspera(estudiante.Dni);
                            GestorEstudiantes.AgregaAListaDeEspera(estudianteParaLista);
                            DialogResult = DialogResult.OK;
                            Close();

                        }
                    }
                }
                else if (numero == 2 && unCurso is not null)
                {
                    DialogResult result = MessageBox.Show($"¿Asigna profesor {unProfesor.Nombre}   {unProfesor.Apellido} este curso?  {unCurso.NombreCurso}", "Confirmación de eliminación", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        unProfesor.AgregaMateriaAProfesor(unCurso.CodigoCurso);
                        unCurso.AgregaProfesorAMateria(unProfesor.NumeroIdentificador);
                        GestorCursos.ModificaCurso(unCurso);
                        GestorProfesores.ModificaProfesor(unProfesor);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Inscripcion cancelada");
                    dataGridView1.Focus();

                }
            }
        }

        private void FormMuestraMaterias_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show($"¿Quiere guardar cambios?", "Confirmación de eliminación", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                GestorEstudiantes.GuardarListaEstudiantesEnArchivos();
            }
        }
    }
}
