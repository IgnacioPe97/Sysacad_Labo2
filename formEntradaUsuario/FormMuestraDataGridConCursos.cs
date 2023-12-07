using LogicaDeNegocio;
using NPOI.SS.Formula.Functions;
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
    public partial class FormMuestraDataGridConCursos : Form
    {
        int opcionParaDataGrid;
        List<Curso> cursos;
       public Curso cursoSeleccionado { get; set; }
        private const string rutaImagen = @"C:\Users\Ignacio Pereyra\Desktop\Solution C#\formEntradaUsuario\Imagenes\cruz.png";
        public List<Estudiante> Estudiantes { get;  private set ; }

        public FormMuestraDataGridConCursos(int modificarSi)
        {
            InitializeComponent();
            opcionParaDataGrid = modificarSi;
            cursos = GestorCursos.ObtieneListaCursos();
            dataGridView1.DataSource = cursos;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Curso unCurso = cursos[e.RowIndex];
                if (opcionParaDataGrid == 1)
                {

                    DialogResult result = MessageBox.Show($"¿Desea eliminar este elemento?  {unCurso.NombreCurso}", "Confirmación de eliminación", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        GestorCursos.EliminaCurso(unCurso);
                        cursos = GestorCursos.ObtieneListaCursos();
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = cursos;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Operacion cancelada");
                        dataGridView1.Focus();
                    }
                }
                else if (opcionParaDataGrid == -1)
                {
                    FormModificacionCurso formModificacion = new FormModificacionCurso(unCurso);
                    formModificacion.ShowDialog();
                    if (formModificacion.DialogResult == DialogResult.OK)
                    {
                        MessageBox.Show("Curso modificado con éxito");
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
                else if (opcionParaDataGrid == 2)
                {
                    cursoSeleccionado = unCurso;
                    if (cursoSeleccionado is not null)
                    {
                        DialogResult = DialogResult.OK;
                        Close();
                    }

                }
                else if (opcionParaDataGrid == 3)
                {
                    cursoSeleccionado = unCurso;
                    if (cursoSeleccionado is not null && cursoSeleccionado.CodigoListaEspera > 0)
                    {
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show($"Este Curso {cursoSeleccionado.NombreCurso} no tiene lista de espera");
                        dataGridView1.Focus();
                    }
                }
                else
                {
                    if (unCurso.Estudiantes.Count >= 0)
                    {
                        Estudiantes = Estudiante.DevuelveEstudiantePorListaDeDni(unCurso.Estudiantes);//;
                        DialogResult = DialogResult.OK;

                    }
                    else
                    {
                        DialogResult = DialogResult.Cancel;

                    }
                }
            }
        }
        private void FormMuestraDataGridConCursos_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}


