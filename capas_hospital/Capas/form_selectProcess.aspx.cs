using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Capas
{
    public partial class form_selectProcess : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void toCitas_Click(object sender, EventArgs e)
        {
            Response.Redirect("form_cita.aspx");
        }

        protected void toMedico_Click(object sender, EventArgs e)
        {
            Response.Redirect("form_medico.aspx");
        }

        protected void toPaciente_Click(object sender, EventArgs e)
        {
            Response.Redirect("form_paciente.aspx");
        }
    }
}