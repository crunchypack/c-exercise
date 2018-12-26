using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleEventExample
{
    public partial class SimpleEventExample : Form
    {
        public SimpleEventExample()
        {
            InitializeComponent();
        }


        private void displayPassButton_Click(object sender, EventArgs e)
        {
            displayedPassLabel.Text = passInput.Text;
        }

        private void displayMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BUTTON CLICKED!");
        }

        private void hiButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "Hi pressed";
        }

        private void byeButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "Bye pressed";
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "Right pressed";
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "Left pressed";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "Button 5 clicked";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "Button 6 clicked";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "Button 7 clicked";
        }

        private void boldCheck_CheckedChanged(object sender, EventArgs e)
        {
            outputLabel.Font = new Font(outputLabel.Font,
                outputLabel.Font.Style ^ FontStyle.Bold);
        }

        private void italicCheck_CheckedChanged(object sender, EventArgs e)
        {
            outputLabel.Font = new Font(outputLabel.Font,
                outputLabel.Font.Style ^ FontStyle.Italic);
        }
    }
}
