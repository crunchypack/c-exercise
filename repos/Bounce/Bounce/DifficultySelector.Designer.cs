namespace BounceNew
{
    partial class DifficultySelector
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
            this.easyDiff = new System.Windows.Forms.RadioButton();
            this.hardDiff = new System.Windows.Forms.RadioButton();
            this.diffButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // easyDiff
            // 
            this.easyDiff.AutoSize = true;
            this.easyDiff.Checked = true;
            this.easyDiff.Location = new System.Drawing.Point(13, 26);
            this.easyDiff.Name = "easyDiff";
            this.easyDiff.Size = new System.Drawing.Size(48, 17);
            this.easyDiff.TabIndex = 0;
            this.easyDiff.TabStop = true;
            this.easyDiff.Text = "Easy";
            this.easyDiff.UseVisualStyleBackColor = true;
            // 
            // hardDiff
            // 
            this.hardDiff.AutoSize = true;
            this.hardDiff.Location = new System.Drawing.Point(13, 61);
            this.hardDiff.Name = "hardDiff";
            this.hardDiff.Size = new System.Drawing.Size(48, 17);
            this.hardDiff.TabIndex = 1;
            this.hardDiff.Text = "Hard";
            this.hardDiff.UseVisualStyleBackColor = true;
            // 
            // diffButton
            // 
            this.diffButton.Location = new System.Drawing.Point(161, 126);
            this.diffButton.Name = "diffButton";
            this.diffButton.Size = new System.Drawing.Size(75, 23);
            this.diffButton.TabIndex = 2;
            this.diffButton.Text = "OK";
            this.diffButton.UseVisualStyleBackColor = true;
            this.diffButton.Click += new System.EventHandler(this.diffButton_Click);
            // 
            // DifficultySelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 161);
            this.Controls.Add(this.diffButton);
            this.Controls.Add(this.hardDiff);
            this.Controls.Add(this.easyDiff);
            this.Name = "DifficultySelector";
            this.Text = "DifficultySelector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton easyDiff;
        private System.Windows.Forms.RadioButton hardDiff;
        private System.Windows.Forms.Button diffButton;
    }
}