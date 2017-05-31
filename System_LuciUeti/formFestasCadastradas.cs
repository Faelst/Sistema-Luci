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
        

            

            formFestasCadastradas.eventos_carregados = classe_eventos.buscar();
            

            List<classe_eventos> simple = formFestasCadastradas.eventos_carregados;


            for (int i = 0; i < simple.Count; i++)
            {

                string[] nova_linha = {
                    simple[i].id.ToString(),
                    simple[i].nome,
                };
                dvg_dadosEvento.Rows.Add(nova_linha);
            }
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



       


    }
    }

