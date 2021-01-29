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
    public partial class MyUserControl : UserControl
    {
        private UserControlCart _cartControl;

        public MyUserControl(UserControlCart cartControl)
        {
            InitializeComponent();
            _cartControl = cartControl;
        }

        public MyUserControl()
        {
            InitializeComponent();
        }

        public int BeverageID { get; set; }

        public string BeverageName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public string Description
        {
            get { return lblDescription.Text; }
            set { lblDescription.Text = value; }
        }

        public string Price
        {
            get { return lblPrice.Text; }
            set { lblPrice.Text = value; }
        }

        private string _image;

        public string Image
        {
            set
            {
                if (value != null)
                {
                    _image = value;
                    pictureBox1.ImageLocation = _image;
                }
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            _cartControl.Cart.AddToCart(BeverageID, Convert.ToInt32(numericUpDown1.Value));
            _cartControl.SetCart();
        }
    }
}