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
    public partial class FormMuestraProfesores : Form
    {
       public Profesores unProfe { get; set; }
        List<Profesores> prof;
        int numeroOpcion;
        public FormMuestraProfesores(int numero)
        {
            InitializeComponent();
            numeroOpcion = numero;
        }

        private void FormMuestraProfesores_Load(object sender, EventArgs e)
        {
            prof = GestorProfesores.ObtieneListaProfesores();
            if (prof is not null)
            {
                dataGridView1.DataSource = prof;
                dataGridView1.Visible = true;
            }
            else
            {
                MessageBox.Show("No hay profesores registrados");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Profesores profe = prof[e.RowIndex];
                if (profe is not null &&  e.RowIndex >= 0 && e.RowIndex < prof.Count)
                {
                    if (numeroOpcion == 1)
                    {
                        DialogResult result = MessageBox.Show($"¿Selecciona este profesor?  {profe.Nombre}  {profe.Apellido}", "Confirmación de eliminación", MessageBoxButtons.YesNoCancel);
                        if (result == DialogResult.Yes)
                        {
                            unProfe = profe;
                            DialogResult = DialogResult.OK;
                            Close();
                        }
                        else
                        {
                            dataGridView1.Focus();
                        }
                    }
                }
             

              
            }
        }
    }
}
