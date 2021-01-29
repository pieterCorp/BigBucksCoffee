
using System;

namespace BigBucksCoffee
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
            this.btnShowBaverages = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowBaverages
            // 
            this.btnShowBaverages.Location = new System.Drawing.Point(12, 249);
            this.btnShowBaverages.Name = "btnShowBaverages";
            this.btnShowBaverages.Size = new System.Drawing.Size(900, 153);
            this.btnShowBaverages.TabIndex = 3;
            this.btnShowBaverages.Text = "Show beverages";
            this.btnShowBaverages.UseVisualStyleBackColor = true;
            this.btnShowBaverages.Click += new System.EventHandler(this.btnShowBaverages_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 638);
            this.Controls.Add(this.btnShowBaverages);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion
       
        private System.Windows.Forms.Button btnShowBaverages;
    }
}

