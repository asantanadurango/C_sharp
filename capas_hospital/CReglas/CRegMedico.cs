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
    public class CRegMedico
    {
        CDMedico OFmedico = new CDMedico();
        public bool guardar_medico(CEMedico omedico)
        {
            return OFmedico.Guardar_medico(omedico);
        }
        public bool anular_medico(CEMedico omedico)
        {
            return OFmedico.Anular_medico(omedico);
        }

        public DataSet consultar_medico(CEMedico omedico)
        {
            return OFmedico.Consultar_medico(omedico);
        }
    }
}
