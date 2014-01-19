namespace _15_apli_shutdown
{
    partial class frmShutdown
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
            this.components = new System.ComponentModel.Container();
            this.txtShutTime = new System.Windows.Forms.TextBox();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.shutdownTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtShutTime
            // 
            this.txtShutTime.Location = new System.Drawing.Point(40, 34);
            this.txtShutTime.Name = "txtShutTime";
            this.txtShutTime.Size = new System.Drawing.Size(240, 20);
            this.txtShutTime.TabIndex = 0;
            // 
            // btnShutdown
            // 
            this.btnShutdown.Location = new System.Drawing.Point(95, 71);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(115, 35);
            this.btnShutdown.TabIndex = 1;
            this.btnShutdown.Text = "Shutdown";
            this.btnShutdown.UseVisualStyleBackColor = true;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // shutdownTimer
            // 
            this.shutdownTimer.Tick += new System.EventHandler(this.shutdownTimer_Tick);
            // 
            // frmShutdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 130);
            this.Controls.Add(this.btnShutdown);
            this.Controls.Add(this.txtShutTime);
            this.Name = "frmShutdown";
            this.Text = "Shutdown";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtShutTime;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Timer shutdownTimer;
    }
}

