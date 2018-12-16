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
    public partial class Form3 : Form
    {
        private Customer c;
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.c = this.c;
            Form4 f4 = new Form4();
            f4.Hide();
            f4.ShowDialog();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)  //search button
        {
            string phoneEntry = textBox4.Text;
            //check entry validity
            //MessageBox.Show("You entered into Phone field: \n" + phoneEntry);
            c = Program.cdb.retrieveProfile(phoneEntry);
            if (c.Name != "")
            {
                ListViewItem item = new ListViewItem(c.Id.ToString());
                string[] nameSplit = c.Name.Split(' ');
                item.SubItems.Add(nameSplit[0]);
                item.SubItems.Add(nameSplit[1]);
                item.SubItems.Add(c.Phone);
                item.SubItems.Add(c.Address);
                item.SubItems.Add(c.Directions);
                listView1.Items.Add(item);
            }
            //MessageBox.Show(c.ToString());
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Program.cdb = new CustomerDatabase();
        }

        private void EditCustomerButton_Click(object sender, EventArgs e)
        {
            if (this.c == null)
            {
                MessageBox.Show("No customer to edit.\nPlease search for a customer.");
                return;
            }
            Program.c = this.c;
            Form2 f2 = new Form2(false);
            f2.Hide();
            f2.ShowDialog();
        }
    }
}
