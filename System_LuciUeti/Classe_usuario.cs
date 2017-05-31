using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;
using NpgsqlTypes;

namespace System_LuciUeti
{
    class Classe_usuario
    {
        private int id_usuario { get; set; }
        private string nome { get; set; }
        private string senha { get; set; }

        public static Classe_usuario Logar(string nome, string senha)
        {

            Classe_usuario usuario = new Classe_usuario();
            NpgsqlConnection conexao = null;
            try
            {
                conexao = new ConectaDB().getConexao();
                //string sql = "SELECT * FROM usuario WHERE nome = '" + nome + "' and senha = '" + senha + "'";
                string sql = "SELECT * FROM usuario WHERE nome = 'fael' and senha = '123'";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    usuario.nome = dr["nome"].ToString();
                    usuario.senha = dr["senha"].ToString();
                }
                conexao.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao logar. " + ex.Message);
            }

            return usuario;
        }
    }
}
