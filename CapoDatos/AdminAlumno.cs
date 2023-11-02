using System.Data.OleDb;
using System.Data;
using BackendAlumno;

namespace CapoDatos
{
    public class AdminAlumno : DatosConexion
    {
        public int abmAlumno(string accion, ALumno alumno)
        {
            int resultado = -1;
            string orden = string.Empty;
            if (accion == "Alta")
            {
                orden = $"insert into Alumno values ( '{alumno.DNI}','{alumno.Nombre}','{alumno.Apellido}',{alumno.Analitico},{alumno.Legajo});";

            }

            if (accion == "Modificar")
            {
                orden = "update Alumno SET Nombre='" + alumno.Nombre + "'Apellido='" + alumno.Apellido + "Anlitico=" + alumno.Analitico + "Legajo=" + alumno.Legajo + "'where DNI='" + alumno.DNI + "'";
            }
            if (accion == "Borrar")
            {
                orden = "Delete* from Alumno WHERE DNI='" + alumno.DNI + "'";
            }

            // falta la orden de borrar
            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Errror al tratar de guardar,borrar o modificar de alumno", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }


        public DataSet listadoAlumno(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
            {
                orden = "select * from Alumno where DNI = " + cual + ";";
            }

            else
            {
                orden = "select * from Alumno;";
            }

            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter();
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Alumno", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }
    }

}
