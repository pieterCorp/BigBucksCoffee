using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigBucksCoffee
{
    public partial class MakeNewBeverageForm : Form
    {
        const string PATH = "../../Images/Beverages/";
        private MakeNewBeverage makeNewBeverage;

        public MakeNewBeverageForm()
        {
            InitializeComponent();
            makeNewBeverage = new MakeNewBeverage();
            makeNewBeverage.MakeNewBeer(10, "Stella", "Description", 20, $"{PATH}Stella.jfif", 5, true, "blond");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nmbrAlcoholpercentage.Visible = false;
            checkBoxTrapist.Visible = false;
            txtType.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            checkBoxExtras.Visible = false;
            checkBoxWithSugar.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            checkBoxExtraFruits.Visible = false;
            nmbrSize.Visible = false;
            label8.Visible = false;
            label9.Visible = false;

            if (comboBox1.Text == "Beer")
            {
                makeNewBeverage.MakeNewBeer(1, txtName.Text, txtDescription.Text, (double)nmbrPrice.Value, txtImage.Text, (int)nmbrAlcoholpercentage.Value, checkBoxTrapist.Checked, txtType.Text );
                nmbrAlcoholpercentage.Visible = true;
                checkBoxTrapist.Visible = true;
                txtType.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;

            }
            else if (comboBox1.Text == "Soda")
            {
                makeNewBeverage.MakeNewSoda();
                checkBoxExtras.Visible = true;
                checkBoxWithSugar.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
            }
            else if (comboBox1.Text == "Smoothie")
            {
                makeNewBeverage.MakeNewSmoothie();
                checkBoxExtraFruits.Visible = true;
                nmbrSize.Visible = true;
                label8.Visible = true;
                label9.Visible = true;

            }

        }

    }
}
