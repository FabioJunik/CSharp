using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Momory_Game_0._1
{
    public partial class Form1 : Form
    {
        int movimentos;
        int cliques, tagIndex;
        int cartasEncontradas;
        Image[] img = new Image[9];
        List<string> lista = new List<string>();
        int[] tags = new int[2];

        private void Inicio()
        {
            foreach(PictureBox i in Controls.OfType <PictureBox>())
            {
                tagIndex = int.Parse(string.Format("{0}", i.Tag));
                img[tagIndex]= i.Image; 
                i.Image = Properties.Resources.verso;
                i.Enabled= true;
            }
            Posicoes();
        }

        private void Posicoes()
        {
            foreach (PictureBox i in Controls.OfType<PictureBox>())
            {
                Random r = new Random();
                int [] xp= { 73, 216, 359, 502, 645, 788};
                int[] yp = { 35, 169, 303};

                Repeticao:

                var x = xp[ r.Next(0, xp.Length)];
                var y = yp [r.Next(0, yp.Length)];

                string verificacao = x.ToString() + y.ToString();

                if (lista.Contains(verificacao))
                {
                    goto Repeticao;
                }
                else
                {
                    i.Location = new Point(x, y);
                    lista.Add(verificacao);
                }

            }
        }
        public Form1()
        {
            InitializeComponent();
            Inicio();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ImagensClick_Click(object sender, EventArgs e)
        {
            bool parEncontrado = false;

            PictureBox pic = (PictureBox)sender;
            cliques++;
            tagIndex = int.Parse(string.Format("{0}", pic.Tag));
            pic.Image = img[tagIndex];
            pic.Refresh();

            if(cliques == 1)
            {
                tags[0] = int.Parse(string.Format("{0}", pic.Tag));
            }
            else if (cliques == 2)
            {
                movimentos++;
                lbl_movimentos.Text = "Movimentos :" +movimentos.ToString();
                tags[1]= int.Parse(string.Format("{0}", pic.Tag));
                parEncontrado = ChecagemPares();
                Devira(parEncontrado);
            }
        }

        private bool ChecagemPares()
        {
            cliques = 0;
            if (tags[0] == tags[1])
                return true;
            else
                return false;
        }

        private void Devira(bool cheque)
        {
            Thread.Sleep(500);
            foreach (PictureBox i in Controls.OfType<PictureBox>())
            {
                if(int.Parse(string.Format("{0}", i.Tag)) == tags[0]
                    || int.Parse(string.Format("{0}", i.Tag)) == tags[1])
                {
                    if(cheque == true)
                    {
                        i.Enabled = false;
                        cartasEncontradas++;
                    }
                    else
                    {
                        i.Image = Properties.Resources.verso;
                        i.Refresh();
                    }
                }
            }
            FinalizarJogo();
        }

        private void FinalizarJogo()
        {
            if (cartasEncontradas == img.Length * 2)
            {
                MessageBox.Show("Parabens !!! você terminou o jogo com " + movimentos + " jogadas");
                DialogResult ms = MessageBox.Show("Deseja continuar o jogo?", "Caixa de pergunta", MessageBoxButtons.YesNo);

                if (ms == DialogResult.Yes)
                {
                    cliques = movimentos = cartasEncontradas = 0;
                    lista.Clear();
                    Inicio();
                }
                else if (ms == DialogResult.No)
                {
                    Application.Exit();
                }
            }
        }
    }
}
