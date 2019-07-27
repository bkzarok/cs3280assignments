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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Boolean comboSelected = false;
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboSelected = true;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    
         

                    int  i = System.Convert.ToInt32(ageTextBox.Text);

                    comboSelected = false;
                    nameTextBox.Text = "";
                    ageTextBox.Text = "";
                    chooseComboBox.SelectedItem = null;
                  

                    Form2 form2 = new Form2();
                    form2.Show();
                }
                catch (Exception h)
                {
                    ageTextBox.Text = "";
                    MessageBox.Show("Age must contain a number only");
                }
                
            }
        }
    }
}
