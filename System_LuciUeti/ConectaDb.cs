using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;

namespace System_LuciUeti
{
    class ConectaDB
    {
        private string serverName = "localhost";
        private string port = "5433";               //MUDAR SENHA E O PORT (VARIANDO DE CADA MAQUINA).
        private string userName = "postgres";
        private string password = "Rafaelnba";
        private string dataBaseName = "postgres";


        public NpgsqlConnection getConexao()
        {
            try
            {
                string stgConexao = String.Format("Server={0}; Port={1}; User Id={2}; Password={3}; Database={4}",
                                                      serverName, port, userName, password, dataBaseName);


                NpgsqlConnection conexao = new NpgsqlConnection(stgConexao);

                conexao.Open();

                return conexao;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);

            }

        }

    }
}
