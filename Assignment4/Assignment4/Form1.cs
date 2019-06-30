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
        private int[,] tictac = new int[3,3];
        private int player_1_wins = 0;
        private int player_2_wins = 0;
        private int ties =0;
        private  static Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }


        private void Button_play_again_Click(object sender, EventArgs e)
        {

        }

        private void Button00_Click(object sender, EventArgs e)
        {

        }

        private void Button10_Click(object sender, EventArgs e)
        {

        }


        private void Button20_Click(object sender, EventArgs e)
        {

        }

        private void Button01(object sender, EventArgs e)
        {

        }

        private void Button11_Click(object sender, EventArgs e)
        {

        }

        private void Button21_Click(object sender, EventArgs e)
        {

        }

        private void Button02_Click(object sender, EventArgs e)
        {

        }

        private void Button12_Click(object sender, EventArgs e)
        {

        }

        private void Button22_Click(object sender, EventArgs e)
        {

        }

        private void startGame()
        {
            
            while (true)
            {
                if (tictac[GetRandomNumber(0, 3), GetRandomNumber(0, 3)] == 0)
                {
                    
                    break;
                }
              
            }

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
