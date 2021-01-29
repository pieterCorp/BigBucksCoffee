using System;

namespace BigBucksCoffee
{
    public partial class UserControlSmoothie : MyUserControl
    {
        public UserControlSmoothie()

        {
            InitializeComponent();
        }

        public bool ExtraFruits
        {
            get { return cboxExtraFruit.Checked; }
            set { cboxExtraFruit.Checked = value; }
        }

        public int BeverageSize
        {
            get { return Convert.ToInt32(lblSize.Text); }
            set { lblSize.Text = Convert.ToString(value); }
        }
    }
}