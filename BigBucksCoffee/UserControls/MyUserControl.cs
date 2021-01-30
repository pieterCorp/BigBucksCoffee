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
        //bevat geen functionaliteit, geen businesslogica, puur data en properties 
        //om de knoppen etc (het visuele aspect) te doen werken

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

        //in de usercontrol: kunnen we aan de methods en properties die in deze usercontrol zitten
        //opm: als je niet expliciet de onderdelen aanbiedt/exposed (moet omdat usercontrols is)
        //kan je ze niet bereiken
        //TLDR: exposen
        public event EventHandler ButtonOrderClicked;

        //we voorzien property, gebruiker zal dan beslissen wat die doet
        protected virtual void OnButtonOrderClicked(EventArgs e)
        {
            ButtonOrderClicked?.Invoke(this, e);
        }

        //die willen we exposen naar boven, aan die kunnen we niet in de form
        //dus: ipv in de klik zelf onze berekeningendoen, bubble dat omhoog 
        //this = hele myusercontrol = verwijst nr de klasse waarin we aan het werken zijn
        //je geeft dus heel het object mee 
        private void btnOrder_Click(object sender, EventArgs e)
        {
            OnButtonOrderClicked(e);
        }
    }
}