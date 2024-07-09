using System;
using System.Collections.Generic;
using System.Linq;

namespace Hospital
{
    public class DataRandomGenerator
    {
        private Random random = new Random();

        public void Menu()
        {
            bool salir = false;
            List<Medico> medicos = new List<Medico>();
            List<Paciente> pacientes = new List<Paciente>();
            List<Empleado> empleados = new List<Empleado>();
            string dni = "";


            do
            {
                Console.WriteLine("MENU:");
                Console.WriteLine("1. Dar de alta un médico");
                Console.WriteLine("2. Dar de alta un paciente para un médico");
                Console.WriteLine("3. Dar de alta personal administrativo");
                Console.WriteLine("4. Listar los médicos");
                Console.WriteLine("5. Listar los pacientes de un médico");
                Console.WriteLine("6. Eliminar a un paciente");
                Console.WriteLine("7. Ver la lista de personas del hospital");
                Console.WriteLine("8. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();


                switch (opcion)
                {
                    case "1":
                        medicos.AddRange(AltaMedico(1, pacientes));
                        break;
                    case "2":
                        pacientes.AddRange(AltaPacientes(1, medicos));
                        break;
                    case "3":
                        empleados.AddRange(AltaEmpleados(1));
                        break;
                    case "4":
                        foreach (Medico medico in medicos)
                        {
                            Console.WriteLine(medico);
                        }
                        break;
                    case "5":
                        Console.Write("Introduce el dni del medico: ");
                        dni= Console.ReadLine();
                        Medico.ListarPacientesPorMedico(dni, medicos);
                        break;
                    case "6":
                        Console.Write("Introduce el dni del paciente a eliminar: ");
                        dni= Console.ReadLine();
                        Paciente.EliminarPaciente(dni, pacientes);
                        break;
                    case "7":
                        foreach (Empleado empleado in empleados)
                        {
                            Console.WriteLine(empleado);
                        }
                        break;
                    case "8":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                        break;
                }

                Console.ReadLine();
                AltaMedico(2, pacientes);
                AltaPacientes(2, medicos);

            } while (!salir);
        }

        public List<Medico> AltaMedico(int cantidad, List<Paciente> pacientes)
        {
            var medicos = new List<Medico>();
            for (int i = 0; i < cantidad; i++)
            {
                var idEmpleado = i + 1;
                var tipoHorario =
                    (Horario.TipoHorarioEnum)random.Next(Enum.GetNames(typeof(Horario.TipoHorarioEnum)).Length);
                var turnos = GenerarTurnosAleatorios(random.Next(5, 12), tipoHorario);
                var direccion = GenerarDireccionAleatoria();

                var pacientesAsignados = new List<Paciente>();
                foreach (var paciente in pacientes)
                {
                    if (random.Next(2) == 0) 
                    {
                        pacientesAsignados.Add(paciente);
                    }
                }

                var medico = Medico.AltaMedico(
                    new List<Turno>(turnos),
                    "Especialidad " + (i + 1),
                    pacientesAsignados,
                    idEmpleado,
                    "Medico" + (i + 1),
                    new List<string> { "Apellido" + (i + 1) },
                    new DateTime(random.Next(1950, 2000), random.Next(1, 13), random.Next(1, 29)),
                    "123-456-789" + random.Next(1000, 10000),
                    "medico" + (i + 1) + "@hospital.com",
                    direccion,
                    random.Next(30000, 100000),
                    new DateTime(random.Next(2000, 2024), random.Next(1, 13), random.Next(1, 29)),
                    tipoHorario,
                    $"{random.Next(10000000, 99999999)}",
                    "SS" + random.Next(100000000, 999999999),
                    "Médico"
                );

                foreach (var paciente in pacientesAsignados)
                {
                    paciente.MedicoCabecera = medico;
                }
                
                medicos.Add(medico);
            }

            return medicos;
        }


        public List<Turno> GenerarTurnosAleatorios(int cantidad, Horario.TipoHorarioEnum tipoHorario)
        {
            var turnos = new List<Turno>();
            var random = new Random();
            TimeSpan start, end;

            if (tipoHorario == Horario.TipoHorarioEnum.Mañana)
            {
                start = new TimeSpan(8, 0, 0);
                end = new TimeSpan(14, 59, 59);
            }
            else
            {
                start = new TimeSpan(15, 0, 0);
                end = new TimeSpan(21, 0, 0);
            }

            DateTime currentHoraInicio = new DateTime(2024, 06, 2).Add(start);

            for (int i = 0; i < cantidad; i++)
            {
                if (currentHoraInicio.TimeOfDay + TimeSpan.FromMinutes(27) > end)
                {
                    break;
                }

                var disponibilidad = random.Next(4) != 0;
                ;
                var duracion = TimeSpan.FromMinutes(27);
                var turno = new Turno(tipoHorario, disponibilidad, currentHoraInicio, duracion);
                turnos.Add(turno);

                currentHoraInicio = currentHoraInicio.Add(duracion).Add(TimeSpan.FromMinutes(4));
            }

            return turnos;
        }


        public Direccion GenerarDireccionAleatoria()
        {
            return new Direccion("Tipo via " + random.Next(1, 1000),
                "Calle " + random.Next(1, 1000),
                "Número " + random.Next(1, 100),
                "Ciudad " + random.Next(1, 100),
                "País " + random.Next(1, 100),
                random.Next(10000, 99999).ToString(),
                "Información adicional " + random.Next(1, 1000)
            );
        }

        public List<Empleado> AltaEmpleados(int cantidad)
        {
            var empleados = new List<Empleado>();
            for (int i = 0; i < cantidad; i++)
            {
                var idEmpleado = i + 1;
                var direccion = GenerarDireccionAleatoria();
                var empleado = new Empleado(
                    idEmpleado,
                    random.Next(27500, 100000),
                    new DateTime(random.Next(2015, 2023), random.Next(1, 13), random.Next(1, 29)),
                    (Horario.TipoHorarioEnum)random.Next(Enum.GetNames(typeof(Horario.TipoHorarioEnum)).Length),
                    "SS" + random.Next(100000000, 999999999),
                    "Empleado" + (i + 1),
                    new List<string> { "Apellido" + (i + 1) },
                    new DateTime(random.Next(DateTime.Now.Year - 100, DateTime.Now.Year), random.Next(1, 13),
                        random.Next(1, 29)),
                    "123-456-789" + random.Next(1000, 10000),
                    "empleado" + (i + 1) + "@hospital.com",
                    direccion,
                    "Empleado",
                    $"{random.Next(10000000, 99999999)}"
                );
                empleados.Add(empleado);
            }

            return empleados;
        }

        public List<Paciente> AltaPacientes(int cantidad, List<Medico> medicos)
        {
            var pacientes = new List<Paciente>();
            for (int i = 0; i < cantidad; i++)
            {
                var direccion = GenerarDireccionAleatoria();
                var medicoCabecera = medicos[random.Next(medicos.Count)];
                var paciente = new Paciente(
                    new List<HistorialMedico>(),
                    medicoCabecera,
                    "Paciente" + (i + 1),
                    new List<string> { "Apellido" + (i + 1) },
                    new DateTime(random.Next(1950, 2000), random.Next(1, 13), random.Next(1, 29)),
                    "123-456-789" + random.Next(1000, 10000),
                    "paciente" + (i + 1) + "@hospital.com",
                    direccion,
                    "Paciente",
                    $"{random.Next(10000000, 99999999)}"
                );
                pacientes.Add(paciente);
            }

            return pacientes;
        }

        public List<Medico> AsignarPacientesAMedico(int cantidad)
        {
            var medicos = AltaMedico(cantidad, new List<Paciente>());
            var pacientes = AltaPacientes(cantidad * 4, medicos);

            medicos = AltaMedico(10, pacientes);

            return medicos;
        }
    }
}