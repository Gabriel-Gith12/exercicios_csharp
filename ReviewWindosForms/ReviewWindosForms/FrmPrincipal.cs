using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReviewWindosForms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void relatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroDeVeiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmCadVeiculos();
            frm.StartPosition = FormStartPosition.CenterScreen;
            new FrmCadVeiculos().ShowDialog(this);
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmFuncionarios();
            frm.StartPosition = FormStartPosition.CenterScreen;
            new FrmFuncionarios().ShowDialog(this);
        }

        private void inssToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmInss().ShowDialog();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmVenda().ShowDialog();
        }
    }
}
