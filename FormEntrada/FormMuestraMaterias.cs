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
        List<Curso> listaCurso;
        public FormMuestraMaterias(Estudiante estudianteParaInscripcion )
        {
            InitializeComponent();
            estudiante = estudianteParaInscripcion;
            listaCurso = GestorCursos.ObtieneListaCursos();
            dataGridView1.DataSource = listaCurso;

        }
     

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Curso unCurso = listaCurso[e.RowIndex];
                if (unCurso is not null && unCurso.CupoMaximo > 0 )
                {
                    DialogResult result = MessageBox.Show($"¿Desea anotarse en este curso?  {unCurso.NombreCurso}", "Confirmación de eliminación", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        if ((estudiante.AgregaMateriaParaAlumno(unCurso) && unCurso.AgregaEstudianteAMateria(estudiante)))
                        {
                            MessageBox.Show("Se ingreso correctamente");
                            

                        }
                        else
                        {
                            MessageBox.Show("No se puede ingresar");
                        }
                        GestorEstudiantes.GuardaListaEstudiantesEnArchivo();

                    }
                }
                else
                {
                    MessageBox.Show("Cupo lleno");
                    dataGridView1.Focus();
                }
            }
        }

      
    }
}
