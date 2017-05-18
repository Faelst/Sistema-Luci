using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_LuciUeti
{
    public partial class formFestasCadastradas : Form
    {
        
        public formFestasCadastradas()
        {
            InitializeComponent();
            for (int i = 0; i < FormLogin.lista.Count; i++)
            { 
                string[] nova_linha = {FormLogin.lista[i].id_contrato.ToString() ,  FormLogin.lista[i].nome_contrato , FormLogin.lista[i].data.ToString() , FormLogin.lista[i].cpf_contrato.ToString(), FormLogin.lista[i].rg_contrato.ToString() , FormLogin.lista[i].tel_principal_contrato.ToString(),FormLogin.lista[i].tel_recado_contrato.ToString(), FormLogin.lista[i].cep_contrato.ToString() , FormLogin.lista[i].nCasa_contrato.ToString(), FormLogin.lista[i].email_contrato.ToString(), FormLogin.lista[i].endereco_contrato.ToString(), FormLogin.lista[i].nome_evento.ToString(), FormLogin.lista[i].tipo_festa.ToString() , FormLogin.lista[i].valor_pessoa_contrato.ToString() , FormLogin.lista[i].valor_total_contrato.ToString(), FormLogin.lista[i].data_evento.ToString(), FormLogin.lista[i].horario_evento_inicio.ToString(), FormLogin.lista[i].horario_evento_termino.ToString() , FormLogin.lista[i].obs_evento.ToString() };
                dgvContrato.Rows.Add(nova_linha);

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
    }
    }

