using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa.DAL;
using Capa.Modelos;
namespace Capa.BSS
{
    public class EmpleadoBSS
    {
        EmpleadoDAL dal = new EmpleadoDAL();

        public DataTable ListarEmpleadoBSS()
        {
            return dal.ListarEmpleadosDAL();
        }

        public void InsertarEmpleadoBSS(Empleado empleado)
        {
            dal.InsertarEmpleadoDAL(empleado);
        }

        public Empleado ObtenerEmpleadoBSS(int id)
        {
            return dal.ObtenerEmpleadoID(id);
        }

        public void EditarEmpleadoBSS(Empleado empleado)
        {
            dal.EditarEmpleadoDAL(empleado);
        }

        public void EliminarEmpleadoBSS(int id)
        {
            dal.EliminarEmpleadoDAL(id);
        }
    }
}
