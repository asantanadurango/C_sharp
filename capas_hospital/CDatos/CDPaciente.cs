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
    public class CDPaciente
    {
        CConexion oconexion = new CConexion();
        SqlCommand ocmd = new SqlCommand();
        public bool Guardar_paciente(CEPaciente ocitas)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDHospital");
                ocmd.CommandText = "guardar_paciente";
                ocmd.Parameters.Add("@id_paciente", ocitas.Idpaciente);
                ocmd.Parameters.Add("@tip_doc", ocitas.Tipdocumento);
                ocmd.Parameters.Add("@nom_paciente", ocitas.Nompaciente);
                ocmd.Parameters.Add("@dir_paciente", ocitas.Dirpaciente);
                ocmd.Parameters.Add("@tel_paciente", ocitas.Telpaciente);
                ocmd.Parameters.Add("@activo", ocitas.Activo);
                ocmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }

        }
        public bool Anular_paciente(CEPaciente ocitas)// de CECitas recibe la información para guardar citas.
        {
            //Se realiza un crud dependiendo de los procedimientos almacenados que se han realizado, se realiza un método por cada procedimiento
            try  // desactiva la recoleccion automatica de errores
            {

                ocmd.CommandType = CommandType.StoredProcedure;// comando de sql para abrir la conexión
                ocmd.Connection = oconexion.conectar("BDHospital");// se emplea para conectar
                ocmd.CommandText = "anular_paciente";
                ocmd.Parameters.Add("@id_paciente", ocitas.Idpaciente);
                ocmd.ExecuteNonQuery();
                return true;

            }


            catch (Exception err)
            {
                throw new Exception(err.Message); // solo se ejecuta si hay error
            }

        }

        public DataSet Consultar_paciente(CEPaciente ocitas)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDHospital");
                ocmd.CommandText = "consultar_paciente";
                ocmd.Parameters.Add("@id_paciente", ocitas.Idpaciente);
                SqlDataAdapter da = new SqlDataAdapter(ocmd);
                da.SelectCommand = ocmd;
                DataSet ds = new DataSet();

                da.Fill(ds);
                return ds;


            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }


        }
    }
}
