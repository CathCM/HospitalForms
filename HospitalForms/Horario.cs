using System;

namespace Hospital
{
    public class Horario
    {
        public enum TipoHorarioEnum
        {
            Mañana,
            Tarde,
            Completo
            // FullTime
        }

        public TipoHorarioEnum TipoHorario { get; set; }

        public bool DefinirHorario(DateTime hora)
        {
            switch (TipoHorario)
            {
                case TipoHorarioEnum.Mañana:
                    return hora.TimeOfDay >= new TimeSpan(8, 0, 0) && hora.TimeOfDay <= new TimeSpan(14, 59, 59);
                case TipoHorarioEnum.Tarde:
                    return hora.TimeOfDay >= new TimeSpan(15, 0, 0) && hora.TimeOfDay <= new TimeSpan(21, 0, 0);
                // case TipoHorarioEnum.FullTime:
                //     return hora.TimeOfDay >= new TimeSpan(8, 0, 0) && hora.TimeOfDay <= new TimeSpan(21, 0, 0);
                default:
                    return false;
            }
        }
    }

    
}