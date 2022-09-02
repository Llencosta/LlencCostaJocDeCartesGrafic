using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LlencCostaJocDeCartasGrafic
{
    public partial class Form1 : Form
    {
        Baraja baraja = new Baraja();
        public Form1()
        {
            InitializeComponent();
            actualitzarLista();
        }

        private void NCartas_Click(object sender, EventArgs e)
        {
            MessageBox.Show(baraja.NumeoCartas().ToString());
        }

        private void RobarCarta_Click(object sender, EventArgs e)
        {
            MessageBox.Show(baraja.RobaCarta().ToString());
            actualitzarLista();
        }

        private void CojerCarta_Click(object sender, EventArgs e)
        {
            MessageBox.Show(baraja.CogeCarta((int)PCarta.Value).ToString());
            actualitzarLista();
        }

        private void CojerCartaAlazar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(baraja.CogeCartaAlAzar().ToString());
            actualitzarLista();
        }

        private void Barajar_Click(object sender, EventArgs e)
        {
            baraja.Barajar();
            actualitzarLista();
        }

        private void actualitzarLista()
        {
            ListaDeCartas.Items.Clear();
            for (int i = 0; i < baraja.getBaraja.Count; i++)
            {
                ListaDeCartas.Items.Add(baraja.getBaraja[i].ToString());
            }
        }
    }
}
