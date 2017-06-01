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
    public partial class FormCadastro_evento : Form
    {
        public FormCadastro_evento()
        {
            InitializeComponent();
            btnUpdate.Enabled = false;
        }

        public FormCadastro_evento(int idEvento)
        {
            InitializeComponent();

            classe_eventos evento = classe_eventos.buscar(0, idEvento)[0];
            txtNomeDoEvento_contrato.Text = evento.nome;
            txtIdEvento.Text = evento.id.ToString();
            txtIdCliente.Text = evento.contratante.ToString();
            comboTipodeFesta_contrato.Text = evento.tipo_evento;

            btnSavar.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeCliente = textPequisaNomeCliente.Text;
       

            Classe_contratante cont = Classe_contratante.busca(nomeCliente);

            txtIdCliente.Text = cont.id_contratante.ToString();
            txtNomeCliente.Text = cont.nome;
        }

        private void btnSavar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeDoEvento_contrato.Text;
            string tipo_evento = comboTipodeFesta_contrato.Text;
            DateTime horario_inicio = new DateTime(1970, 1, 1, Convert.ToInt16(txtHorarioInicio.Text), Convert.ToInt16(txtMinutoInicio.Text), 0);
            DateTime horario_termino = new DateTime(1970, 1, 1, Convert.ToInt16(txtHorarioTermino_contrato.Text), Convert.ToInt16(txtMinutoTermino_contrato.Text), 0);
            string obs = txtobs_contrato.Text;
            double valor_pessoa = Convert.ToDouble(txtValorPessoa_contrato.Text);
            double valor_total = Convert.ToDouble(textValorTotal.Text);
            DateTime data_contrato = DateTime.Now;
            DateTime data_evento = datapickeDatadeInicio_contrato.Value;
            int contratante = Convert.ToInt16(txtIdCliente.Text);
            int qtde_convidados = Convert.ToInt16(textNumConvidados.Text);

            classe_eventos evento = new classe_eventos(nome, tipo_evento, horario_inicio, horario_termino, obs, valor_pessoa, valor_total, data_contrato, data_evento, contratante, qtde_convidados);

            MessageBox.Show("Salvo com sucesso!");
            evento.save();
        }

        private void txtValorPessoa_contrato_TextChanged(object sender, EventArgs e)
        {
            textValorTotal.Text = (Convert.ToDouble(textNumConvidados.Text) * Convert.ToDouble(txtValorPessoa_contrato.Text)).ToString();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu a = new FormMenu();
            a.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToUInt16(txtIdEvento.Text);
            string nome = txtNomeDoEvento_contrato.Text;
            string tipo_evento = comboTipodeFesta_contrato.Text;
            DateTime horario_inicio = new DateTime(1970, 1, 1, Convert.ToInt16(txtHorarioInicio.Text), Convert.ToInt16(txtMinutoInicio.Text), 0);
            DateTime horario_termino = new DateTime(1970, 1, 1, Convert.ToInt16(txtHorarioTermino_contrato.Text), Convert.ToInt16(txtMinutoTermino_contrato.Text), 0);
            string obs = txtobs_contrato.Text;
            double valor_pessoa = Convert.ToDouble(txtValorPessoa_contrato.Text);
            double valor_total = Convert.ToDouble(textValorTotal.Text);
            DateTime data_contrato = DateTime.Now;
            DateTime data_evento = datapickeDatadeInicio_contrato.Value;
            int contratante = Convert.ToInt16(txtIdCliente.Text);
            int qtde_convidados = Convert.ToInt16(textNumConvidados.Text);

            classe_eventos evento = new classe_eventos(id, nome, tipo_evento, horario_inicio, horario_termino, obs, valor_pessoa, valor_total, data_contrato, data_evento, contratante, qtde_convidados);

            MessageBox.Show("Atualizado com sucesso!");
            evento.atualizar();
        }
    }
}
