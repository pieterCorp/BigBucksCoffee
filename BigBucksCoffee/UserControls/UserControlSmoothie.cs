using System;

namespace BigBucksCoffee
{
    public partial class UserControlSmoothie : MyUserControl
    {
        public UserControlSmoothie(UserControlCart cartControl)
            : base(cartControl)
        {
            InitializeComponent();
        }

        public bool ExtraFruits
        {
            get { return cboxExtraFruit.Checked; }
            set { cboxExtraFruit.Checked = value; }
        }

        public int Size
        {
            get { return Convert.ToInt32(lblSize.Text); }
            set { lblSize.Text = Convert.ToString(value); }
        }
    }
}