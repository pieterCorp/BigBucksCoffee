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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Image myimage = new Bitmap("../../Images/bg.jpg");
            this.BackgroundImage = myimage;
        }

        private void btnShowBaverages_Click(object sender, EventArgs e)
        {
            DynamicControls controls = new DynamicControls();
            controls.Show();
        }
    }
}