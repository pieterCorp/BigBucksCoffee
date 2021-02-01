
namespace BigBucksCoffee
{
    partial class UserControlSoda
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlSoda));
            this.cboxWithSugar = new System.Windows.Forms.CheckBox();
            this.lblExtras = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboxWithSugar
            // 
            this.cboxWithSugar.AutoSize = true;
            this.cboxWithSugar.BackColor = System.Drawing.Color.Transparent;
            this.cboxWithSugar.Location = new System.Drawing.Point(176, 305);
            this.cboxWithSugar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxWithSugar.Name = "cboxWithSugar";
            this.cboxWithSugar.Size = new System.Drawing.Size(130, 21);
            this.cboxWithSugar.TabIndex = 3;
            this.cboxWithSugar.Text = "With sugarSsSs";
            this.cboxWithSugar.UseVisualStyleBackColor = false;
            // 
            // lblExtras
            // 
            this.lblExtras.AutoSize = true;
            this.lblExtras.Location = new System.Drawing.Point(3, 310);
            this.lblExtras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExtras.Name = "lblExtras";
            this.lblExtras.Size = new System.Drawing.Size(47, 17);
            this.lblExtras.TabIndex = 4;
            this.lblExtras.Text = "Extras";
            // 
            // UserControlSoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.lblExtras);
            this.Controls.Add(this.cboxWithSugar);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "UserControlSoda";
            this.Controls.SetChildIndex(this.cboxWithSugar, 0);
            this.Controls.SetChildIndex(this.lblExtras, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cboxWithSugar;
        private System.Windows.Forms.Label lblExtras;
    }
}
