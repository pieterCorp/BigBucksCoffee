
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
            this.cboxWithSugar = new System.Windows.Forms.CheckBox();
            this.lblExtras = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboxWithSugar
            // 
            this.cboxWithSugar.AutoSize = true;
            this.cboxWithSugar.BackColor = System.Drawing.Color.Transparent;
            this.cboxWithSugar.Location = new System.Drawing.Point(132, 248);
            this.cboxWithSugar.Name = "cboxWithSugar";
            this.cboxWithSugar.Size = new System.Drawing.Size(79, 17);
            this.cboxWithSugar.TabIndex = 3;
            this.cboxWithSugar.Text = "Whit Sugar";
            this.cboxWithSugar.UseVisualStyleBackColor = false;
            // 
            // lblExtras
            // 
            this.lblExtras.AutoSize = true;
            this.lblExtras.Location = new System.Drawing.Point(2, 252);
            this.lblExtras.Name = "lblExtras";
            this.lblExtras.Size = new System.Drawing.Size(36, 13);
            this.lblExtras.TabIndex = 4;
            this.lblExtras.Text = "Extras";
            // 
            // UserControlSoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.lblExtras);
            this.Controls.Add(this.cboxWithSugar);
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
