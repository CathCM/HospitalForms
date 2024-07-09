using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Hospital
{
    public class Medico : Empleado
    {
        public List<Turno> Turnos { get; set; }
        public string Especialidad { get; set; }
        
        public List<Paciente> PacientesAsignados { get; set; }
        
        public Medico(List<Turno> turnos, string especialidad, List<Paciente> pacientesAsignados, int idEmpleado, string nombre, List<string> apellidos, DateTime fechaNacimiento, string telefono, string email,
            Direccion direccion, double salario, DateTime fechaIncorporacion, Horario.TipoHorarioEnum tipoHorario, string dni,
            string numSeguridadSocial, string tipoPersona) :
            base(idEmpleado, salario, fechaIncorporacion, tipoHorario, numSeguridadSocial, nombre, apellidos, fechaNacimiento, telefono, email, direccion, tipoPersona, dni)
        {
            Turnos = turnos;
            Especialidad = especialidad;
            PacientesAsignados = pacientesAsignados;
        }
        
        public static Medico AltaMedico(List<Turno> turnos, string especialidad, List<Paciente> pacientesAsignados, int idEmpleado, string nombre, List<string> apellidos, DateTime fechaNacimiento, string telefono,
            string email, Direccion direccion, double salario, DateTime fechaIncorporacion, Horario.TipoHorarioEnum tipoHorario,
            string dni, string numSeguridadSocial, string tipoPersona)
        {
            Medico nuevoMedico = new Medico(turnos, especialidad, pacientesAsignados, idEmpleado, nombre, apellidos, fechaNacimiento, telefono, email, direccion,
                salario, fechaIncorporacion, tipoHorario, dni, numSeguridadSocial, tipoPersona);
            
            return nuevoMedico;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Médico: {Nombre} {string.Join(" ", Apellidos)}");
            stringBuilder.AppendLine($"Especialidad: {Especialidad}");
           // stringBuilder.AppendLine($"Fecha de nacimiento: {FechaNacimiento:dd/MM/yyyy}");
            stringBuilder.AppendLine($"Teléfono: {Telefono}");
            stringBuilder.AppendLine($"Email: {Email}");
           // stringBuilder.AppendLine($"Dirección:\n\t{Direccion.ToString().Replace("\n", "\n\t")}");
           // stringBuilder.AppendLine($"Salario: {Salario.ToString("C", CultureInfo.CurrentCulture)}");
           // stringBuilder.AppendLine($"Fecha de incorporación: {FechaIncorporacion:dd/MM/yyyy}");
            stringBuilder.AppendLine($"Horario: {TipoHorario}"); 
            // stringBuilder.AppendLine($"DNI: {Dni}");
            // stringBuilder.AppendLine($"Número de seguridad social: {NumSeguridadSocial}");
            // stringBuilder.AppendLine($"Tipo de persona: {TipoPersona}");
            // stringBuilder.AppendLine($"Edad: {ObtenerEdad()}");
            stringBuilder.AppendLine($"Turnos");

            foreach (var turno in Turnos)
            {
                stringBuilder.AppendLine($"\t{turno} - {turno.Disponibilidad}");
            }
            
         
            stringBuilder.AppendLine("Pacientes asignados:");
            foreach (var paciente in PacientesAsignados)
            {
                if (paciente.MedicoCabecera != null && paciente.MedicoCabecera.IdEmpleado == IdEmpleado)
                {
                    stringBuilder.AppendLine($"\t{paciente.Dni} - {paciente.Nombre} {string.Join(" ", paciente.Apellidos)}");
                }
            }
            return stringBuilder.ToString();
        }

        public static void ListarPacientesPorMedico(string dni, List<Medico> medicos)
        {
            foreach (Medico medico in medicos)
            {
                if (medico.Dni == dni)
                {
                    Console.WriteLine($"Pacientes asignados al médico {medico.Nombre} {medico.Apellidos}:");
                    foreach (Paciente paciente in medico.PacientesAsignados)
                    {
                        Console.WriteLine(paciente);
                    }
                    return;
                }
            }

            Console.WriteLine($"No se encontró ningún médico con el DNI {dni}.");
        }

    }
}
