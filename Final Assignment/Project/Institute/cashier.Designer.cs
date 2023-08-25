namespace Institute
{
    partial class cashier
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GrayText;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(43, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 157);
            this.button1.TabIndex = 0;
            this.button1.Text = "Students";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GrayText;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.Location = new System.Drawing.Point(124, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 157);
            this.button2.TabIndex = 1;
            this.button2.Text = "Student Registration";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(45, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Home";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.GrayText;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.Location = new System.Drawing.Point(207, 90);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 157);
            this.button5.TabIndex = 5;
            this.button5.Text = "Teachers";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.GrayText;
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.Location = new System.Drawing.Point(288, 287);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 157);
            this.button6.TabIndex = 6;
            this.button6.Text = "Log Out";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GrayText;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.Location = new System.Drawing.Point(377, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 157);
            this.button3.TabIndex = 7;
            this.button3.Text = "Payment";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(537, 496);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "cashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
    }
}