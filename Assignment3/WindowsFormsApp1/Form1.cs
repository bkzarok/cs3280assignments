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
        private int[] student_assigments;
        public Form1()
        {
            InitializeComponent();
        }


        private void Submit_count_Click(object sender, EventArgs e)
        {
            if (num_of_assignments.Text == "" || num_of_students.Text == "")
            { }
            else
            {
                student_information = new string[Convert.ToInt32(num_of_students.Text)];
                student_assigments = new int[Convert.ToInt32(num_of_assignments.Text)];
                Enable_Form();
            }

        }

        private void Reset_scores_Click(object sender, EventArgs e)
        {
            Disable_Form();
        }

        private void First_student_Click(object sender, EventArgs e)
        {

        }
        private void Previouse_student_Click(object sender, EventArgs e)
        {

        }
        private void Next_student_Click(object sender, EventArgs e)
        {

        }

        private void Last_student_Click(object sender, EventArgs e)
        {

        }

        private void Save_name_Click(object sender, EventArgs e)
        {

        }

        private void Save_score_Click(object sender, EventArgs e)
        {

        }

        private void Display_score_Click(object sender, EventArgs e)
        {

        }

        private void Save_file_bttn_Click(object sender, EventArgs e)
        {

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

                }
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name +
                    "." + MethodInfo.GetCurrentMethod().Name + ": " + ex.ToString() + " -> " + ex.Message);
                //throw ex;
            }
        }

        private void Enable_Form()
        {
          
            reset_scores.Enabled = true;
            first_student.Enabled = true;
            previouse_student.Enabled = true;
            next_student.Enabled = true;
            last_student.Enabled = true;
            student_number.Enabled = true;
            save_name.Enabled = true;
            save_score.Enabled = true;
            assignment_score.Enabled = true;
            enter_assignment.Enabled = true;
            display_score.Enabled = true;
            display_score_text_area.Enabled = true;
            save_file_bttn.Enabled = true;
            save_file_textbox.Enabled = true;

        }
        private void Disable_Form()
        {
           
            reset_scores.Enabled = false;
            first_student.Enabled = false;
            previouse_student.Enabled = false;
            next_student.Enabled = false;
            last_student.Enabled = false;
            student_number.Enabled = false;
            save_name.Enabled = false;
            save_score.Enabled = false;
            assignment_score.Enabled = false;
            enter_assignment.Enabled = false;
            display_score.Enabled = false;
            display_score_text_area.Enabled = false;
            save_file_bttn.Enabled = false;
            save_file_textbox.Enabled = false;

        }

    }
}
