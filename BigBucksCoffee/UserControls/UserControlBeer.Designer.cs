
namespace BigBucksCoffee
{
    partial class UserControlBeer
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
            this.cboxIsTrapist = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cboxIsTrapist
            // 
            this.cboxIsTrapist.AutoSize = true;
            this.cboxIsTrapist.Location = new System.Drawing.Point(90, 160);
            this.cboxIsTrapist.Name = "cboxIsTrapist";
            this.cboxIsTrapist.Size = new System.Drawing.Size(65, 17);
            this.cboxIsTrapist.TabIndex = 3;
            this.cboxIsTrapist.Text = "Is trapist";
            this.cboxIsTrapist.UseVisualStyleBackColor = true;
            // 
            // UserControlBeer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.cboxIsTrapist);
            this.Name = "UserControlBeer";
            this.Size = new System.Drawing.Size(294, 216);
            this.Controls.SetChildIndex(this.cboxIsTrapist, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cboxIsTrapist;
    }
}
