using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShapesMidterm;

namespace ShapesMidterm.GUI
{
    public partial class ShapesWindow : Form
    {
        public ShapesWindow()
        {
            InitializeComponent();
        }

        private void SquareButtonSelected(object sender, EventArgs e)
        {
            param1Label.Text = "Side";
            param2Label.Visible = false;
            param2TextBox.Visible = false;
        }

        private void CircleButtonSelected(object sender, EventArgs e)
        {
            param1Label.Text = "Radius";
            param2Label.Visible = false;
            param2TextBox.Visible = false;
        }

        private void TriangleButtonSelected(object sender, EventArgs e)
        {
            param1Label.Text = "Height";
            param2Label.Text = "Base";
            param2Label.Visible = true;
            param2TextBox.Text = "";
            param2TextBox.Visible = true;
        }

        private void AreaButton_Click(object sender, EventArgs e)
        {
            // YOUR CODE
            // Instantiate Selected Shape and Calculate Area
            // Validate parameters
            // Write ToString() and Area to outputBox
        }

        private void InvalidInput()
        {
            errorLabel.Text = "Invalid Input";
        }
    }
}
