namespace PizzaOrderingSystemSWE
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputTextBox4 = new System.Windows.Forms.TextBox();
            this.inputTextBox1 = new System.Windows.Forms.TextBox();
            this.inputTextBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.inputLabel1 = new System.Windows.Forms.Label();
            this.inputLabel2 = new System.Windows.Forms.Label();
            this.inputLabel3 = new System.Windows.Forms.Label();
            this.inputLabel4 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.mTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(102, 123);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(168, 26);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Credit/Debit Card";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(102, 155);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(90, 26);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "eCheck";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(102, 187);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(71, 26);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Cash";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(98, 303);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(102, 22);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "Total Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Payment Type:";
            // 
            // inputTextBox4
            // 
            this.inputTextBox4.Location = new System.Drawing.Point(519, 190);
            this.inputTextBox4.Name = "inputTextBox4";
            this.inputTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.inputTextBox4.Size = new System.Drawing.Size(168, 27);
            this.inputTextBox4.TabIndex = 7;
            this.inputTextBox4.Click += new System.EventHandler(this.inputTextBox4_Click);
            // 
            // inputTextBox1
            // 
            this.inputTextBox1.Location = new System.Drawing.Point(519, 90);
            this.inputTextBox1.Name = "inputTextBox1";
            this.inputTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.inputTextBox1.Size = new System.Drawing.Size(168, 27);
            this.inputTextBox1.TabIndex = 4;
            this.inputTextBox1.Click += new System.EventHandler(this.inputTextBox1_Click);
            // 
            // inputTextBox3
            // 
            this.inputTextBox3.Location = new System.Drawing.Point(519, 157);
            this.inputTextBox3.Name = "inputTextBox3";
            this.inputTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.inputTextBox3.Size = new System.Drawing.Size(168, 27);
            this.inputTextBox3.TabIndex = 6;
            this.inputTextBox3.Click += new System.EventHandler(this.inputTextBox3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(489, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 65);
            this.button1.TabIndex = 8;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputLabel1
            // 
            this.inputLabel1.AutoSize = true;
            this.inputLabel1.Location = new System.Drawing.Point(361, 92);
            this.inputLabel1.Name = "inputLabel1";
            this.inputLabel1.Size = new System.Drawing.Size(62, 22);
            this.inputLabel1.TabIndex = 0;
            this.inputLabel1.Text = "Name:";
            this.inputLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inputLabel1.UseMnemonic = false;
            // 
            // inputLabel2
            // 
            this.inputLabel2.AutoSize = true;
            this.inputLabel2.Location = new System.Drawing.Point(361, 127);
            this.inputLabel2.Name = "inputLabel2";
            this.inputLabel2.Size = new System.Drawing.Size(122, 22);
            this.inputLabel2.TabIndex = 0;
            this.inputLabel2.Text = "Card Number:";
            // 
            // inputLabel3
            // 
            this.inputLabel3.AutoSize = true;
            this.inputLabel3.Location = new System.Drawing.Point(361, 160);
            this.inputLabel3.Name = "inputLabel3";
            this.inputLabel3.Size = new System.Drawing.Size(138, 22);
            this.inputLabel3.TabIndex = 0;
            this.inputLabel3.Text = "Expiration Date:";
            // 
            // inputLabel4
            // 
            this.inputLabel4.AutoSize = true;
            this.inputLabel4.Location = new System.Drawing.Point(361, 193);
            this.inputLabel4.Name = "inputLabel4";
            this.inputLabel4.Size = new System.Drawing.Size(120, 22);
            this.inputLabel4.TabIndex = 0;
            this.inputLabel4.Text = "CVV Number:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(519, 157);
            this.maskedTextBox1.Mask = "00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(168, 27);
            this.maskedTextBox1.TabIndex = 10;
            // 
            // mTextBox2
            // 
            this.mTextBox2.Location = new System.Drawing.Point(519, 124);
            this.mTextBox2.Mask = "0000-0000-0000-0000";
            this.mTextBox2.Name = "mTextBox2";
            this.mTextBox2.Size = new System.Drawing.Size(168, 27);
            this.mTextBox2.TabIndex = 11;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 431);
            this.Controls.Add(this.mTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.inputLabel4);
            this.Controls.Add(this.inputLabel3);
            this.Controls.Add(this.inputLabel2);
            this.Controls.Add(this.inputLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.inputTextBox1);
            this.Controls.Add(this.inputTextBox3);
            this.Controls.Add(this.inputTextBox4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputTextBox4;
        private System.Windows.Forms.TextBox inputTextBox1;
        private System.Windows.Forms.TextBox inputTextBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label inputLabel1;
        private System.Windows.Forms.Label inputLabel2;
        private System.Windows.Forms.Label inputLabel3;
        private System.Windows.Forms.Label inputLabel4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox mTextBox2;
    }
}