using BackendAlumno;
using CapoDatos;
using System.Data;

namespace CapaNegocio
{
    public class NegAlumno
    {
        AdminAlumno DatosAlumno = new AdminAlumno();
        
        public int abmAlumno(string accion, ALumno aLumno)
        {
            return DatosAlumno.abmAlumno(accion, aLumno);
        }
        public DataSet ListadoAlumno(string cual)
        {
            return DatosAlumno.listadoAlumno(cual);
        }
    }
}