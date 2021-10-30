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
    public partial class form_cita : System.Web.UI.Page
    {
        CRegCitas ONcitas = new CRegCitas();
        CECitas OEcitas = new CECitas();


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            OEcitas.Codcita = Convert.ToString(tbCodcita.Text);
            OEcitas.Fecha = Convert.ToDateTime(tbFecha.Text);
            OEcitas.Hora = Convert.ToDateTime(tbHora.Text);
            OEcitas.Idmedico = Convert.ToString(tbIdmedico.Text);
            OEcitas.Idpaciente = Convert.ToString(tbIDpaciente.Text);
            OEcitas.Nomacompanante = Convert.ToString(tbAcompa.Text);
            OEcitas.Diagnostico = Convert.ToString(tbDiagnostico.Text);
            OEcitas.Valor = Convert.ToInt32(tbValor.Text);
            OEcitas.Activo = 1;
            if (ONcitas.guardar_cita(OEcitas))
            {
                Label1.Text = "Cita Guardada";

            }
            else
            {
                Label1.Text = "No se pudo guardar la cita";
            }
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            OEcitas.Codcita = Convert.ToString(tbCodcita.Text);

            ds = ONcitas.consultar_cita(OEcitas);
            if (ds.Tables[0].Rows.Count == 0)
            {
                Label1.Text = "No hay Cita";
            }
            else
            {
                //Label1.Text = ds.Tables[0].Rows[0]["cod_cita"].ToString();
                txtfecha.Text = ds.Tables[0].Rows[0]["fecha"].ToString();
                txthora.Text = ds.Tables[0].Rows[0]["hora"].ToString();
                txtidpaciente.Text = ds.Tables[0].Rows[0]["id_paciente"].ToString();
                txtidmedico.Text = ds.Tables[0].Rows[0]["id_medico"].ToString();
                txtvalor.Text = ds.Tables[0].Rows[0]["valor"].ToString();
                txtdiagnostico.Text = ds.Tables[0].Rows[0]["diagnostico"].ToString();
                txtnomacopañante.Text = ds.Tables[0].Rows[0]["nom_acompañante"].ToString();
                txtactivo.Text = ds.Tables[0].Rows[0]["activo"].ToString();

            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            OEcitas.Codcita = Convert.ToString(tbCodcita.Text);

            if (ONcitas.anular_cita(OEcitas))
            {
                Label1.Text = "Cita Eliminada";
            }
            else
            {
                Label1.Text = "No se pudo eliminar";
            }
        }
    }
}