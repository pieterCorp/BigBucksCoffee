
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
            this.lblAlcoholPercentage = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboxIsTrapist
            // 
            this.cboxIsTrapist.AutoSize = true;
            this.cboxIsTrapist.Location = new System.Drawing.Point(132, 243);
            this.cboxIsTrapist.Name = "cboxIsTrapist";
            this.cboxIsTrapist.Size = new System.Drawing.Size(65, 17);
            this.cboxIsTrapist.TabIndex = 3;
            this.cboxIsTrapist.Text = "Is trapist";
            this.cboxIsTrapist.UseVisualStyleBackColor = true;
            // 
            // lblAlcoholPercentage
            // 
            this.lblAlcoholPercentage.AutoSize = true;
            this.lblAlcoholPercentage.Location = new System.Drawing.Point(3, 270);
            this.lblAlcoholPercentage.Name = "lblAlcoholPercentage";
            this.lblAlcoholPercentage.Size = new System.Drawing.Size(97, 13);
            this.lblAlcoholPercentage.TabIndex = 4;
            this.lblAlcoholPercentage.Text = "AlcoholPercentage";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(3, 247);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Type";
            // 
            // UserControlBeer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblAlcoholPercentage);
            this.Controls.Add(this.cboxIsTrapist);
            this.Name = "UserControlBeer";
            this.Controls.SetChildIndex(this.cboxIsTrapist, 0);
            this.Controls.SetChildIndex(this.lblAlcoholPercentage, 0);
            this.Controls.SetChildIndex(this.lblType, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cboxIsTrapist;
        private System.Windows.Forms.Label lblAlcoholPercentage;
        private System.Windows.Forms.Label lblType;
    }
}
