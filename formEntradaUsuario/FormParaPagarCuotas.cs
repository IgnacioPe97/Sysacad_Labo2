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
    public partial class FormParaPagarCuotas : Form
    {
        private List<Pagos> cuotas;
        private string numeroTarjeta;
        private string codigoTarjeta;
        private int totalParaPagar;
        private int dniEstudianteQuePaga;
        private PagosRealizadosPorUsuario pagosRealizadosPorUsuario;
        ValidacionDeDatos validar = new ValidacionDeDatos();
        public FormParaPagarCuotas(List<Pagos> aPagar, int dni)
        {
            InitializeComponent();
            cuotas = aPagar;
            totalParaPagar = SumaCuotasDePagos(cuotas);
            dniEstudianteQuePaga = dni;
        }
    

        private int SumaCuotasDePagos(List<Pagos> cuotas)
        {
            int valorTotalAPagar = 0;
            foreach (Pagos item in cuotas)
            {
                valorTotalAPagar += item.ValorCuota;

            }
            return valorTotalAPagar;
        }

        private void FormParaPagarCuotas_Load(object sender, EventArgs e)
        {
            label1.Text = "Total a Pagar: $ " + totalParaPagar.ToString();
        }

        private void txt_NumeroTarjeta_Leave(object sender, EventArgs e)
        {
            if (validar.ContieneSoloNumeros(txt_NumeroTarjeta.Text))
            {
                if (validar.EsValidoNumeroTarjeta(txt_NumeroTarjeta.Text))
                {
                    numeroTarjeta = txt_NumeroTarjeta.Text;
                }
            }
            else
            {
                MessageBox.Show("Ingrese solo numeros");
                txt_NumeroTarjeta.Focus();
            }
        }

        private void txt_CodigoTarjeta_Leave(object sender, EventArgs e)
        {
            if (validar.EsValidoCodigoTarjeta(txt_CodigoTarjeta.Text) && validar.ContieneSoloNumeros(txt_CodigoTarjeta.Text))
            {
                codigoTarjeta = txt_CodigoTarjeta.Text;
            }
            else
            {
                MessageBox.Show("Ingrese solo numeros");
                txt_CodigoTarjeta.Focus();
            }
        }

        private void btn_Pagar_Click(object sender, EventArgs e)
        {
            if (codigoTarjeta is not null && numeroTarjeta is not null)
            {
                CambiaEstaPago(cuotas);
                DialogResult = DialogResult.OK;
                Close();
            }
         
        }
        private void CambiaEstaPago(List<Pagos> pagos)
        {
            foreach (Pagos item in pagos)
            {
                if (item.EstaPago == false)
                {
                    item.EstaPago = true;
                    pagosRealizadosPorUsuario = new PagosRealizadosPorUsuario(dniEstudianteQuePaga, item.ValorCuota, DateTime.Now, item.Mes);
                }
            }
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FormParaPagarCuotas_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                GestorDePagos.AgregaPagoAListaPagosRealizados(pagosRealizadosPorUsuario);
                GestorEstudiantes.GuardarListaEstudiantesEnArchivos();
                GestorDePagos.GuardaListaDePagos();

            }
        }
    }
}
