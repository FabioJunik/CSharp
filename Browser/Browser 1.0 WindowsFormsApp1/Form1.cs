using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser_1._0_WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string home= null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Navegar()
        {
            if (txt_url.Text == string.Empty)
                MessageBox.Show("Nada a ser pesquisado!\nPor favor digite a URL");
            else
            {
                webBrowser1.Navigate(txt_url.Text);
            }
        }

        private void btn_ir_Click(object sender, EventArgs e)
        {
            Navegar();   
        }

        private void txt_url_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Navegar();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            if(home == null)
                webBrowser1.GoHome();
            else
                webBrowser1.Navigate(home);
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void webBrowser1_CanGoForwardChanged(object sender, EventArgs e)
        {
            btn_proximo.Enabled = webBrowser1.CanGoForward;
        }
        private void webBrowser1_CanGoBackChanged(object sender, EventArgs e)
        {
            btn_proximo.Enabled = webBrowser1.CanGoBack;
        }

        private void btn_parar_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btn_definirHome_Click(object sender, EventArgs e)
        {
            home = txt_url.Text;
        }
    }
}
