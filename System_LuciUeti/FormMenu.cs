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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
           FormCadastro_evento ss = new FormCadastro_evento();
            ss.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            formFestasCadastradas n = new formFestasCadastradas();
            n.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            formFestasCadastradas n = new formFestasCadastradas();
            n.Show();
        }

        private void btnCadContratante_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCadastro_contratante nn = new FormCadastro_contratante();
            nn.Show();

        }
    }
}
