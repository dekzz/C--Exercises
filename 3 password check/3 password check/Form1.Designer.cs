namespace _3_password_check
{
    partial class frmLog
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
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtRePass = new System.Windows.Forms.TextBox();
            this.bntLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(22, 32);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '@';
            this.txtPass.Size = new System.Drawing.Size(227, 20);
            this.txtPass.TabIndex = 0;
            // 
            // txtRePass
            // 
            this.txtRePass.Location = new System.Drawing.Point(22, 73);
            this.txtRePass.Name = "txtRePass";
            this.txtRePass.PasswordChar = '@';
            this.txtRePass.Size = new System.Drawing.Size(227, 20);
            this.txtRePass.TabIndex = 1;
            // 
            // bntLog
            // 
            this.bntLog.Location = new System.Drawing.Point(22, 112);
            this.bntLog.Name = "bntLog";
            this.bntLog.Size = new System.Drawing.Size(75, 23);
            this.bntLog.TabIndex = 2;
            this.bntLog.Text = "Login";
            this.bntLog.UseVisualStyleBackColor = true;
            this.bntLog.Click += new System.EventHandler(this.bntLog_Click);
            // 
            // frmLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 155);
            this.Controls.Add(this.bntLog);
            this.Controls.Add(this.txtRePass);
            this.Controls.Add(this.txtPass);
            this.Name = "frmLog";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtRePass;
        private System.Windows.Forms.Button bntLog;
    }
}

