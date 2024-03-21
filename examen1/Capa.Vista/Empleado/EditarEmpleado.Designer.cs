namespace Capa.Vista.Empleado
{
    partial class EditarEmpleado
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
            btnGuardar = new Button();
            txtFechaContratacion = new DateTimePicker();
            txtSalario = new TextBox();
            txtPuesto = new TextBox();
            txtApellido = new TextBox();
            txtIDEmpleado = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            btnBuscar = new Button();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(520, 333);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 22;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtFechaContratacion
            // 
            txtFechaContratacion.Location = new Point(365, 275);
            txtFechaContratacion.Name = "txtFechaContratacion";
            txtFechaContratacion.Size = new Size(217, 23);
            txtFechaContratacion.TabIndex = 21;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(365, 234);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(217, 23);
            txtSalario.TabIndex = 20;
            // 
            // txtPuesto
            // 
            txtPuesto.Location = new Point(365, 192);
            txtPuesto.Name = "txtPuesto";
            txtPuesto.Size = new Size(217, 23);
            txtPuesto.TabIndex = 19;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(365, 144);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(217, 23);
            txtApellido.TabIndex = 18;
            // 
            // txtIDEmpleado
            // 
            txtIDEmpleado.Location = new Point(365, 99);
            txtIDEmpleado.Name = "txtIDEmpleado";
            txtIDEmpleado.Size = new Size(217, 23);
            txtIDEmpleado.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(219, 281);
            label5.Name = "label5";
            label5.Size = new Size(124, 15);
            label5.TabIndex = 16;
            label5.Text = "Fecha de contratacion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(219, 237);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 15;
            label4.Text = "salario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(219, 195);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 14;
            label3.Text = "puesto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(219, 144);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 13;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(219, 99);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 12;
            label1.Text = "ID Empleado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(219, 43);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 23;
            label6.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(365, 43);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(217, 23);
            txtNombre.TabIndex = 24;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(398, 333);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 25;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += button1_Click;
            // 
            // EditarEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscar);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(btnGuardar);
            Controls.Add(txtFechaContratacion);
            Controls.Add(txtSalario);
            Controls.Add(txtPuesto);
            Controls.Add(txtApellido);
            Controls.Add(txtIDEmpleado);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditarEmpleado";
            Text = "EditarEmpleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private DateTimePicker txtFechaContratacion;
        private TextBox txtSalario;
        private TextBox txtPuesto;
        private TextBox txtApellido;
        private TextBox txtIDEmpleado;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private TextBox txtNombre;
        private Button btnBuscar;
    }
}