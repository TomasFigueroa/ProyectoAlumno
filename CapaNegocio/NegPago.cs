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
    internal class NegPago
    {
        AdminPago DatosPago = new AdminPago();
        public int abmAutos(string accion, Pago pago)
        {
            return DatosPago.abmPago(accion, pago);
        }
        public DataSet ListadoAutos(string cual)
        {
            return DatosPago.listadoPago(cual);
        }
    }
}
