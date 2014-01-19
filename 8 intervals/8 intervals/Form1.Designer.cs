namespace _8_intervals
{
    partial class frmInerval
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
            this.txtInterval1 = new System.Windows.Forms.TextBox();
            this.txtInterval2 = new System.Windows.Forms.TextBox();
            this.txtInterval3 = new System.Windows.Forms.TextBox();
            this.txtInterval4 = new System.Windows.Forms.TextBox();
            this.btnMerge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInterval1
            // 
            this.txtInterval1.Location = new System.Drawing.Point(39, 33);
            this.txtInterval1.Name = "txtInterval1";
            this.txtInterval1.Size = new System.Drawing.Size(156, 20);
            this.txtInterval1.TabIndex = 0;
            // 
            // txtInterval2
            // 
            this.txtInterval2.Location = new System.Drawing.Point(39, 72);
            this.txtInterval2.Name = "txtInterval2";
            this.txtInterval2.Size = new System.Drawing.Size(156, 20);
            this.txtInterval2.TabIndex = 1;
            // 
            // txtInterval3
            // 
            this.txtInterval3.Location = new System.Drawing.Point(39, 111);
            this.txtInterval3.Name = "txtInterval3";
            this.txtInterval3.Size = new System.Drawing.Size(156, 20);
            this.txtInterval3.TabIndex = 2;
            // 
            // txtInterval4
            // 
            this.txtInterval4.Location = new System.Drawing.Point(39, 148);
            this.txtInterval4.Name = "txtInterval4";
            this.txtInterval4.Size = new System.Drawing.Size(156, 20);
            this.txtInterval4.TabIndex = 3;
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(39, 187);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(75, 23);
            this.btnMerge.TabIndex = 4;
            this.btnMerge.Text = "Merge";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // frmInerval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 243);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.txtInterval4);
            this.Controls.Add(this.txtInterval3);
            this.Controls.Add(this.txtInterval2);
            this.Controls.Add(this.txtInterval1);
            this.Name = "frmInerval";
            this.Text = "Intervals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInterval1;
        private System.Windows.Forms.TextBox txtInterval2;
        private System.Windows.Forms.TextBox txtInterval3;
        private System.Windows.Forms.TextBox txtInterval4;
        private System.Windows.Forms.Button btnMerge;
    }
}

