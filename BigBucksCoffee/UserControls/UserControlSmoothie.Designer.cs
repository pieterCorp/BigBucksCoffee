
namespace BigBucksCoffee
{
    partial class UserControlSmoothie
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
            this.lblSize = new System.Windows.Forms.Label();
            this.cboxExtraFruit = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(3, 248);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(25, 13);
            this.lblSize.TabIndex = 3;
            this.lblSize.Text = "size";
            // 
            // cboxExtraFruit
            // 
            this.cboxExtraFruit.AutoSize = true;
            this.cboxExtraFruit.Location = new System.Drawing.Point(132, 248);
            this.cboxExtraFruit.Name = "cboxExtraFruit";
            this.cboxExtraFruit.Size = new System.Drawing.Size(73, 17);
            this.cboxExtraFruit.TabIndex = 4;
            this.cboxExtraFruit.Text = "Extra Fruit";
            this.cboxExtraFruit.UseVisualStyleBackColor = true;
            // 
            // UserControlSmoothie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.cboxExtraFruit);
            this.Controls.Add(this.lblSize);
            this.Name = "UserControlSmoothie";
            this.Controls.SetChildIndex(this.lblSize, 0);
            this.Controls.SetChildIndex(this.cboxExtraFruit, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.CheckBox cboxExtraFruit;
    }
}
