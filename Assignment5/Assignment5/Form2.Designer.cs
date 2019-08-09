namespace Assignment5
{
    partial class Form2
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
            this.nextButton2 = new System.Windows.Forms.Button();
            this.firstNumLabel = new System.Windows.Forms.Label();
            this.operatorLabel = new System.Windows.Forms.Label();
            this.secondNumLabel = new System.Windows.Forms.Label();
            this.exitFrame2 = new System.Windows.Forms.Button();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.questionForm = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.questionForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // nextButton2
            // 
            this.nextButton2.BackColor = System.Drawing.Color.Purple;
            this.nextButton2.Location = new System.Drawing.Point(330, 280);
            this.nextButton2.Name = "nextButton2";
            this.nextButton2.Size = new System.Drawing.Size(127, 35);
            this.nextButton2.TabIndex = 0;
            this.nextButton2.Text = "Next >";
            this.nextButton2.UseVisualStyleBackColor = false;
            this.nextButton2.Click += new System.EventHandler(this.NextButton2_Click);
            // 
            // firstNumLabel
            // 
            this.firstNumLabel.AutoSize = true;
            this.firstNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNumLabel.Location = new System.Drawing.Point(6, 60);
            this.firstNumLabel.Name = "firstNumLabel";
            this.firstNumLabel.Size = new System.Drawing.Size(57, 63);
            this.firstNumLabel.TabIndex = 2;
            this.firstNumLabel.Text = "0";
            // 
            // operatorLabel
            // 
            this.operatorLabel.AutoSize = true;
            this.operatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatorLabel.Location = new System.Drawing.Point(84, 60);
            this.operatorLabel.Name = "operatorLabel";
            this.operatorLabel.Size = new System.Drawing.Size(59, 63);
            this.operatorLabel.TabIndex = 3;
            this.operatorLabel.Text = "+";
            // 
            // secondNumLabel
            // 
            this.secondNumLabel.AutoSize = true;
            this.secondNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondNumLabel.Location = new System.Drawing.Point(159, 60);
            this.secondNumLabel.Name = "secondNumLabel";
            this.secondNumLabel.Size = new System.Drawing.Size(57, 63);
            this.secondNumLabel.TabIndex = 4;
            this.secondNumLabel.Text = "0";
            // 
            // exitFrame2
            // 
            this.exitFrame2.BackColor = System.Drawing.Color.Red;
            this.exitFrame2.Location = new System.Drawing.Point(519, 12);
            this.exitFrame2.Name = "exitFrame2";
            this.exitFrame2.Size = new System.Drawing.Size(95, 65);
            this.exitFrame2.TabIndex = 5;
            this.exitFrame2.Text = "Exit";
            this.exitFrame2.UseVisualStyleBackColor = false;
            this.exitFrame2.Click += new System.EventHandler(this.ExitFrame2_Click);
            // 
            // answerTextBox
            // 
            this.answerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerTextBox.Location = new System.Drawing.Point(299, 60);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(103, 68);
            this.answerTextBox.TabIndex = 6;
            this.answerTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnswerTextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 63);
            this.label1.TabIndex = 7;
            this.label1.Text = "=";
            // 
            // questionForm
            // 
            this.questionForm.Controls.Add(this.firstNumLabel);
            this.questionForm.Controls.Add(this.answerTextBox);
            this.questionForm.Controls.Add(this.label1);
            this.questionForm.Controls.Add(this.operatorLabel);
            this.questionForm.Controls.Add(this.secondNumLabel);
            this.questionForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionForm.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.questionForm.Location = new System.Drawing.Point(55, 29);
            this.questionForm.Name = "questionForm";
            this.questionForm.Size = new System.Drawing.Size(428, 206);
            this.questionForm.TabIndex = 8;
            this.questionForm.TabStop = false;
            this.questionForm.Text = "Question: 0/0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(519, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 87);
            this.button1.TabIndex = 9;
            this.button1.Text = "start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 338);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.questionForm);
            this.Controls.Add(this.exitFrame2);
            this.Controls.Add(this.nextButton2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.questionForm.ResumeLayout(false);
            this.questionForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nextButton2;
        private System.Windows.Forms.Label firstNumLabel;
        private System.Windows.Forms.Label operatorLabel;
        private System.Windows.Forms.Label secondNumLabel;
        private System.Windows.Forms.Button exitFrame2;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox questionForm;
        private System.Windows.Forms.Button button1;
    }
}