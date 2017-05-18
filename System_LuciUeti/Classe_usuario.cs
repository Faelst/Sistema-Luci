using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;

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
                string sql = "SELECT usuario FROM usuario WHERE usuario.nome = " + nome +" and usuario.senha = " + senha;

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    usuario.nome = dr["nome"].ToString();
                    usuario.senha = dr["senha"].ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar veiculos. " + ex.Message);
            }

            return usuario;
        }
    }
}
