
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
            this.btnAddNewBeverage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowBaverages
            // 
            this.btnShowBaverages.Location = new System.Drawing.Point(16, 306);
            this.btnShowBaverages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowBaverages.Name = "btnShowBaverages";
            this.btnShowBaverages.Size = new System.Drawing.Size(1200, 188);
            this.btnShowBaverages.TabIndex = 3;
            this.btnShowBaverages.Text = "Show beverages";
            this.btnShowBaverages.UseVisualStyleBackColor = true;
            this.btnShowBaverages.Click += new System.EventHandler(this.btnShowBaverages_Click);
            // 
            // btnAddNewBeverage
            // 
            this.btnAddNewBeverage.Location = new System.Drawing.Point(16, 233);
            this.btnAddNewBeverage.Name = "btnAddNewBeverage";
            this.btnAddNewBeverage.Size = new System.Drawing.Size(316, 23);
            this.btnAddNewBeverage.TabIndex = 4;
            this.btnAddNewBeverage.Text = "Add new beverage";
            this.btnAddNewBeverage.UseVisualStyleBackColor = true;
            this.btnAddNewBeverage.Click += new System.EventHandler(this.btnAddNewBeverage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1232, 785);
            this.Controls.Add(this.btnAddNewBeverage);
            this.Controls.Add(this.btnShowBaverages);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button btnAddNewBeverage;
    }
}

