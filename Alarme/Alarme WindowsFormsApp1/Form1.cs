using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Alarme_WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        System.Timers.Timer tempo;
        SoundPlayer tocar = new SoundPlayer();

        delegate void UpdateLable(Label lb1, string value);

        void UpDateLable(Label lb1,string value)
        {
            lb1.Text = value; 
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tempo = new System.Timers.Timer();
            tempo.Interval = 1000;
            tempo.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            DateTime tempoCorreto =  DateTime.Now;
            DateTime tempoUsuario = dateTimePicker1.Value;

            if(tempoCorreto.Hour== tempoUsuario.Hour && tempoCorreto.Minute== tempoUsuario.Minute && tempoCorreto.Second == tempoUsuario.Second)
            {
                tempo.Stop();
                try
                {
                    UpdateLable upd = UpDateLable;

                    if (label1.InvokeRequired)
                        Invoke(upd, label1, "Esta na hora");
                    
                    
                    tocar.SoundLocation = @"C:\Windows\Media\Alarm05.wav";
                    tocar.PlayLooping();
                }catch(Exception ex)
                {

                }
            }
        }

        private void bn_iniciar_Click(object sender, EventArgs e)
        {
            tempo.Start();
            label1.Text = "Rodando...";
        }

        private void btn_parar_Click(object sender, EventArgs e)
        {
            tempo.Stop();
            label1.Text = "Parado!";
            tocar.Stop();   
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
