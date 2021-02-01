
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlBeer));
            this.cboxIsTrapist = new System.Windows.Forms.CheckBox();
            this.lblAlcoholPercentage = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboxIsTrapist
            // 
            this.cboxIsTrapist.AutoSize = true;
            this.cboxIsTrapist.Location = new System.Drawing.Point(176, 299);
            this.cboxIsTrapist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxIsTrapist.Name = "cboxIsTrapist";
            this.cboxIsTrapist.Size = new System.Drawing.Size(83, 21);
            this.cboxIsTrapist.TabIndex = 3;
            this.cboxIsTrapist.Text = "Is trapist";
            this.cboxIsTrapist.UseVisualStyleBackColor = true;
            // 
            // lblAlcoholPercentage
            // 
            this.lblAlcoholPercentage.AutoSize = true;
            this.lblAlcoholPercentage.Location = new System.Drawing.Point(4, 332);
            this.lblAlcoholPercentage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlcoholPercentage.Name = "lblAlcoholPercentage";
            this.lblAlcoholPercentage.Size = new System.Drawing.Size(127, 17);
            this.lblAlcoholPercentage.TabIndex = 4;
            this.lblAlcoholPercentage.Text = "AlcoholPercentage";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(4, 304);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(40, 17);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Type";
            // 
            // UserControlBeer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblAlcoholPercentage);
            this.Controls.Add(this.cboxIsTrapist);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
