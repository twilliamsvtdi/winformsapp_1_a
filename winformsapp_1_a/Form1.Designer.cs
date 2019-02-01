namespace winformsapp_1_a
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
            this.lblBanner = new System.Windows.Forms.Label();
            this.lblNamePrompt = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBanner
            // 
            this.lblBanner.AutoSize = true;
            this.lblBanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanner.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblBanner.Location = new System.Drawing.Point(12, 9);
            this.lblBanner.Name = "lblBanner";
            this.lblBanner.Size = new System.Drawing.Size(576, 48);
            this.lblBanner.TabIndex = 0;
            this.lblBanner.Text = "My First Winforms Application";
            // 
            // lblNamePrompt
            // 
            this.lblNamePrompt.AutoSize = true;
            this.lblNamePrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamePrompt.ForeColor = System.Drawing.Color.Red;
            this.lblNamePrompt.Location = new System.Drawing.Point(13, 92);
            this.lblNamePrompt.Name = "lblNamePrompt";
            this.lblNamePrompt.Size = new System.Drawing.Size(222, 31);
            this.lblNamePrompt.TabIndex = 1;
            this.lblNamePrompt.Text = "Enter Your Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(19, 127);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(216, 22);
            this.tbName.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(188, 205);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(216, 67);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(386, 127);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(216, 22);
            this.tbAge.TabIndex = 5;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.Red;
            this.lblAge.Location = new System.Drawing.Point(380, 92);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(198, 31);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Enter Your Age";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 359);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblNamePrompt);
            this.Controls.Add(this.lblBanner);
            this.Name = "Form1";
            this.Text = "My First Winform App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBanner;
        private System.Windows.Forms.Label lblNamePrompt;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Label lblAge;
    }
}

