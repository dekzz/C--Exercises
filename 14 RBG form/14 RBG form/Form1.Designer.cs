namespace _14_RBG_form
{
    partial class frmRBG
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
            this.btnClorize = new System.Windows.Forms.Button();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClorize
            // 
            this.btnClorize.Location = new System.Drawing.Point(79, 157);
            this.btnClorize.Name = "btnClorize";
            this.btnClorize.Size = new System.Drawing.Size(75, 23);
            this.btnClorize.TabIndex = 0;
            this.btnClorize.Text = "Clorize";
            this.btnClorize.UseVisualStyleBackColor = true;
            this.btnClorize.Click += new System.EventHandler(this.btnClorize_Click);
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(35, 33);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(177, 20);
            this.txtR.TabIndex = 1;
            this.txtR.TextChanged += new System.EventHandler(this.txtR_TextChanged);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(35, 79);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(177, 20);
            this.txtB.TabIndex = 2;
            this.txtB.TextChanged += new System.EventHandler(this.txtB_TextChanged);
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(35, 121);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(177, 20);
            this.txtG.TabIndex = 3;
            this.txtG.TextChanged += new System.EventHandler(this.txtG_TextChanged);
            // 
            // frmRBG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 203);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.btnClorize);
            this.Name = "frmRBG";
            this.Text = "RBG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClorize;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtG;
    }
}

