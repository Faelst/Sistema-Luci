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
                string[] nova_linha = { FormLogin.lista[i].nome_contrato };
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

