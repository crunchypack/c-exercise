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
            this.buttonType = new System.Windows.Forms.GroupBox();
            this.yesNoCancel = new System.Windows.Forms.RadioButton();
            this.yesNo = new System.Windows.Forms.RadioButton();
            this.retryCancel = new System.Windows.Forms.RadioButton();
            this.okCancel = new System.Windows.Forms.RadioButton();
            this.abortRetry = new System.Windows.Forms.RadioButton();
            this.okButton = new System.Windows.Forms.RadioButton();
            this.icon = new System.Windows.Forms.GroupBox();
            this.warning = new System.Windows.Forms.RadioButton();
            this.stop = new System.Windows.Forms.RadioButton();
            this.question = new System.Windows.Forms.RadioButton();
            this.info = new System.Windows.Forms.RadioButton();
            this.exclamation = new System.Windows.Forms.RadioButton();
            this.hand = new System.Windows.Forms.RadioButton();
            this.error = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.displayB = new System.Windows.Forms.Button();
            this.displayLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.buttonType.SuspendLayout();
            this.icon.SuspendLayout();
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
            // buttonType
            // 
            this.buttonType.Controls.Add(this.yesNoCancel);
            this.buttonType.Controls.Add(this.yesNo);
            this.buttonType.Controls.Add(this.retryCancel);
            this.buttonType.Controls.Add(this.okCancel);
            this.buttonType.Controls.Add(this.abortRetry);
            this.buttonType.Controls.Add(this.okButton);
            this.buttonType.Location = new System.Drawing.Point(401, 40);
            this.buttonType.Name = "buttonType";
            this.buttonType.Size = new System.Drawing.Size(204, 286);
            this.buttonType.TabIndex = 11;
            this.buttonType.TabStop = false;
            this.buttonType.Text = "Button Type";
            // 
            // yesNoCancel
            // 
            this.yesNoCancel.AutoSize = true;
            this.yesNoCancel.Location = new System.Drawing.Point(22, 117);
            this.yesNoCancel.Name = "yesNoCancel";
            this.yesNoCancel.Size = new System.Drawing.Size(94, 19);
            this.yesNoCancel.TabIndex = 5;
            this.yesNoCancel.TabStop = true;
            this.yesNoCancel.Text = "YesNoCancel";
            this.yesNoCancel.UseVisualStyleBackColor = true;
            this.yesNoCancel.CheckedChanged += new System.EventHandler(this.buttonTyp_CheckedChanged);
            // 
            // yesNo
            // 
            this.yesNo.AutoSize = true;
            this.yesNo.Location = new System.Drawing.Point(22, 142);
            this.yesNo.Name = "yesNo";
            this.yesNo.Size = new System.Drawing.Size(58, 19);
            this.yesNo.TabIndex = 4;
            this.yesNo.TabStop = true;
            this.yesNo.Text = "YesNo";
            this.yesNo.UseVisualStyleBackColor = true;
            this.yesNo.CheckedChanged += new System.EventHandler(this.buttonTyp_CheckedChanged);
            // 
            // retryCancel
            // 
            this.retryCancel.AutoSize = true;
            this.retryCancel.Location = new System.Drawing.Point(22, 170);
            this.retryCancel.Name = "retryCancel";
            this.retryCancel.Size = new System.Drawing.Size(88, 19);
            this.retryCancel.TabIndex = 3;
            this.retryCancel.TabStop = true;
            this.retryCancel.Text = "RetryCancel";
            this.retryCancel.UseVisualStyleBackColor = true;
            this.retryCancel.CheckedChanged += new System.EventHandler(this.buttonTyp_CheckedChanged);
            // 
            // okCancel
            // 
            this.okCancel.AutoSize = true;
            this.okCancel.Location = new System.Drawing.Point(22, 63);
            this.okCancel.Name = "okCancel";
            this.okCancel.Size = new System.Drawing.Size(76, 19);
            this.okCancel.TabIndex = 2;
            this.okCancel.TabStop = true;
            this.okCancel.Text = "OKCancel";
            this.okCancel.UseVisualStyleBackColor = true;
            this.okCancel.CheckedChanged += new System.EventHandler(this.buttonTyp_CheckedChanged);
            // 
            // abortRetry
            // 
            this.abortRetry.AutoSize = true;
            this.abortRetry.Location = new System.Drawing.Point(22, 88);
            this.abortRetry.Name = "abortRetry";
            this.abortRetry.Size = new System.Drawing.Size(116, 19);
            this.abortRetry.TabIndex = 1;
            this.abortRetry.TabStop = true;
            this.abortRetry.Text = "AbortRetryIgnore";
            this.abortRetry.UseVisualStyleBackColor = true;
            this.abortRetry.CheckedChanged += new System.EventHandler(this.buttonTyp_CheckedChanged);
            // 
            // okButton
            // 
            this.okButton.AutoSize = true;
            this.okButton.Location = new System.Drawing.Point(22, 38);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(41, 19);
            this.okButton.TabIndex = 0;
            this.okButton.TabStop = true;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.CheckedChanged += new System.EventHandler(this.buttonTyp_CheckedChanged);
            // 
            // icon
            // 
            this.icon.Controls.Add(this.warning);
            this.icon.Controls.Add(this.stop);
            this.icon.Controls.Add(this.question);
            this.icon.Controls.Add(this.info);
            this.icon.Controls.Add(this.exclamation);
            this.icon.Controls.Add(this.hand);
            this.icon.Controls.Add(this.error);
            this.icon.Controls.Add(this.radioButton7);
            this.icon.Location = new System.Drawing.Point(624, 40);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(219, 359);
            this.icon.TabIndex = 12;
            this.icon.TabStop = false;
            this.icon.Text = "Icon";
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.Location = new System.Drawing.Point(22, 219);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(70, 19);
            this.warning.TabIndex = 8;
            this.warning.TabStop = true;
            this.warning.Text = "Warning";
            this.warning.UseVisualStyleBackColor = true;
            this.warning.CheckedChanged += new System.EventHandler(this.icons_Enter);
            // 
            // stop
            // 
            this.stop.AutoSize = true;
            this.stop.Location = new System.Drawing.Point(22, 192);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(49, 19);
            this.stop.TabIndex = 7;
            this.stop.TabStop = true;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.CheckedChanged += new System.EventHandler(this.icons_Enter);
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.Location = new System.Drawing.Point(22, 167);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(73, 19);
            this.question.TabIndex = 6;
            this.question.TabStop = true;
            this.question.Text = "Question";
            this.question.UseVisualStyleBackColor = true;
            this.question.CheckedChanged += new System.EventHandler(this.icons_Enter);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(22, 142);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(88, 19);
            this.info.TabIndex = 5;
            this.info.TabStop = true;
            this.info.Text = "Information";
            this.info.UseVisualStyleBackColor = true;
            this.info.CheckedChanged += new System.EventHandler(this.icons_Enter);
            // 
            // exclamation
            // 
            this.exclamation.AutoSize = true;
            this.exclamation.Location = new System.Drawing.Point(22, 117);
            this.exclamation.Name = "exclamation";
            this.exclamation.Size = new System.Drawing.Size(89, 19);
            this.exclamation.TabIndex = 4;
            this.exclamation.TabStop = true;
            this.exclamation.Text = "Exclamation";
            this.exclamation.UseVisualStyleBackColor = true;
            this.exclamation.CheckedChanged += new System.EventHandler(this.icons_Enter);
            // 
            // hand
            // 
            this.hand.AutoSize = true;
            this.hand.Location = new System.Drawing.Point(22, 90);
            this.hand.Name = "hand";
            this.hand.Size = new System.Drawing.Size(54, 19);
            this.hand.TabIndex = 3;
            this.hand.TabStop = true;
            this.hand.Text = "Hand";
            this.hand.UseVisualStyleBackColor = true;
            this.hand.CheckedChanged += new System.EventHandler(this.icons_Enter);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Location = new System.Drawing.Point(22, 63);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(50, 19);
            this.error.TabIndex = 2;
            this.error.TabStop = true;
            this.error.Text = "Error";
            this.error.UseVisualStyleBackColor = true;
            this.error.CheckedChanged += new System.EventHandler(this.icons_Enter);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(22, 38);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(66, 19);
            this.radioButton7.TabIndex = 1;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Asterisk";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.icons_Enter);
            // 
            // displayB
            // 
            this.displayB.Location = new System.Drawing.Point(423, 339);
            this.displayB.Name = "displayB";
            this.displayB.Size = new System.Drawing.Size(157, 60);
            this.displayB.TabIndex = 13;
            this.displayB.Text = "Display";
            this.displayB.UseVisualStyleBackColor = true;
            this.displayB.Click += new System.EventHandler(this.displayB_Click);
            // 
            // displayLabel
            // 
            this.displayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayLabel.Location = new System.Drawing.Point(420, 402);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(245, 32);
            this.displayLabel.TabIndex = 14;
            // 
            // SimpleEventExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 637);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.displayB);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.buttonType);
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
            this.buttonType.ResumeLayout(false);
            this.buttonType.PerformLayout();
            this.icon.ResumeLayout(false);
            this.icon.PerformLayout();
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
        private System.Windows.Forms.GroupBox buttonType;
        private System.Windows.Forms.RadioButton yesNoCancel;
        private System.Windows.Forms.RadioButton yesNo;
        private System.Windows.Forms.RadioButton retryCancel;
        private System.Windows.Forms.RadioButton okCancel;
        private System.Windows.Forms.RadioButton abortRetry;
        private System.Windows.Forms.RadioButton okButton;
        private System.Windows.Forms.GroupBox icon;
        private System.Windows.Forms.RadioButton warning;
        private System.Windows.Forms.RadioButton stop;
        private System.Windows.Forms.RadioButton question;
        private System.Windows.Forms.RadioButton info;
        private System.Windows.Forms.RadioButton exclamation;
        private System.Windows.Forms.RadioButton hand;
        private System.Windows.Forms.RadioButton error;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.Button displayB;
        private System.Windows.Forms.Label displayLabel;
    }
}

