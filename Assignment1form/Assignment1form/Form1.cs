using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Button3_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string input = textBox3.Text;
            result = MessageBox.Show("You typed: " + input, "Message Box 3", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            this.label1.Text = "the button " + result + " was clicked";
            this.textBox3.Text = "";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string input = textBox2.Text;
            result = MessageBox.Show("You typed: " + input, "Message Box 2", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            this.label1.Text = "the button " + result + " was clicked";
            this.textBox2.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string input = textBox1.Text;
            result = MessageBox.Show("You typed: " + input, "Message Box 1", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk);
            this.label1.Text = "the button " +result +" was clicked";
            this.textBox1.Text = "";

        }
    }
}
