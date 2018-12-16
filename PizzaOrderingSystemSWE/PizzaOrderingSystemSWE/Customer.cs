using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderingSystemSWE
{
    public class Customer
    {
        #region Fields
        private int id;
        private string name;
        private string address;
        private string phone;
        private string cardNum;
        private string directions;

        #endregion



        #region Properties

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }

        public string CardNum
        {
            get { return this.cardNum; }
            set { this.cardNum = value; }
        }

        public string Directions
        {
            get { return this.directions; }
            set { this.directions = value; }
        }

        #endregion



        #region Constructors

        public Customer() : this(0,"", "", "", "", "")  //sets default values using the appropriate constructor
        {
        }

        public Customer(string phoneNum)
        {
            //retrieve customer information from DB and populate the appropriate fields
        }

        public Customer(int id, string name, string address, string phoneNum, string cNum, string directions)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phoneNum;
            this.cardNum = cNum;
            this.directions = directions;
        }

        #endregion



        #region Public Methods

        public bool loadProfile(long phoneNum)
        {
            bool isSuccessful = false;
            //retrieve customer information 
            return isSuccessful;
        }

        public void modCardNum(string newCardNum)
        {
            //change card number and update the database
        }

        public void modDirections(string newDir)
        {
            //change directions and update the database 
        }

        public override string ToString()
        {
            return this.name + "\n" + this.address + "\n" + this.phone + "\n" + this.cardNum + "\n" + this.directions;
        }
        #endregion

    }
}
