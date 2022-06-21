using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReviewSemaforo
{
    public partial class FrmSemaforo : Form
    {
        int ciclo = 1;
        public FrmSemaforo()
        {
            InitializeComponent();
        }
        private void LigarVermelho()
        {
            picVermelho.BackColor = Color.Red;
            picAmarelo.BackColor = Color.Black;
            picVerde.BackColor = Color.Black;
        }
        private void LigarAmarelo()
        {
            picVermelho.BackColor = Color.Black;
            picAmarelo.BackColor = Color.Yellow;
            picVerde.BackColor = Color.Black;
        }
        private void LigarVede()
        {
            picVermelho.BackColor = Color.Black;
            picAmarelo.BackColor = Color.Black;
            picVerde.BackColor = Color.Green;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Evento executando...");
            if (ciclo == 1)
            {
                LigarVermelho();
            }
            if (ciclo == 2)
            {
                LigarAmarelo();
            }

            if (ciclo == 3)
            {
                LigarVede();
                ciclo = 0;
            }
            ciclo++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ApagarLuzes();
            timer1.Start();
        }

        private void ApagarLuzes()
        {
            picVermelho.BackColor = Color.Black;
            picAmarelo.BackColor = Color.Black;
            picVerde.BackColor = Color.Black;
        }
    }
}
