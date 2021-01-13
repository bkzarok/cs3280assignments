namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.num_of_students = new System.Windows.Forms.TextBox();
            this.num_of_assignments = new System.Windows.Forms.TextBox();
            this.submit_count = new System.Windows.Forms.Button();
            this.reset_scores = new System.Windows.Forms.Button();
            this.first_student = new System.Windows.Forms.Button();
            this.previouse_student = new System.Windows.Forms.Button();
            this.next_student = new System.Windows.Forms.Button();
            this.last_student = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.student_number_textbox = new System.Windows.Forms.TextBox();
            this.save_name = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.save_score = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.assignment_score_textbox = new System.Windows.Forms.TextBox();
            this.enter_assignment_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.display_score = new System.Windows.Forms.Button();
            this.save_file_bttn = new System.Windows.Forms.Button();
            this.save_file_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.display_score_richtextbox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of students:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of assignments:";
            // 
            // num_of_students
            // 
            this.num_of_students.Location = new System.Drawing.Point(137, 19);
            this.num_of_students.Name = "num_of_students";
            this.num_of_students.Size = new System.Drawing.Size(100, 20);
            this.num_of_students.TabIndex = 3;
            // 
            // num_of_assignments
            // 
            this.num_of_assignments.Location = new System.Drawing.Point(137, 53);
            this.num_of_assignments.Name = "num_of_assignments";
            this.num_of_assignments.Size = new System.Drawing.Size(100, 20);
            this.num_of_assignments.TabIndex = 4;
            // 
            // submit_count
            // 
            this.submit_count.Location = new System.Drawing.Point(288, 25);
            this.submit_count.Name = "submit_count";
            this.submit_count.Size = new System.Drawing.Size(96, 41);
            this.submit_count.TabIndex = 5;
            this.submit_count.Text = "Submit Count";
            this.submit_count.UseVisualStyleBackColor = true;
            this.submit_count.Click += new System.EventHandler(this.Submit_count_Click);
            // 
            // reset_scores
            // 
            this.reset_scores.Enabled = false;
            this.reset_scores.Location = new System.Drawing.Point(511, 25);
            this.reset_scores.Name = "reset_scores";
            this.reset_scores.Size = new System.Drawing.Size(81, 75);
            this.reset_scores.TabIndex = 6;
            this.reset_scores.Text = "Reset Scores";
            this.reset_scores.UseVisualStyleBackColor = true;
            this.reset_scores.Click += new System.EventHandler(this.Reset_scores_Click);
            // 
            // first_student
            // 
            this.first_student.Enabled = false;
            this.first_student.Location = new System.Drawing.Point(19, 19);
            this.first_student.Name = "first_student";
            this.first_student.Size = new System.Drawing.Size(97, 23);
            this.first_student.TabIndex = 8;
            this.first_student.Text = "<< First Student";
            this.first_student.UseVisualStyleBackColor = true;
            this.first_student.Click += new System.EventHandler(this.First_student_Click);
            // 
            // previouse_student
            // 
            this.previouse_student.Enabled = false;
            this.previouse_student.Location = new System.Drawing.Point(151, 19);
            this.previouse_student.Name = "previouse_student";
            this.previouse_student.Size = new System.Drawing.Size(113, 23);
            this.previouse_student.TabIndex = 9;
            this.previouse_student.Text = "< Previous Student";
            this.previouse_student.UseVisualStyleBackColor = true;
            this.previouse_student.Click += new System.EventHandler(this.Previouse_student_Click);
            // 
            // next_student
            // 
            this.next_student.Enabled = false;
            this.next_student.Location = new System.Drawing.Point(288, 19);
            this.next_student.Name = "next_student";
            this.next_student.Size = new System.Drawing.Size(99, 23);
            this.next_student.TabIndex = 10;
            this.next_student.Text = "> Next Student";
            this.next_student.UseVisualStyleBackColor = true;
            this.next_student.Click += new System.EventHandler(this.Next_student_Click);
            // 
            // last_student
            // 
            this.last_student.Enabled = false;
            this.last_student.Location = new System.Drawing.Point(426, 19);
            this.last_student.Name = "last_student";
            this.last_student.Size = new System.Drawing.Size(116, 23);
            this.last_student.TabIndex = 11;
            this.last_student.Text = ">> Last Student";
            this.last_student.UseVisualStyleBackColor = true;
            this.last_student.Click += new System.EventHandler(this.Last_student_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Student #";
            // 
            // student_number_textbox
            // 
            this.student_number_textbox.Enabled = false;
            this.student_number_textbox.Location = new System.Drawing.Point(115, 19);
            this.student_number_textbox.Name = "student_number_textbox";
            this.student_number_textbox.Size = new System.Drawing.Size(100, 20);
            this.student_number_textbox.TabIndex = 14;
            // 
            // save_name
            // 
            this.save_name.Enabled = false;
            this.save_name.Location = new System.Drawing.Point(249, 16);
            this.save_name.Name = "save_name";
            this.save_name.Size = new System.Drawing.Size(75, 23);
            this.save_name.TabIndex = 15;
            this.save_name.Text = "Save Name";
            this.save_name.UseVisualStyleBackColor = true;
            this.save_name.Click += new System.EventHandler(this.Save_name_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.num_of_students);
            this.groupBox1.Controls.Add(this.num_of_assignments);
            this.groupBox1.Controls.Add(this.submit_count);
            this.groupBox1.Location = new System.Drawing.Point(28, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 83);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Count";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.first_student);
            this.groupBox2.Controls.Add(this.previouse_student);
            this.groupBox2.Controls.Add(this.next_student);
            this.groupBox2.Controls.Add(this.last_student);
            this.groupBox2.Location = new System.Drawing.Point(28, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(606, 60);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Navigate";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.student_number_textbox);
            this.groupBox3.Controls.Add(this.save_name);
            this.groupBox3.Location = new System.Drawing.Point(28, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(423, 60);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Student info:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.save_score);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.assignment_score_textbox);
            this.groupBox4.Controls.Add(this.enter_assignment_textbox);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(28, 225);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(423, 110);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Student Info:";
            // 
            // save_score
            // 
            this.save_score.Enabled = false;
            this.save_score.Location = new System.Drawing.Point(288, 48);
            this.save_score.Name = "save_score";
            this.save_score.Size = new System.Drawing.Size(75, 23);
            this.save_score.TabIndex = 4;
            this.save_score.Text = "Save Score";
            this.save_score.UseVisualStyleBackColor = true;
            this.save_score.Click += new System.EventHandler(this.Save_score_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Assigment Score:";
            // 
            // assignment_score_textbox
            // 
            this.assignment_score_textbox.Enabled = false;
            this.assignment_score_textbox.Location = new System.Drawing.Point(151, 58);
            this.assignment_score_textbox.Name = "assignment_score_textbox";
            this.assignment_score_textbox.Size = new System.Drawing.Size(100, 20);
            this.assignment_score_textbox.TabIndex = 2;
            // 
            // enter_assignment_textbox
            // 
            this.enter_assignment_textbox.Enabled = false;
            this.enter_assignment_textbox.Location = new System.Drawing.Point(151, 31);
            this.enter_assignment_textbox.Name = "enter_assignment_textbox";
            this.enter_assignment_textbox.Size = new System.Drawing.Size(100, 20);
            this.enter_assignment_textbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Assignment #1-5:";
            // 
            // display_score
            // 
            this.display_score.Enabled = false;
            this.display_score.Location = new System.Drawing.Point(179, 341);
            this.display_score.Name = "display_score";
            this.display_score.Size = new System.Drawing.Size(102, 23);
            this.display_score.TabIndex = 20;
            this.display_score.Text = "Display Score";
            this.display_score.UseVisualStyleBackColor = true;
            this.display_score.Click += new System.EventHandler(this.Display_score_Click);
            // 
            // save_file_bttn
            // 
            this.save_file_bttn.Enabled = false;
            this.save_file_bttn.Location = new System.Drawing.Point(582, 510);
            this.save_file_bttn.Name = "save_file_bttn";
            this.save_file_bttn.Size = new System.Drawing.Size(75, 23);
            this.save_file_bttn.TabIndex = 22;
            this.save_file_bttn.Text = "Save File";
            this.save_file_bttn.UseVisualStyleBackColor = true;
            this.save_file_bttn.Click += new System.EventHandler(this.Save_file_bttn_Click);
            // 
            // save_file_textbox
            // 
            this.save_file_textbox.Enabled = false;
            this.save_file_textbox.Location = new System.Drawing.Point(347, 510);
            this.save_file_textbox.Name = "save_file_textbox";
            this.save_file_textbox.Size = new System.Drawing.Size(190, 20);
            this.save_file_textbox.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 515);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Save File Enter Name:";
            // 
            // display_score_richtextbox
            // 
            this.display_score_richtextbox.Location = new System.Drawing.Point(47, 387);
            this.display_score_richtextbox.Name = "display_score_richtextbox";
            this.display_score_richtextbox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.display_score_richtextbox.Size = new System.Drawing.Size(610, 102);
            this.display_score_richtextbox.TabIndex = 26;
            this.display_score_richtextbox.Text = "";
            this.display_score_richtextbox.WordWrap = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.display_score_richtextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.save_file_textbox);
            this.Controls.Add(this.save_file_bttn);
            this.Controls.Add(this.display_score);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reset_scores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox num_of_students;
        private System.Windows.Forms.TextBox num_of_assignments;
        private System.Windows.Forms.Button submit_count;
        private System.Windows.Forms.Button reset_scores;
        private System.Windows.Forms.Button first_student;
        private System.Windows.Forms.Button previouse_student;
        private System.Windows.Forms.Button next_student;
        private System.Windows.Forms.Button last_student;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox student_number_textbox;
        private System.Windows.Forms.Button save_name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button save_score;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox assignment_score_textbox;
        private System.Windows.Forms.TextBox enter_assignment_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button display_score;
        private System.Windows.Forms.Button save_file_bttn;
        private System.Windows.Forms.TextBox save_file_textbox;
        private System.Windows.Forms.Label label5;
      
        private System.Windows.Forms.RichTextBox display_score_richtextbox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

