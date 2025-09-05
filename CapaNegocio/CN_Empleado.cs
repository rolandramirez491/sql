using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;

namespace CapaNegocio
{
    public class CN_Empleado
    {
        CD_Empleado pelicula = new CD_Empleado();

        public void Insertar(int id, string nom, int duracion, string genero, int horafunc, int cantboletas)
        {
            pelicula.InsertarPelicula(id,nom,duracion,genero,horafunc,cantboletas);
        }

        public void Actualizar (int id, string nom, int duracion, string genero, int horafunc, int cantboletas)
        {
            pelicula.ActualizarPelicula(id, nom, duracion, genero, horafunc, cantboletas);
        }
        public void Eliminar (int id)
        {
            pelicula.EliminarPelicula(id);

        }

        public DataRow Buscar(int id)
        {
            return pelicula.BuscarPelicula(id);
        }

        public DataTable Listar()
        {
            return pelicula.ListarPeliculas();
        }
    }
}
