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
    public partial class EditarEmpleado : Form
    {
        public EditarEmpleado()
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
                txtFechaContratacion.Value = empleado.FechaContratacion;
            }
            else
            {
                MessageBox.Show("No se encontró ningún empleado con el ID proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
          
            int idEmpleado;
            if (!int.TryParse(txtIDEmpleado.Text, out idEmpleado))
            {
                MessageBox.Show("Por favor, introduzca un ID de empleado válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string puesto = txtPuesto.Text;
            decimal salario;
            if (!decimal.TryParse(txtSalario.Text, out salario))
            {
                MessageBox.Show("El salario debe ser un valor numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime fechaContratacion = txtFechaContratacion.Value;

            
            EmpleadoDAL empleadoDAL = new EmpleadoDAL();
            empleadoDAL.EditarEmpleado(idEmpleado, nombre, apellido, puesto, salario, fechaContratacion);

           
            MessageBox.Show("Empleado actualizado correctamente.");
        }

        
        
