namespace frmTrackThread
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
            this.threadlbl = new System.Windows.Forms.Label();
            this.btnrun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // threadlbl
            // 
            this.threadlbl.AutoSize = true;
            this.threadlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threadlbl.Location = new System.Drawing.Point(229, 141);
            this.threadlbl.Name = "threadlbl";
            this.threadlbl.Size = new System.Drawing.Size(362, 55);
            this.threadlbl.TabIndex = 0;
            this.threadlbl.Text = "-Thread Starts-";
            // 
            // btnrun
            // 
            this.btnrun.BackColor = System.Drawing.Color.RosyBrown;
            this.btnrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrun.ForeColor = System.Drawing.Color.Black;
            this.btnrun.Location = new System.Drawing.Point(341, 232);
            this.btnrun.Name = "btnrun";
            this.btnrun.Size = new System.Drawing.Size(119, 51);
            this.btnrun.TabIndex = 1;
            this.btnrun.Text = "Run";
            this.btnrun.UseVisualStyleBackColor = false;
            this.btnrun.Click += new System.EventHandler(this.btnrun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnrun);
            this.Controls.Add(this.threadlbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label threadlbl;
        private System.Windows.Forms.Button btnrun;
    }
}

