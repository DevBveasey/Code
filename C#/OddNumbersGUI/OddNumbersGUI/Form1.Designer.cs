namespace OddNumbersGUI
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
            this.showNumButton = new System.Windows.Forms.Button();
            this.numLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showNumButton
            // 
            this.showNumButton.Location = new System.Drawing.Point(85, 31);
            this.showNumButton.Name = "showNumButton";
            this.showNumButton.Size = new System.Drawing.Size(140, 46);
            this.showNumButton.TabIndex = 0;
            this.showNumButton.Text = "&Display Numbers";
            this.showNumButton.UseVisualStyleBackColor = true;
            this.showNumButton.Click += new System.EventHandler(this.showNumButton_Click);
            // 
            // numLabel
            // 
            this.numLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.numLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLabel.Location = new System.Drawing.Point(87, 99);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(138, 175);
            this.numLabel.TabIndex = 1;
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(87, 292);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(138, 44);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.showNumButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(314, 363);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.numLabel);
            this.Controls.Add(this.showNumButton);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ODD NUMBERS 1 TO 99";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showNumButton;
        private System.Windows.Forms.Label numLabel;
        private System.Windows.Forms.Button exitButton;
    }
}

