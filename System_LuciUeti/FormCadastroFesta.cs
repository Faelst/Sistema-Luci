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
    public partial class FormCadastroFesta : Form
    {

        public FormCadastroFesta()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu ss = new FormMenu();
            ss.Show();
        }

        public void button1_Click(object sender, EventArgs e)
        {

            bool jaExiste = false;
            classe_eventos objEv = new classe_eventos();
            objEv.nome_contrato = txtNomeContrato.Text;
            objEv.cpf_contrato = txtCpf_contrato.Text;
            objEv.rg_contrato = txtRg_contrato.Text;
            objEv.endereco_contrato = txtEndereco_contrato.Text;
            objEv.nome_evento = txtNomeEvento_contrato.Text;
            objEv.tipo_festa = comboBoxTipoFesta_contrato.Text;
            objEv.horario_evento_inicio = txtHorarioInicio_contrato.Text;
            objEv.horario_evento_termino = txtHorarioTermino_contrato.Text;
            objEv.obs_evento = txtObs_contrato.Text;
            objEv.email_contrato = txtEmail_contrato.Text;
            //objEv.valor_pessoa_contrato = Convert.ToDouble(txtValorPessoa_contrato.Text);
            //objEv.tel_principal_contrato = Convert.ToInt16(txtTel_contrato.Text);
            //objEv.tel_recado_contrato = Convert.ToInt16(txtTelRecado_contrato);
            //objEv.cep_contrato = Convert.ToInt16(txtCEP_contrato.Text);
            //objEv.nCasa_contrato = Convert.ToInt16(txtNcasa_contrato.Text);
            //objEv.qtde_convidados = Convert.ToInt32(txtQtde_contrato.Text);
            //objEv.valor_total_contrato = (Convert.ToDouble(txtValorPessoa_contrato.Text) * Convert.ToDouble(txtQtde_contrato.Text));

            MessageBox.Show("Salvo Com Sucesso"," atenção");

            for (int i = 0; i < FormLogin.lista.Count; i++)
            {
                if (FormLogin.lista[i].nome_contrato == objEv.nome_contrato)
                {
                    jaExiste = true;
                }
            }


            if (jaExiste == false)
            {
                FormLogin.lista.Add(objEv);
            } else
            {
               DialogResult resposta = MessageBox.Show("Já existe.", " Deseja cadastrar Novamente ?" , MessageBoxButtons.YesNo);
                if (resposta == DialogResult.Yes)
                {
                    FormLogin.lista.Add(objEv);
                }
            }


            /*
             * 1. recuperar os dados do formulario
             * 2. criar o objeto da classe evento
             * 3. popular os atributos 
             * 4. criar um objeto do Form formFestaCadastro
             * 5. passar o objeto evento como parametro do metodo da classe formFestaCadastro
            */
        } 

        private void button4_Click(object sender, EventArgs e)
        {
          
        }
    }
}
