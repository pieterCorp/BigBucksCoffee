namespace BigBucksCoffee
{
    public partial class UserControlSoda : MyUserControl
    {
        public UserControlSoda()

        {
            InitializeComponent();
        }

        public bool WithSugar
        {
            get { return cboxWithSugar.Checked; }
            set { cboxWithSugar.Checked = value; }
        }

        public string Extras
        {
            get { return lblExtras.Text; }
            set { lblExtras.Text = value; }
        }
    }
}