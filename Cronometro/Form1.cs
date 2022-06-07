using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; 

namespace Cronometro_0._1
{
    public partial class Form1 : Form
    {
        private Stopwatch watch;

        private void btn_parar_Click(object sender, EventArgs e)
        {
            watch.Stop();
        }

        public Form1()
        {
            InitializeComponent();
            watch = new Stopwatch();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            watch.Start();
        }

        private void btn_zerar_Click(object sender, EventArgs e)
        {
            watch.Reset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", watch.Elapsed);
        }
    }
}
