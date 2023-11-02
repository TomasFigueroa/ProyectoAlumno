using CapoDatos;
using System.Data.OleDb;
using System.Data;
using CapoDatos;
using BackendAlumno;

namespace CapaNegocio
{
    public class NegAlumno
    {
        AdminAlumno DatosAlumno = new AdminAlumno();
        public int abmAutos(string accion, ALumno alumno)
        {
            return DatosAlumno.abmAlumno(accion, alumno);
        }
        public DataSet ListadoAutos(string cual)
        {
            return DatosAlumno.listadoAlumno(cual);
        }
    }
}