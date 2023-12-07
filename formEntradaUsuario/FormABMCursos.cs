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
    public partial class FormABMCursos : Form
    {
        public FormABMCursos()
        {
            InitializeComponent();
        }
        /*
        private void btn_AltaCurso_Click(object sender, EventArgs e)
        {
            FormAltaCurso frmAlta = new FormAltaCurso();
            frmAlta.ShowDialog();
            if (frmAlta.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Curso Agregado correctamente");

            }
            else
            {
                MessageBox.Show("Error en el ingreso");

            }
        }
        
        private void btn_ModificacionCurso_Click(object sender, EventArgs e)
        {
           // FormMuestraDataGridConCursos formMuestra = new FormMuestraDataGridConCursos(true);
            formMuestra.ShowDialog();
            if (formMuestra.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Curso modificado con exito");
                GestorCursos.GuardaListaCursosEnArchivo();
            }
            else
            {
                MessageBox.Show("Error en modificacion");
            }
        }

        private void btn_BajaCurso_Click(object sender, EventArgs e)
        {
            FormMuestraDataGridConCursos formBaja = new FormMuestraDataGridConCursos(false);
            formBaja.ShowDialog();
        }

        private void FormABMCursos_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void FormABMCursos_Load(object sender, EventArgs e)
        {
            
       }*/
    }
}
