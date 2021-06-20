using System;
using System.Collections.Generic;
using System.Text;

namespace Super_Market
{
    class Cart
    {
        private String productId;
        private String productName;
        private int quantity;
        private decimal productPrice;
        private decimal total_price;
        public Cart()
        {

        }
        public Cart(String productId,String productName,int quantity,decimal productPrice)
        {
            this.productId = productId;
            this.productName = productName;
            this.productPrice = productPrice;
            this.quantity = quantity;
        }
        public String _ProductId
        {
            get { return this.productId; }
            set { this.productId= value; }
        }
        public String _ProductName
        {
            get { return this.productName; }
            set { this.productName = value; }
        }
        public int _Quantity {
            get { return this.quantity; }
            set { this.quantity = value; }
        }
        public decimal _ProductPrice
        {
            get { return this.productPrice; }
            set { this.productPrice = value; }
        }
        public decimal _Total
        {
            get { return (quantity > 0 ? quantity : 0) * productPrice; }
            
        }
    }
    class HoaDon {
        private List<Cart> cart;
        public HoaDon()
        {
            if (this.cart == null)
                this.cart = new List<Cart>();
        }
        public List<Cart> _Cart {
            get { return this.cart; }
            set { this.cart = value; }
        }
        //tim mot san pham trong gio? hang`
        public int search_item_incart(String productid)
        {
            int index = 0;
            foreach (Cart item in cart)
            {
                if (item._ProductId.Equals(productid))
                    return index;
                index += 1;

            }
            return -1;
        }
        //insert 1 san pham vao
        public void insert_item_toCart(String productid, String productName, int quantity, decimal productPrice)
        {
            if (search_item_incart(productid) == -1)
            {
                Cart items = new Cart(productid, productName, quantity, productPrice);
                this.cart.Add(items);

            }
            else
                cart[search_item_incart(productid)]._Quantity += quantity;
        }
        public void remove_item(String Productid)
        {
            try
            {
                int index = search_item_incart(Productid);
                cart.RemoveAt(index);
            }
            catch (IndexOutOfRangeException) { }
        }
        public decimal tong_HoaDon
        {
            get {
                decimal tempt = 0;
                if (cart == null)
                    return 0;
                else
                    foreach (Cart items in cart)
                    {
                        tempt += items._Total;
                    }
                return tempt;
            }
            
        }
    }
   
}
