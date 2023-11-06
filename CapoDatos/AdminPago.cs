using BackendAlumno;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapoDatos
{
    public class AdminPago : DatosConexion
    {
        public int abmPago(string accion, Pago pago)
        {
            int resultado = -1;
            string orden = string.Empty;
            if (accion == "Alta")
            {
                orden = $"insert into Pagos values ( '{pago.COD}','{pago.DNI_Alumno}','{pago.Cuota}',{pago.Fecha_Pago},{pago.Descripcion});";

            }

            if (accion == "Modificar")
            {
                orden = "update Pagos SET DNI_Alumno='" + pago.DNI_Alumno + "'Cuota='" + pago.Cuota + "Fecha_Pago=" + pago.Fecha_Pago + "Descripcion=" + pago.Descripcion + "'where COD='" + pago.COD + "'";
            }
            if (accion == "Borrar")
            {
                orden = "Delete* from Pagos WHERE DNI='" + pago.COD + "'";
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
                throw new Exception("Errror al tratar de guardar,borrar o modificar de autos", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }


        public DataSet listadoPago(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
            {
                orden = "select * from Pagos where COD = " + cual + ";";
            }

            else
            {
                orden = "select * from Pagos;";
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
                throw new Exception("Error al listar Pago", e);
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
