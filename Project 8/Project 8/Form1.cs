using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Recipt Program
//Eric Bates
//December 14, 2017

namespace Project_8
{
    public partial class Form1 : Form
    {
        decimal price = 0, tax = 0, total = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (maincoursebox.Text)
            {
                case "Seafood Alfredo":
                    price = 15.95m;
                    tax = tax + price * 0.07m;
                    total = total + price + tax;
                    break;

                case "Chicken Alfredo":
                    price = 13.95m;
                    tax = tax + price * 0.07m;
                    total = total + price + tax;
                    break;

                case "Chicken Picatta":
                    price = 13.95m;
                    tax = tax + price * 0.07m;
                    total = total + price + tax;
                    break;

                case "Turkey Club":
                    price = 11.95m;
                    tax = tax + price * 0.07m;
                    total = total + price + tax;
                    break;

                case "Lobster Pie":
                    price = 19.95m;
                    tax = tax + price * 0.07m;
                    total = total + price + tax;
                    break;

                case "Prime Rib":
                    price = 20.95m;
                    tax = tax + price * 0.07m;
                    total = total + price + tax;
                    break;
                case "Shrimp Scampi":
                    price = 18.95m;
                    tax = tax + price * 0.07m;
                    total = total + price + tax;
                    break;
                case "Turkey Dinner":
                    price = 13.95m;
                    tax = tax + price * 0.07m;
                    total = total + price + tax;
                    break;
                case "Stuffed Chicken":
                    price = 14.95m;
                    tax = tax + price * 0.07m;
                    total = total + price + tax;
                    break;
            }

            Recipt.Items.Add(maincoursebox.Text + "\t" + "\t" + "$" + price);
            this.subtotaltable.Text = "$" + price.ToString();
            taxtable.Text = "$" + tax.ToString("N2");
            totaltable.Text = "$" + total.ToString("N2");
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (dessertbox.Text)
            {
                case "Apple Pie":
                    price = 5.95m;
                    tax = tax + price * 0.07m;
                    total = total + price + tax;
                    break;

                case "Sundae":
                    price = 3.95m;
                    tax = tax + price * 0.07m;
                    total = total + price + tax;
                    break;

                case "Carrot Cake":
                    price = 5.95m;
                    tax = tax + price * 0.07m;
                    total = total + price + tax;
                    break;

                case "Mud Pie":
                    price = 4.95m;
                    tax = tax + price * 0.07m;
                    total = total + price + tax;
                    break;

                case "Apple Crisp":
                    price = 5.95m;
                    tax = tax + price * 0.07m;
                    total = total + price + tax;
                    break;

            }

            if (dessertbox.Text != "Apple Crisp" && dessertbox.Text != "Carrot Cake")
                Recipt.Items.Add(dessertbox.Text + "\t" + "\t" + "\t" + "$" + price);
            else Recipt.Items.Add(dessertbox.Text + "\t" + "\t" + "$" + price);
            this.subtotaltable.Text = "$" + price.ToString();
            taxtable.Text = "$" + tax.ToString("N2");
            totaltable.Text = "$" + total.ToString("N2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Recipt.Items.Clear();
            subtotaltable.Text = String.Empty;
            taxtable.Text = String.Empty;
            totaltable.Text = String.Empty;
            total = 0;
            tax = 0;


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (beverage.Text)
            {
                case "Soda":
                    price = 1.95m;
                    tax = tax + price * 0.07m;
                    total = total + price + tax;
                    break;

                case "Tea":
                    price = 1.50m;
                    tax = tax + price * 0.07m;
                    total = total + price + tax;
                    break;

                case "Coffee":
                    price = 1.25m;
                    tax = tax + price * 0.07m;
                    total = total + price + tax;
                    break;

                case "Mineral Water":
                    price = 2.95m;
                    tax = tax + price * 0.07m;
                    total = total + price + tax;
                    break;

                case "Juice":
                    price = 2.50m;
                    tax = tax + price * 0.07m;
                    total = total + price + tax;
                    break;

                case "Milk":
                    price = 1.50m;
                    tax = tax + price * 0.07m;
                    total = total + price + tax;
                    break;
            }

            if(beverage.Text != "Mineral Water")
                Recipt.Items.Add(beverage.Text + "\t" + "\t" + "\t" + "$" + price);
            else Recipt.Items.Add(beverage.Text + "\t" + "\t" + "$" + price);
            this.subtotaltable.Text = "$" + price.ToString();
            taxtable.Text = "$" + tax.ToString("N2");
            totaltable.Text = "$" + total.ToString("N2");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void appetizerbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (appetizerbox.Text)
            {
                case "Buffalo Wings":
                    price = 5.95m;
                    tax = tax + price * 0.07m;
                    total = total + price + tax;
                    break;

                case "Buffalo Fingers":
                    price = 6.95m;
                    tax = tax + price * 0.07m;
                    total = total + price + tax;
                    break;

                case "Potato Skins":
                    price = 8.95m;
                    tax = tax + price * 0.07m;
                    total = total + price + tax;
                    break;

                case "Nachos":
                    price = 8.95m;
                    tax = tax + price * 0.07m;
                    total = total + price + tax;
                    break;

                case "Mushroom Caps":
                    price = 10.95m;
                    tax = tax + price * 0.07m;
                    total = total + price + tax;
                    break;

                case "Shrimp Coctail":
                    price = 12.95m;
                    tax = tax + price * 0.07m;
                    total = total + price + tax;
                    break;
                case "Chips and Salsa":
                    price = 6.95m;
                    tax = tax + price * 0.07m;
                    total = total + price + tax;
                    break;
            }

            if (appetizerbox.Text == "Nachos")
                Recipt.Items.Add(appetizerbox.Text + "\t" + "\t" + "\t" + "$" + price);
            else Recipt.Items.Add(appetizerbox.Text + "\t" + "\t" + "$" + price);
            this.subtotaltable.Text = "$" + price.ToString();
            taxtable.Text = "$" + tax.ToString("N2");
            totaltable.Text = "$" + total.ToString("N2");
        }
    }
}
