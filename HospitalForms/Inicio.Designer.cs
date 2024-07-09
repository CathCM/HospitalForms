namespace HospitalForms
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPacientes = new System.Windows.Forms.Button();
            this.buttonEmpleados = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPacientes
            // 
            this.buttonPacientes.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonPacientes.Font = new System.Drawing.Font("Calibri", 16.25F);
            this.buttonPacientes.Location = new System.Drawing.Point(410, 127);
            this.buttonPacientes.Name = "buttonPacientes";
            this.buttonPacientes.Size = new System.Drawing.Size(285, 240);
            this.buttonPacientes.TabIndex = 26;
            this.buttonPacientes.Text = "PACIENTES";
            this.buttonPacientes.UseVisualStyleBackColor = false;
            // 
            // buttonEmpleados
            // 
            this.buttonEmpleados.BackColor = System.Drawing.Color.Pink;
            this.buttonEmpleados.Font = new System.Drawing.Font("Calibri", 16.25F);
            this.buttonEmpleados.Location = new System.Drawing.Point(101, 127);
            this.buttonEmpleados.Name = "buttonEmpleados";
            this.buttonEmpleados.Size = new System.Drawing.Size(285, 240);
            this.buttonEmpleados.TabIndex = 25;
            this.buttonEmpleados.Text = "EMPLEADOS";
            this.buttonEmpleados.UseVisualStyleBackColor = false;
            this.buttonEmpleados.Click += new System.EventHandler(this.buttonEmpleados_Click);  
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 39);
            this.label1.TabIndex = 24;
            this.label1.Text = "BIENVENIDO AL HOSPITAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPacientes);
            this.Controls.Add(this.buttonEmpleados);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Hospital App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button buttonPacientes;
        private System.Windows.Forms.Button buttonEmpleados;
        private System.Windows.Forms.Label label1;



    }
}