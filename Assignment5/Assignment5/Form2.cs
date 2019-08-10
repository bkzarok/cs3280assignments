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

namespace Assignment5
{
    public partial class Form2 : Form
    {
        public char operation;
        public Users users;
        public List<Game> arrayList = new List<Game>();
        public List<Users> listUsers;
        public int incre = 0;
        public int correct = 0;
        private static System.Timers.Timer aTimer;
        private static int timer;
        

        public Form2(char operation, Users users,List<Users> listUsers)
        {
            this.users = users;
            this.operation = operation;
            this.listUsers = listUsers;
            InitializeComponent();
            genQuestions();

        }

        private void ExitFrame2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(listUsers);
            
            this.Close();
            form1.Show();
        }

        private void BackButton2_Click(object sender, EventArgs e)
        {

        }

        private void NextButton2_Click(object sender, EventArgs e)
        {
            checkAnswer();
            nextQuestion();
           
        }


        private void Button1_Click(object sender, EventArgs e)
        {
          
                populateForm(incre);
                SetTimer();
        }
        private void AnswerTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkAnswer();
                nextQuestion();
                
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void resetAll()
        {
            answerTextBox.Text = "";
            
            incre = 0;
            correct = 0;
            timer = 0;
        }
        private void nextQuestion()
        {
            if (incre <9)
            {
                answerTextBox.Text = "";
                incre++;
                populateForm(incre);
               
                
            }
            else
            {
                MessageBox.Show($"Finished and you got {correct} / 10");
                Form3 form3 = new Form3(correct, timer, users, listUsers);
                aTimer.Close();
                aTimer.Dispose();
                timer = 0;
                form3.Show();
                this.Close();
                
            }
        }
        private void checkAnswer()
        {
            try
            {
                int i = Convert.ToInt32(answerTextBox.Text);
                if (arrayList[incre].Answer == i)
                {

                    correct++;
                    playaudioScore();

                }
                else
                {
                    playaudioMiss();
                }
            }
            catch (Exception h)
            { MessageBox.Show("Must enter a number please try again"); }
        }
        private void genQuestions()
        {
            Game game;
            Random random = new Random()               
;
            for (int i = 0; i < 10; i++)
            {
                int num1 = random.Next(1, 10);
                int num2 = random.Next(1, 10);
                game = new Game(operation, num1, num2, getAnswer(num1, num2, operation));
                arrayList.Add(game);
            }
        }

        private int getAnswer(int num1, int num2, char operation)
        {
            switch(operation)
            {
                case '+':
                    return num1 + num2;
                  
                case '-':
                    return Math.Abs(num1 - num2);
                 
                case '*':
                    return num1 * num2;
                 
                case '/':
                    return (int)num1 / num2;
                   
                default:
                    return 0;

            }
        }

        

        private void populateForm(int incre)
        {
            Game game = arrayList[incre];
            questionForm.Text = $"{incre + 1}/10";
            firstNumLabel.Text = "" + game.firstNum;
            operatorLabel.Text = "" + game.Operation;
            secondNumLabel.Text = "" + game.secondNum;
        }

        
        private static void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(1000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            timer++;
        }
        private void playaudioMiss() // defining the function
        {
            SoundPlayer audio = new SoundPlayer(Assignment5.Properties.Resources.Back_Board); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
            audio.Play();
        }
        private void playaudioScore() // defining the function
        {
            SoundPlayer audio = new SoundPlayer(Assignment5.Properties.Resources.Swish); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
            audio.Play();
        }

    }
}
