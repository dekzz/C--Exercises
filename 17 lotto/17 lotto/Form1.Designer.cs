namespace _17_lotto
{
    partial class frmLotto
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
            this.btnRoll = new System.Windows.Forms.Button();
            this.lblNr1 = new System.Windows.Forms.Label();
            this.lblNr2 = new System.Windows.Forms.Label();
            this.lblNr3 = new System.Windows.Forms.Label();
            this.lblNr4 = new System.Windows.Forms.Label();
            this.lblNr5 = new System.Windows.Forms.Label();
            this.lblNr6 = new System.Windows.Forms.Label();
            this.lblNr7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(39, 208);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(75, 23);
            this.btnRoll.TabIndex = 0;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // lblNr1
            // 
            this.lblNr1.AutoSize = true;
            this.lblNr1.Location = new System.Drawing.Point(26, 18);
            this.lblNr1.Name = "lblNr1";
            this.lblNr1.Size = new System.Drawing.Size(0, 13);
            this.lblNr1.TabIndex = 1;
            // 
            // lblNr2
            // 
            this.lblNr2.AutoSize = true;
            this.lblNr2.Location = new System.Drawing.Point(26, 40);
            this.lblNr2.Name = "lblNr2";
            this.lblNr2.Size = new System.Drawing.Size(0, 13);
            this.lblNr2.TabIndex = 2;
            // 
            // lblNr3
            // 
            this.lblNr3.AutoSize = true;
            this.lblNr3.Location = new System.Drawing.Point(26, 62);
            this.lblNr3.Name = "lblNr3";
            this.lblNr3.Size = new System.Drawing.Size(0, 13);
            this.lblNr3.TabIndex = 3;
            // 
            // lblNr4
            // 
            this.lblNr4.AutoSize = true;
            this.lblNr4.Location = new System.Drawing.Point(26, 86);
            this.lblNr4.Name = "lblNr4";
            this.lblNr4.Size = new System.Drawing.Size(0, 13);
            this.lblNr4.TabIndex = 4;
            // 
            // lblNr5
            // 
            this.lblNr5.AutoSize = true;
            this.lblNr5.Location = new System.Drawing.Point(26, 111);
            this.lblNr5.Name = "lblNr5";
            this.lblNr5.Size = new System.Drawing.Size(0, 13);
            this.lblNr5.TabIndex = 5;
            // 
            // lblNr6
            // 
            this.lblNr6.AutoSize = true;
            this.lblNr6.Location = new System.Drawing.Point(26, 135);
            this.lblNr6.Name = "lblNr6";
            this.lblNr6.Size = new System.Drawing.Size(0, 13);
            this.lblNr6.TabIndex = 6;
            // 
            // lblNr7
            // 
            this.lblNr7.AutoSize = true;
            this.lblNr7.Location = new System.Drawing.Point(26, 159);
            this.lblNr7.Name = "lblNr7";
            this.lblNr7.Size = new System.Drawing.Size(0, 13);
            this.lblNr7.TabIndex = 7;
            // 
            // frmLotto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(158, 248);
            this.Controls.Add(this.lblNr7);
            this.Controls.Add(this.lblNr6);
            this.Controls.Add(this.lblNr5);
            this.Controls.Add(this.lblNr4);
            this.Controls.Add(this.lblNr3);
            this.Controls.Add(this.lblNr2);
            this.Controls.Add(this.lblNr1);
            this.Controls.Add(this.btnRoll);
            this.Name = "frmLotto";
            this.Text = "Lotto 7/39";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Label lblNr1;
        private System.Windows.Forms.Label lblNr2;
        private System.Windows.Forms.Label lblNr3;
        private System.Windows.Forms.Label lblNr4;
        private System.Windows.Forms.Label lblNr5;
        private System.Windows.Forms.Label lblNr6;
        private System.Windows.Forms.Label lblNr7;
    }
}

