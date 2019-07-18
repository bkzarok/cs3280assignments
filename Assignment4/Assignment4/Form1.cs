using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class Form1 : Form
    {
        private char[,] tictac = new char[3,3];
        private int player_1_wins = 0;
        private int player_2_wins = 0;
        private int ties =0;
        private  static Random rand = new Random();
        private Boolean play_1_turn = true;
        private Boolean isGameStart = false;
        private Rules rules = new Rules();
        private int num_of_turns = 0;
        public Form1()
        {
            InitializeComponent();
            resetGame();
        }


        private void Button_play_again_Click(object sender, EventArgs e)
        {
            if (isGameStart)
            {
                resetGame();
                isGameStart = false ;
                button_play_again.Text = "Start Game";

            }
            else
            {
                startGame();
                isGameStart = true ;
                button_play_again.Text = "Reset Game";
                
            }
        }

        private void Button00_Click(object sender, EventArgs e)
        {
            if (whosTurn())
            {
                button00.Text = "X";
                button00.BackColor = Color.Green;  
                tictac[0, 0]= 'X';
            }
            else
            {
                button00.Text = "O";
                button00.BackColor = Color.Yellow;
                tictac[0, 0]= 'O';
            }
          
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            if (whosTurn())
            {
                button10.Text = "X";
                button10.BackColor = Color.Green;
                tictac[1, 0] = 'X';
              
                
            }
            else
            {
                button10.Text = "O";
                button10.BackColor = Color.Yellow;
                tictac[1, 0] = 'O';
                

            }
          
        }


        private void Button20_Click(object sender, EventArgs e)
        {
            if (whosTurn())
            {
               
                button20.Text = "X";
                button20.BackColor = Color.Green;
                tictac[2, 0] = 'X';
             
            }
            else
            {
                button20.Text = "O";
                button20.BackColor = Color.Yellow;
                tictac[2, 0] = 'O';
            }
          
        }

        private void Button01(object sender, EventArgs e)
        {
            if (whosTurn())
            {
                button01.Text = "X";
                button01.BackColor = Color.Green;
                tictac[0, 1] = 'X';
            }
            else
            {
                button01.Text = "O";
                button01.BackColor = Color.Yellow;
                tictac[0, 1] = 'O';
            }
           
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            if (whosTurn())
            {
                button11.Text = "X";
                button11.BackColor = Color.Green;
                tictac[1,1] = 'X';
                
            }
            else
            {
                button11.Text = "O";
                button11.BackColor = Color.Yellow;
                tictac[1, 1] = 'O';
                
            }
           
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            if (whosTurn())
            {
                button21.Text = "X";
                button21.BackColor = Color.Green;
                tictac[2, 1] = 'X';
               
            }
            else
            {
                button21.Text = "O";
                button21.BackColor = Color.Yellow;
                tictac[2, 1] = 'O';
                
            }
            
        }

        private void Button02_Click(object sender, EventArgs e)
        {
            if (whosTurn())
            {
                button02.Text = "X";
                button02.BackColor = Color.Green;
                tictac[0,2] = 'X';
                
            }
            else
            {
                button02.Text = "O";
                button02.BackColor = Color.Yellow;
                tictac[0, 2] = 'O';
                
            }
           
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            if (whosTurn())
            {
                button12.Text = "X";
                button12.BackColor = Color.Green;
                tictac[1, 2] = 'X';
                
            }
            else
            {
                button12.Text = "O";
                button12.BackColor = Color.Yellow;
                tictac[1, 2] = 'O';
                
            }
           
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            if (whosTurn())
            {
                button22.Text = "X";
                button22.BackColor = Color.Green;
                tictac[2, 2] = 'X';
     
            }
            else
            {
                button22.Text = "O";
                button22.BackColor = Color.Yellow;
                tictac[2, 2] = 'O';
            }
           
        }


        public Boolean whosTurn()
        {
            num_of_turns++;
            if (num_of_turns >= 5)
            {
                whoWon();
            }
            if (play_1_turn)
            {
                play_1_turn = false;
                label_game_status.Text = "It's Player 2 turn";
                return true;
            }
            else
            { play_1_turn = true;
                label_game_status.Text = "It's Player 1 turn";
                return false;
            }
        }

        public void whoWon()
        {
            if (rules.checkForWin(tictac))
            {
                if (play_1_turn)
                {
                    player_1_wins++;
                    label_player_1.Text = "Player 1 wins:" + player_1_wins;
                    MessageBox.Show("Player 1 Wins");
                    resetGame();
                }
                else
                {
                    player_2_wins++;
                    label_player_2.Text = "Player 2 wins: " + player_2_wins;
                    MessageBox.Show("Player 2 Wins");
                    resetGame();
                }
                
            }
            else
            { ties++; }
                
        }


        private void startGame()
        {

            button00.Enabled = true;
            button01.Enabled = true;
            button02.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;

        }

        public void resetGame()
        {
         
            isGameStart = false;
            button_play_again.Text = "Start Game";
            tictac = new char[3, 3];
            player_1_wins = 0;
            player_2_wins = 0;
            ties = 0;
            num_of_turns = 0;


            button00.Enabled = false;
            button01.Enabled = false;
            button02.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;
            button00.Text = "-";
            button01.Text = "-";
            button02.Text = "-";
            button10.Text = "-";
            button11.Text = "-";
            button12.Text = "-";
            button20.Text = "-";
            button21.Text = "-";
            button22.Text = "-";

            button00.BackColor = Color.Gray;
            button01.BackColor = Color.Gray;
            button02.BackColor = Color.Gray;
            button10.BackColor = Color.Gray;
            button11.BackColor = Color.Gray;
            button12.BackColor = Color.Gray;
            button20.BackColor = Color.Gray;
            button21.BackColor = Color.Gray;
            button22.BackColor = Color.Gray;

        }
        public static int GetRandomNumber(int min, int max)
        {
            lock (rand) // synchronize
            {
                return rand.Next(min, max);
            }
        }
    }
}
