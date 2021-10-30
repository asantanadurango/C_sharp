using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CEntidades;
using CReglas;
using System.Data;

namespace Capas
{
    public partial class form_medico : System.Web.UI.Page
    {

        CRegMedico ONmedico = new CRegMedico();
        CEMedico OEmedico = new CEMedico();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            OEmedico.Idmedico= Convert.ToString(tbIdmedico.Text);
            OEmedico.Nomedico = Convert.ToString(tbNommedico.Text);
            OEmedico.Especialidad = Convert.ToString(tbEspecialidad.Text);
            OEmedico.Telmedico = Convert.ToString(tbTelmedico.Text);
            OEmedico.Activo = 1;
            if (ONmedico.guardar_medico(OEmedico))
            {
                Label1.Text = "Medico guardado";

            }
            else
            {
                Label1.Text = "No se pudo guardar medico";
            }
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            OEmedico.Idmedico = Convert.ToString(tbIdmedico.Text);

            ds = ONmedico.consultar_medico(OEmedico);
            if (ds.Tables[0].Rows.Count == 0)
            {
                Label1.Text = "No hay medico";
            }
            else
            {
                Label1.Text = ds.Tables[0].Rows[0]["id_medico"].ToString();
                txtnommedico.Text = ds.Tables[0].Rows[0]["nom_medico"].ToString();
                txtespecialidad.Text = ds.Tables[0].Rows[0]["especialidad"].ToString();
                txttelmedico.Text = ds.Tables[0].Rows[0]["tel_medico"].ToString();
                txtactivo.Text = ds.Tables[0].Rows[0]["activo"].ToString();

            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            OEmedico.Idmedico = Convert.ToString(tbIdmedico.Text);

            if (ONmedico.anular_medico(OEmedico))
            {
                Label1.Text = "Medico anulado";
            }
            else
            {
                Label1.Text = "No se pudo anular";
            }
        }
    }
}