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
            objEv.nome_contrato = txtNomeContrato.Text;

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
