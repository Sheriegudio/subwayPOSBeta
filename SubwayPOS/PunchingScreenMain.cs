using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SubwayPOS
{
    public partial class PunchingScreenMain : Form
    {
        public ListBox itemsOftheBill;

        public int userID;
        public string userName;
        public decimal itemSubTotal;
        public decimal totalBillAmount;
        public string subTotalLabel = "Sub Total: $";
        public decimal main;
        public decimal type;

        public bool bread12in = false;
        public bool bread6in = false;
        public bool ftbread12in = false;
        public bool ftbread6in = false;
        public bool wrap = false;
        public bool riceWrap = false;
        public bool salad = false;
        public bool riceBowl = false;

        public string itemSize;
        public int itemCounter;
        public string wholeOrder;
        public PunchingScreenMain(int currentUserId, string currentUserName)
        {
            InitializeComponent();
            userID = currentUserId;
            userName = currentUserName;
            totalBillAmount = 0.0m;
            main = 0.0m;
            type = 0.0m;
            itemsOftheBill = new ListBox();
        }
        private void lbl_userName_Click(object sender, EventArgs e)
        {

        }

        private void PunchingScreenMain_Load(object sender, EventArgs e)
        {
            lbl_userName.Text = userName;
            gb_type.Enabled = false;
        }

        private void btn_10oz_Click(object sender, EventArgs e)
        {
            totalBillAmount += 2.59m;
            updateSubtotal(totalBillAmount);
            Item orderItem = new Item(2.59m, "", "10 Oz drink");
            itemsOftheBill.Items.Add(orderItem);
            displayItems(itemsOftheBill);
        }
        private void btn_20oz_Click(object sender, EventArgs e)
        {
            totalBillAmount += 3.00m;
            updateSubtotal(totalBillAmount);
            Item orderItem = new Item(3.00m, "", "20 Oz drink");
            itemsOftheBill.Items.Add(orderItem);
            displayItems(itemsOftheBill);
        }
        private void btn_30oz_Click(object sender, EventArgs e)
        {
            totalBillAmount += 3.30m;
            updateSubtotal(totalBillAmount);
            Item orderItem = new Item(3.30m, "", "30 Oz drink");
            itemsOftheBill.Items.Add(orderItem);
            displayItems(itemsOftheBill);
        }

        private void btn_water_Click(object sender, EventArgs e)
        {
            totalBillAmount += 3.30m;
            updateSubtotal(totalBillAmount);
            Item orderItem = new Item(3.30m, "", "Water bottle");
            itemsOftheBill.Items.Add(orderItem);
            displayItems(itemsOftheBill);
        }

        private void btn_softDrink_Click(object sender, EventArgs e)
        {
            totalBillAmount += 3.30m;
            updateSubtotal(totalBillAmount);
            Item orderItem = new Item(3.30m, "", "Soft drink");
            itemsOftheBill.Items.Add(orderItem);
            displayItems(itemsOftheBill);
        }

        private void btn_1cookie_Click(object sender, EventArgs e)
        {
            totalBillAmount += 1.05m;
            updateSubtotal(totalBillAmount);
            Item orderItem = new Item(1.05m, "", "Cookie");
            itemsOftheBill.Items.Add(orderItem);
            displayItems(itemsOftheBill);
        }
        private void btn_3cookies_Click(object sender, EventArgs e)
        {
            totalBillAmount += 2.85m;
            updateSubtotal(totalBillAmount);
            Item orderItem = new Item(2.85m, "", "3 Cookies");
            itemsOftheBill.Items.Add(orderItem);
            displayItems(itemsOftheBill);
        }

        private void btn_6cookies_Click(object sender, EventArgs e)
        {
            totalBillAmount += 5.50m;
            updateSubtotal(totalBillAmount);
            Item orderItem = new Item(5.50m, "", "6 Cookies");
            itemsOftheBill.Items.Add(orderItem);
            displayItems(itemsOftheBill);
        }

        private void btn_total_Click(object sender, EventArgs e)
        {

        }

        //helping methods
        private void updateSubtotal(decimal amount)
        {
            lbl_subTotal.Text = subTotalLabel + amount.ToString(".00");
        }

        private void rb_wrap_CheckedChanged(object sender, EventArgs e)
        {
            main += 4.5m;
            selectType();
        }

        private void rb_6inBread_CheckedChanged(object sender, EventArgs e)
        {
            main += 4.0m;
            selectType();
        }

        private void rb_riceWrap_CheckedChanged(object sender, EventArgs e)
        {
            main += 6.5m;
            selectType();

        }

        private void rb_12inBread_CheckedChanged(object sender, EventArgs e)
        {
            main += 7.5m;
            selectType();
        }

        private void rb_12inFlatBread_CheckedChanged(object sender, EventArgs e)
        {
            main += 7.0m;
            selectType();
        }

        private void rb_6inFlatBread_CheckedChanged(object sender, EventArgs e)
        {
            main += 3.8m;
            selectType();
        }

        private void rb_salad_CheckedChanged(object sender, EventArgs e)
        {
            main += 6.0m;
            selectType();
        }

        private void rb_riceBowl_CheckedChanged(object sender, EventArgs e)
        {
            main += 8.0m;
            selectType();
        }

        private void selectType()
        {
            gb_type.Enabled = true;
        }

        private void backtoMain()
        {
            gb_type.Enabled = false;
        }

        private void btn_vegDelight_Click(object sender, EventArgs e)
        {
            type += 2.1m;
            itemSize = checkSize();
            updateSubtotal(calculateTotalItemPrice());
            Item orderItem = new Item(itemSubTotal, itemSize, "Veggie Delight");
            itemsOftheBill.Items.Add(orderItem);
            displayItems(itemsOftheBill);
            backtoMain();

        }

        private void btn_vegPatty_Click(object sender, EventArgs e)
        {
            type += 3.6m;
            itemSize = checkSize();
            updateSubtotal(calculateTotalItemPrice());
            Item orderItem = new Item(itemSubTotal, itemSize, "Veggie Patty");
            itemsOftheBill.Items.Add(orderItem);
            displayItems(itemsOftheBill);
            backtoMain();

        }

        private void btn_turky_Click(object sender, EventArgs e)
        {
            type += 3.9m;
            itemSize = checkSize();
            updateSubtotal(calculateTotalItemPrice());
            Item orderItem = new Item(itemSubTotal, itemSize, "Turky");
            itemsOftheBill.Items.Add(orderItem);
            displayItems(itemsOftheBill);
            backtoMain();

        }

        private void btn_ham_Click(object sender, EventArgs e)
        {
            type += 3.65m;
            itemSize = checkSize();
            updateSubtotal(calculateTotalItemPrice());
            Item orderItem = new Item(itemSubTotal, itemSize, "Ham");
            itemsOftheBill.Items.Add(orderItem);
            displayItems(itemsOftheBill);
            backtoMain();

        }

        private void btn_spcyItalian_Click(object sender, EventArgs e)
        {
            type += 4.5m;
            itemSize = checkSize();
            updateSubtotal(calculateTotalItemPrice());
            Item orderItem = new Item(itemSubTotal, itemSize, "Spicy Italian");
            itemsOftheBill.Items.Add(orderItem);
            displayItems(itemsOftheBill);
            backtoMain();
        }

        private void btn_meatBall_Click(object sender, EventArgs e)
        {
            type += 4.2m;
            itemSize = checkSize();
            updateSubtotal(calculateTotalItemPrice());
            Item orderItem = new Item(itemSubTotal, itemSize, "Meatball");
            itemsOftheBill.Items.Add(orderItem);
            displayItems(itemsOftheBill);
            backtoMain();

        }

        private void btn_steak_Click(object sender, EventArgs e)
        {
            type += 4.9m;
            itemSize = checkSize();
            updateSubtotal(calculateTotalItemPrice());
            Item orderItem = new Item(itemSubTotal, itemSize, "Steak");
            itemsOftheBill.Items.Add(orderItem);
            displayItems(itemsOftheBill);
            backtoMain();

        }

        private void btn_grillChicken_Click(object sender, EventArgs e)
        {
            type += 3.85m;
            itemSize = checkSize();
            updateSubtotal(calculateTotalItemPrice());
            Item orderItem = new Item(itemSubTotal, itemSize, "Grill Chicken");
            itemsOftheBill.Items.Add(orderItem);
            displayItems(itemsOftheBill);
            backtoMain();

        }

        private void btn_tuna_Click(object sender, EventArgs e)
        {
            type += 3.55m;
            itemSize = checkSize();
            updateSubtotal(calculateTotalItemPrice());
            Item orderItem = new Item(itemSubTotal, itemSize, "Tuna");
            itemsOftheBill.Items.Add(orderItem);
            displayItems(itemsOftheBill);
            backtoMain();

        }

        private void btn_coldCut_Click(object sender, EventArgs e)
        {
            type += 3.0m;
            itemSize = checkSize();
            updateSubtotal(calculateTotalItemPrice());
            Item orderItem = new Item(itemSubTotal, itemSize, "Cold Cut");
            itemsOftheBill.Items.Add(orderItem);
            displayItems(itemsOftheBill);
            backtoMain();

        }

        private void btn_chickenTeriyaki_Click(object sender, EventArgs e)
        {
            type += 3.65m;
            itemSize = checkSize();
            updateSubtotal(calculateTotalItemPrice());
            Item orderItem = new Item(itemSubTotal, itemSize, "Chicken Teriyaki");
            itemsOftheBill.Items.Add(orderItem);
            displayItems(itemsOftheBill);
            backtoMain();

        }

        private void btn_BLT_Click(object sender, EventArgs e)
        {
            type += 3.10m;
            itemSize = checkSize();
            updateSubtotal(calculateTotalItemPrice());
            Item orderItem = new Item(itemSubTotal, itemSize, "B.L.T");
            itemsOftheBill.Items.Add(orderItem);
            displayItems(itemsOftheBill);
            backtoMain();
        }

        private decimal calculateTotalItemPrice()
        {
            itemSubTotal = main + type;
            totalBillAmount += itemSubTotal;
            main = 0;
            type = 0;
            return totalBillAmount;
        }

        private void clearRadioCheck()
        {
            rb_12inBread.Checked = false;
            rb_12inFlatBread.Checked = false;
            rb_6inBread.Checked = false;
            rb_6inFlatBread.Checked = false;
            rb_wrap.Checked = false;
            rb_riceWrap.Checked = false;
            rb_salad.Checked = false;
            rb_riceBowl.Checked = false;
        }

        private string checkSize()
        {
            if (rb_6inBread.Checked)
            {
                //half meat or veggies
                type /= 2;
                bread6in = true;
                return "6\" Sub";
            }
            else if (rb_12inBread.Checked)
            {
                bread12in = true;
                return "12\" Sub";
            }
            else if (rb_12inFlatBread.Checked)
            {
                ftbread12in = true;
                return "12\" Ft. Sub";
            }
            else if (rb_6inFlatBread.Checked)
            {
                type /= 2;
                ftbread6in = true;
                return "6\" Ft. Sub";
            }
            else if (rb_wrap.Checked)
            {
                type /= 2;
                wrap = true;
                return "Wrap";
            }
            else if (rb_riceWrap.Checked)
            {
                type /= 2;
                type += 1.8m;
                riceWrap = true;
                return "Rice Wrap";
            }
            else if (rb_salad.Checked)
            {
                type /= 2;
                salad = true;
                return "Salad Bowl";
            }
            else if (rb_riceBowl.Checked)
            {
                //half meat or veggies 
                type /= 2;
                //additional cost of rice
                type += 1.8m;
                riceBowl = true;
                return "Rice Bowl";
            }

            clearRadioCheck();
            return "";
        }
        private void displayItems(ListBox lstBX)
        {
            wholeOrder = "";
            itemCounter = 1;
            foreach (Item orderItem in lstBX.Items)
            {
                wholeOrder += "#"+itemCounter.ToString() +". " +orderItem.itemDescription + "\n";
                itemCounter++;
            }
            richtx_Orderitems.Text = wholeOrder;
        }
    }
}
