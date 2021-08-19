
namespace SimpleWinForms
{
    partial class Startupform
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.Simplebotton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Simplebotton
            // 
            this.Simplebotton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Simplebotton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Simplebotton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Simplebotton.Location = new System.Drawing.Point(91, 111);
            this.Simplebotton.Name = "Simplebotton";
            this.Simplebotton.Size = new System.Drawing.Size(150, 75);
            this.Simplebotton.TabIndex = 0;
            this.Simplebotton.Text = "Simple botton";
            this.Simplebotton.UseVisualStyleBackColor = false;
            this.Simplebotton.Click += new System.EventHandler(this.Simplebotton_Click);
            // 
            // Startupform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Simplebotton);
            this.Name = "Startupform";
            this.Text = "Startupform";
            this.Load += new System.EventHandler(this.Startupform_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button Simplebotton;
    }
}