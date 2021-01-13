namespace ShapesMidterm.GUI
{
    partial class ShapesWindow
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
            this.areaButton = new System.Windows.Forms.Button();
            this.param2TextBox = new System.Windows.Forms.TextBox();
            this.param1TextBox = new System.Windows.Forms.TextBox();
            this.param1Label = new System.Windows.Forms.Label();
            this.param2Label = new System.Windows.Forms.Label();
            this.squareButton = new System.Windows.Forms.RadioButton();
            this.circleButton = new System.Windows.Forms.RadioButton();
            this.triangleButton = new System.Windows.Forms.RadioButton();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // areaButton
            // 
            this.areaButton.AccessibleName = "Calculate Area";
            this.areaButton.Location = new System.Drawing.Point(110, 136);
            this.areaButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.areaButton.Name = "areaButton";
            this.areaButton.Size = new System.Drawing.Size(147, 52);
            this.areaButton.TabIndex = 0;
            this.areaButton.Text = "Calculate Area";
            this.areaButton.UseVisualStyleBackColor = true;
            this.areaButton.Click += new System.EventHandler(this.AreaButton_Click);
            // 
            // param2TextBox
            // 
            this.param2TextBox.Location = new System.Drawing.Point(110, 78);
            this.param2TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.param2TextBox.Name = "param2TextBox";
            this.param2TextBox.Size = new System.Drawing.Size(182, 26);
            this.param2TextBox.TabIndex = 1;
            this.param2TextBox.Visible = false;
            // 
            // param1TextBox
            // 
            this.param1TextBox.Location = new System.Drawing.Point(110, 36);
            this.param1TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.param1TextBox.Name = "param1TextBox";
            this.param1TextBox.Size = new System.Drawing.Size(182, 26);
            this.param1TextBox.TabIndex = 2;
            // 
            // param1Label
            // 
            this.param1Label.AutoSize = true;
            this.param1Label.Location = new System.Drawing.Point(47, 40);
            this.param1Label.Name = "param1Label";
            this.param1Label.Size = new System.Drawing.Size(41, 20);
            this.param1Label.TabIndex = 3;
            this.param1Label.Text = "Side";
            this.param1Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // param2Label
            // 
            this.param2Label.AutoSize = true;
            this.param2Label.Location = new System.Drawing.Point(47, 81);
            this.param2Label.Name = "param2Label";
            this.param2Label.Size = new System.Drawing.Size(51, 20);
            this.param2Label.TabIndex = 4;
            this.param2Label.Text = "label2";
            this.param2Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.param2Label.Visible = false;
            // 
            // squareButton
            // 
            this.squareButton.AutoSize = true;
            this.squareButton.Checked = true;
            this.squareButton.Location = new System.Drawing.Point(309, 25);
            this.squareButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.squareButton.Name = "squareButton";
            this.squareButton.Size = new System.Drawing.Size(86, 24);
            this.squareButton.TabIndex = 5;
            this.squareButton.TabStop = true;
            this.squareButton.Text = "Square";
            this.squareButton.UseVisualStyleBackColor = true;
            this.squareButton.Click += new System.EventHandler(this.SquareButtonSelected);
            // 
            // circleButton
            // 
            this.circleButton.AutoSize = true;
            this.circleButton.Location = new System.Drawing.Point(309, 58);
            this.circleButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(73, 24);
            this.circleButton.TabIndex = 6;
            this.circleButton.Text = "Circle";
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.CircleButtonSelected);
            // 
            // triangleButton
            // 
            this.triangleButton.AutoSize = true;
            this.triangleButton.Location = new System.Drawing.Point(309, 90);
            this.triangleButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.triangleButton.Name = "triangleButton";
            this.triangleButton.Size = new System.Drawing.Size(90, 24);
            this.triangleButton.TabIndex = 7;
            this.triangleButton.Text = "Triangle";
            this.triangleButton.UseVisualStyleBackColor = true;
            this.triangleButton.Click += new System.EventHandler(this.TriangleButtonSelected);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(38, 214);
            this.outputBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(367, 119);
            this.outputBox.TabIndex = 8;
            this.outputBox.Text = "";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(278, 152);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 20);
            this.errorLabel.TabIndex = 9;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ShapesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 385);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.triangleButton);
            this.Controls.Add(this.circleButton);
            this.Controls.Add(this.squareButton);
            this.Controls.Add(this.param2Label);
            this.Controls.Add(this.param1Label);
            this.Controls.Add(this.param1TextBox);
            this.Controls.Add(this.param2TextBox);
            this.Controls.Add(this.areaButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ShapesWindow";
            this.Text = "Midterm Shapes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button areaButton;
        private System.Windows.Forms.TextBox param2TextBox;
        private System.Windows.Forms.TextBox param1TextBox;
        private System.Windows.Forms.Label param1Label;
        private System.Windows.Forms.Label param2Label;
        private System.Windows.Forms.RadioButton squareButton;
        private System.Windows.Forms.RadioButton circleButton;
        private System.Windows.Forms.RadioButton triangleButton;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.Label errorLabel;
    }
}

