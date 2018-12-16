using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrderingSystemSWE
{
    public class Receipt
    {
        #region Fields
        public Customer cust;
        public Order ord;
        public float orderTotal;
        private string payType;
        private float payAmount;
        private const float salesTax = 4;
        private float taxAmount;

        #endregion

        #region Properties
        public string PayType
        {
            get { return this.payType; }
            set { this.payType = value; }
        }
        #endregion

        #region Constructors

        public Receipt()
        {

        }

        public Receipt(Customer c, Order o)
        {

            this.ord = o;
            this.cust = c;
            orderTotal = ord.OrderSum;
            if (ord.IsDelivery)
            {
                orderTotal += 2f;
            }
            taxAmount = orderTotal * (salesTax / 100f);
            orderTotal = orderTotal + taxAmount;

        }

        #endregion

        #region Public Methods

        public override string ToString()
        {
            string s = "Mom and Pop's Pizza\n" +
                        "Order Receipt\n\n" +
                        string.Format("{0,-30}{1,20}","Product", "Price") + "\n";
            foreach (Pizza p in ord.pizzas)
            {
                s += string.Format("{0,-30}{1,20:C2}", (p.Size + " " + p.Crust), float.Parse((string)(Program.inventory.Select("productName = '" + p.Size + "'")[0]["price"]))) +"\n";
                foreach (string t in p.toppings)
                {
                    s += string.Format("{0,-30}{1,20:C2}", ("  " + t), float.Parse((string)(Program.inventory.Select("productName = '" + t + "'")[0]["price"]))) + "\n";
                }
            }
            foreach (Beverage b in ord.beverages)
            {
                s += string.Format("{0,-30}{1,20:C2}", b.Name, float.Parse((string)(Program.inventory.Select("productName = '" + b.Name + "'")[0]["price"]))) + "\n";
            }
            if (ord.IsDelivery)
            {
                s += string.Format("{0,-30}{1,20:C2}", "Delivery Charge", 2.00f) + "\n";
            }
            s += string.Format("{0,-30}{1,20:C2}", "Sales Tax", taxAmount) + "\n";
            s += "\n" + string.Format("{0,-30}{1,20:C2}", "Total", orderTotal) + "\n";
            s += "\nMethod of Payment: " + PayType +"\n";
            if (ord.IsDelivery)
            {
                s += "Delivery\n\n";
            }
            else
            {
                s += "Pick-up\n\n";
            }
            s += "Customer information:\n" +
                    cust.Name + "\n" +
                    cust.Address + "\n" +
                    cust.Phone + "\n" +
                    "XXXX-XXXX-XXXX-" + cust.CardNum.Substring(cust.CardNum.Length - 4) + "\n" +
                    "Directions: " + cust.Directions + "\n\n";

            if (PayType == "Card")
            {
                s += string.Format("{0,-30}{1,20}", "Tip:", "_______________") + "\n\n" +
                        string.Format("{0,-30}{1,20}", "Total:", "_______________") + "\n\n" +
                        string.Format("{0,-30}{1,20}", "Signature: ", "____________________") + "\n\n";
            }
            s += "Thanks for choosing Mom and Pop's Pizza!!!";
            return s;
        }
        #endregion

    }
}
