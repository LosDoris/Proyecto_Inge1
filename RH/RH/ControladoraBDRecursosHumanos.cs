using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace RH
{
    public class ControladoraBDRecursosHumanos
    {

        public DataTable consultarRH() {
            DataTable dt = new DataTable();
            //dt = adapterVentas.GetData();
            return dt;
        }

        public void insertarRH(EntidadRecursosHumanos RH) {
            try
            {
                
            }
            catch (SqlException e)
            {

            }
        }

        public void modificarRH(EntidadRecursosHumanos RH)
        {
            try
            {
            
            }
            catch (SqlException e)
            {
                
            }
        }

        public void eliminarRH(int id) {
            try
            {
                

            }
            catch (SqlException e)
            {
                
            }
        }

        public DataTable consultarRH(int idVenta) {
            DataTable dt = new DataTable();
            //dt = this.adapterVentas.consultarFila(idVenta);
            return dt;
        }
    }





}

