using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;
using CDatos;
using System.Data;



namespace CReglas
{
    public class CRegCitas
    {
        CDCitas odatcitas = new CDCitas();
        public bool guardar_cita(CECitas oentcita)
        {
            return odatcitas.Guardar_cita(oentcita);
        }
        public bool anular_cita(CECitas oentcita)
        {
            return odatcitas.Anular_cita(oentcita);
        }

        public DataSet consultar_cita(CECitas oentcita)
        {
            return odatcitas.Consultar_cita(oentcita);
        }


    }
}
