using System;
using Hospital;

public class Turno:Horario
{
    public TipoHorarioEnum TipoHorario { get; set; }
    public bool Disponibilidad { get; set; }
    public DateTime FechaInicio { get; set; }
    public TimeSpan Duracion { get; set; }

    public Turno(TipoHorarioEnum tipoHorario, bool disponibilidad, DateTime fechaInicio, TimeSpan duracion)
    {
        TipoHorario = tipoHorario;
        Disponibilidad = disponibilidad;
        FechaInicio = fechaInicio;
        Duracion = duracion;
    }

    public override string ToString()
    {
        return $"Horario: {TipoHorario}, Fecha: {FechaInicio: dd/MM/yyyy} Hora: {FechaInicio: HH:mm} - {(Disponibilidad ? "Disponible" : "Ocupado")}.";
    }
}
