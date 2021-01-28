namespace BigBucksCoffee
{
    public partial class UserControlBeer : MyUserControl
    {
        public UserControlBeer()
        {
            InitializeComponent();
        }

        public double AlcoholPercentage { get; set; }

        public string Type { get; set; }

        public bool IsTrapist
        {
            get { return cboxIsTrapist.Checked; }
            set { cboxIsTrapist.Checked = value; }
        }
    }
}