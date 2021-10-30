using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades
{
    public class CEPaciente
    {
        private String idpaciente;
        private String tipdocumento;
        private String nompaciente;
        private String dirpaciente;
        private String telpaciente;
        private byte activo;
        public string Idpaciente { get => idpaciente; set => idpaciente = value; }
        public string Tipdocumento { get => tipdocumento; set => tipdocumento = value; }
        public string Nompaciente { get => nompaciente; set => nompaciente = value; }
        public string Dirpaciente { get => dirpaciente; set => dirpaciente = value; }
        public String Telpaciente { get => telpaciente; set => telpaciente = value; }
        public byte Activo { get => activo; set => activo = value; }
    }
}
