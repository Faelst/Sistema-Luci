using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_LuciUeti
{
    class pesquisa
    {

        public int id_contratante { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public DateTime nascimento { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public string endereco { get; set; }
        public string complemento { get; set; }
        public string cep { get; set; }
        public string telefone { get; set; }
        public string tel_recado { get; set; }
        public string ncasa { get; set; }

        public pesquisa()
        {

        }

        public pesquisa(string nome, string email, DateTime nascimento, string cpf, string rg, string endereco, string complemento,
                                    string cep, string telefone, string tel_recado, string ncasa)
        {

            this.nome = nome;
            this.email = email;
            this.nascimento = nascimento;
            this.cpf = cpf;
            this.rg = rg;
            this.endereco = endereco;
            this.complemento = complemento;
            this.cep = cep;
            this.telefone = telefone;
            this.tel_recado = tel_recado;
            this.ncasa = ncasa;
        }
    }
}
