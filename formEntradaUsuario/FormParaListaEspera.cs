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
    public partial class FormParaListaEspera : Form
    {
        bool AgregaEstudiante = false;
        List<Estudiante> estu;
        Curso unCurso;
        ListaEsperaDeCurso listaEspera;
        public FormParaListaEspera(Curso unCurso)
        {
            InitializeComponent();
        }

        private void btn_AgregaEstudiante_Click(object sender, EventArgs e)
        {
            List<Estudiante> listaEstu = GestorEstudiantes.ObtenerListaDeEstudiante();
            if (listaEstu is not null)
            {
                dataGridView1.DataSource = listaEstu;
                panel1.Visible = true;
                AgregaEstudiante = true;
            }
            else
            {
                MessageBox.Show("No hay estudiantes registrados");
            }


        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                Estudiante unEstudiante = estu[e.RowIndex];
                if (AgregaEstudiante)
                {
                    if (!listaEspera.Estudiantes1.Contains(new EstudiantesEnListaDeEsperaParaCurso(DateTime.Now, unEstudiante.Dni)))
                    {
                        DialogResult result = MessageBox.Show($"¿Desea Agregar este estudiante?  {unEstudiante.Nombre}   {unEstudiante.Apellido}", "Confirmación de eliminación", MessageBoxButtons.YesNoCancel);
                        if (result == DialogResult.Yes)
                        {
                            listaEspera.AgregaEstudianteAListaEspera(unEstudiante.Dni);

                        }
                        else
                        {
                            MessageBox.Show("Estudiante ya esta ingresado");
                            dataGridView1.Focus();
                        }
                    }
                }
                else
                {
                    if (listaEspera is not null && listaEspera.Estudiantes1.Contains(new EstudiantesEnListaDeEsperaParaCurso(DateTime.Now, unEstudiante.Dni)))
                    {
                        DialogResult result = MessageBox.Show($"¿Desea Eliminar este estudiante?  {unEstudiante.Nombre}   {unEstudiante.Apellido}", "Confirmación de eliminación", MessageBoxButtons.YesNoCancel);
                        if (result == DialogResult.Yes)
                        {
                            listaEspera.EliminaEstudianteAListaEspera(unEstudiante.Dni);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No esta registrado este estudiante");
                    }

                }
            }
        }

        private void FormParaListaEspera_Load(object sender, EventArgs e)
        {
            listaEspera = GestorEstudiantes.ObtieneListaDeEspera(unCurso.CodigoListaEspera);
        }

        private void btn_EliminarEstudiante_Click(object sender, EventArgs e)
        {
            AgregaEstudiante = false;
            dataGridView1.DataSource = listaEspera;
            panel1.Visible = true;
            MessageBox.Show("Seleccione estudiante para eliminar");
            dataGridView1.Focus();
        }

        private void FormParaListaEspera_FormClosing(object sender, FormClosingEventArgs e)
        {
            GestorEstudiantes.GuardaListasDeEspera();
        }
    }
}
