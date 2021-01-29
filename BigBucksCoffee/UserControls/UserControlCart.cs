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
    public partial class UserControlCart : UserControl
    {
        public Cart Cart;

        public UserControlCart()
        {
            InitializeComponent();
            Cart = new Cart();
        }

        public void SetCart()
        {
            lblItemCount.Text = Convert.ToString(Cart.ItemCount);
            lblTotalPrice.Text = Convert.ToString(Cart.TotalPrice);
            lblPriceIncBtw.Text = Convert.ToString(Cart.TotalPriceIncBtw);

            ListViewItem item = new ListViewItem(Cart.ItemInfo[0]);
            item.SubItems.Add(Convert.ToString(Cart.ItemInfo[1]));
            item.SubItems.Add(Convert.ToString(Cart.ItemInfo[2]));
            item.SubItems.Add(Convert.ToString(Cart.ItemInfo[3]));
            lstShowItems.Items.Add(item);
        }
    }
}