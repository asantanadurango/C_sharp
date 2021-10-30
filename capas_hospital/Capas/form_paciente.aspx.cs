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
    public partial class form_paciente : System.Web.UI.Page
    {

        CRegPaciente ONpaciente = new CRegPaciente();
        CEPaciente OEpaciente = new CEPaciente();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            OEpaciente.Idpaciente = Convert.ToString(tbIdpaciente.Text);
            OEpaciente.Tipdocumento = Convert.ToString(tbTipdoc.Text);
            OEpaciente.Nompaciente = Convert.ToString(tbNompaciente.Text);
            OEpaciente.Dirpaciente = Convert.ToString(tbDirpaciente.Text);
            OEpaciente.Telpaciente = Convert.ToString(tbTelpaciente.Text);
            OEpaciente.Activo = 1;
            if (ONpaciente.guardar_paciente(OEpaciente))
            {
                Label1.Text = "Paciente guardado";

            }
            else
            {
                Label1.Text = "No se pudo guardar paciente";
            }
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            OEpaciente.Idpaciente = Convert.ToString(tbIdpaciente.Text);

            ds = ONpaciente.consultar_paciente(OEpaciente);
            if (ds.Tables[0].Rows.Count == 0)
            {
                Label1.Text = "No hay medico";
            }
            else
            {
                Label1.Text = ds.Tables[0].Rows[0]["id_paciente"].ToString();
                txttipdoc.Text = ds.Tables[0].Rows[0]["tip_doc"].ToString();
                txtnompaciente.Text = ds.Tables[0].Rows[0]["nom_paciente"].ToString();
                txtdirpaciente.Text = ds.Tables[0].Rows[0]["dir_paciente"].ToString();
                txttelpaciente.Text = ds.Tables[0].Rows[0]["tel_paciente"].ToString();
                txtactivo.Text = ds.Tables[0].Rows[0]["activo"].ToString();

            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            OEpaciente.Idpaciente = Convert.ToString(tbIdpaciente.Text);

            if (ONpaciente.anular_paciente(OEpaciente))
            {
                Label1.Text = "Paciente anulado";
            }
            else
            {
                Label1.Text = "No se pudo anular";
            }
        }
    }
}