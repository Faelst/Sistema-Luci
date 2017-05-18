using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_LuciUeti
{
    public class classe_eventos
    {
        //public int id_contratante { get; set; }
        //public string tel_principal_contrato { get; set; }
        //public string tel_recado_contrato { get; set; }
        //public int cep_contrato { get; set; }
        //public int nCasa_contrato { get; set; }
        public int qtde_convidados {get; set;}
       //public string nome_contrato { get; set; }
       //public string cpf_contrato { get; set; }        
       //public string rg_contrato { get; set; }
        //public string endereco_contrato { get; set; }
        public string nome { get; set; }
        public string tipo_evento { get; set; }        
        public DateTime horario_inicio { get; set; }
        public DateTime horario_termino { get; set; }
        public string obs { get; set; }
       // public string email_contrato { get; set; }
        public double valor_pessoa { get; set; }
        public double valor_total { get; set; }
        public int id { get; set;}
        public DateTime data_contrato { get; set; }
        public DateTime data_evento { get; set; }


    }
}
