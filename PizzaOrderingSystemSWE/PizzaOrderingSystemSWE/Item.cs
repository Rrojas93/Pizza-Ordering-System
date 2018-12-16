using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderingSystemSWE
{
    public abstract class Item
    {
        //Fields
        private float price;


        //Properties
        public float Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        //Public Methods
        public abstract float calcPrice();

    }
}
