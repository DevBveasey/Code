namespace SumOfNumbersGUI
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
            this.integerTextBox = new System.Windows.Forms.TextBox();
            this.dspSumLabel = new System.Windows.Forms.Label();
            this.sumButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(48, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Integer Value";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // integerTextBox
            // 
            this.integerTextBox.Location = new System.Drawing.Point(181, 45);
            this.integerTextBox.Name = "integerTextBox";
            this.integerTextBox.Size = new System.Drawing.Size(137, 23);
            this.integerTextBox.TabIndex = 0;
            this.integerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.integerTextBox.TextChanged += new System.EventHandler(this.integerTextBox_TextChanged);
            // 
            // dspSumLabel
            // 
            this.dspSumLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dspSumLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dspSumLabel.Location = new System.Drawing.Point(60, 88);
            this.dspSumLabel.Name = "dspSumLabel";
            this.dspSumLabel.Size = new System.Drawing.Size(257, 29);
            this.dspSumLabel.TabIndex = 1;
            this.dspSumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sumButton
            // 
            this.sumButton.Location = new System.Drawing.Point(60, 146);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(102, 40);
            this.sumButton.TabIndex = 1;
            this.sumButton.Text = "&Sum Button";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.Click += new System.EventHandler(this.sumButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(211, 147);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(107, 39);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "&Exit Button";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.sumButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(383, 232);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.dspSumLabel);
            this.Controls.Add(this.integerTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SUM NUMBERS CALCULATOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox integerTextBox;
        private System.Windows.Forms.Label dspSumLabel;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.Button exitButton;
    }
}

