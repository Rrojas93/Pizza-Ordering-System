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
    public partial class Form6 : Form
    {
        //bool firstTime = true;
        Receipt r;

        public Form6(Receipt r)
        {
            InitializeComponent();
            
            inputTextBox4.Enabled = false;
            mTextBox2.Enabled = false;
            inputTextBox1.Enabled = false;
            inputTextBox3.Enabled = false;
            maskedTextBox1.Visible = false;
            //inputLabel1.Hide();
            //inputLabel2.Hide();
            //inputLabel3.Hide();
            //inputLabel4.Hide();
            this.r = r;
            priceLabel.Text = "Total Price: " + string.Format("{0:C2}", r.orderTotal);
        }

        private void button1_Click(object sender, EventArgs e)  //Submit Button
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                if (checkBox1.Checked)
                {
                    r.PayType = "Card";
                    if (r.cust.CardNum != mTextBox2.Text.Replace("-", ""))
                    {
                        r.cust.CardNum = mTextBox2.Text.Replace("-", "");
                    }
                }
                else if (checkBox2.Checked)
                {
                    r.PayType = "Check";
                }
                else if (checkBox3.Checked)
                {
                    r.PayType = "Cash";
                }
                Form5 f5 = new Form5(r);
                f5.Hide();
                f5.ShowDialog();
            }
            else
                MessageBox.Show("Please select a method of payment.");
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)   //credit card 
        {
            CheckBox c = (CheckBox)sender as CheckBox;

            if (c.Checked == true)
            {
                inputTextBox3.Visible = false;
                maskedTextBox1.Visible = true;

                inputTextBox1.Enabled = true;
                mTextBox2.Enabled = true;
                //inputTextBox3.Enabled = true;
                inputTextBox4.Enabled = true;
                //inputLabel1.Show();
                //inputLabel2.Show();
                //inputLabel3.Show();
                //inputLabel4.Show();
                inputTextBox1.Text = r.cust.Name;
                mTextBox2.Text = r.cust.CardNum;
                inputLabel2.Text = "Card Number:";
                inputLabel3.Text = "Expiration Date:";
                inputLabel4.Text = "CVV Number:";
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
            }
            else if (c.Checked == false)
            {
                inputTextBox3.Visible = true;
                maskedTextBox1.Visible = false;

                inputTextBox1.Enabled = false;
                mTextBox2.Enabled = false;
                //inputTextBox3.Enabled = false;

                inputTextBox4.Enabled = false;
                inputTextBox1.Clear();
                mTextBox2.Clear();
                inputTextBox3.Clear();
                inputTextBox4.Clear();
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) //echeck
        {
            CheckBox c = (CheckBox)sender as CheckBox;

            if (c.Checked == true)
            {
                inputTextBox1.Enabled = true;
                mTextBox2.Enabled = true;
                inputTextBox3.Enabled = true;
                inputTextBox4.Enabled = true;
                inputTextBox1.Text = r.cust.Name;
                inputLabel2.Text = "Routing Number:";
                inputLabel3.Text = "Account Number:";
                inputLabel4.Text = "Amount:";
                checkBox1.Enabled = false;
                checkBox3.Enabled = false;
            }
            else if (c.Checked == false)
            {
                inputTextBox1.Enabled = false;
                mTextBox2.Enabled = false;
                inputTextBox3.Enabled = false;
                inputTextBox4.Enabled = false;
                inputTextBox1.Clear();
                mTextBox2.Clear();
                inputTextBox3.Clear();
                inputTextBox4.Clear();
                checkBox1.Enabled = true;
                checkBox3.Enabled = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e) //cash
        {
            CheckBox c = (CheckBox)sender as CheckBox;

            if (c.Checked == true)
            {
                //textBox9.Show();
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
            }
            else if (c.Checked == false)
            {
                //textBox9.Hide();
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
            }
        }


        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void inputTextBox1_Click(object sender, EventArgs e)
        {
            
            inputTextBox1.SelectAll();            
            
        }

        private void inputTextBox2_Click(object sender, EventArgs e)
        {
            mTextBox2.SelectAll();
        }

        private void inputTextBox3_Click(object sender, EventArgs e)
        {
            inputTextBox3.SelectAll();
        }

        private void inputTextBox4_Click(object sender, EventArgs e)
        {
            inputTextBox4.SelectAll();
        }
    }
}
