using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace RH
{
    public class ControladoraRH
    {
        ControladoraBDRecursosHumanos controladoraBDrh = new ControladoraBDRecursosHumanos();
        public DataTable consultarRH()
        {
            return controladoraBDrh.consultarRH();
        }

        public void insertar(Object[] datos) {
            EntidadRecursosHumanos venta = new EntidadRecursosHumanos(datos);
            controladoraBDrh.insertarRH(venta);
        }

        public void modificar(Object[] datos) {
            EntidadRecursosHumanos venta = new EntidadRecursosHumanos(datos);
            controladoraBDrh.modificarRH(venta);
        }

        public void eliminar(int id) {
            controladoraBDrh.eliminarRH(id);
        }


        public DataTable consultarRH(int idVenta)
        {
            return controladoraBDrh.consultarRH(idVenta);
        }
    }
}