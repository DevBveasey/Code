namespace SortNamesGUI
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
            this.numNamesTextBox = new System.Windows.Forms.TextBox();
            this.inputButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.namesDisplayLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(43, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Will you be entering 2, 5, or 10 names?";
            // 
            // numNamesTextBox
            // 
            this.numNamesTextBox.Location = new System.Drawing.Point(101, 40);
            this.numNamesTextBox.Name = "numNamesTextBox";
            this.numNamesTextBox.Size = new System.Drawing.Size(97, 23);
            this.numNamesTextBox.TabIndex = 0;
            this.numNamesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numNamesTextBox.TextChanged += new System.EventHandler(this.numNamesTextBox_TextChanged);
            // 
            // inputButton
            // 
            this.inputButton.Location = new System.Drawing.Point(75, 81);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(147, 34);
            this.inputButton.TabIndex = 1;
            this.inputButton.Text = "&Input Names";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(43, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Input names sorted in ascending order";
            // 
            // namesDisplayLabel
            // 
            this.namesDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.namesDisplayLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namesDisplayLabel.Location = new System.Drawing.Point(75, 169);
            this.namesDisplayLabel.Name = "namesDisplayLabel";
            this.namesDisplayLabel.Size = new System.Drawing.Size(154, 200);
            this.namesDisplayLabel.TabIndex = 3;
            this.namesDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(75, 385);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(146, 34);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.inputButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(311, 441);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.namesDisplayLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputButton);
            this.Controls.Add(this.numNamesTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NAME SORTER APPLICATION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numNamesTextBox;
        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label namesDisplayLabel;
        private System.Windows.Forms.Button exitButton;
    }
}

