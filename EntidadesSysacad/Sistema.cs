using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesSysacad
{
    public class Sistema
    {
        public delegate void NotificacionEventHandler(object sender, NotificacionEventArgs e);
        public event NotificacionEventHandler FechaLimiteInscripcion;

        public virtual void OnFechaLimiteInscripcion(NotificacionEventArgs e)
        {
            FechaLimiteInscripcion?.Invoke(this, e);
        }

        public void IniciarTemporizador()
        {
            DateTime fechaLimiteInscripcion = new DateTime(2023, 12, 9);
            System.Timers.Timer timer = new System.Timers.Timer(60 * 1000); // Temporizador configurado para ejecutarse cada minuto

            timer.Elapsed += (sender, e) =>
            {
                TimeSpan tiempoRestante = fechaLimiteInscripcion - DateTime.Now;

                if (tiempoRestante.TotalSeconds <= 7 * 24 * 60 * 60) // Puedes ajustar el número de segundos según tus necesidades
                {
                    string mensaje = $"Quedan {tiempoRestante.Days} días, {tiempoRestante.Hours} horas, {tiempoRestante.Minutes} minutos y {tiempoRestante.Seconds} segundos para la fecha límite de inscripción a cursos.";

                    // Disparar el evento y pasar el mensaje
                    OnFechaLimiteInscripcion(new NotificacionEventArgs(mensaje));
                }
            };

            timer.Start();
        }


    }
}
