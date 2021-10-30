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
    public class CRegPaciente
    {
        CDPaciente OFpaciente = new CDPaciente();
        public bool guardar_paciente(CEPaciente opaciente)
        {
            return OFpaciente.Guardar_paciente(opaciente);
        }
        public bool anular_paciente(CEPaciente opaciente)
        {
            return OFpaciente.Anular_paciente(opaciente);
        }

        public DataSet consultar_paciente(CEPaciente opaciente)
        {
            return OFpaciente.Consultar_paciente(opaciente);
        }
    }
}
