using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Tictactoe
{
    public partial class Form1 : Form
    {
        AITicTacToe Game;
        public Form1()
        {
            InitializeComponent();
            Game = new AITicTacToe();
        }


        private void cell1_Click(object sender, EventArgs e) 
        {
            var myButton = (Button)sender;
            myButton.Enabled = false;
            bool xWin = false;
            txtTurn.Text = Game.getAttacker().ToString() + " Jogou!";
            myButton.Text = (Game.getAttacker() == AITicTacToe.Player.X) ? "X" : "O";
            Game.setValueOnBoard(int.Parse(myButton.Name.Replace("cell",""))-1);
            if (Game.HasWinner(Game.getBoard()))
            {
                getIndexes(Game.getIndices());

                if (MessageBox.Show(this, Game.getAttacker() + " VENCEU O JOGO !","Jogo Da Velha",MessageBoxButtons.OK) == System.Windows.Forms.DialogResult.OK)
                {
                    xWin = (Game.getAttacker() == AITicTacToe.Player.X) ? true : false;
                    if (xWin)
                    {
                        txtX.Text = (int.Parse(txtX.Text) + 1).ToString();
                    }
                    else
                    {
                        txtO.Text = (int.Parse(txtO.Text) + 1).ToString();
                    }
                    Game.InitBoard();
                    ResetButton();
                    HabilitaBotao(true);
                }
                Game.clearIndices();
                
            }
            else if (Game.isDraw(Game.getBoard())) {
                MessageBox.Show("Reiniciar Jogo!");
                Game.InitBoard();
                ResetButton();
                HabilitaBotao(true);
            }
            Game.getNextAttacker();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Jogador O , deseja iniciar o jogo ?", "Iniciar", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Game.setAttacker(AITicTacToe.Player.O);
            }
            else
            {
                Game.setAttacker(AITicTacToe.Player.X);
            }
            txtTurn.Text = Game.getAttacker().ToString() + " Jogou!";
        }

        private void btnResetar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this,"Deseja resetar o jogo ?","Jogo Da Velha",MessageBoxButtons.YesNo) == DialogResult.Yes) { 
                txtX.Text = "0";
                txtO.Text = "0";
                Form1_Load(sender, e);
                ResetButton();
                Game.InitBoard();
                HabilitaBotao(true);
            }
        }

        private void ResetButton() {
            foreach (Button btn in this.Controls.OfType<Button>())
            {
                if (btn.Text != "&Resetar")
                {
                    btn.Text = "";
                }
            }
        }

        private void HabilitaBotao(bool wen) {
            foreach (Button btn in this.Controls.OfType<Button>())
            {
                if (btn.Enabled == false)
                {
                    btn.Enabled = wen;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetButton();
        }
        
        private void getIndexes(List<int> indexes) {
            int ctr = 8;
            foreach (Button btn in this.Controls.OfType<Button>())
            {
                if (btn.Name != "btnResetar")
                {
                    ctr--;
                    foreach (int index in indexes)
                    {
                        if (index == ctr)
                        {
                            btn.Enabled = (btn.Enabled == false) ? true : true;
                            btn.ForeColor = Color.Green;
                        }
                    }
                }
                else {
                    ctr++;
                }
                
            }
        }
       
    }
}
