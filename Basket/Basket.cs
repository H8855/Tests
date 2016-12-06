using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketNS
{
    public class Basket
    {
        #region CONSTRUCTORS
        public Basket(string name)
        {
            this.customer = name;
            this.contents = new StringCollection();
        }
        #endregion
        #region PROPERTIES
        private string customer;        

        public string Customer
        {
            get { return customer; }
        }

        private float price;

        public float Price
        {
            get { return price; }
        }

        private StringCollection contents;

        public StringCollection Contents
        {
            get { return contents; }
        }
        #endregion
        #region METHODS
        public void AddProduct(string product, float productPrice)
        {
            contents.Add(product);
            price += productPrice;
        }

        public void DeleteProduct(string product, float productPrice)
        {
            contents.Remove(product);
            price -= productPrice;

        }

        public float CountDiscountPrice(float percent)
        {
            float discount = (percent / 100);
            return price - (price * discount);
        }
        #endregion
    }
}
