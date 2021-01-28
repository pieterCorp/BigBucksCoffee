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
        //private IBeverageRepo _repo;

        public MyUserControl()
        {
            InitializeComponent();
            //_repo = new BeverageRepo();
        }

        public int BeverageID { get; set; }

        public string BeverageName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public string Description
        {
            get { return lblPrice.Text; }
            set { lblPrice.Text = value; }
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
                    //pictureBox1.Load(_image);
                }
            }
        }
    }
}