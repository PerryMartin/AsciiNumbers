namespace AssciiNumbers
{
    partial class frmAscii
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
            this.btnEnter = new System.Windows.Forms.Button();
            this.lstOfAscii = new System.Windows.Forms.ListBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(36, 59);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 31);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "ENTER";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lstOfAscii
            // 
            this.lstOfAscii.FormattingEnabled = true;
            this.lstOfAscii.Location = new System.Drawing.Point(36, 111);
            this.lstOfAscii.Name = "lstOfAscii";
            this.lstOfAscii.Size = new System.Drawing.Size(201, 134);
            this.lstOfAscii.TabIndex = 1;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(33, 27);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(135, 13);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "Press enter to the ASCII list";
            // 
            // frmAscii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lstOfAscii);
            this.Controls.Add(this.btnEnter);
            this.Name = "frmAscii";
            this.Text = "ASCII";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.ListBox lstOfAscii;
        private System.Windows.Forms.Label lblQuestion;
    }
}

