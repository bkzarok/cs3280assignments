using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class Form3 : Form
    {
        public int correct;
        public int seconds;
        public Users users;
        public List<Users> listUsers;

        public Form3(int correct, int seconds, Users users, List<Users> listUsers)
        {
            this.correct = correct;
            this.seconds = seconds;
            this.users = users;
            this.listUsers = listUsers;
            this.BackColor = Color.Green;
            InitializeComponent();


            populateForm();

            var timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

        }
        void timer_Tick(object sender, EventArgs e)
        {

            //set color in background  
            var colors = new[] { Color.CornflowerBlue, Color.Green, Color.Aqua, Color.Azure, Color.CadetBlue };
            var index = DateTime.Now.Second % colors.Length;
            this.BackColor = colors[index];
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            users.Score = correct;
            listUsers.Add(users);
            Form1 form1 = new Form1(listUsers);
            form1.Show();
            this.Close(); 
        }


        private void populateForm()
        {
            richTextBox1.Text = $"Name is: {users.Name}" +
                   $"\nAges is: {users.Age}" +
                   $"\nYou got {correct}/ 10 Answers correct\n" +
                   $"\nYou finished in {seconds} seconds\n";
        }
    }
}
