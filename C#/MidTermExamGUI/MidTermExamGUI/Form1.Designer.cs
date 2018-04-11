namespace MidTermExamGUI
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
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.drawerTextBox = new System.Windows.Forms.TextBox();
            this.quoteDisplayLabel = new System.Windows.Forms.Label();
            this.showTypesButton = new System.Windows.Forms.Button();
            this.quoteButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(42, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Number of Drawers";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(42, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Type of Wood (P,O,M)";
            // 
            // typeTextBox
            // 
            this.typeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.typeTextBox.Location = new System.Drawing.Point(213, 91);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(91, 23);
            this.typeTextBox.TabIndex = 1;
            this.typeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.typeTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // drawerTextBox
            // 
            this.drawerTextBox.Location = new System.Drawing.Point(213, 46);
            this.drawerTextBox.Name = "drawerTextBox";
            this.drawerTextBox.Size = new System.Drawing.Size(91, 23);
            this.drawerTextBox.TabIndex = 0;
            this.drawerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.drawerTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // quoteDisplayLabel
            // 
            this.quoteDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.quoteDisplayLabel.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteDisplayLabel.Location = new System.Drawing.Point(45, 124);
            this.quoteDisplayLabel.Name = "quoteDisplayLabel";
            this.quoteDisplayLabel.Size = new System.Drawing.Size(335, 140);
            this.quoteDisplayLabel.TabIndex = 2;
            // 
            // showTypesButton
            // 
            this.showTypesButton.Location = new System.Drawing.Point(324, 46);
            this.showTypesButton.Name = "showTypesButton";
            this.showTypesButton.Size = new System.Drawing.Size(56, 65);
            this.showTypesButton.TabIndex = 4;
            this.showTypesButton.Text = "&View Wood Types";
            this.showTypesButton.UseVisualStyleBackColor = true;
            this.showTypesButton.Click += new System.EventHandler(this.showTypesButton_Click);
            // 
            // quoteButton
            // 
            this.quoteButton.Location = new System.Drawing.Point(45, 276);
            this.quoteButton.Name = "quoteButton";
            this.quoteButton.Size = new System.Drawing.Size(153, 35);
            this.quoteButton.TabIndex = 2;
            this.quoteButton.Text = "&Get Quote";
            this.quoteButton.UseVisualStyleBackColor = true;
            this.quoteButton.Click += new System.EventHandler(this.quoteButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(226, 276);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(154, 35);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.quoteButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(459, 360);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.quoteButton);
            this.Controls.Add(this.showTypesButton);
            this.Controls.Add(this.quoteDisplayLabel);
            this.Controls.Add(this.drawerTextBox);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CUSTOM DESK PRICE CALCULATOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox drawerTextBox;
        private System.Windows.Forms.Label quoteDisplayLabel;
        private System.Windows.Forms.Button showTypesButton;
        private System.Windows.Forms.Button quoteButton;
        private System.Windows.Forms.Button exitButton;
    }
}

