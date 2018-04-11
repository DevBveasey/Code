namespace ProjectedSalesGUI
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
            this.findSalesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.projectNorthLabel = new System.Windows.Forms.Label();
            this.projectSouthLabel = new System.Windows.Forms.Label();
            this.currentNorthTextBox = new System.Windows.Forms.TextBox();
            this.currentSouthTextBox = new System.Windows.Forms.TextBox();
            this.projectedNorthLabel = new System.Windows.Forms.Label();
            this.projectedSouthLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // findSalesButton
            // 
            this.findSalesButton.Location = new System.Drawing.Point(61, 221);
            this.findSalesButton.Name = "findSalesButton";
            this.findSalesButton.Size = new System.Drawing.Size(146, 41);
            this.findSalesButton.TabIndex = 3;
            this.findSalesButton.Text = "&Find Projected Sales";
            this.findSalesButton.UseVisualStyleBackColor = true;
            this.findSalesButton.Click += new System.EventHandler(this.findSalesButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(230, 221);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(140, 41);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(58, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Current North Division Sales";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(58, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Current South Division Sales";
            // 
            // projectNorthLabel
            // 
            this.projectNorthLabel.Location = new System.Drawing.Point(61, 131);
            this.projectNorthLabel.Name = "projectNorthLabel";
            this.projectNorthLabel.Size = new System.Drawing.Size(198, 23);
            this.projectNorthLabel.TabIndex = 4;
            this.projectNorthLabel.Text = "Projected North Division Sales";
            // 
            // projectSouthLabel
            // 
            this.projectSouthLabel.Location = new System.Drawing.Point(61, 163);
            this.projectSouthLabel.Name = "projectSouthLabel";
            this.projectSouthLabel.Size = new System.Drawing.Size(198, 20);
            this.projectSouthLabel.TabIndex = 5;
            this.projectSouthLabel.Text = "Projected South Division Sales";
            // 
            // currentNorthTextBox
            // 
            this.currentNorthTextBox.Location = new System.Drawing.Point(270, 39);
            this.currentNorthTextBox.Name = "currentNorthTextBox";
            this.currentNorthTextBox.Size = new System.Drawing.Size(100, 23);
            this.currentNorthTextBox.TabIndex = 0;
            this.currentNorthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.currentNorthTextBox.TextChanged += new System.EventHandler(this.currentNorthTextBox_TextChanged);
            // 
            // currentSouthTextBox
            // 
            this.currentSouthTextBox.Location = new System.Drawing.Point(270, 73);
            this.currentSouthTextBox.Name = "currentSouthTextBox";
            this.currentSouthTextBox.Size = new System.Drawing.Size(100, 23);
            this.currentSouthTextBox.TabIndex = 1;
            this.currentSouthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.currentSouthTextBox.TextChanged += new System.EventHandler(this.currentSouthTextBox_TextChanged);
            // 
            // projectedNorthLabel
            // 
            this.projectedNorthLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.projectedNorthLabel.Location = new System.Drawing.Point(270, 127);
            this.projectedNorthLabel.Name = "projectedNorthLabel";
            this.projectedNorthLabel.Size = new System.Drawing.Size(100, 23);
            this.projectedNorthLabel.TabIndex = 6;
            this.projectedNorthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // projectedSouthLabel
            // 
            this.projectedSouthLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.projectedSouthLabel.Location = new System.Drawing.Point(270, 159);
            this.projectedSouthLabel.Name = "projectedSouthLabel";
            this.projectedSouthLabel.Size = new System.Drawing.Size(100, 23);
            this.projectedSouthLabel.TabIndex = 7;
            this.projectedSouthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.findSalesButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(432, 318);
            this.ControlBox = false;
            this.Controls.Add(this.projectedSouthLabel);
            this.Controls.Add(this.projectedNorthLabel);
            this.Controls.Add(this.currentSouthTextBox);
            this.Controls.Add(this.currentNorthTextBox);
            this.Controls.Add(this.projectSouthLabel);
            this.Controls.Add(this.projectNorthLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.findSalesButton);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CURRENT AND PROJECTED SALES CALCULATOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button findSalesButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label projectNorthLabel;
        private System.Windows.Forms.Label projectSouthLabel;
        private System.Windows.Forms.TextBox currentNorthTextBox;
        private System.Windows.Forms.TextBox currentSouthTextBox;
        private System.Windows.Forms.Label projectedNorthLabel;
        private System.Windows.Forms.Label projectedSouthLabel;
    }
}

