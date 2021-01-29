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
        public MyUserControl()
        {
            InitializeComponent();
        }

        public int BeverageID { get; set; }

        public int Amount
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }

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

        public event EventHandler ButtonOrderClicked;

        protected virtual void OnButtonOrderClicked(EventArgs e)
        {
            ButtonOrderClicked?.Invoke(this, e);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OnButtonOrderClicked(e);
        }
    }
}