using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_1._0_WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        float valor;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btn_numero_Click(object sender, EventArgs e)
        {
            Button numero = (Button)sender;
            
            if(numero.Text == ",")
            { }
            else if (txt_resultado.Text == "0")
                txt_resultado.Clear();
            
            txt_resultado.Text = txt_resultado.Text + numero.Text;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_resultado.Text = "0";
            label1.Text = " ";
        }

        private void operador_Click(object sender, EventArgs e)
        {
            Button op = (Button)sender;

            operacao = op.Text;
            valor = float.Parse(txt_resultado.Text);
            label1.Text = txt_resultado.Text + operacao;
            txt_resultado.Text = string.Empty;
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            float resultado = 0;

            try
            {
                if (operacao == "+")
                    resultado =  valor +(float.Parse(txt_resultado.Text));
                                      
                if (operacao == "-")   
                    resultado =  valor- (float.Parse(txt_resultado.Text));
                                      
                if (operacao == "/")                                  
                    resultado =  valor/(float.Parse(txt_resultado.Text));

                if (operacao == "*")                                  
                    resultado = valor*(float.Parse(txt_resultado.Text));
            }                          
            catch (Exception) { }
            label1.Text = valor.ToString()  + operacao + txt_resultado.Text ;
            txt_resultado.Text = resultado.ToString();
        }

    }
}
