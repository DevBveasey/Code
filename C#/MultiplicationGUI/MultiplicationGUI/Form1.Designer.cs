namespace MultiplicationGUI
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
            this.dspLabel = new System.Windows.Forms.Label();
            this.genButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.intTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(53, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter an integer";
            // 
            // dspLabel
            // 
            this.dspLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dspLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dspLabel.Location = new System.Drawing.Point(58, 99);
            this.dspLabel.Name = "dspLabel";
            this.dspLabel.Size = new System.Drawing.Size(183, 139);
            this.dspLabel.TabIndex = 1;
            // 
            // genButton
            // 
            this.genButton.Location = new System.Drawing.Point(61, 258);
            this.genButton.Name = "genButton";
            this.genButton.Size = new System.Drawing.Size(179, 33);
            this.genButton.TabIndex = 1;
            this.genButton.Text = "&Generate Table";
            this.genButton.UseVisualStyleBackColor = true;
            this.genButton.Click += new System.EventHandler(this.genButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(66, 311);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(174, 40);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // intTextBox
            // 
            this.intTextBox.Location = new System.Drawing.Point(155, 52);
            this.intTextBox.Name = "intTextBox";
            this.intTextBox.Size = new System.Drawing.Size(85, 23);
            this.intTextBox.TabIndex = 0;
            this.intTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.intTextBox.TextChanged += new System.EventHandler(this.intTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.genButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(303, 402);
            this.ControlBox = false;
            this.Controls.Add(this.intTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.genButton);
            this.Controls.Add(this.dspLabel);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MUTIPLICATION TABLE GENERATOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dspLabel;
        private System.Windows.Forms.Button genButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox intTextBox;
    }
}

