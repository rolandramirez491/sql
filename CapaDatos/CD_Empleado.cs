using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Empleado
    {
        //Usar la cadena de conexion
        private static readonly string cadena = 
            ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;

        //Metodo para insertar datos en la base de datos
        public void InsertarEmpleado(int id, string nom, string ape, double salario)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_InsertarEmpleado", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Identificacion", id);
                comando.Parameters.AddWithValue("@Nombre", nom);
                comando.Parameters.AddWithValue("@Apellido", ape);
                comando.Parameters.AddWithValue("@Salario", salario);
                //abrir la conexion
                cn.Open();
                //Ejecute el comando
                comando.ExecuteNonQuery();
            }
        }//metodo

        //Metodo actualizar
        public void ActualizarEmpleado(int id, string nom, string ape, double salario)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_ActualizarEmpleado", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Identificacion", id);
                comando.Parameters.AddWithValue("@Nombre", nom);
                comando.Parameters.AddWithValue("@Apellido", ape);
                comando.Parameters.AddWithValue("@Salario", salario);
                //abrir la conexion
                cn.Open();
                //Ejecute el comando
                comando.ExecuteNonQuery();
            }
        }//metodo

        //Metodo eliminar
        public void EliminarEmpleado(int id)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_InsertarEmpleado", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Identificacion", id);
                //abrir la conexion
                cn.Open();
                //Ejecute el comando
                comando.ExecuteNonQuery();
            }
        }//metodo

        //Buscar empleado
        public DataRow BuscarEmpleado(int id)
        {
            DataTable dt = new DataTable(); //Tabla virtual
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_BuscarEmpleado", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Identificacion", id);
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
            }
            if (dt.Rows.Count > 0){
                return dt.Rows[0];
            }else{
                return null;
            }
        }//metodo


        public DataTable ListarEmpleados()
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand("sp_ListarEmpleados", cn);
                comando.CommandType= CommandType.StoredProcedure;
                SqlDataAdapter da   =new SqlDataAdapter(comando); da.Fill(dt);
            }
            return dt;

        }
    }
}
