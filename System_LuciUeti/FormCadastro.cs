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
    public partial class FormCadastro : Form
    {
        private bool a;

        public FormCadastro()
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
            //Convert.ToInt32(txtNumero_contrato.Text);

            do
            {
                Boolean a = false;


                if (txtNomeContrato.Text.Length <= 0)
                {

                    MessageBox.Show("Digite o nome do Contratante", "Erro", MessageBoxButtons.OK);
                    break;

                }
                else
                {
                    objEv.nome_contrato = txtNomeContrato.Text;
                }

                if (txtNumero_contrato.Text.Length <= 0)
                {
                    objEv.nContrato = 0;
                }
                else
                {
                    MessageBox.Show(txtNumero_contrato.Text);
                }
                //MessageBox.Show(objEv.data.ToString());

                // ( condição IF ) ? (retorno se true) : (retorno se falso)
                //objEv.data = textBox2.Text.Length > 0 ? Convert.ToDateTime(textBox2.Text) : Convert.ToDateTime(0);
                // MessageBox.Show(objEv.data.ToString());

                // if(textBox2.Text.Length >0)  objEv.data = Convert.ToDateTime(textBox2.Text);

                if (txtCpe_contrato.Text.Length <= 0)
                {
                    MessageBox.Show("Digite o CEP corretamente.", "ERRO", MessageBoxButtons.OK);
                    break;
                }
                else
                {
                    objEv.cpf_contrato = txtCpf_contrato.Text;
                }

                if (txtRg_contrato.Text == null)
                {
                    MessageBox.Show("Digite o CPF corretamente", "ERRO", MessageBoxButtons.OK);
                    break;
                }
                else
                {
                    objEv.rg_contrato = txtRg_contrato.Text;
                }

                if (txtTelPrincipal_contrato.Text.Length <= 0)
                {
                    MessageBox.Show(" Digite o telefone Corretamento. Ex: 12911111111", "ERRO", MessageBoxButtons.OK);
                    break;
                }
                else
                {
                    objEv.tel_principal_contrato = Convert.ToInt32(txtTelPrincipal_contrato.Text);
                }

                if (txtTelRecado_contrato.Text.Length <= 0)
                {
                    MessageBox.Show(" Digite o telefone de recado", "ERRO", MessageBoxButtons.OK);
                    break;
                }
                else
                {
                    objEv.tel_recado_contrato = Convert.ToInt32(txtTelRecado_contrato.Text);
                }

                if (txtCpe_contrato.Text.Length <= 0)
                {
                    MessageBox.Show("Digite o CPF Corretamente. ", "ERRO", MessageBoxButtons.OK);
                    break;
                }
                else
                {
                    objEv.cep_contrato = Convert.ToInt16(txtCpe_contrato.Text);
                }

                objEv.nCasa_contrato = Convert.ToInt16(txtNCasa_contrato.Text);
                objEv.email_contrato = txtEmail_contrato.Text;
                objEv.endereco_contrato = txtend_contrato.Text;
                objEv.nome_evento = txtNomeDoEvento_contrato.Text;
                objEv.tipo_festa = comboTipodeFesta_contrato.Text;
                objEv.valor_pessoa_contrato = Convert.ToDouble(txtValorPessoa_contrato.Text);
                objEv.valor_total_contrato = Convert.ToDouble(txtValorTotal_contrato.Text);
                objEv.data_evento = Convert.ToDateTime(datapickeDatadeInicio_contrato.Text);
                objEv.horario_evento_inicio = txtHorarioInicio.Text;
                objEv.horario_evento_termino = txtHorarioTermino_contrato.Text;
                objEv.obs_evento = txtObs_contrato.Text;

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
                }
                else
                {
                    DialogResult resposta = MessageBox.Show("Já existe.", " Deseja cadastrar Novamente ?", MessageBoxButtons.YesNo);
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
                a = true;
            } while (a == true);
            } 

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
