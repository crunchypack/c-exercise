namespace BounceNew
{
    partial class BounceNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BounceNew));
            this.goButton = new System.Windows.Forms.Button();
            this.gravityUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.targetBox = new System.Windows.Forms.PictureBox();
            this.nrOfThrows = new System.Windows.Forms.Label();
            this.throwForce = new System.Windows.Forms.NumericUpDown();
            this.throwUpForce = new System.Windows.Forms.NumericUpDown();
            this.forceLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difficultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difLabel = new System.Windows.Forms.Label();
            this.windLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.highScoreLabel = new System.Windows.Forms.Label();
            this.highScoreView = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.gravityUpDown)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.targetBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.throwForce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.throwUpForce)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // goButton
            // 
            this.goButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.goButton.Location = new System.Drawing.Point(13, 491);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 0;
            this.goButton.Text = "Go!";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // gravityUpDown
            // 
            this.gravityUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gravityUpDown.DecimalPlaces = 2;
            this.gravityUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.gravityUpDown.Location = new System.Drawing.Point(1214, 494);
            this.gravityUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            65536});
            this.gravityUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.gravityUpDown.Name = "gravityUpDown";
            this.gravityUpDown.Size = new System.Drawing.Size(120, 20);
            this.gravityUpDown.TabIndex = 1;
            this.gravityUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gravityUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.gravityUpDown.ValueChanged += new System.EventHandler(this.gravityUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(1168, 496);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gravity";
            // 
            // panel
            // 
            this.panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Controls.Add(this.targetBox);
            this.panel.Location = new System.Drawing.Point(237, 29);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1079, 456);
            this.panel.TabIndex = 3;
            // 
            // targetBox
            // 
            this.targetBox.BackColor = System.Drawing.Color.Transparent;
            this.targetBox.Image = ((System.Drawing.Image)(resources.GetObject("targetBox.Image")));
            this.targetBox.Location = new System.Drawing.Point(932, 126);
            this.targetBox.Name = "targetBox";
            this.targetBox.Size = new System.Drawing.Size(123, 120);
            this.targetBox.TabIndex = 0;
            this.targetBox.TabStop = false;
            // 
            // nrOfThrows
            // 
            this.nrOfThrows.AutoSize = true;
            this.nrOfThrows.Location = new System.Drawing.Point(10, 354);
            this.nrOfThrows.Name = "nrOfThrows";
            this.nrOfThrows.Size = new System.Drawing.Size(45, 13);
            this.nrOfThrows.TabIndex = 4;
            this.nrOfThrows.Text = "Throws:";
            // 
            // throwForce
            // 
            this.throwForce.DecimalPlaces = 2;
            this.throwForce.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.throwForce.Location = new System.Drawing.Point(70, 383);
            this.throwForce.Name = "throwForce";
            this.throwForce.Size = new System.Drawing.Size(59, 20);
            this.throwForce.TabIndex = 5;
            this.throwForce.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // throwUpForce
            // 
            this.throwUpForce.DecimalPlaces = 2;
            this.throwUpForce.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.throwUpForce.Location = new System.Drawing.Point(70, 409);
            this.throwUpForce.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.throwUpForce.Name = "throwUpForce";
            this.throwUpForce.Size = new System.Drawing.Size(59, 20);
            this.throwUpForce.TabIndex = 6;
            this.throwUpForce.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // forceLabel
            // 
            this.forceLabel.AutoSize = true;
            this.forceLabel.Location = new System.Drawing.Point(4, 390);
            this.forceLabel.Name = "forceLabel";
            this.forceLabel.Size = new System.Drawing.Size(60, 13);
            this.forceLabel.TabIndex = 7;
            this.forceLabel.Text = "Force right:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Force up:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1346, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.difficultyToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // difficultyToolStripMenuItem
            // 
            this.difficultyToolStripMenuItem.Name = "difficultyToolStripMenuItem";
            this.difficultyToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.difficultyToolStripMenuItem.Text = "Difficulty";
            this.difficultyToolStripMenuItem.Click += new System.EventHandler(this.difficultyToolStripMenuItem_Click);
            // 
            // difLabel
            // 
            this.difLabel.AutoSize = true;
            this.difLabel.Location = new System.Drawing.Point(10, 294);
            this.difLabel.Name = "difLabel";
            this.difLabel.Size = new System.Drawing.Size(30, 13);
            this.difLabel.TabIndex = 10;
            this.difLabel.Text = "Easy";
            // 
            // windLabel
            // 
            this.windLabel.AutoSize = true;
            this.windLabel.Location = new System.Drawing.Point(10, 319);
            this.windLabel.Name = "windLabel";
            this.windLabel.Size = new System.Drawing.Size(35, 13);
            this.windLabel.TabIndex = 11;
            this.windLabel.Text = "label3";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(10, 264);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(38, 13);
            this.scoreLabel.TabIndex = 14;
            this.scoreLabel.Text = "Score:";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(13, 452);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 20);
            this.nameInput.TabIndex = 15;
            this.nameInput.Text = "Anon";
            // 
            // highScoreLabel
            // 
            this.highScoreLabel.AutoSize = true;
            this.highScoreLabel.Location = new System.Drawing.Point(10, 52);
            this.highScoreLabel.Name = "highScoreLabel";
            this.highScoreLabel.Size = new System.Drawing.Size(60, 13);
            this.highScoreLabel.TabIndex = 16;
            this.highScoreLabel.Text = "High Score";
            // 
            // highScoreView
            // 
            this.highScoreView.FullRowSelect = true;
            this.highScoreView.GridLines = true;
            this.highScoreView.Location = new System.Drawing.Point(7, 68);
            this.highScoreView.Name = "highScoreView";
            this.highScoreView.Size = new System.Drawing.Size(202, 150);
            this.highScoreView.TabIndex = 17;
            this.highScoreView.UseCompatibleStateImageBehavior = false;
            this.highScoreView.View = System.Windows.Forms.View.Details;
            // 
            // BounceNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 526);
            this.Controls.Add(this.highScoreView);
            this.Controls.Add(this.highScoreLabel);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.windLabel);
            this.Controls.Add(this.difLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.forceLabel);
            this.Controls.Add(this.throwUpForce);
            this.Controls.Add(this.throwForce);
            this.Controls.Add(this.nrOfThrows);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gravityUpDown);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BounceNew";
            this.Text = "Target Practise";
            this.Load += new System.EventHandler(this.Bounce_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gravityUpDown)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.targetBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.throwForce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.throwUpForce)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.NumericUpDown gravityUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label nrOfThrows;
        private System.Windows.Forms.NumericUpDown throwForce;
        private System.Windows.Forms.NumericUpDown throwUpForce;
        private System.Windows.Forms.Label forceLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem difficultyToolStripMenuItem;
        private System.Windows.Forms.PictureBox targetBox;
        private System.Windows.Forms.Label difLabel;
        private System.Windows.Forms.Label windLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label highScoreLabel;
        private System.Windows.Forms.ListView highScoreView;
    }
}

