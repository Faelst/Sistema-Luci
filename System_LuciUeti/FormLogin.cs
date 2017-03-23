using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace System_LuciUeti
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
            
        private void btnEntrar_Click(object sender, EventArgs e)
        {
          
                this.Hide();
                FormMenu ss = new FormMenu();
                ss.Show();
            }
    }
}
