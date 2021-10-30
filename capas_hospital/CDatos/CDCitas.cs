using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;
using System.Data;
using System.Data.SqlClient;

namespace CDatos
{
    public class CDCitas
    {
        CConexion oconexion = new CConexion();
        SqlCommand ocmd = new SqlCommand();
        public bool Guardar_cita(CECitas ocitas)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDHospital");
                ocmd.CommandText = "guardar_cita";
                ocmd.Parameters.Add("@cod_cita", ocitas.Codcita);
                ocmd.Parameters.Add("@fecha", ocitas.Fecha);
                ocmd.Parameters.Add("@hora", ocitas.Hora);
                ocmd.Parameters.Add("@id_paciente", ocitas.Idpaciente);
                ocmd.Parameters.Add("@id_medico", ocitas.Idmedico);
                ocmd.Parameters.Add("@valor", ocitas.Valor);
                ocmd.Parameters.Add("@diagnostico", ocitas.Diagnostico);
                ocmd.Parameters.Add("@nom_acompañante", ocitas.Nomacompanante);
                ocmd.Parameters.Add("@activo", ocitas.Activo);
                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }

        }

        public DataSet Consultar_cita(CECitas ocitas)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDHospital");
                ocmd.CommandText = "consultar_cita";
                ocmd.Parameters.Add("@cod_cita", ocitas.Codcita);
                SqlDataAdapter da = new SqlDataAdapter(ocmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;


            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }


        }
        public bool Anular_cita(CECitas ocitas)// de CECitas recibe la información para guardar citas.
        {
            //Se realiza un crud dependiendo de los procedimientos almacenados que se han realizado, se realiza un método por cada procedimiento
            try  // desactiva la recoleccion automatica de errores
            {

                ocmd.CommandType = CommandType.StoredProcedure;// comando de sql para abrir la conexión
                ocmd.Connection = oconexion.conectar("BDHospital");// se emplea para conectar
                ocmd.CommandText = "anular_cita";
                ocmd.Parameters.Add("@cod_cita", ocitas.Codcita);
                ocmd.ExecuteNonQuery();
                return true;

            }


            catch (Exception err)
            {
                throw new Exception(err.Message); // solo se ejecuta si hay error
            }

        }

        
    }
}
