namespace Capa.Vista.Empleado
{
    partial class InsertarEmpleado
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtPuesto = new TextBox();
            txtSalario = new TextBox();
            txtFechaContratacion = new DateTimePicker();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 46);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 91);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 142);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "puesto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 184);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 3;
            label4.Text = "salario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 228);
            label5.Name = "label5";
            label5.Size = new Size(124, 15);
            label5.TabIndex = 4;
            label5.Text = "Fecha de contratacion";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(200, 46);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(217, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(200, 91);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(217, 23);
            txtApellido.TabIndex = 6;
            // 
            // txtPuesto
            // 
            txtPuesto.Location = new Point(200, 139);
            txtPuesto.Name = "txtPuesto";
            txtPuesto.Size = new Size(217, 23);
            txtPuesto.TabIndex = 7;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(200, 181);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(217, 23);
            txtSalario.TabIndex = 8;
            // 
            // txtFechaContratacion
            // 
            txtFechaContratacion.Location = new Point(200, 222);
            txtFechaContratacion.Name = "txtFechaContratacion";
            txtFechaContratacion.Size = new Size(217, 23);
            txtFechaContratacion.TabIndex = 10;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(258, 275);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // DatosEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 337);
            Controls.Add(btnGuardar);
            Controls.Add(txtFechaContratacion);
            Controls.Add(txtSalario);
            Controls.Add(txtPuesto);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DatosEmpleado";
            Text = "DatosEmpleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtPuesto;
        private TextBox txtSalario;
        private DateTimePicker txtFechaContratacion;
        private Button btnGuardar;
    }
}