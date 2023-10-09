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
    public partial class FormModificacionCurso : Form
    {
        
        Curso cursoParaModificar;
        List<Curso> listaCurso;
        ValidacionDeDatos validacion = new ValidacionDeDatos();
        private string nombreCurso;
        private int codigoCurso;
        private int cupoMaximo;
        private string descripcion;
        private int cargaHoraria;
        public FormModificacionCurso(Curso unCurso)
        {
            InitializeComponent();
            cursoParaModificar = unCurso;
            listaCurso = GestorCursos.ObtieneListaCursos();
        }

        private void txt_NombreCurso_TextChanged(object sender, EventArgs e)
        {
        }

        private void FormModificacionCurso_Load(object sender, EventArgs e)
        {
            txt_NombreCurso.Text = cursoParaModificar.NombreCurso;
            nombreCurso = txt_NombreCurso.Text;
            txt_codigo.Text = cursoParaModificar.CodigoCurso.ToString();
            codigoCurso = cursoParaModificar.CodigoCurso;
            txt_cupoMaximo.Text = cursoParaModificar.CupoMaximo.ToString();
            cupoMaximo = cursoParaModificar.CupoMaximo;
            txt_CargaHoraria.Text = cursoParaModificar.CargaHoraria.ToString();
            cargaHoraria = cursoParaModificar.CargaHoraria;
            rich_Descripcion.Text = cursoParaModificar.Descripcion.ToString();
            descripcion = cursoParaModificar.Descripcion;
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

        private void rich_Descripcion_Leave(object sender, EventArgs e)
        {
            if (!validacion.EsValidoCantidadPalabras(rich_Descripcion.Text))
            {
                
            }
            else
            {
                descripcion = rich_Descripcion.Text;
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btn_GuardarCurso_Click(object sender, EventArgs e)
        {
            if (nombreCurso is not null && cupoMaximo > 0 && cargaHoraria > 0 && descripcion is not null && codigoCurso > 0)
            {
                DialogResult result = MessageBox.Show($"¿Confirma los cambios? ", "Confirmación de eliminación", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    cursoParaModificar.CargaHoraria = cargaHoraria;
                    cursoParaModificar.NombreCurso = nombreCurso;
                    cursoParaModificar.CodigoCurso = codigoCurso;
                    cursoParaModificar.CupoMaximo = cupoMaximo;
                    cursoParaModificar.Descripcion = descripcion;
                    GestorCursos.AgregarCurso(cursoParaModificar);    
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Modificacion cancelada");
                    Focus();
                }
            }
        }
    }
}
