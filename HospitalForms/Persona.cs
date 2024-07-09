using System;
using System.Collections.Generic;

namespace Hospital
{
    public class Persona
    {
        public string Nombre { get; set; }
        public List<string> Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string TipoPersona { get; set; }
        public string Dni { get; set; }
        public int Edad { get; set; }
        
        

        public Persona(string nombre, List<string> apellidos, DateTime fechaNacimiento, string telefono, string email,
            string direccion, string tipoPersona, string dni)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            FechaNacimiento = fechaNacimiento;
            Telefono = telefono;
            Email = email;
            Direccion = direccion;
            TipoPersona = tipoPersona;
            Dni = dni;
            
        }
        public int ObtenerEdad()
        {
            int edad = DateTime.Now.Year - FechaNacimiento.Year;
            if (DateTime.Now.Month < FechaNacimiento.Month || (DateTime.Now.Month == FechaNacimiento.Month && DateTime.Now.Day < FechaNacimiento.Day))
                edad--;
            return edad;
        }
        
    }
}