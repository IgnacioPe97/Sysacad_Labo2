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
    public partial class FormMuestraDataGridConCursos : Form
    {
        bool esModificacion;
        List<Curso> cursos;

        public FormMuestraDataGridConCursos( bool modificarSi)
        {
            InitializeComponent();
            esModificacion = modificarSi;
            cursos = GestorCursos.ObtieneListaCursos();
            dataGridView1.DataSource = cursos;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Curso unCurso = cursos[e.RowIndex];
                if (!esModificacion)
                {

                    DialogResult result = MessageBox.Show($"¿Desea eliminar este elemento?  {unCurso.NombreCurso}", "Confirmación de eliminación", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {

                        GestorCursos.EliminaCurso(unCurso);
                        cursos = GestorCursos.ObtieneListaCursos(); 
                        dataGridView1.DataSource = null; 
                        dataGridView1.DataSource = cursos;
                    }
                    else
                    {
                        MessageBox.Show("Operacion cancelada"); 
                        dataGridView1.Focus();
                    }
                }
                else if (esModificacion)
                {
                    FormModificacionCurso formModificacion = new FormModificacionCurso( unCurso);
                    formModificacion.ShowDialog();
                    if (formModificacion.DialogResult == DialogResult.OK)
                    {
                        MessageBox.Show("Curso modificado con éxito");
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }

            }
           
        }
    }
 }
    

