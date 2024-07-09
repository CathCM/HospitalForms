using Hospital;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalForms
{
    public partial class CrearMedico : Form
    {
        private static int nextMedicoId = 1;
        public CrearMedico()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBoxEspecialidad.Items.Add("Cardiología");
            comboBoxEspecialidad.Items.Add("Pediatría");
            comboBoxEspecialidad.Items.Add("Neurología");
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            List<string> apellidos = textBoxApellidos.Text.Split(' ').ToList();
            string dni = textBoxDNI.Text;
            string direccion = textBoxDireccion.Text;
            DateTime fechaNacimiento = dateTimePickerNacimiento.Value;
            string telefono = textBoxTelefono.Text;
            string email = textBoxEmail.Text;
            DateTime fechaIncorporacion = dateTimePickerIncorporacion.Value;
            string especialidad = comboBoxEspecialidad.SelectedItem?.ToString();
            double salario;
            if (!double.TryParse(textBoxSalario.Text, out salario))
            {
                MessageBox.Show("Por favor, ingrese un salario válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string numSeguridadSocial = textBoxSS.Text;

            Horario.TipoHorarioEnum tipoHorario;
            if (radioButtonMañana.Checked)
            {
                tipoHorario = Horario.TipoHorarioEnum.Mañana;
            }
            else if (radioButtonTarde.Checked)
            {
                tipoHorario = Horario.TipoHorarioEnum.Tarde;
            }
            else
            {
                tipoHorario = Horario.TipoHorarioEnum.Completo;
            }

           
            List<Turno> turnos = new List<Turno>();
            List<Paciente> pacientesAsignados = new List<Paciente>();
            
            int nuevoMedicoId = nextMedicoId++;

            Medico nuevoMedico = Medico.AltaMedico(turnos, especialidad, pacientesAsignados, nuevoMedicoId, nombre, apellidos, fechaNacimiento, telefono, email, direccion, salario, fechaIncorporacion, tipoHorario, dni, numSeguridadSocial, "Médico");

            
            labelID.Text = "ID " + nuevoMedicoId;

           
            //MessageBox.Show("Nuevo médico creado:\n" + nuevoMedico.ToString());
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            MenuEmpleados form2 = new MenuEmpleados();
            form2.Show();
            this.Close();
        }
    }
}
