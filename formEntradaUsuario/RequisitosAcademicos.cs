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
    public partial class RequisitosAcademicos : Form
    {
        private int codigoMateriasAsociadas;
        private double promedioMinimo;
        private int cantidadCreditos;
        Curso curso;

        public RequisitosAcademicos(Curso unCurso)
        {
            InitializeComponent();
            curso = unCurso;
        }

        private void btn_AgregarRequisitos_Click(object sender, EventArgs e)
        {

            if (promedioMinimo > 0)
            {
                curso.AgregaRequisitosACurso(codigoMateriasAsociadas, cantidadCreditos, promedioMinimo);
                DialogResult = DialogResult.OK;
                Close();
            }

        }
        private bool VerificaComboBox()
        {
            if (comboBox_MateriaCorrelativa.SelectedItem is not null && comboBox_MateriaCorrelativa.SelectedItem is ComboBoxItem selectedItem && comboBox_Creditos.SelectedIndex > 0)
            {
                int codigo = selectedItem.Codigo;
                cantidadCreditos = (int)comboBox_Creditos.SelectedItem;
                return true;
            }
            return false;
        }

        private void RequisitosAcademicos_Load(object sender, EventArgs e)
        {
            CargaComboBoxMaterias();
            lbl_NombreMateria.Text = curso.NombreCurso.ToString();
        }
        private void CargaComboBoxMaterias()
        {
            List<Curso> cursos = GestorCursos.ObtieneListaCursos();
            foreach (Curso item in cursos)
            {
                comboBox_MateriaCorrelativa.Items.Add(new ComboBoxItem(item.CodigoCurso, item.NombreCurso));
            }




        }

        private void txt_Promedio_Leave(object sender, EventArgs e)
        {
            double.TryParse(txt_Promedio.Text, out double salida);
            if (salida > 0 && salida < 11)
            {
                promedioMinimo = salida;
            }
            else
            {
                MessageBox.Show("Ingrese un valor valido");
                txt_Promedio.Focus();
            }
        }

        private void btn_BorrarRequisitos_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"¿Desea eliminar Requisitos? ", "Confirmación de eliminación", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                curso.DarBajaRequisitos();
            }


        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    public class ComboBoxItem
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public ComboBoxItem(int codigo, string nombre)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
        }
        public override string ToString()
        {
            return $"{Codigo} - {Nombre}";
        }
    }
}
