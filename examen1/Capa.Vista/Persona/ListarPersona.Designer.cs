namespace Capa.Vista.Persona
{
    partial class ListarPersona
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
            menuStrip1 = new MenuStrip();
            eDITAREMPLEADOToolStripMenuItem = new ToolStripMenuItem();
            eLIMINAREMPLEADOToolStripMenuItem = new ToolStripMenuItem();
            iNSERTAREMPLEADOToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(315, 149);
            label1.Name = "label1";
            label1.Size = new Size(163, 21);
            label1.TabIndex = 0;
            label1.Text = "INSERTAR EMPLEADO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 37);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 1;
            label2.Text = "EMPLEADO ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(315, 43);
            label3.Name = "label3";
            label3.Size = new Size(164, 21);
            label3.TabIndex = 2;
            label3.Text = "ELIMINAR EMPLEADO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 149);
            label4.Name = "label4";
            label4.Size = new Size(142, 21);
            label4.TabIndex = 3;
            label4.Text = "LISTAR EMPLEADO";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { eDITAREMPLEADOToolStripMenuItem, eLIMINAREMPLEADOToolStripMenuItem, iNSERTAREMPLEADOToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // eDITAREMPLEADOToolStripMenuItem
            // 
            eDITAREMPLEADOToolStripMenuItem.Name = "eDITAREMPLEADOToolStripMenuItem";
            eDITAREMPLEADOToolStripMenuItem.Size = new Size(120, 20);
            eDITAREMPLEADOToolStripMenuItem.Text = "EDITAR EMPLEADO";
            // 
            // eLIMINAREMPLEADOToolStripMenuItem
            // 
            eLIMINAREMPLEADOToolStripMenuItem.Name = "eLIMINAREMPLEADOToolStripMenuItem";
            eLIMINAREMPLEADOToolStripMenuItem.Size = new Size(136, 20);
            eLIMINAREMPLEADOToolStripMenuItem.Text = "ELIMINAR EMPLEADO";
            // 
            // iNSERTAREMPLEADOToolStripMenuItem
            // 
            iNSERTAREMPLEADOToolStripMenuItem.Name = "iNSERTAREMPLEADOToolStripMenuItem";
            iNSERTAREMPLEADOToolStripMenuItem.Size = new Size(133, 20);
            iNSERTAREMPLEADOToolStripMenuItem.Text = "INSERTAR EMPLEADO";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(587, 227);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS";
            // 
            // DatosPersona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "DatosPersona";
            Text = "DatosPersona";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem eDITAREMPLEADOToolStripMenuItem;
        private ToolStripMenuItem eLIMINAREMPLEADOToolStripMenuItem;
        private ToolStripMenuItem iNSERTAREMPLEADOToolStripMenuItem;
        private GroupBox groupBox1;
    }
}