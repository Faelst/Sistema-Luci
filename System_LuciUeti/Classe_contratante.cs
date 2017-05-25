using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace System_LuciUeti
{
    class Classe_contratante
    {
        public int id_contratante { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        private DateTime nascimento { get; set; }
        private string cpf { get; set; }
        private string rg { get; set; }
        private string endereco { get; set; }
        private string complemento { get; set; }
        private string cep { get; set; }
        private string telefone { get; set; }
        private string tel_recado { get; set; }

        public Classe_contratante ()
        {

        }

        public Classe_contratante(string nome, string email, DateTime nascimento, string cpf, string rg, string endereco, string complemento,
                                    string cep, string telefone, string tel_recado) {

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
        }

        public void save ()
        {
            Classe_usuario usuario = new Classe_usuario();
            NpgsqlConnection conexao = null;
            conexao = new ConectaDB().getConexao();
            //string sql = "SELECT * FROM usuario WHERE nome = '" + nome + "' and senha = '" + senha + "'";
            string sql = "INSERT INTO contratante (nome, email, nascimento, cpf, rg, endereco, complemento, cep, telefone, tel_recado) " +
                String.Format("values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')", 
                this.nome, this.email, this.nascimento.ToString("yyyy-MM-dd"), this.cpf, this.rg, this.endereco, this.complemento, this.cep, this.telefone, this.tel_recado);

            NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
            cmd.ExecuteNonQuery();
            conexao.Close();
        }

        public static Classe_contratante busca (string nome)
        {
            Classe_contratante cont = new Classe_contratante();
            NpgsqlConnection conexao = null;
            try
            {
                conexao = new ConectaDB().getConexao();
                //string sql = "SELECT * FROM usuario WHERE nome = '" + nome + "' and senha = '" + senha + "'";
                string sql = String.Format("SELECT * FROM contratante WHERE nome = '{0}'", nome);

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cont.id_contratante = Convert.ToUInt16(dr["id"]);
                    cont.nome = dr["nome"].ToString();
                }
                conexao.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar veiculos. " + ex.Message);
            }

            return cont;
        }
    }
}
