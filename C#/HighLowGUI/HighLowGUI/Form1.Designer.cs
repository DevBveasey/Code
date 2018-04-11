namespace HighLowGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.highLabel = new System.Windows.Forms.Label();
            this.lowLabel = new System.Windows.Forms.Label();
            this.intThreeTextBox = new System.Windows.Forms.TextBox();
            this.intTwoTextBox = new System.Windows.Forms.TextBox();
            this.intOneTextBox = new System.Windows.Forms.TextBox();
            this.determineButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(71, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Integer One";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(71, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Integer Two";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(56, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Integer Three";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(81, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "High Number";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(81, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Low Number";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highLabel
            // 
            this.highLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.highLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highLabel.Location = new System.Drawing.Point(180, 192);
            this.highLabel.Name = "highLabel";
            this.highLabel.Size = new System.Drawing.Size(90, 26);
            this.highLabel.TabIndex = 5;
            this.highLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lowLabel
            // 
            this.lowLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lowLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowLabel.Location = new System.Drawing.Point(180, 230);
            this.lowLabel.Name = "lowLabel";
            this.lowLabel.Size = new System.Drawing.Size(90, 26);
            this.lowLabel.TabIndex = 6;
            this.lowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // intThreeTextBox
            // 
            this.intThreeTextBox.Location = new System.Drawing.Point(180, 149);
            this.intThreeTextBox.Name = "intThreeTextBox";
            this.intThreeTextBox.Size = new System.Drawing.Size(100, 23);
            this.intThreeTextBox.TabIndex = 2;
            this.intThreeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.intThreeTextBox.TextChanged += new System.EventHandler(this.int_TextChanged);
            // 
            // intTwoTextBox
            // 
            this.intTwoTextBox.Location = new System.Drawing.Point(180, 109);
            this.intTwoTextBox.Name = "intTwoTextBox";
            this.intTwoTextBox.Size = new System.Drawing.Size(100, 23);
            this.intTwoTextBox.TabIndex = 1;
            this.intTwoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.intTwoTextBox.TextChanged += new System.EventHandler(this.int_TextChanged);
            // 
            // intOneTextBox
            // 
            this.intOneTextBox.Location = new System.Drawing.Point(180, 66);
            this.intOneTextBox.Name = "intOneTextBox";
            this.intOneTextBox.Size = new System.Drawing.Size(100, 23);
            this.intOneTextBox.TabIndex = 0;
            this.intOneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.intOneTextBox.TextChanged += new System.EventHandler(this.int_TextChanged);
            // 
            // determineButton
            // 
            this.determineButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.determineButton.Location = new System.Drawing.Point(74, 307);
            this.determineButton.Name = "determineButton";
            this.determineButton.Size = new System.Drawing.Size(90, 54);
            this.determineButton.TabIndex = 3;
            this.determineButton.Text = "&Determine High / Low";
            this.determineButton.UseVisualStyleBackColor = true;
            this.determineButton.Click += new System.EventHandler(this.determineButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(192, 307);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(78, 54);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.determineButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(343, 398);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.determineButton);
            this.Controls.Add(this.intOneTextBox);
            this.Controls.Add(this.intTwoTextBox);
            this.Controls.Add(this.intThreeTextBox);
            this.Controls.Add(this.lowLabel);
            this.Controls.Add(this.highLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HIGH AND LOW NUMBER FINDER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label highLabel;
        private System.Windows.Forms.Label lowLabel;
        private System.Windows.Forms.TextBox intThreeTextBox;
        private System.Windows.Forms.TextBox intTwoTextBox;
        private System.Windows.Forms.TextBox intOneTextBox;
        private System.Windows.Forms.Button determineButton;
        private System.Windows.Forms.Button exitButton;
    }
}

