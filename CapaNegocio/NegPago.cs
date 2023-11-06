using BackendAlumno;
using CapoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegPago
    {
        AdminPago DatosPago = new AdminPago();
        public int abmPago(string accion, Pago pago)
        {
            return DatosPago.abmPago(accion, pago);
        }
        public DataSet ListadoPago(string cual)
        {
            return DatosPago.listadoPago(cual);
        }
    }
}
