using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrderingSystemSWE
{
    public class Order
    {
        #region Fields

        private bool isDelivery;
        private float orderSum;
        public List<Pizza> pizzas;
        public List<Beverage> beverages;

        #endregion



        #region Properties

        public bool IsDelivery
        {
            get { return this.isDelivery; }
            set { this.isDelivery = value; }
        }

        public float OrderSum
        {
            get { return this.orderSum; }
            set { this.orderSum = value; }
        }
        #endregion



        #region Constructors

        public Order()
        {
            pizzas = new List<Pizza>();
            beverages = new List<Beverage>();
        }
        
        #endregion



        #region Public methods

        public Receipt completeOrder()
        {
            //take in all values from input fields and calculate sum. 
            //DataRow[] row = Program.inventory.Select("productName = '" + pizzas[0].Size + "'");
            //MessageBox.Show(row[0]["price"].ToString());
            float sum = 0;
            foreach (Pizza p in pizzas)
            {
                sum += p.calcPrice();
            }
            foreach (Beverage b in beverages)
            {
                sum += b.calcPrice();
            }
            this.orderSum = sum;
            //MessageBox.Show(this.orderSum.ToString());
            
            return new Receipt(Program.c, this);
        }

        public void cancelOrder()
        {
            //reset all values and return the user to a default starting point.
            pizzas.Clear();
            beverages.Clear();
        }
        #endregion

    }
}
