using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace PizzaOrderingSystemSWE
{
    public class Pizza : Item
    {
        //Fields
        private string size;
        public List<string> toppings;
        private string crust;

        public string Size
        {
            get { return this.size; }
            set { this.size = value; }
        }
        public string Crust
        {
            get { return this.crust; }
            set { this.crust = value; }
        }
        //Constructors
        public Pizza()
        {

        }

        public Pizza(string size)
        {
            this.size = size;
            this.crust = "";
            toppings = new List<string>();
        }

        //Public Methods
        public void addTopping(string topping)
        {
            this.toppings.Add(topping);
        }

        public bool removeTopping(string topping)
        {
            return this.toppings.Remove(topping);
        }
        
        public override float calcPrice()
        {            
            float p = 0; //price
            List<string> temp = new List<string>();
            foreach (string s in this.toppings)
            {
                temp.Add(s);
            }
            temp.Add(this.size);
            temp.Add(this.crust);
            foreach (string i in temp)
            {
                DataRow[] d = Program.inventory.Select("productName = '" + i + "'");
                p += float.Parse((string)d[0]["price"]);                
            }
            //MessageBox.Show(p.ToString());
            return p;
        }
    }
}
