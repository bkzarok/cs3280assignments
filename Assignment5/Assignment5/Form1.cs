using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
   
    public partial class Form1 : Form
    {
        public List<Users> listUsers;
        public Form1(List<Users> listUsers)
        {
            this.listUsers = listUsers;
            this.BackgroundImage = Properties.Resources.im;
            InitializeComponent();
            playaudio();
            var timer = new Timer();
            //change the background image every second  
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            
          

        }

        private void playaudio() // defining the function
        {
            SoundPlayer audio = new SoundPlayer(Assignment5.Properties.Resources.bball_crowd); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
            audio.Play();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            //add image in list from resource file.  
            List<Bitmap> lisimage = new List<Bitmap>();
            lisimage.Add(Properties.Resources.im);
            lisimage.Add(Properties.Resources.im2);
            lisimage.Add(Properties.Resources.im3);
            var indexbackimage = DateTime.Now.Second % lisimage.Count;
            this.BackgroundImage = lisimage[indexbackimage];
        }

        Boolean comboSelected = false;
        public char operation;
        public Users users = new Users();
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboSelected = true;
            switch (chooseComboBox.SelectedIndex)
            {
                case 0:
                    operation = '+';
                    break;
                case 1:
                    operation = '-';
                    break;
                case 2:
                    operation = '*';
                    break;
                case 3:
                    operation = '/';
                    break;
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            ValidateInput();
            
            
        }

      

        private void ValidateInput()
        {
            if ((nameTextBox.Text.Equals("") || ageTextBox.Text.Equals("")) || comboSelected == false)
            {
                MessageBox.Show("Please fill out all fields before continuing");
            }
            else
            {
                try
                {
                   
                    int  i =  Convert.ToInt32(ageTextBox.Text);
                    users.Age = i;
                    if (i < 3 || i > 10)
                        throw new System.Exception(" exeption");
                    users.Name = nameTextBox.Text;

                    comboSelected = false;
                    nameTextBox.Text = "";
                    ageTextBox.Text = "";
                    chooseComboBox.SelectedItem = null;

                  
                    Form2 form2 = new Form2(operation, users,listUsers);
                 
                    form2.Show();
                    this.Hide();
                }
                catch (Exception h)
                {
                    ageTextBox.Text = "";
                    MessageBox.Show("Age must contain a number only and between 3 and 10");
                }
                
            }
        }


        public void loadList()
        {
            if (listUsers != null)
            {
                richTextBoxScores.Text = "";
                foreach (var user in listUsers)
                {
                    richTextBoxScores.Text += user.ToString();
                }
            }
           
        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            loadList();
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
