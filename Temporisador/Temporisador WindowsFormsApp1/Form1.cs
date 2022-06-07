using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temporisador_WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int tempo, hora, minuto, segundo;

        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try{
                tempo = int.Parse(txt_tempo.Text);
                timer1.Enabled = true;

                if (tempo >= 3600)
                {
                    hora = tempo / 3600;
                    minuto = (tempo % 3600)/60;
                    segundo = (tempo % 3600) % 60;
                } else if (tempo > 59)
                {
                    hora = 0;
                    minuto = tempo / 60;
                    segundo = tempo % 60;
                }
                else
                {
                    hora = 0;
                    minuto = 0;
                    segundo = tempo;
                }
                lb_temporisador.Text = hora + ":" + minuto + ":" + segundo;
            }
            catch (Exception ex)
            {

            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hora > 0 || minuto > 0 || segundo>0)
            {
                if(segundo > 0)
                    segundo--;
            }
            if (minuto == 0 && hora>0)
            {
                hora--;
                minuto = 59;
            }
            else if(segundo == 0 && minuto >0)
            {
                 minuto--;
                 segundo = 59;
            }
            
            lb_temporisador.Text = hora + ":" + minuto + ":" + segundo;

        }
    }
    
}
