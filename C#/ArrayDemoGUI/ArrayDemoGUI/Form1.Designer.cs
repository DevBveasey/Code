namespace ArrayDemoGUI
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
            this.valuesTextBox = new System.Windows.Forms.TextBox();
            this.writeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.entryLabel = new System.Windows.Forms.Label();
            this.reverseLabel = new System.Windows.Forms.Label();
            this.sortLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.entryButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.reverseButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(39, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter 10 integer Values";
            // 
            // valuesTextBox
            // 
            this.valuesTextBox.Location = new System.Drawing.Point(186, 56);
            this.valuesTextBox.Name = "valuesTextBox";
            this.valuesTextBox.Size = new System.Drawing.Size(89, 23);
            this.valuesTextBox.TabIndex = 0;
            this.valuesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(307, 57);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(102, 22);
            this.writeButton.TabIndex = 1;
            this.writeButton.Text = "&Write to Array";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(42, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Entry Order";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // entryLabel
            // 
            this.entryLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.entryLabel.Location = new System.Drawing.Point(45, 129);
            this.entryLabel.Name = "entryLabel";
            this.entryLabel.Size = new System.Drawing.Size(102, 154);
            this.entryLabel.TabIndex = 4;
            this.entryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reverseLabel
            // 
            this.reverseLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reverseLabel.Location = new System.Drawing.Point(173, 129);
            this.reverseLabel.Name = "reverseLabel";
            this.reverseLabel.Size = new System.Drawing.Size(102, 154);
            this.reverseLabel.TabIndex = 5;
            this.reverseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sortLabel
            // 
            this.sortLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sortLabel.Location = new System.Drawing.Point(307, 129);
            this.sortLabel.Name = "sortLabel";
            this.sortLabel.Size = new System.Drawing.Size(102, 154);
            this.sortLabel.TabIndex = 6;
            this.sortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(173, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Reverse Order";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(304, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sorted Order";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // entryButton
            // 
            this.entryButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.entryButton.Location = new System.Drawing.Point(45, 307);
            this.entryButton.Name = "entryButton";
            this.entryButton.Size = new System.Drawing.Size(102, 47);
            this.entryButton.TabIndex = 2;
            this.entryButton.Text = "View &Entry Order";
            this.entryButton.UseVisualStyleBackColor = true;
            this.entryButton.Click += new System.EventHandler(this.entryButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(310, 307);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(102, 47);
            this.sortButton.TabIndex = 4;
            this.sortButton.Text = "View &Sort Order";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // reverseButton
            // 
            this.reverseButton.Location = new System.Drawing.Point(176, 307);
            this.reverseButton.Name = "reverseButton";
            this.reverseButton.Size = new System.Drawing.Size(102, 47);
            this.reverseButton.TabIndex = 3;
            this.reverseButton.Text = "View &Reverse Order";
            this.reverseButton.UseVisualStyleBackColor = true;
            this.reverseButton.Click += new System.EventHandler(this.reverseButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(146, 375);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(164, 47);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.writeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(449, 457);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.reverseButton);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.entryButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sortLabel);
            this.Controls.Add(this.reverseLabel);
            this.Controls.Add(this.entryLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.valuesTextBox);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARRAY ORDER / SEARCH APPLICATION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox valuesTextBox;
        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label entryLabel;
        private System.Windows.Forms.Label reverseLabel;
        private System.Windows.Forms.Label sortLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button entryButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button reverseButton;
        private System.Windows.Forms.Button exitButton;
    }
}

