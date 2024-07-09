using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital
{
    public class Paciente : Persona
    {
        public List<HistorialMedico> HistorialMedico { get; set; }
        public Medico MedicoCabecera { get; set; }

        public Paciente(List<HistorialMedico> historialMedico, Medico medicoCabecera, string nombre,
            List<string> apellidos, DateTime fechaNacimiento, string telefono, string email,
            Direccion direccion, string tipoPersona, string dni) : base(nombre, apellidos, fechaNacimiento, telefono,
            email, direccion, tipoPersona, dni)
        {
            HistorialMedico = historialMedico;
            MedicoCabecera = medicoCabecera;

        }

        public static void EliminarPaciente(string dni, List<Paciente> pacientes)
        {
            bool pacienteEncontrado = false;
            for (int i = 0; i < pacientes.Count; i++)
            {
                if (pacientes[i].Dni == dni)
                {
                    pacientes.RemoveAt(i);
                    Console.WriteLine($"Se eliminó correctamente al paciente con DNI {dni}.");
                    return; 
                }
            }

            if (!pacienteEncontrado)
            {
                Console.WriteLine($"No se encontró ningún paciente con el DNI {dni}.");
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Paciente: {Nombre} {string.Join(" ", Apellidos)}");
            stringBuilder.AppendLine($"Fecha de nacimiento: {FechaNacimiento:dd/MM/yyyy}");
            stringBuilder.AppendLine($"Teléfono: {Telefono}");
            stringBuilder.AppendLine($"Email: {Email}");
            stringBuilder.AppendLine($"Dirección:\n\t{Direccion.ToString().Replace("\n", "\n\t")}");
            stringBuilder.AppendLine($"Tipo de persona: {TipoPersona}");
            stringBuilder.AppendLine($"DNI: {Dni}");

            if (MedicoCabecera != null)
            {
                stringBuilder.AppendLine(
                    $"Médico de cabecera: {MedicoCabecera.Nombre} {string.Join(" ", MedicoCabecera.Apellidos)}");
            }

            HistorialMedico = null;

            // if (HistorialMedico != null && HistorialMedico.Count > 0)
            // {
            //     stringBuilder.AppendLine("Historial médico:");
            //     foreach (var historia in HistorialMedico)
            //     {
            //         stringBuilder.AppendLine($"\tFecha: {historia.:dd/MM/yyyy}");
            //         stringBuilder.AppendLine($"\tDescripción: {historia.Descripcion}");
            //     }
            // }

            return stringBuilder.ToString();
        }
    }
}