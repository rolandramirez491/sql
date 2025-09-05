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
        CD_Empleado empleado = new CD_Empleado();

        public void Insertar(int id,string nom,string ape,double salario)
        {
            empleado.InsertarEmpleado(id,nom,ape,salario);
        }

        public void Actualizar (int id,string nom,string ape,double salario)
        {
            empleado.ActualizarEmpleado(id, nom,ape,salario);
        }
        public void Eliminar (int id)
        {
            empleado.EliminarEmpleado(id);

        }

        public DataRow Buscar(int id)
        {
            return empleado.BuscarEmpleado(id);
        }

        public DataTable Listar()
        {
            return empleado.ListarEmpleados();
        }
    }
}
