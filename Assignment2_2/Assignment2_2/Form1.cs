using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2_2
{
    public partial class Form1 : Form
    {
        int[] frequency = new int[6];
        int[] percent = new int[6];
        int[] timesguessed = new int[6];
        int timesplayed = 0;
        int timeswon = 0;
        int timeslost = 0;
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Text = "FACE\t   FREQUENCY\t       PERCENT\tTIMES GUESSED\n"

                                 + "1\t\t0\t\t0%\t\t0\n"
                                 + "2\t\t0\t\t0%\t\t0\n"
                                 + "3\t\t0\t\t0%\t\t0\n"
                                 + "4\t\t0\t\t0%\t\t0\n"
                                 + "5\t\t0\t\t0%\t\t0\n"
                                 + "6\t\t0\t\t0%\t\t0\n";



        }



        private void Button1_Click(object sender, EventArgs e)
        {

            int value;
            if (int.TryParse(textBox1.Text, out value) && value >= 1 && value <= 6)
            {
                //add to the number of times played
                timesplayed+=1;

                //add increment value to the number of times guessed
                int faceguessed = value - 1;
                timesguessed[faceguessed] += 1;
                
                Random random = new Random();
                int dice =0;

                for (int i = 1; i < 7; i++)
                {
          
                    dice = random.Next(1, 7);
                    
                   
                    //show image's of dice roll
                    pictureBox1.Image = (Image)(Properties.Resources.ResourceManager.GetObject($"die{dice}"));
                    pictureBox1.Refresh();
                    Thread.Sleep(300);
                }
                //Check if won or lost
                if (value == dice)
                {
                    timeswon += 1;
                }
                else
                {
                    timeslost += 1;
                }

                //increment dice value to the frequency array
                int face = dice - 1;
                frequency[face] += 1;

                label6.Text = $"your last guess:{value}";
                printValues();
            }
            else
            {
                label6.Text = "Invalid input please type a number between 1-6, try again.";
            }

          
        }

        void resetValue()
        {
            frequency = new int[6];
            timesguessed = new int[6];
            percent = new int[6];
            timesplayed = 0;
            timeswon = 0;
            timeslost = 0;
            textBox1.Text = "";
        }

        void printValues()
        {
            label2.Text = $"Number of Times Played: {timesplayed}";
            label3.Text = $"Number of Times Won: {timeswon}";
            label4.Text = $"Number of Time Lost: {timeslost}";

            richTextBox1.Text = "FACE\t   FREQUENCY\t       PERCENT\tTIMES GUESSED\n";

            for (int i = 0; i <= 5; i++)
            {

                double percentage = (double) frequency[i] / (timesplayed );

                richTextBox1.Text += $"{i + 1}\t\t{frequency[i]}\t\t{percentage*100:f3}%\t\t{timesguessed[i]}\n";
            }
        }
        
        private void Button2_Click(object sender, EventArgs e)
        {
            resetValue();
            printValues();
        }
    }
}
