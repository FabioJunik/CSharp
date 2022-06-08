using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reprodutor_de_vidio_audio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] paths, files;

        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = paths[track_list.SelectedIndex];
            player.Ctlcontrols.play();
            timer1.Start();
            trackBar1.Value = 45;
            lbl_volume.Text = trackBar1.Value.ToString() + " %";
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex < track_list.Items.Count - 1)
            {
                track_list.SelectedIndex = track_list.SelectedIndex + 1;
            }

        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex > 0)
                track_list.SelectedIndex = track_list.SelectedIndex - 1;
        }

        private void btn_pause_Click_1(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
            lbl_msg.Text = "Pause";
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
            lbl_msg.Text = "Stop";
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
            lbl_msg.Text = "Playing...";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(player.playState== WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar1.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                progressBar1.Value = (int)player.Ctlcontrols.currentPosition;
            }
            lbl_track_start.Text = player.Ctlcontrols.currentPositionString;
            lbl_track_end.Text = player.Ctlcontrols.currentItem.durationString.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = trackBar1.Value;
            lbl_volume.Text = trackBar1.Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;
                for(int x = 0; x < files.Length; x++)
                {
                    track_list.Items.Add(files[x]);
                }   

            }
        }
    }
}
