using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePed_0._1.View
{
    public partial class Man : Form
    {
        private string lastpath;
        public Man()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt";
            var resu = saveFileDialog1.ShowDialog();

            if (resu.Equals(DialogResult.OK))
            {
                lastpath = saveFileDialog1.FileName;
                Date.DateController.write(lastpath, textBox1.Text);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NotePad foi feito apartir de um tutorial do YouTube \nLINK: https://www.youtube.com/watch?v=3gy2pZ4bF60");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = ".txt";
            openFileDialog1.Filter = "Text files(*.txt)|*.txt";

            var result = openFileDialog1.ShowDialog();

            if (result.Equals(DialogResult.OK))
            {
                lastpath = openFileDialog1.FileName;
                Text = "NotePad - "+Date.DateController.extrairNome(lastpath);
                textBox1.Text = Date.DateController.Read(lastpath);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(lastpath))
            {
                Date.DateController.write(lastpath, textBox1.Text);
            }
            else
            {
                saveFileDialog1.Filter = "Text files(*.txt)|*.txt";
                var resu = saveFileDialog1.ShowDialog();

                if(resu.Equals(DialogResult.OK))
                {
                    lastpath = saveFileDialog1.FileName;
                    Date.DateController.write(lastpath, textBox1.Text);
                }
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog()== DialogResult.OK)
            {
                this.textBox1.Font = fontDialog1.Font;
            }
        }
    }
}
