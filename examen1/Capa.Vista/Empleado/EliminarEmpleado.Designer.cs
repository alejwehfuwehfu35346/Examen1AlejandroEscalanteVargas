namespace Capa.Vista.Empleado
{
    partial class EliminarEmpleado
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
            btnBuscar = new Button();
            txtNombre = new TextBox();
            label6 = new Label();
            btnEliminar = new Button();
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
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(391, 359);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 39;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(358, 69);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(217, 23);
            txtNombre.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(212, 69);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 37;
            label6.Text = "Nombre";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(513, 359);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 36;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtFechaContratacion
            // 
            txtFechaContratacion.Location = new Point(358, 301);
            txtFechaContratacion.Name = "txtFechaContratacion";
            txtFechaContratacion.Size = new Size(217, 23);
            txtFechaContratacion.TabIndex = 35;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(358, 260);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(217, 23);
            txtSalario.TabIndex = 34;
            // 
            // txtPuesto
            // 
            txtPuesto.Location = new Point(358, 218);
            txtPuesto.Name = "txtPuesto";
            txtPuesto.Size = new Size(217, 23);
            txtPuesto.TabIndex = 33;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(358, 170);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(217, 23);
            txtApellido.TabIndex = 32;
            // 
            // txtIDEmpleado
            // 
            txtIDEmpleado.Location = new Point(358, 125);
            txtIDEmpleado.Name = "txtIDEmpleado";
            txtIDEmpleado.Size = new Size(217, 23);
            txtIDEmpleado.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(212, 307);
            label5.Name = "label5";
            label5.Size = new Size(124, 15);
            label5.TabIndex = 30;
            label5.Text = "Fecha de contratacion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(212, 263);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 29;
            label4.Text = "salario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(212, 221);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 28;
            label3.Text = "puesto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 170);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 27;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(212, 125);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 26;
            label1.Text = "ID Empleado";
            // 
            // EliminarEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscar);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(btnEliminar);
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
            Name = "EliminarEmpleado";
            Text = "EliminarEmpleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private TextBox txtNombre;
        private Label label6;
        private Button btnEliminar;
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
    }
}