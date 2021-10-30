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
    public class CDMedico
    {
        CConexion oconexion = new CConexion();
        SqlCommand ocmd = new SqlCommand();
        public bool Guardar_medico(CEMedico ocitas)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDHospital");
                ocmd.CommandText = "guardar_medico";
                ocmd.Parameters.Add("@id_medico", ocitas.Idmedico);
                ocmd.Parameters.Add("@activo", ocitas.Activo);
                ocmd.Parameters.Add("@nom_medico", ocitas.Nomedico);
                ocmd.Parameters.Add("@especialidad", ocitas.Especialidad);
                ocmd.Parameters.Add("@tel_medico", ocitas.Telmedico);
                ocmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }

        }
        public bool Anular_medico(CEMedico ocitas)// de CECitas recibe la información para guardar citas.
        {
            //Se realiza un crud dependiendo de los procedimientos almacenados que se han realizado, se realiza un método por cada procedimiento
            try  // desactiva la recoleccion automatica de errores
            {

                ocmd.CommandType = CommandType.StoredProcedure;// comando de sql para abrir la conexión
                ocmd.Connection = oconexion.conectar("BDHospital");// se emplea para conectar
                ocmd.CommandText = "anular_medico";
                ocmd.Parameters.Add("@id_medico", ocitas.Idmedico);
                ocmd.ExecuteNonQuery();
                return true;

            }


            catch (Exception err)
            {
                throw new Exception(err.Message); // solo se ejecuta si hay error
            }

        }

        public DataSet Consultar_medico(CEMedico ocitas)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDHospital");
                ocmd.CommandText = "consultar_medico";
                ocmd.Parameters.Add("@id_medico", ocitas.Idmedico);
                SqlDataAdapter da = new SqlDataAdapter(ocmd);
                DataSet ds = new DataSet();
                da.SelectCommand = ocmd;
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
