/*
 Project:       Message Formatter
 Programmer:    Dan Brost
 Date:          September 29 2017
 Description:   This application displays the name and the message
 entered by the user in the chosen color. The image size can be changed 
 by clicking on the image.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson02_MessageFormatter
{
    public partial class MessageForm : Form
    {
        public MessageForm()
        {
            InitializeComponent();
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {
            StartUp();
        }
        /// <summary>
        /// Default state when form is loaded or cleared.
        /// </summary>
        private void StartUp()
        {
            //The black radio button and the visible check box are selected by default
            BlackRadioButton.Checked= true;
            MessageVisibleCheckBox.Checked = true;
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            //Check that both name and message have been provided(non-empty)
            //Display a separate appropriate error message if either is missing
            if (NameTextBox.Text.Equals(String.Empty))
            {
                MessageBox.Show("Your Namer is Missing", "Please Enter Your Name");
                NameTextBox.Focus();
            }
            else
           if (MessageTextBox.Text.Equals(String.Empty))
            {
                MessageBox.Show("Your Message is Missing", "Please Enter A Message");
                MessageTextBox.Focus();
            }
            
            // If both inputs are provided, display name : message 
            else
            {
                MessageLabel.Text = NameTextBox.Text + " : " + MessageTextBox.Text;
            }

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Set the form to its default starting state
            NameTextBox.Text = string.Empty;
            MessageTextBox.Text = string.Empty;
            MessageLabel.Text = string.Empty;
            NameTextBox.Focus();

            StartUp();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Exit program
            this.Close();
        }

        private void BlackRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Show the text in the message label in black.
            MessageLabel.ForeColor = Color.Black;

        }

        private void BlueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Show the text in the message label in blue.
            MessageLabel.ForeColor = Color.Blue;

        }

        private void GreenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Show the text in the message label in green.
            MessageLabel.ForeColor = Color.Green;
            
        }

        private void RedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Show the text in the message label in red.
            MessageLabel.ForeColor = Color.Red;
           
        }

        private void BigPictureBox_Click(object sender, EventArgs e)
        {
        // Switch the icon. The small picture should appear
        // dont know how.
       
        }

        private void SmallPictureBox_Click(object sender, EventArgs e)
        {
            // Switch the icon. The big picture should appear

       
        }

        private void MessageVisibleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Set the visibility for messageLabel.

            MessageLabel.Visible = MessageVisibleCheckBox.Checked;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ClickLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
