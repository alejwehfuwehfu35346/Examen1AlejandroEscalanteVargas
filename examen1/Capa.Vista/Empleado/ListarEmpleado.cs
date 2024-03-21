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
    public partial class ListarEmpleado : Form
    {
        public ListarEmpleado()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            {
              
                CargarListaEmpleados();
            }

            private void CargarListaEmpleados()
            {
                
                EmpleadoDAL empleadoDAL = new EmpleadoDAL();
                DataTable dataTable = empleadoDAL.ListarEmpleados();

                
                dgvEmpleados.DataSource = dataTable;
            }

            private void btnActualizar_Click(object sender, EventArgs e)
            {
                
                CargarListaEmpleados();
            }
        }
    }
}
