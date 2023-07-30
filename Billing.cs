using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SubwayPOS
{
    public partial class Billing : Form
    {
        List<Item> items;
        String userName;
        decimal subTotal;
        public Billing(List<Item> items, String userName, decimal subTotal)
        {
            InitializeComponent();
            this.items = items;
            this.userName = userName;
            this.subTotal = subTotal;
            txtUserName.Text = userName;
            for (int i = 0; i < items.Count; i++)
            { 
                Item item = items[i];
                String type = item.itemType;
                String price = item.itemPrice.ToString();

                int count = 30 - type.Length;

                String display = " " + type;
                for (int j = 0; j <= count; j++)
                {
                    display += ".";
                }

                display += price;
                
                listItems.Items.Add(display);
            }

            decimal taxPercent = (decimal).135;
            decimal tax = subTotal * taxPercent;
            decimal total = subTotal + tax;
            txtSubtotal.Text = subTotal.ToString();
            txtTax.Text = tax.ToString("#.##");

            txtTotal.Text = total.ToString("#.##");
            txtUser.Text = userName;
        }

        public Billing(String userName, decimal subTotal)
        {
            List<string> items = new List<string>();
            InitializeComponent();
            //this.items = items;
            this.userName = userName;
            this.subTotal = subTotal;

            items.Add("Burger");
            items.Add("Fries");
            items.Add("Coke");

            for (int i = 0; i < 5; i++)
            {
                Item item = new Item(20, "small", "Short");
                String type = item.itemType;
                String price = item.itemPrice.ToString();

                int count = 30 - type.Length;

                String display = " " + type;
                for (int j=0; j<=count; j++) {
                    display += ".";
                }
                display += price;
                listItems.Items.Add(display);
            }
            decimal taxPercent = (decimal).135;
            decimal tax = subTotal * taxPercent;
            decimal total = subTotal + tax;
            txtSubtotal.Text = subTotal.ToString();
            txtTax.Text = tax.ToString("#.##");

            txtTotal.Text = total.ToString("#.##");
            txtUser.Text = userName;
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            decimal cash = decimal.Parse(txtPaidAmount.Text) - decimal.Parse(txtTotal.Text);
            CashReturn cashReturn = new CashReturn(this.userName,cash.ToString());
            cashReturn.Show();
            Hide();
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            PunchingScreenMain punchScreenMain = new PunchingScreenMain(this.userName);
            punchScreenMain.Show();
            Hide();
        }
    }
}
