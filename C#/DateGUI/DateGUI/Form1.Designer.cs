namespace DateGUI
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
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.todayLabel = new System.Windows.Forms.Label();
            this.tomorrowLabel = new System.Windows.Forms.Label();
            this.dispalyButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(55, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Month";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(214, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Year";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(138, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Day";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthTextBox
            // 
            this.monthTextBox.Location = new System.Drawing.Point(58, 46);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(55, 23);
            this.monthTextBox.TabIndex = 0;
            this.monthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.monthTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // dayTextBox
            // 
            this.dayTextBox.Location = new System.Drawing.Point(138, 46);
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.Size = new System.Drawing.Size(55, 23);
            this.dayTextBox.TabIndex = 3;
            this.dayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dayTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(214, 46);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(55, 23);
            this.yearTextBox.TabIndex = 4;
            this.yearTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yearTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // todayLabel
            // 
            this.todayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.todayLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayLabel.Location = new System.Drawing.Point(58, 83);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(211, 23);
            this.todayLabel.TabIndex = 5;
            this.todayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tomorrowLabel
            // 
            this.tomorrowLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tomorrowLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tomorrowLabel.Location = new System.Drawing.Point(58, 119);
            this.tomorrowLabel.Name = "tomorrowLabel";
            this.tomorrowLabel.Size = new System.Drawing.Size(211, 23);
            this.tomorrowLabel.TabIndex = 6;
            this.tomorrowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dispalyButton
            // 
            this.dispalyButton.Location = new System.Drawing.Point(58, 158);
            this.dispalyButton.Name = "dispalyButton";
            this.dispalyButton.Size = new System.Drawing.Size(95, 43);
            this.dispalyButton.TabIndex = 7;
            this.dispalyButton.Text = "&Display Dates";
            this.dispalyButton.UseVisualStyleBackColor = true;
            this.dispalyButton.Click += new System.EventHandler(this.dispalyButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(175, 158);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(94, 43);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.dispalyButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(329, 236);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.dispalyButton);
            this.Controls.Add(this.tomorrowLabel);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.dayTextBox);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DATE MANIPULATOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.TextBox dayTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.Label tomorrowLabel;
        private System.Windows.Forms.Button dispalyButton;
        private System.Windows.Forms.Button exitButton;
    }
}

