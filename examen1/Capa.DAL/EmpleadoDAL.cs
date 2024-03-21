using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.DAL
{
    public class EmpleadoDAL
    {
        string connectionString = "tu_cadena_de_conexión";

        public void InsertarEmpleado(string nombre, string apellido, string puesto, decimal salario, DateTime fechaContratacion)
        {
            // Validar los campos obligatorios y el salario como un valor numérico válido aquí

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Empleado (Nombre, Apellido, Puesto, Salario, FechaContratacion) VALUES (@Nombre, @Apellido, @Puesto, @Salario, @FechaContratacion)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Apellido", apellido);
                command.Parameters.AddWithValue("@Puesto", puesto);
                command.Parameters.AddWithValue("@Salario", salario);
                command.Parameters.AddWithValue("@FechaContratacion", fechaContratacion);

                connection.Open();
                command.ExecuteNonQuery();
            }

            Console.WriteLine("Empleado insertado correctamente.");
        }

        public void EditarEmpleado(int idEmpleado, string nombre, string apellido, string puesto, decimal salario, DateTime fechaContratacion)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Empleado SET Nombre = @Nombre, Apellido = @Apellido, Puesto = @Puesto, Salario = @Salario, FechaContratacion = @FechaContratacion WHERE IDEmpleado = @IDEmpleado";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Apellido", apellido);
                command.Parameters.AddWithValue("@Puesto", puesto);
                command.Parameters.AddWithValue("@Salario", salario);
                command.Parameters.AddWithValue("@FechaContratacion", fechaContratacion);
                command.Parameters.AddWithValue("@IDEmpleado", idEmpleado);

                connection.Open();
                command.ExecuteNonQuery();
            }

            Console.WriteLine("Empleado actualizado correctamente.");
        }

        public void EliminarEmpleado(int idEmpleado)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Empleado WHERE IDEmpleado = @IDEmpleado";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IDEmpleado", idEmpleado);

                connection.Open();
                command.ExecuteNonQuery();
            }

            Console.WriteLine("Empleado eliminado correctamente.");
        }

        public DataTable ListarEmpleados()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Empleado";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }
    }
}
