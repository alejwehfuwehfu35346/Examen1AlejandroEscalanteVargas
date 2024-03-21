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
    public partial class EliminarEmpleado : Form
    {
        public EliminarEmpleado()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Obtener el ID del empleado a partir del TextBox
            int idEmpleado;
            if (!int.TryParse(txtIDEmpleado.Text, out idEmpleado))
            {
                MessageBox.Show("Por favor, introduzca un ID de empleado válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            EmpleadoDAL empleadoDAL = new EmpleadoDAL();
            Empleado empleado = empleadoDAL.ObtenerEmpleadoPorID(idEmpleado);

           
            if (empleado != null)
            {
                txtNombre.Text = empleado.Nombre;
                txtApellido.Text = empleado.Apellido;
                txtPuesto.Text = empleado.Puesto;
                txtSalario.Text = empleado.Salario.ToString();
                txtFechaContratacion.Text = empleado.FechaContratacion.ToShortDateString();
            }
            else
            {
                MessageBox.Show("No se encontró ningún empleado con el ID proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
          
            int idEmpleado;
            if (!int.TryParse(txtIDEmpleado.Text, out idEmpleado))
            {
                MessageBox.Show("Por favor, introduzca un ID de empleado válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este empleado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
             
                EmpleadoDAL empleadoDAL = new EmpleadoDAL();
                empleadoDAL.EliminarEmpleado(idEmpleado);

               
                LimpiarTextBoxes();

                
                MessageBox.Show("Empleado eliminado correctamente.");
            }
        }

        private void LimpiarTextBoxes()
        {
            txtIDEmpleado.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtPuesto.Text = "";
            txtSalario.Text = "";
            txtFechaContratacion.Text = "";
        }
    }
}
    }
}
