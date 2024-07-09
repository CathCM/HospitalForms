using System;

namespace Hospital
{
    public class CitaMedica
    {
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public string ApuntesDeCita { get; set; }
        public Medico MedicoAsignado { get; set; }
        public Paciente Paciente { get; set; }

        public CitaMedica(DateTime fecha, string estado, string apuntesDeCita, Medico medicoAsignado, Paciente paciente)
        {
            Fecha = fecha;
            Estado = estado;
            ApuntesDeCita = apuntesDeCita;
            MedicoAsignado = medicoAsignado;
            Paciente = paciente;
        }
    }
}