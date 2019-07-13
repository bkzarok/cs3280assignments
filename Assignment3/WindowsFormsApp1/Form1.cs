using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private string[] student_information;
        private int[,] student_assigments;
        private int nav_student = 0;
        private int student_num = 0;
        private int assign_num = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void Submit_count_Click(object sender, EventArgs e)
        {

            try
            {
                student_num = Convert.ToInt32(num_of_students.Text);
               
                if (int.TryParse(num_of_assignments.Text, out assign_num) && assign_num >= 1  )
                { 
                    student_information = new string[student_num];
                    student_assigments = new int[student_num, assign_num];
                    Enable_Form();
                    Populate_Arrays();
                    student_number_textbox.Text = student_information[0];
                    label6.Text = $"Student #{1}";
                    

                }
                else { throw new Exception(); }
            }
            catch(Exception h){
                MessageBox.Show("Enter a value that's a number only on both fields ");
                Reset_CountField();
            }
        }

        private void Reset_scores_Click(object sender, EventArgs e)
        {
            Disable_Form();
            Reset_CountField();
        }

        private void First_student_Click(object sender, EventArgs e)
        {

                nav_student = 0;
                student_number_textbox.Text = student_information[0];
                label6.Text = $"Student #{1}";
             

        }
        private void Previouse_student_Click(object sender, EventArgs e)
        {
            
            if (nav_student <= 0)
            {
            }
            else
            {
                nav_student = nav_student - 1;
                student_number_textbox.Text = student_information[nav_student];
                label6.Text = $"Student #{nav_student+1}";
            }
        }
        private void Next_student_Click(object sender, EventArgs e)
        {
           
            
            if (nav_student >= student_num-1)
            {
            }
            else
            {
                nav_student = nav_student + 1;
                student_number_textbox.Text = student_information[nav_student];
                label6.Text = $"Student #{nav_student+1}";
            }
        }

        private void Last_student_Click(object sender, EventArgs e)
        {
            nav_student = student_num - 1;
            student_number_textbox.Text = student_information[nav_student];
            label6.Text = $"Student #{student_num}";
           
        }

        private void Save_name_Click(object sender, EventArgs e)
        {
           
                student_information[nav_student] = student_number_textbox.Text;
            
        }

        private void Save_score_Click(object sender, EventArgs e)
        {
            try
            {
                int assign_value = 0;
                if (int.TryParse(enter_assignment_textbox.Text, out assign_value) && assign_value >= 1 )
                {
                    student_assigments[nav_student, assign_value - 1]
                       = Convert.ToInt32(assignment_score_textbox.Text);
                }
                else { throw new Exception(); }
            }
            catch (Exception h)
            {
                MessageBox.Show("Enter a value that's a number only on both fields And on a number" +
                    "between 1-5 on the Assignment# field ");
                Reset_CountField();
            }

            enter_assignment_textbox.Text = "";
            assignment_score_textbox.Text = "";
            
        }

        private void Display_score_Click(object sender, EventArgs e)
        {
            displayScore();
        }

        private void Save_file_bttn_Click(object sender, EventArgs e)
        {
            displayScore();
            string[] allLines = display_score_richtextbox.Text.Split('\n');
            if (!save_file_textbox.Text.Equals(""))
            { OutputStringToFile(save_file_textbox.Text, allLines); }
            save_file_textbox.Text = "";
        }

       

        /// <summary>
        /// Outputs the string array to file. Each element in the array is a line of text.
        /// Output path - C:\Users\Public\<paramref name="fileName"/>
        /// </summary>
        /// <param name="output">The output.</param>
        /// <param name="fileName">Name of the file.</param>
        public void OutputStringToFile(string fileName, string[] outputLines)
        {
            try
            {
                // set file path
                string filePath = @"C:\Users\Public\" + fileName + ".txt";

                // check if file exists
                if (File.Exists(filePath))
                {
                    MessageBox.Show("This file already exists");
                }
                else
                {
                    using (StreamWriter writer = File.AppendText(filePath))
                    {
                        for (int i = 0; i < outputLines.Length; i++)
                            writer.WriteLine(outputLines[i] + "\n");
                    }

                    MessageBox.Show($"Success!\nSaved as: {fileName}\n At Location: \n{filePath}");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name +
                    "." + MethodInfo.GetCurrentMethod().Name + ": " + ex.ToString() + " -> " + ex.Message);
                //throw ex;
            }
        }

       
        private void displayScore()
        {
            display_score_richtextbox.Text = "";
            display_score_richtextbox.Text +=
                          $"Students\t\t";
            for (int k = 0; k < assign_num; k++)
            {
                display_score_richtextbox.Text +=
                  $"\t#{k}";
            }
            display_score_richtextbox.Text +=
                  $"\tAVG\tGRADE\n";

            for (int i = 0; i < student_num; i++)
            {
                display_score_richtextbox.Text +=
                    $"{student_information[i]}\t   ";
                for (int t = 0; t < assign_num; t++)
                {
                    display_score_richtextbox.Text +=
                    $"\t{student_assigments[i, t]}";
                }
                display_score_richtextbox.Text += $"\t{Avarage(i)}" +
                    $"\t{Grade(Avarage(i))}\n";

            }
        }
        private double Avarage(int indexrow)
        {
            double result= 0;
            for (int i = 0; i < assign_num; i++)
            {
                result += (student_assigments[indexrow, i]);
            }
            return result/assign_num;
        }

        private char Grade(double avg)
        {

            if (avg >= 90.0)
            {
                return 'A';
            }

            if (avg >= 80.0)
            {
                return 'B';
            }

            if (avg >= 70.0)
            {
                return 'C';
            }

            if (avg >= 60.0)
            {
                return 'D';
            }

            return 'F';
        }
        private void Reset_CountField()
        {
            num_of_students.Text = "";
            num_of_assignments.Text = "";
        }
        private void Enable_Form()
        {

            num_of_assignments.Enabled = false;
            num_of_students.Enabled = false;
            submit_count.Enabled = false;
            reset_scores.Enabled = true;
            first_student.Enabled = true;
            previouse_student.Enabled = true;
            next_student.Enabled = true;
            last_student.Enabled = true;
            student_number_textbox.Enabled = true;
            save_name.Enabled = true;
            save_score.Enabled = true;
            assignment_score_textbox.Enabled = true;
            enter_assignment_textbox.Enabled = true;
            display_score.Enabled = true;
            display_score_richtextbox.Enabled = true;
            save_file_bttn.Enabled = true;
            save_file_textbox.Enabled = true;

        }
        private void Disable_Form()
        {

            num_of_assignments.Enabled = true;
            num_of_students.Enabled = true;
            submit_count.Enabled = true;
            reset_scores.Enabled = false;
            first_student.Enabled = false;
            previouse_student.Enabled = false;
            next_student.Enabled = false;
            last_student.Enabled = false;
            student_number_textbox.Enabled = false;
            save_name.Enabled = false;
            save_score.Enabled = false;
            assignment_score_textbox.Enabled = false;
            enter_assignment_textbox.Enabled = false;
            display_score.Enabled = false;
            display_score_richtextbox.Enabled = false;
            save_file_bttn.Enabled = false;
            save_file_textbox.Enabled = false;

        }

        private void Populate_Arrays()
        {
            for (int i = 0; i < student_num; i++)
            {
                student_information[i] = $"Student #{i+1}";
                for(int t=0; t<assign_num;t++)
                {
                    student_assigments[i,t] = 0;
                }
            }

        }

    }
}
