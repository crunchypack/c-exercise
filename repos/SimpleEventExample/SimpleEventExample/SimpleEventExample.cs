using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleEventExample
{
    public partial class SimpleEventExample : Form
    {
        private MessageBoxIcon icons;
        private MessageBoxButtons buttonTyp;
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

        private void buttonTyp_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == okButton)
                buttonTyp = MessageBoxButtons.OK;
            else if (sender == okCancel)
                buttonTyp = MessageBoxButtons.OKCancel;
            else if (sender == abortRetry)
                buttonTyp = MessageBoxButtons.AbortRetryIgnore;
            else if (sender == yesNoCancel)
                buttonTyp = MessageBoxButtons.YesNoCancel;
            else if (sender == yesNo)
                buttonTyp = MessageBoxButtons.YesNo;
            else
                buttonTyp = MessageBoxButtons.RetryCancel;
            Console.WriteLine(sender);
        }

        private void icons_Enter(object sender, EventArgs e)
        {
            if (sender == radioButton7)
                icons = MessageBoxIcon.Asterisk;
            else if (sender == error)
                icons = MessageBoxIcon.Error;
            else if (sender == hand)
                icons = MessageBoxIcon.Exclamation;
            else if (sender == info)
                icons = MessageBoxIcon.Hand;
            else if (sender == question)
                icons = MessageBoxIcon.Question;
            else if (sender == stop)
                icons = MessageBoxIcon.Stop;
            else
                icons = MessageBoxIcon.Warning;
            Console.WriteLine(sender);
        }

        private void displayB_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "This is you ugly Message box,", "Cusom MessageBox", buttonTyp, icons);
            switch (result)
            {
                case DialogResult.OK:
                    displayLabel.Text = "OK was pressed.";
                    break;
                case DialogResult.Cancel:
                    displayLabel.Text = "Cancel was pressed.";
                    break;
                case DialogResult.Abort:
                    displayLabel.Text = "Abort was pressed.";
                    break;
                case DialogResult.Retry:
                     displayLabel.Text = "Retry was pressed.";
                     break;
                case DialogResult.Ignore:
                     displayLabel.Text = "Ignore was pressed.";
                     break;
                case DialogResult.Yes:
                    displayLabel.Text = "Yes was pressed.";
                    break;
                case DialogResult.No:
                    displayLabel.Text = "No was pressed.";
                    break;
            }
        }

    }
}
