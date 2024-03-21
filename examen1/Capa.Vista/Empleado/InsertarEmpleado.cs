using Capa.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa.Vista.Empleado
{
    public partial class InsertarEmpleado : Form
    {
        public InsertarEmpleado()
        {
            InitializeComponent();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string puesto = txtPuesto.Text;
            decimal salario;
            if (!decimal.TryParse(txtSalario.Text, out salario))
            {
                MessageBox.Show("El salario debe ser un valor numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime fechaContratacion = dateTimePicker1.Value;

            
            EmpleadoDAL empleadoDAL = new EmpleadoDAL();
            empleadoDAL.InsertarEmpleado(nombre, apellido, puesto, salario, fechaContratacion);

            
            MessageBox.Show("Empleado insertado correctamente.");
        }
    }
}
