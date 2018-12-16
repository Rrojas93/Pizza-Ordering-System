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
    public partial class Form2 : Form
    {
        private bool isNewCustomer;

        public Form2(bool isNew)
        {
            InitializeComponent();
            this.isNewCustomer = isNew;
            if (!isNewCustomer)
            {
                button1.Text = "Submit Change";
                NameTextBox.Text = Program.c.Name;
                phoneMTextBox.Text = Program.c.Phone;
                phoneMTextBox.Enabled = false;
                cNumMTextBox.Text = Program.c.CardNum;
                AddressTextBox.Text = Program.c.Address;
                DirTextBox.Text = Program.c.Directions;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Program.cdb == null)
            {
                Program.cdb = new CustomerDatabase();
            }
        }

        private void FirstNTextBox_Click(object sender, EventArgs e)
        {
            NameTextBox.SelectAll();
        }

        private void PhoneTextBox_Click(object sender, EventArgs e)
        {
            phoneMTextBox.SelectAll();
        }

        private void CNumTextBox_Click(object sender, EventArgs e)
        {
            cNumMTextBox.SelectAll();
        }

        private void StreetTextBox_Click(object sender, EventArgs e)
        {
            AddressTextBox.SelectAll();
        }

        private void DirTextBox_Click(object sender, EventArgs e)
        {
            DirTextBox.SelectAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isNewCustomer)
            {
                string name = NameTextBox.Text;
                string address = AddressTextBox.Text;
                Customer c = new Customer(0, name, address, phoneMTextBox.Text.Replace("-", ""), cNumMTextBox.Text.Replace("-", ""), DirTextBox.Text);
                if (Program.cdb.createNewProfile(c))
                {
                    Program.c = c;
                    Form4 f4 = new Form4();
                    f4.Hide();
                    f4.ShowDialog();
                } 
            }
            else
            {
                if ((NameTextBox.Text) != Program.c.Name)
                {
                    Program.c.Name = NameTextBox.Text;
                }
                else if (cNumMTextBox.Text.Replace("-", "") != Program.c.CardNum)
                {
                    Program.c.CardNum = cNumMTextBox.Text.Replace("-", "");
                }
                else if (AddressTextBox.Text != Program.c.Address)
                {
                    Program.c.Address = AddressTextBox.Text;
                }
                else if (DirTextBox.Text != Program.c.Directions)
                {
                    Program.c.Directions = DirTextBox.Text;
                }
                if (Program.cdb.updateCustomer(Program.c))
                {
                    Program.c = Program.cdb.retrieveProfile(Program.c.Phone);
                    MessageBox.Show("Customer info updated successfully. ");
                    Form4 f4 = new Form4();
                    f4.Hide();
                    f4.ShowDialog();
                }
                
            }
        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(phoneMTextBox.Text.Replace("-", ""));
        }
    }
}
