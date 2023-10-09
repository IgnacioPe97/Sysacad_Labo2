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
    public partial class FormAltaCurso : Form
    {
        ValidacionDeDatos validacion = new ValidacionDeDatos();
        private string nombreCurso;
        private int codigoCurso;
        private int cupoMaximo;
        private string descripcion;
        private int cargaHoraria;
        List<Curso> listaCurso;

        public FormAltaCurso( )
        {
            InitializeComponent();
            listaCurso = GestorCursos.ObtieneListaCursos();
        }

        private void txt_NombreCurso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_NombreCurso_Leave(object sender, EventArgs e)
        {
            if (!validacion.ValidaNombre(txt_NombreCurso.Text))
            {
                MessageBox.Show("Ingrese un nombre valido");
                txt_NombreCurso.Focus();
            }
            else
            {
                nombreCurso = txt_NombreCurso.Text;
            }
        }

        private void txt_codigo_Leave(object sender, EventArgs e)
        {
            int.TryParse(txt_codigo.Text, out int numero);
            if (!validacion.EsValidoCodigoCurso(listaCurso, numero))
            {
                MessageBox.Show("Codigo ya utilizado");
                txt_codigo.Focus();
            }
            else
            {
                codigoCurso = numero;
            }

        }

        private void txt_cupoMaximo_Leave(object sender, EventArgs e)
        {
            int.TryParse(txt_cupoMaximo.Text, out int number);

            if (!validacion.EsCupoValido(number))
            {
                MessageBox.Show("Ingrese un numero válido, entre 0 y 100");
                txt_cupoMaximo.Focus();
            }
            else
            {
                cupoMaximo = number;
            }
        }

        private void rich_Descripcion_TextChanged(object sender, EventArgs e)
        {



        }

        private void txt_CargaHoraria_Leave(object sender, EventArgs e)
        {
            int.TryParse(txt_CargaHoraria.Text, out int carga);
            if (!validacion.EsValidaCargaHoras(carga))
            {
                MessageBox.Show("Indique carga valida, entre 1 y 8 horas");
                txt_CargaHoraria.Focus();
            }
            else
            {
                cargaHoraria = carga;
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btn_GuardarCurso_Click(object sender, EventArgs e)
        {
            try
            {
                if (nombreCurso is not null && cupoMaximo > 0 && cargaHoraria > 0 && descripcion is not null && codigoCurso > 0)
                {
                    Curso cursoCreado = new Curso(nombreCurso, cupoMaximo, codigoCurso, descripcion, cargaHoraria);
                    GestorCursos.AgregarCurso(cursoCreado);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese todos los campos que sean correctos");
                throw;
            }
        }

        private void rich_Descripcion_Leave(object sender, EventArgs e)
        {
            if (!validacion.EsValidoCantidadPalabras(rich_Descripcion.Text))
            {
                MessageBox.Show("Se ha alcanzado el límite de palabras (200 palabras).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                string textoLimitado = string.Join(" ", rich_Descripcion.Text.Take(200));
                rich_Descripcion.Text = textoLimitado;
                rich_Descripcion.SelectionStart = rich_Descripcion.Text.Length;
                rich_Descripcion.Focus();
            }
            else
            {
                descripcion = rich_Descripcion.Text; 
            }
        }

      
    }
}
