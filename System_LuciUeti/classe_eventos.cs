using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_LuciUeti
{
    public class classe_eventos
    {
       public int nContrato, tel_principal_contrato, tel_recado_contrato, cep_contrato, nCasa_contrato, qtde_convidados;
       public string nome_contrato { get; set; }
       public string cpf_contrato { get; set; }        
       public string rg_contrato { get; set; }
        public string endereco_contrato { get; set; }
        public string nome_evento { get; set; }
        public string tipo_festa { get; set; }        
        public string horario_evento_inicio { get; set; }
        public string horario_evento_termino { get; set; }
        public string obs_evento { get; set; }
        public char email_contrato { get; set; }
        public double valor_pessoa_contrato { get; set; }
        public double valor_total_contrato { get; set; }

    }
}
