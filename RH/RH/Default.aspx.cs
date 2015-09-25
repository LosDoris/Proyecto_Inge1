using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace RH
{
    public partial class _Default : Page
    {

        ControladoraRH controladoraRH = new ControladoraRH();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnInsertar_Click(object sender, EventArgs e)
        {
           Object[] datos = new Object[2];
           datos[0] = this.txtID.Text;
           datos[0] = this.TextBox2.Text;
           controladoraRH.insertar(datos);
        }
        protected void btnModificar_Click(object sender, EventArgs e)
        {
            Object[] datos = new Object[2];
            datos[0] = this.txtID.Text;
            datos[0] = this.TextBox2.Text;
            controladoraRH.insertar(datos);
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            controladoraRH.eliminar(Convert.ToInt32(this.txtID.Text));
        }
        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            controladoraRH.consultarRH();
        }
    }

    
}