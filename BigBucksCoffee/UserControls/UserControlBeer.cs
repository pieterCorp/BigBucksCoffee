using System;

namespace BigBucksCoffee
{
    public partial class UserControlBeer : MyUserControl
    {
        public UserControlBeer()

        {
            InitializeComponent();
        }

        public double AlcoholPercentage
        {
            get { return Convert.ToDouble(lblAlcoholPercentage.Text); }
            set { lblAlcoholPercentage.Text = Convert.ToString(value); }
        }

        public bool IsTrapist
        {
            get { return cboxIsTrapist.Checked; }
            set { cboxIsTrapist.Checked = value; }
        }

        public string Type
        {
            get { return lblType.Text; }
            set { lblType.Text = value; }
        }
    }
}