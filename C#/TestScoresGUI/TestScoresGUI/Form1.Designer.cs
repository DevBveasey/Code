namespace TestScoresGUI
{
    partial class Form1
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
            this.findAvgButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.averageLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreOneTextBox = new System.Windows.Forms.TextBox();
            this.scoreTwoTextBox = new System.Windows.Forms.TextBox();
            this.scoreThreeTextBox = new System.Windows.Forms.TextBox();
            this.scoreFourTextBox = new System.Windows.Forms.TextBox();
            this.scoreFiveTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // findAvgButton
            // 
            this.findAvgButton.Location = new System.Drawing.Point(72, 317);
            this.findAvgButton.Name = "findAvgButton";
            this.findAvgButton.Size = new System.Drawing.Size(132, 35);
            this.findAvgButton.TabIndex = 5;
            this.findAvgButton.Text = "&Find Average";
            this.findAvgButton.UseVisualStyleBackColor = true;
            this.findAvgButton.Click += new System.EventHandler(this.findAvgButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(227, 317);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(119, 35);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // averageLabel
            // 
            this.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.averageLabel.Location = new System.Drawing.Point(227, 256);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(119, 25);
            this.averageLabel.TabIndex = 2;
            this.averageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(69, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Average Test Score";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(69, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter Test Score 4";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(69, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Enter Test Score 3";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(69, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 29);
            this.label7.TabIndex = 8;
            this.label7.Text = "Enter Test Score 2";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(69, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 22);
            this.label8.TabIndex = 9;
            this.label8.Text = "Enter Test Score 1";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(69, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter Test Score 5";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreOneTextBox
            // 
            this.scoreOneTextBox.Location = new System.Drawing.Point(227, 56);
            this.scoreOneTextBox.Name = "scoreOneTextBox";
            this.scoreOneTextBox.Size = new System.Drawing.Size(119, 23);
            this.scoreOneTextBox.TabIndex = 0;
            this.scoreOneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.scoreOneTextBox.TextChanged += new System.EventHandler(this.scoreOneTextBox_TextChanged);
            // 
            // scoreTwoTextBox
            // 
            this.scoreTwoTextBox.Location = new System.Drawing.Point(227, 91);
            this.scoreTwoTextBox.Name = "scoreTwoTextBox";
            this.scoreTwoTextBox.Size = new System.Drawing.Size(119, 23);
            this.scoreTwoTextBox.TabIndex = 1;
            this.scoreTwoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.scoreTwoTextBox.TextChanged += new System.EventHandler(this.scoreTwoTextBox_TextChanged);
            // 
            // scoreThreeTextBox
            // 
            this.scoreThreeTextBox.Location = new System.Drawing.Point(227, 129);
            this.scoreThreeTextBox.Name = "scoreThreeTextBox";
            this.scoreThreeTextBox.Size = new System.Drawing.Size(119, 23);
            this.scoreThreeTextBox.TabIndex = 2;
            this.scoreThreeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.scoreThreeTextBox.TextChanged += new System.EventHandler(this.scoreThreeTextBox_TextChanged);
            // 
            // scoreFourTextBox
            // 
            this.scoreFourTextBox.Location = new System.Drawing.Point(227, 168);
            this.scoreFourTextBox.Name = "scoreFourTextBox";
            this.scoreFourTextBox.Size = new System.Drawing.Size(119, 23);
            this.scoreFourTextBox.TabIndex = 3;
            this.scoreFourTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.scoreFourTextBox.TextChanged += new System.EventHandler(this.scoreFourTextBox_TextChanged);
            // 
            // scoreFiveTextBox
            // 
            this.scoreFiveTextBox.Location = new System.Drawing.Point(227, 200);
            this.scoreFiveTextBox.Name = "scoreFiveTextBox";
            this.scoreFiveTextBox.Size = new System.Drawing.Size(119, 23);
            this.scoreFiveTextBox.TabIndex = 4;
            this.scoreFiveTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.scoreFiveTextBox.TextChanged += new System.EventHandler(this.scoreFiveTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.findAvgButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(420, 412);
            this.ControlBox = false;
            this.Controls.Add(this.scoreFiveTextBox);
            this.Controls.Add(this.scoreFourTextBox);
            this.Controls.Add(this.scoreThreeTextBox);
            this.Controls.Add(this.scoreTwoTextBox);
            this.Controls.Add(this.scoreOneTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.findAvgButton);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AVERAGE TEST SCORE CALCULATOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button findAvgButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox scoreOneTextBox;
        private System.Windows.Forms.TextBox scoreTwoTextBox;
        private System.Windows.Forms.TextBox scoreThreeTextBox;
        private System.Windows.Forms.TextBox scoreFourTextBox;
        private System.Windows.Forms.TextBox scoreFiveTextBox;
    }
}

