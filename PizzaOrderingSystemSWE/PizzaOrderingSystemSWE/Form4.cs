using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrderingSystemSWE
{
    public partial class Form4 : Form
    {
        bool firstTime = true;//checks first time clicking text box
        bool hasbeenClicked = false; //has the 'Add' button been clicked?
        int currentPizza = -1;  //tracks the current pizza being modified 
        private Order order;
        //private DataTable inventory;
        public Form4()
        {
            InitializeComponent();
            textBox1.Hide();
            Box_crust.Enabled = false;
            //Box_beverages.Enabled = false;
            Box_toppings.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)    //remove selection button
        {
            if (OrderListBox.SelectedIndex == -1)
            {
                return;
            }
            //must remove the correct item from the Order object instance and THEN update GUI. 
            string selection = ((string)OrderListBox.SelectedItem).Trim();
            int selectionIndex = OrderListBox.SelectedIndex;
            //MessageBox.Show(selection + "\nindex: " + selectionIndex);

            if (order.beverages.Count>0)    //first determine if a beverage is being removed (easiest so do it first)
            {
                if (selectionIndex >= (OrderListBox.Items.Count - order.beverages.Count)) //determine if the selection was one of the beverages
                {
                    order.beverages.RemoveAt(selectionIndex - (OrderListBox.Items.Count - order.beverages.Count));
                }
            }
            if (order.pizzas.Count>0)   //next determine if a pizza or its contents will be removed
            {
                string[] selectParts = selection.Split(':');
                for (int i = 0; i < selectParts.Length; i++)
                {
                    selectParts[i] = selectParts[i].Trim();
                }
                //string test = "";
                //foreach (string s in selectParts)
                //{
                //    test += s + "|";
                //}
                //MessageBox.Show(test + "\n count: " + selectParts.Length);
                int numOfP;
                switch (selectParts[0])
                {
                    case "Pizza":
                        numOfP = getPizzaNum(OrderListBox.SelectedIndex);
                        order.pizzas.RemoveAt(numOfP);
                        if (order.pizzas.Count > 0)
                        {
                            currentPizza = 0;
                        }
                        else
                            currentPizza = -1;
                        break;
                    case "Crust":
                        numOfP = getPizzaNum(OrderListBox.SelectedIndex);
                        order.pizzas.RemoveAt(numOfP);
                        if (order.pizzas.Count > 0)
                        {
                            currentPizza = 0;
                        }
                        else
                            currentPizza = -1;

                        break;
                    case "Topping":                        
                        order.pizzas[getPizzaNum(OrderListBox.SelectedIndex)].removeTopping(selectParts[1]);
                        //MessageBox.Show("selected topping: " + selectParts[1]);
                        break;
                    default:
                        break;
                }
                
            }

            updateOrderBox();
        }

        private int getPizzaNum(int listBoxIndex)   //gets the pizza number in which the specified item is a part of (works for toppings and crust only)
        {
            int num = -1;
            string label = "";
            string[] delimS;
            while(listBoxIndex >= 0)
            {
                
                delimS = (((string)OrderListBox.Items[listBoxIndex])).Split(':');
                for (int i = 0; i < delimS.Length; i++)
                {
                    delimS[i] = delimS[i].Trim();
                }
                //string test = "";
                //foreach (string s in delimS)
                //{
                //    test += s + "|";
                //}
                //MessageBox.Show(test + "\n count: " + delimS.Length);

                label = delimS[0];
                if (label == "Pizza")
                {
                    num = Int32.Parse(delimS[1])-1;
                    break;
                }
                else
                    listBoxIndex--;
            }
            //MessageBox.Show(num.ToString());
            return num;
        }

        private void button2_Click(object sender, EventArgs e) //Size add button
        {
            if (Box_size.SelectedIndex != -1)
            {
                order.pizzas.Add(new Pizza((string)Box_size.SelectedItem));
                currentPizza++;
                updateOrderBox();
                hasbeenClicked = true;
                Box_crust.Enabled = true;
            }

            if (hasbeenClicked == false)
            {
                Box_size.Enabled = true;
            }
            if (hasbeenClicked == true)
            {
                Box_size.Enabled = false;
                Box_size.ClearSelected();
            }
        }

        private void button3_Click(object sender, EventArgs e)  //Crust add Button
        {
            if (Box_crust.SelectedIndex != -1 && order.pizzas.Count > 0)
            {
                order.pizzas[currentPizza].Crust = (string)Box_crust.SelectedItem;
                updateOrderBox();
                hasbeenClicked = true;
                Box_toppings.Enabled = true;
            }

            if (hasbeenClicked == false)
            {
                Box_crust.Enabled = true;
            }
            if (hasbeenClicked == true)
            {
                Box_crust.Enabled = false;
                Box_crust.ClearSelected();
            }

        }

        private void button4_Click(object sender, EventArgs e)  //Toppings add Button
        {
            if (Box_toppings.SelectedIndex != -1 && order.pizzas.Count > 0)
            {
                order.pizzas[currentPizza].addTopping((string)Box_toppings.SelectedItem);
                updateOrderBox();
                Box_beverages.Enabled = true;
                Box_toppings.ClearSelected();
            }
        }

        private void button5_Click(object sender, EventArgs e)  //Beverage add button
        {
            if (Box_beverages.SelectedIndex != -1)
            {
                order.beverages.Add(new Beverage((string)Box_beverages.SelectedItem));
                updateOrderBox();
                Box_beverages.ClearSelected();
            }
        }

        private void Box_crust_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void Box_size_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Box_beverages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (order.beverages.Count > 0 && OrderListBox.SelectedIndex != -1)
            {
                if (OrderListBox.SelectedIndex < (OrderListBox.Items.Count - order.beverages.Count)) //determine if the selection was not one of the beverages
                {
                    this.currentPizza = getPizzaNum(OrderListBox.SelectedIndex);
                }
            }
            currentPizzaLabel.Text = "Modifying Pizza: " + (currentPizza + 1);
            //if (OrderListBox.SelectedIndex == 0)
            //{
            //    Box_size.Enabled = true;
            //}
            //if (OrderListBox.SelectedIndex == 1)
            //{
            //    Box_crust.Enabled = true;
            //}
        }

        private void button6_Click(object sender, EventArgs e)  //clear order
        {
            order.cancelOrder();
            OrderListBox.Items.Clear();
            currentPizza = -1;
            Box_crust.Enabled = false;
            //Box_beverages.Enabled = false;
            Box_toppings.Enabled = false;
            Box_size.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)  //Complete Order Button
        {
            if (checkBox1.Checked || checkBox2.Checked)
            {
                this.order.IsDelivery = checkBox1.Checked;
                if (order.IsDelivery && (Program.c.Address != textBox1.Text))
                {
                    Program.c.Address = textBox1.Text;
                }
                Receipt r = order.completeOrder();
                //MessageBox.Show("Order: \n" + r.print());
                Form6 f6 = new Form6(r);
                f6.Hide();
                f6.ShowDialog();
            }
            else
                MessageBox.Show("Please select whether the order is for delivery or pick up.");
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender as CheckBox;

            if (c.Checked == true)
            {
                textBox1.Show();
                textBox1.Text = Program.c.Address;
                firstTime = true;
                checkBox2.Checked = false;
            }
            else if (c.Checked == false)
            {
                textBox1.Hide();
                textBox1.Text = "Confirm Address...";
            }
        }


        private void textBox1_Click(object sender, EventArgs e)
        {
            if (firstTime)
            {
                firstTime = false;
                //textBox1.Clear();
            }
        }

        private void button8_Click(object sender, EventArgs e)  //add pizza button
        {
            //currentPizza++;
            //button8.Enabled = false;
            Box_crust.Enabled = false;
            Box_beverages.Enabled = true;
            Box_toppings.Enabled = false;
            Box_size.Enabled = true;
            Box_crust.ClearSelected();
            Box_beverages.ClearSelected();
            Box_toppings.ClearSelected();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Box_size.Items.Clear(); //clears the default items in the list box
            Box_crust.Items.Clear();
            Box_toppings.Items.Clear();
            Box_beverages.Items.Clear();

            Program.inventory = Program.cdb.getInventory();   //table with contents from database
            DataRowCollection items =  Program.inventory.Rows;  //retrieves all the rows from the table into a collection
            foreach(DataRow i in items) //for every row (inventory item)
            {
                switch (i["type"])  //add the items from the database to the appropriate list boxes in gui.
                {
                    case "Size":
                        Box_size.Items.Add(i["productName"]);
                        break;
                    case "Crust":
                        Box_crust.Items.Add(i["productName"]);
                        break;
                    case "Topping":
                        Box_toppings.Items.Add(i["productName"]);
                        break;
                    case "Beverage":
                        Box_beverages.Items.Add(i["productName"]);
                        break;
                    default:
                        break;
                }
            }
            this.order = new Order();
            updateOrderBox();
        }

        private void updateOrderBox()
        {
            //OrderListBox.Items.Add("Pizza " + currentPizza + ": " + " Size: " + Box_size.SelectedItem);
            OrderListBox.Items.Clear();
            if (order.pizzas.Count > 0)
            {
                for (int i = 0; i < order.pizzas.Count; i++)
                {
                    OrderListBox.Items.Add("Pizza :" + (i+1) + ": " + " Size: " + order.pizzas[i].Size);
                    if (order.pizzas[i].Crust.Length > 1)
                    {
                        OrderListBox.Items.Add("              Crust: " + order.pizzas[i].Crust);
                    }
                    if (order.pizzas[i].toppings.Count > 0)
                    {
                        foreach (string t in order.pizzas[i].toppings)
                        {
                            OrderListBox.Items.Add("                    Topping:" + t);
                        }
                    }
                }
            }
            if (order.beverages.Count > 0)
            {
                foreach(Beverage b in order.beverages)
                {
                    OrderListBox.Items.Add("Beverage: " + b.Name);
                }
            }
            currentPizzaLabel.Text = "Modifying Pizza: " + (currentPizza + 1);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
