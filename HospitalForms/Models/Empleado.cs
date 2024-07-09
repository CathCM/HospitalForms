using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    public class Empleado:Persona
    {
        public int IdEmpleado { get; set; }
        public double Salario { get; set; }
        public DateTime FechaIncorporacion { get; set; }
        public Horario.TipoHorarioEnum TipoHorario { get; set; }
        public string NumSeguridadSocial { get; set; }
        public int Edad { get; set; }
        public Empleado(int idEmpleado, double salario, DateTime fechaIncorporacion, Horario.TipoHorarioEnum tipoHorario, string numSeguridadSocial, string nombre, List<string> apellidos, DateTime fechaNacimiento, string telefono, string email,
            Direccion direccion, string tipoPersona, string dni):base(nombre, apellidos, fechaNacimiento, telefono, email,direccion, tipoPersona, dni)
        {
            IdEmpleado = idEmpleado;
            Salario = salario;
            FechaIncorporacion = fechaIncorporacion;
            TipoHorario = tipoHorario;
            NumSeguridadSocial = numSeguridadSocial;
            
        }
        
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Empleado: {Nombre} {string.Join(" ", Apellidos)}");
            stringBuilder.AppendLine($"Fecha de nacimiento: {FechaNacimiento:dd/MM/yyyy}");
            stringBuilder.AppendLine($"Edad: {Edad}");
            stringBuilder.AppendLine($"Teléfono: {Telefono}");
            stringBuilder.AppendLine($"Email: {Email}");
            stringBuilder.AppendLine($"Dirección: {Direccion}");
            stringBuilder.AppendLine($"Salario: {Salario:C}");
            stringBuilder.AppendLine($"Fecha de incorporación: {FechaIncorporacion:dd/MM/yyyy}");
            stringBuilder.AppendLine($"Tipo de horario: {TipoHorario}");
            stringBuilder.AppendLine($"Número de seguridad social: {NumSeguridadSocial}");
            stringBuilder.AppendLine($"Tipo de persona: {TipoPersona}");
            
            return stringBuilder.ToString();
        }
    }
}