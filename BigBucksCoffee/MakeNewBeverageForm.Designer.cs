
namespace BigBucksCoffee
{
    partial class MakeNewBeverageForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nmbrPrice = new System.Windows.Forms.NumericUpDown();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nmbrAlcoholpercentage = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxTrapist = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxExtraFruits = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nmbrSize = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxWithSugar = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtExtras = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmbrPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbrAlcoholpercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbrSize)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Beer",
            "Soda",
            "Smoothie"});
            this.comboBox1.Location = new System.Drawing.Point(42, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(135, 97);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(135, 144);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 22);
            this.txtDescription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price:";
            // 
            // nmbrPrice
            // 
            this.nmbrPrice.Location = new System.Drawing.Point(135, 184);
            this.nmbrPrice.Name = "nmbrPrice";
            this.nmbrPrice.Size = new System.Drawing.Size(100, 22);
            this.nmbrPrice.TabIndex = 6;
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(135, 226);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(100, 22);
            this.txtImage.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Image path:";
            // 
            // nmbrAlcoholpercentage
            // 
            this.nmbrAlcoholpercentage.Location = new System.Drawing.Point(406, 98);
            this.nmbrAlcoholpercentage.Name = "nmbrAlcoholpercentage";
            this.nmbrAlcoholpercentage.Size = new System.Drawing.Size(100, 22);
            this.nmbrAlcoholpercentage.TabIndex = 10;
            this.nmbrAlcoholpercentage.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Alcoholpercentage:";
            this.label5.Visible = false;
            // 
            // checkBoxTrapist
            // 
            this.checkBoxTrapist.AutoSize = true;
            this.checkBoxTrapist.Location = new System.Drawing.Point(406, 145);
            this.checkBoxTrapist.Name = "checkBoxTrapist";
            this.checkBoxTrapist.Size = new System.Drawing.Size(18, 17);
            this.checkBoxTrapist.TabIndex = 11;
            this.checkBoxTrapist.UseVisualStyleBackColor = true;
            this.checkBoxTrapist.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Trapist?";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Type?";
            this.label7.Visible = false;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(406, 181);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(100, 22);
            this.txtType.TabIndex = 14;
            this.txtType.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Extra fruits?";
            this.label8.Visible = false;
            // 
            // checkBoxExtraFruits
            // 
            this.checkBoxExtraFruits.AutoSize = true;
            this.checkBoxExtraFruits.Location = new System.Drawing.Point(135, 281);
            this.checkBoxExtraFruits.Name = "checkBoxExtraFruits";
            this.checkBoxExtraFruits.Size = new System.Drawing.Size(18, 17);
            this.checkBoxExtraFruits.TabIndex = 16;
            this.checkBoxExtraFruits.UseVisualStyleBackColor = true;
            this.checkBoxExtraFruits.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Size:";
            this.label9.Visible = false;
            // 
            // nmbrSize
            // 
            this.nmbrSize.Location = new System.Drawing.Point(135, 317);
            this.nmbrSize.Name = "nmbrSize";
            this.nmbrSize.Size = new System.Drawing.Size(100, 22);
            this.nmbrSize.TabIndex = 18;
            this.nmbrSize.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(393, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Extra\'s?";
            this.label10.Visible = false;
            // 
            // checkBoxWithSugar
            // 
            this.checkBoxWithSugar.AutoSize = true;
            this.checkBoxWithSugar.Location = new System.Drawing.Point(488, 300);
            this.checkBoxWithSugar.Name = "checkBoxWithSugar";
            this.checkBoxWithSugar.Size = new System.Drawing.Size(18, 17);
            this.checkBoxWithSugar.TabIndex = 22;
            this.checkBoxWithSugar.UseVisualStyleBackColor = true;
            this.checkBoxWithSugar.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(393, 299);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "With sugar?";
            this.label11.Visible = false;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(114, 377);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(337, 40);
            this.btnCreate.TabIndex = 23;
            this.btnCreate.Text = "Add product";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtExtras
            // 
            this.txtExtras.Location = new System.Drawing.Point(457, 263);
            this.txtExtras.Name = "txtExtras";
            this.txtExtras.Size = new System.Drawing.Size(100, 22);
            this.txtExtras.TabIndex = 24;
            this.txtExtras.Visible = false;
            // 
            // MakeNewBeverageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtExtras);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.checkBoxWithSugar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nmbrSize);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkBoxExtraFruits);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBoxTrapist);
            this.Controls.Add(this.nmbrAlcoholpercentage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.nmbrPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.comboBox1);
            this.Name = "MakeNewBeverageForm";
            this.Text = "MakeNewBeverageForm";
            ((System.ComponentModel.ISupportInitialize)(this.nmbrPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbrAlcoholpercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbrSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmbrPrice;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmbrAlcoholpercentage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxTrapist;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBoxExtraFruits;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nmbrSize;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBoxWithSugar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtExtras;
    }
}