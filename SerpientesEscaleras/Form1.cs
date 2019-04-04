using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerpientesEscaleras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tablero tab = new Tablero();
            Dado dado = new Dado();
        }

        private void DadoBtn_Click(object sender, EventArgs e)
        {
            Tablero Tablero = new Tablero();
            Jugador j1 = new Jugador();
            Jugador j2 = new Jugador();
            while (j1.Posicion < 100 && j2.Posicion < 100)
            {
                j1.Mover(new Dado().Lanzar());
                j2.Mover(new Dado().Lanzar());

                if(Tablero.Casilla(j1.Posicion).esEscaleraoSerpiente())
                {
                    j1.Mover(Tablero.Casilla(j1.Posicion).)
                }
            }
        }
    }
}
