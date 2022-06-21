using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoComSelect
{
    public partial class FormePrincipal : Form
    {
        public FormePrincipal()
        {
            InitializeComponent();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            UsuarioBD usuario = new UsuarioBD();
            usuario.Consultar(Convert.ToInt32(textBoxIdConsulta.Text));
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            UsuarioBD usuario = new UsuarioBD();
            usuario.Inserir(textBoxInserir.Text);
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            UsuarioBD usuario = new UsuarioBD();
            usuario.Alterar(textBoxId.Text,textBoxNome.Text);
            
        }
            private void buttonExcluir_Click(object sender, EventArgs e)
        {
            UsuarioBD usuario = new UsuarioBD();
            usuario.Excluir(Convert.ToInt32(textBoxId.Text));
        }
    }
}
