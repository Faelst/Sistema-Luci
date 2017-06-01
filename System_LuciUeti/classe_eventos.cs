using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;

namespace System_LuciUeti
{
    public class classe_eventos
    {
        public int qtde_convidados {get; set;}
        public string nome { get; set; }
        public string tipo_evento { get; set; }        
        public DateTime horario_inicio { get; set; }
        public DateTime horario_termino { get; set; }
        public string obs { get; set; }
        public double valor_pessoa { get; set; }
        public double valor_total { get; set; }
        public int id { get; set;}
        public DateTime data_contrato { get; set; }
        public DateTime data_evento { get; set; }
        public int contratante { set; get; }


        public classe_eventos()
        {

        }

        public classe_eventos(string nome, string tipo_evento, DateTime horario_inicio, DateTime horario_termino, string obs, double valor_pessoa,
                                double valor_total, DateTime data_contrato, DateTime data_evento, int contratante, int qtde_convidados)
        {
            this.nome = nome;
            this.tipo_evento = tipo_evento;
            this.horario_inicio = horario_inicio;
            this.horario_termino = horario_termino;
            this.obs = obs;
            this.qtde_convidados = qtde_convidados;
            this.valor_pessoa = valor_pessoa;
            this.valor_total = valor_total;
            this.data_contrato = data_contrato;
            this.data_evento = data_evento;
            this.contratante = contratante;
        }
        public classe_eventos(int id, string nome, string tipo_evento, DateTime horario_inicio, DateTime horario_termino, string obs, double valor_pessoa,
                                double valor_total, DateTime data_contrato, DateTime data_evento, int contratante, int qtde_convidados)
        {
            this.id = id;
            this.nome = nome;
            this.tipo_evento = tipo_evento;
            this.horario_inicio = horario_inicio;
            this.horario_termino = horario_termino;
            this.obs = obs;
            this.qtde_convidados = qtde_convidados;
            this.valor_pessoa = valor_pessoa;
            this.valor_total = valor_total;
            this.data_contrato = data_contrato;
            this.data_evento = data_evento;
            this.contratante = contratante;
        }


        public void save()
        {
            NpgsqlConnection conexao = null;
            conexao = new ConectaDB().getConexao();
            //string sql = "SELECT * FROM usuario WHERE nome = '" + nome + "' and senha = '" + senha + "'";
            string sql = "INSERT INTO evento (nome, data_contrato, tipo_evento, data_evento, horario_inicio, horario_termino, num_convidados, valor_pessoa, valor_total, obs, contratante)" +
                String.Format("values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')",
                this.nome, this.data_contrato.ToString("yyyy-MM-dd"), this.tipo_evento, this.data_evento.ToString("yyyy-MM-dd"), this.horario_inicio.ToString("HH:mm:ss"), this.horario_termino.ToString("HH:mm:ss"), this.qtde_convidados, this.valor_pessoa, this.valor_total, this.obs, this.contratante);

            

            NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
            cmd.ExecuteNonQuery();
            conexao.Close();
        }

        public void excluir()
        {
            NpgsqlConnection conexao = null;
            try
            {
                conexao = new ConectaDB().getConexao();
                string sql = "delete from evento where id = '" + this.id.ToString() + "'";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar veiculos. " + ex.Message);
            }
        }

        public void atualizar()
        {
            NpgsqlConnection conexao = null;
            try
            {
                conexao = new ConectaDB().getConexao();
                string sql = "update evento set nome = '" + this.nome + "' where id = '" + this.id.ToString() + "'";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar veiculos. " + ex.Message);
            }
        }

        public static List <classe_eventos> buscar(int id_contratante, int id_evento)
        {

            List <classe_eventos> eventos = new List <classe_eventos>();

            NpgsqlConnection conexao = null;
            try
            {
                conexao = new ConectaDB().getConexao();
                //string sql = "SELECT * FROM usuario WHERE nome = '" + nome + "' and senha = '" + senha + "'";
                string sql;
                if (id_contratante != 0 && id_evento == 0)
                {
                    sql = "SELECT * FROM evento where contratante = '" + id_contratante +"'";
                } else
                {
                    sql = "SELECT * FROM evento where id = '" + id_evento + "'";
                }

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                
                while (dr.Read())
                {
                    classe_eventos evento = new classe_eventos();
                    evento.nome = dr["nome"].ToString();
                    evento.id = Convert.ToInt16(dr["id"]);
                    eventos.Add(evento);
                }
                conexao.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar veiculos. " + ex.Message);
            }

            return eventos;
        }
    }
}
