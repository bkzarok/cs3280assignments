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
            richTextBox1.Text =  "FACE   FREQUENCY   PERCENT     TIMES GUESSED\n"

                                 +"1                   0                    0%                  0\n"

                                 +"2                   0                    0%                  0\n"
   
                                 +"3                   0                    0%                  0\n"
            
                                 +"4                   0                    0%                  0\n"
           
                                 +"5                   0                    0%                  0\n"
          
                                 +"6                   0                    0%                  0";
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

                for (int i = 1; i < 7; i++)
                {
          
                    int dice = random.Next(1, 7);
                    
                    //Check if won or lost
                    if (value == dice)
                    {
                        timeswon += 1;
                    }
                    else
                    {
                        timeslost += 1;
                    }

                    //add dice value to the frequency arra
                    int face = dice - 1;
                    frequency[face] += 1;

                    //show image's of dice roll
                    pictureBox1.Image = (Image)(Properties.Resources.ResourceManager.GetObject($"die{dice}"));
                    pictureBox1.Refresh();
                    Thread.Sleep(300);
                }
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

            richTextBox1.Text = "FACE   FREQUENCY   PERCENT     TIMES GUESSED\n";

            for (int i = 0; i <= 5; i++)
            {
                double percentage = (double) frequency[i] / (timesplayed * 6);
                richTextBox1.Text += $"{i + 1}                   {frequency[i]}       " +
                     $"             {percentage*100:f3}%                  {timesguessed[i]}\n";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            resetValue();
            printValues();
        }
    }
}
