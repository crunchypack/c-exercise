namespace SimpleEventExample
{
    partial class SimpleEventExample
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
            this.displayPassButton = new System.Windows.Forms.Button();
            this.displayedPassLabel = new System.Windows.Forms.Label();
            this.passInput = new System.Windows.Forms.TextBox();
            this.displayMessage = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.hiButton = new System.Windows.Forms.Button();
            this.byeButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.boldCheck = new System.Windows.Forms.CheckBox();
            this.italicCheck = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayPassButton
            // 
            this.displayPassButton.Location = new System.Drawing.Point(117, 122);
            this.displayPassButton.Name = "displayPassButton";
            this.displayPassButton.Size = new System.Drawing.Size(111, 35);
            this.displayPassButton.TabIndex = 1;
            this.displayPassButton.Text = "Show me";
            this.displayPassButton.UseVisualStyleBackColor = true;
            this.displayPassButton.Click += new System.EventHandler(this.displayPassButton_Click);
            // 
            // displayedPassLabel
            // 
            this.displayedPassLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayedPassLabel.Location = new System.Drawing.Point(12, 75);
            this.displayedPassLabel.Name = "displayedPassLabel";
            this.displayedPassLabel.Size = new System.Drawing.Size(318, 21);
            this.displayedPassLabel.TabIndex = 2;
            this.displayedPassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // passInput
            // 
            this.passInput.Location = new System.Drawing.Point(12, 40);
            this.passInput.Name = "passInput";
            this.passInput.Size = new System.Drawing.Size(318, 23);
            this.passInput.TabIndex = 3;
            this.passInput.UseSystemPasswordChar = true;
            // 
            // displayMessage
            // 
            this.displayMessage.Location = new System.Drawing.Point(114, 203);
            this.displayMessage.Name = "displayMessage";
            this.displayMessage.Size = new System.Drawing.Size(111, 26);
            this.displayMessage.TabIndex = 5;
            this.displayMessage.Text = "Click!";
            this.displayMessage.UseVisualStyleBackColor = true;
            this.displayMessage.Click += new System.EventHandler(this.displayMessage_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.leftButton);
            this.groupBox1.Controls.Add(this.hiButton);
            this.groupBox1.Controls.Add(this.byeButton);
            this.groupBox1.Controls.Add(this.rightButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 128);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(251, 99);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(170, 99);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(88, 99);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(7, 99);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(75, 23);
            this.leftButton.TabIndex = 3;
            this.leftButton.Text = "Left ";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // hiButton
            // 
            this.hiButton.Location = new System.Drawing.Point(6, 22);
            this.hiButton.Name = "hiButton";
            this.hiButton.Size = new System.Drawing.Size(75, 23);
            this.hiButton.TabIndex = 2;
            this.hiButton.Text = "hi";
            this.hiButton.UseVisualStyleBackColor = true;
            this.hiButton.Click += new System.EventHandler(this.hiButton_Click);
            // 
            // byeButton
            // 
            this.byeButton.Location = new System.Drawing.Point(87, 22);
            this.byeButton.Name = "byeButton";
            this.byeButton.Size = new System.Drawing.Size(75, 23);
            this.byeButton.TabIndex = 1;
            this.byeButton.Text = "bye";
            this.byeButton.UseVisualStyleBackColor = true;
            this.byeButton.Click += new System.EventHandler(this.byeButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(168, 22);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(75, 23);
            this.rightButton.TabIndex = 0;
            this.rightButton.Text = "Right";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.messageLabel.Location = new System.Drawing.Point(16, 380);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(314, 19);
            this.messageLabel.TabIndex = 7;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(124, 419);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(85, 15);
            this.outputLabel.TabIndex = 8;
            this.outputLabel.Text = "Watch this text";
            // 
            // boldCheck
            // 
            this.boldCheck.AutoSize = true;
            this.boldCheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boldCheck.Location = new System.Drawing.Point(78, 452);
            this.boldCheck.Name = "boldCheck";
            this.boldCheck.Size = new System.Drawing.Size(51, 19);
            this.boldCheck.TabIndex = 9;
            this.boldCheck.Text = "Bold";
            this.boldCheck.UseVisualStyleBackColor = true;
            this.boldCheck.CheckedChanged += new System.EventHandler(this.boldCheck_CheckedChanged);
            // 
            // italicCheck
            // 
            this.italicCheck.AutoSize = true;
            this.italicCheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.italicCheck.Location = new System.Drawing.Point(204, 452);
            this.italicCheck.Name = "italicCheck";
            this.italicCheck.Size = new System.Drawing.Size(51, 19);
            this.italicCheck.TabIndex = 10;
            this.italicCheck.Text = "Italic";
            this.italicCheck.UseVisualStyleBackColor = true;
            this.italicCheck.CheckedChanged += new System.EventHandler(this.italicCheck_CheckedChanged);
            // 
            // SimpleEventExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 637);
            this.Controls.Add(this.italicCheck);
            this.Controls.Add(this.boldCheck);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.displayMessage);
            this.Controls.Add(this.passInput);
            this.Controls.Add(this.displayedPassLabel);
            this.Controls.Add(this.displayPassButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(200, 240);
            this.Name = "SimpleEventExample";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button displayPassButton;
        private System.Windows.Forms.Label displayedPassLabel;
        private System.Windows.Forms.TextBox passInput;
        private System.Windows.Forms.Button displayMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button hiButton;
        private System.Windows.Forms.Button byeButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.CheckBox boldCheck;
        private System.Windows.Forms.CheckBox italicCheck;
    }
}

