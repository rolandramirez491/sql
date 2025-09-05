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
        public void InsertarPelicula(int id, string nom, int duracion, string genero, int horafunc, int cantboletas)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_InsertarPelicula", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Cod", id);
                comando.Parameters.AddWithValue("@Nombre", nom);
                comando.Parameters.AddWithValue("@Duracion", duracion);
                comando.Parameters.AddWithValue("@Genero", genero);
                comando.Parameters.AddWithValue("@HoraFunc", horafunc);
                comando.Parameters.AddWithValue("@CantBoletas", cantboletas);
                //abrir la conexion
                cn.Open();
                //Ejecute el comando
                comando.ExecuteNonQuery();
            }
        }//metodo

        //Metodo actualizar
        public void ActualizarPelicula(int id, string nom, int duracion, string genero, int horafunc, int cantboletas)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_ActualizarPelicula", cn);
                comando.Parameters.AddWithValue("@Cod", id);
                comando.Parameters.AddWithValue("@Nombre", nom);
                comando.Parameters.AddWithValue("@Duracion", duracion);
                comando.Parameters.AddWithValue("@Genero", genero);
                comando.Parameters.AddWithValue("@HoraFunc", horafunc);
                comando.Parameters.AddWithValue("@CantBoletas", cantboletas);
                //abrir la conexion
                cn.Open();
                //Ejecute el comando
                comando.ExecuteNonQuery();
            }
        }//metodo

        //Metodo eliminar
        public void EliminarPelicula(int id)
        {
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_EliminarPelicula", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Cod", id);
                //abrir la conexion
                cn.Open();
                //Ejecute el comando
                comando.ExecuteNonQuery();
            }
        }//metodo

        //Buscar empleado
        public DataRow BuscarPelicula(int id)
        {
            DataTable dt = new DataTable(); //Tabla virtual
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //Crear el comando para ejecutar los procedimientos almacenados
                SqlCommand comando = new SqlCommand("sp_BuscarPelicula", cn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Cod", id);
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
            }
            if (dt.Rows.Count > 0){
                return dt.Rows[0];
            }else{
                return null;
            }
        }//metodo


        public DataTable ListarPeliculas()
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand("sp_ListarPeliculas", cn);
                comando.CommandType= CommandType.StoredProcedure;
                SqlDataAdapter da   =new SqlDataAdapter(comando); da.Fill(dt);
            }
            return dt;

        }
    }
}
