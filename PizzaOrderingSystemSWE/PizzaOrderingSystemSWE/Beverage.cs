using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PizzaOrderingSystemSWE
{
    public class Beverage : Item
    {
        //fields
        private string name;

        //Properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        //constructors
        public Beverage()
        {

        }

        public Beverage(string name)
        {
            this.name = name;
        }

        //Public Methods
        public override float calcPrice()
        {
            DataRow[] d = Program.inventory.Select("productName = '" + this.name + "'");
            float p = float.Parse((string)d[0]["price"]);
            return p;
        }
    }
}
