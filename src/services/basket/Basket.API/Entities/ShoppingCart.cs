using System.Collections.Generic;
using System.Linq;

namespace Basket.API.Entities
{
    public class ShoppingCart
    {
        public string UserName { get; set; }
        public List<ShoppingCartItem> Items { get; set; }

        public ShoppingCart()
        {

        }

        public ShoppingCart(string userName)
        {
            UserName = userName;
        }

        public decimal GetTotalPrice()
        {
            decimal totalPrice = Items.Sum(x => x.Price * x.Quantity);

            return totalPrice;
        }
    }
}
