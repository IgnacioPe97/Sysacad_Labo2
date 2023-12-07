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
    public partial class FormCambiaContrasenia : Form
    {
        Estudiante estudiante;
        private string contraUno;
        private string contraDos;
        public FormCambiaContrasenia(Estudiante unEstudiante)
        {
            InitializeComponent();
            estudiante = unEstudiante;
            label1.Visible = false;
        }

        private void txt_confirmaContra_Leave(object sender, EventArgs e)
        {
            if (txt_confirmaContra.Text is not null)
            {
                contraDos = txt_confirmaContra.Text;
            }
            else
            {
                MessageBox.Show("Ingrese contraseña");
            }

        }

        private void txt__Leave(object sender, EventArgs e)
        {
            if (txt_.Text is not null)
            {
                contraUno = txt_.Text;
            }
            else
            {
                MessageBox.Show("Ingrese contraseña");
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (contraUno is not null && contraDos is not null && contraUno.Equals(contraDos))
            {
                estudiante.Contrasenia = contraDos;
                estudiante.CambiarContrasenia = false;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                label1.Visible = true;
                txt_confirmaContra.BackColor = Color.Red;
                txt_confirmaContra.Focus();
            }
        }
    }
}
