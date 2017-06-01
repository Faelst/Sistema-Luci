using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Npgsql;

namespace System_LuciUeti
{
    public partial class formFestasCadastradas : Form
    {
        public static List<Classe_contratante> contratantes_carregados;

        public static List<classe_eventos> eventos_carregados;

        public static List<Classe_contratante> pesquisa;


        public formFestasCadastradas()
        {
            
            InitializeComponent();

            formFestasCadastradas.contratantes_carregados = Classe_contratante.carregar();

            List<Classe_contratante> simple2 = formFestasCadastradas.contratantes_carregados;

             for (int i = 0; i < simple2.Count; i++)
            {

                string[] nova_linha = {
                    simple2[i].id_contratante.ToString(),
                    simple2[i].nome,
                    simple2[i].cpf,
                    simple2[i].rg,
                    simple2[i].telefone,
                    simple2[i].tel_recado,
                    simple2[i].cep,
                    simple2[i].ncasa.ToString(),
                    simple2[i].email,
                    simple2[i].endereco,
                };
                dgvContratante.Rows.Add(nova_linha);
            }
            dgvContratante.ClearSelection();
            dvg_dadosEvento.ClearSelection();
        }

        private void dgvContrato_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        public void ExibeEventoCadastrado(classe_eventos evento)
        {
            //criar um metodo que popula a dgv com o objeto evento
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu ss = new FormMenu();
            ss.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvContratante.Rows.Clear();

            string pesquisar = txtPesquisar.Text;
            

            Classe_contratante cont = Classe_contratante.busca(pesquisar);
            
            pesquisa pesq = new pesquisa();

            pesq.id_contratante = cont.id_contratante;
            pesq.nome = cont.nome.ToString();

            List<pesquisa> simple3 = new List<System_LuciUeti.pesquisa>();
                        

           MessageBox.Show(pesq.id_contratante.ToString() ,pesq.nome.ToString());         

            for (int i = 0; i < simple3.Count; i++)
            {

                string[] nova_linha = {
                    simple3[i].id_contratante.ToString(),
                    simple3[i].nome,
                    simple3[i].cpf,
                    simple3[i].rg,
                    simple3[i].telefone,
                    simple3[i].tel_recado,
                    simple3[i].cep,
                    simple3[i].ncasa.ToString(),
                    simple3[i].email,
                    simple3[i].endereco,
                };
                dgvContratante.Rows.Add(nova_linha);
            }

        }

        public void dgvContratante_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvContratante.SelectedRows.Count > 0)
            {
                dvg_dadosEvento.Rows.Clear();

                List<classe_eventos> eventos = classe_eventos.buscar(Convert.ToInt16(dgvContratante.SelectedRows[0].Cells[0].Value));
                for (int i = 0; i < eventos.Count; i++)
                {

                    string[] nova_linha = {
                    eventos[i].contratante.ToString(),
                    eventos[i].nome,
                    eventos[i].data_contrato.ToString(),
                    eventos[i].tipo_evento
                };
                    dvg_dadosEvento.Rows.Add(nova_linha);
                }
            }
            dvg_dadosEvento.ClearSelection();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dgvContratante.Rows.Clear();
            formFestasCadastradas.contratantes_carregados = Classe_contratante.carregar();

            List<Classe_contratante> simple2 = formFestasCadastradas.contratantes_carregados;

            for (int i = 0; i < simple2.Count; i++)
            {

                string[] nova_linha = {
                    simple2[i].id_contratante.ToString(),
                    simple2[i].nome,
                    simple2[i].cpf,
                    simple2[i].rg,
                    simple2[i].telefone,
                    simple2[i].tel_recado,
                    simple2[i].cep,
                    simple2[i].ncasa.ToString(),
                    simple2[i].email,
                    simple2[i].endereco,
                };
                dgvContratante.Rows.Add(nova_linha);
            }
            dgvContratante.ClearSelection();
            dvg_dadosEvento.ClearSelection();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DataGridViewRow linha = dgvContratante.CurrentRow;
            string id_selecionado = dgvContratante[0, 0].Value.ToString();
            dgvContratante.Rows.Remove(linha);
           
            MessageBox.Show(id_selecionado.ToString());

            
            


            
            Classe_contratante cont = new Classe_contratante();

            cont.deletar();
        }
    }
}
    

