using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace System_LuciUeti
{
    public class Classe_contratante
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

        public Classe_contratante ()
        {

        }

        public Classe_contratante(string nome, string email, DateTime nascimento, string cpf, string rg, string endereco, string complemento,
                                    string cep, string telefone, string tel_recado , string ncasa) {

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

        public void save ()
        {
            Classe_usuario usuario = new Classe_usuario();
            NpgsqlConnection conexao = null;
            conexao = new ConectaDB().getConexao();
            //string sql = "SELECT * FROM usuario WHERE nome = '" + nome + "' and senha = '" + senha + "'";
            string sql = "INSERT INTO contratante (nome, email, nascimento, cpf, rg, endereco, complemento, cep, telefone, tel_recado, ncasa) " +
                String.Format("values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}' , '{10}')", 
                this.nome, this.email, this.nascimento.ToString("yyyy-MM-dd"), this.cpf, this.rg, this.endereco, this.complemento, this.cep, this.telefone, this.tel_recado ,this.ncasa);

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


        public static List<Classe_contratante> carregar()
        {

            List<Classe_contratante> contratantes = new List<Classe_contratante>();

            NpgsqlConnection conexao = null;
            try
            {
                conexao = new ConectaDB().getConexao();
                //string sql = "SELECT * FROM usuario WHERE nome = '" + nome + "' and senha = '" + senha + "'";
                string sql = "SELECT * FROM contratante";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Classe_contratante contratante = new Classe_contratante();
                    contratante.nome = dr["nome"].ToString();
                    contratante.id_contratante = Convert.ToInt16(dr["id"]);
                    contratante.email = dr["email"].ToString();
                    contratante.nascimento = Convert.ToDateTime(dr["nascimento"]);
                    contratante.cpf = dr["cpf"].ToString();
                    contratante.rg = dr["rg"].ToString();
                    contratante.endereco = dr["endereco"].ToString();
                    contratante.complemento = dr["complemento"].ToString();
                    contratante.cep = dr["cep"].ToString();
                    contratante.telefone = dr["telefone"].ToString();
                    contratante.tel_recado = dr["tel_recado"].ToString();
                    contratante.ncasa = dr["ncasa"].ToString();

                        

                    contratantes.Add(contratante);
                }
                conexao.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar veiculos. " + ex.Message);
            }

            return contratantes;
        }


    }
}
