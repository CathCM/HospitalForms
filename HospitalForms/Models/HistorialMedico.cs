using System;
using System.Collections.Generic;

namespace Hospital
{
    public class HistorialMedico
    {
        public Paciente Paciente { get; set; }
        public Medico Medico { get; set; }
        public List<CitaMedica> CitasMedicas { get; set; }
        public string ResumenMedico { get; set; }

        public HistorialMedico(Paciente paciente, Medico medico, List<CitaMedica> citaMedicas, string resumenMedico)
        {
            Paciente = paciente;
            Medico = medico;
            CitasMedicas = citaMedicas;
            ResumenMedico = resumenMedico;
        }
    }
}