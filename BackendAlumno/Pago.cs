using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendAlumno
{
    public class Pago
    {
        public int COD { get; set; }
        public DateTime Fecha_Pago { get; set; }
        public int Cuota { get; set; }
        public int Monto_Cuota { get; set; }
        public int DNI_Alumno { get; set; }
        public string Descripcion { get; set; }
    }
}
