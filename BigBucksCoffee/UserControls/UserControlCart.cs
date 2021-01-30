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
            Cart = Cart.GetCart();
        }

        public void PrintOrders()
        {
            SetCart();
            AddOrdersToListView(Cart.ItemsInCart);
        }

        private void SetCart()
        {
            lblItemCount.Text = Convert.ToString(Cart.ItemCount);
            lblTotalPrice.Text = Convert.ToString(Cart.TotalPrice);
            lblPriceIncBtw.Text = Convert.ToString(Cart.TotalPriceIncBtw);
        }

        private void AddOrdersToListView(IEnumerable<ItemInCart> itemsInCart)
        {
            lstShowItems.Items.Clear();
            foreach (var itemInCart in itemsInCart)
            {
                ListViewItem item = new ListViewItem(itemInCart.Name);

                //item.SubItems.Add(itemInCart.Name);
                item.SubItems.Add(itemInCart.Amount.ToString());
                item.SubItems.Add(itemInCart.SinglePrice.ToString());
                item.SubItems.Add(itemInCart.TotalPrice.ToString());
                lstShowItems.Items.Add(item);
            }
        }
    }
}