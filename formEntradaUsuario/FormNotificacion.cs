using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formEntradaUsuario
{
    public partial class FormNotificacion : Form
    {
        private System.Timers.Timer timer;
        private int segundosRestantes;

        public FormNotificacion(string mensaje, System.Timers.Timer timer )
        {
            InitializeComponent();
            this.timer = timer;
          //  this.segundosRestantes = segundosRestantes;
            ActualizarEtiqueta();
            timer.Elapsed += Timer_Tick;
            timer.Start();
        }
        public void ConfigurarTemporizador(System.Timers.Timer nuevoTimer)
        {
            timer = nuevoTimer;
            timer.Elapsed += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ActualizarEtiqueta();
        }
        private void ActualizarEtiqueta()
        {
            label1.Text = $"Quedan {segundosRestantes / 3600} horas, {(segundosRestantes % 3600) / 60} minutos y {segundosRestantes % 60} segundos.";
        }
    }
}
