namespace SubwayPOS
{
    partial class PunchingScreenMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PunchingScreenMain));
            lbl_userName = new System.Windows.Forms.Label();
            lbl_orderItems = new System.Windows.Forms.Label();
            gb_drinks = new System.Windows.Forms.GroupBox();
            btn_water = new System.Windows.Forms.Button();
            btn_10oz = new System.Windows.Forms.Button();
            btn_20oz = new System.Windows.Forms.Button();
            btn_30oz = new System.Windows.Forms.Button();
            btn_softDrink = new System.Windows.Forms.Button();
            gb_cookies = new System.Windows.Forms.GroupBox();
            btn_1cookie = new System.Windows.Forms.Button();
            btn_3cookies = new System.Windows.Forms.Button();
            btn_6cookies = new System.Windows.Forms.Button();
            gb_type = new System.Windows.Forms.GroupBox();
            btn_BLT = new System.Windows.Forms.Button();
            btn_chickenTeriyaki = new System.Windows.Forms.Button();
            btn_coldCut = new System.Windows.Forms.Button();
            btn_tuna = new System.Windows.Forms.Button();
            btn_grillChicken = new System.Windows.Forms.Button();
            btn_meatBall = new System.Windows.Forms.Button();
            btn_ham = new System.Windows.Forms.Button();
            btn_vegPatty = new System.Windows.Forms.Button();
            btn_steak = new System.Windows.Forms.Button();
            btn_vegDelight = new System.Windows.Forms.Button();
            btn_turky = new System.Windows.Forms.Button();
            btn_spcyItalian = new System.Windows.Forms.Button();
            btn_total = new System.Windows.Forms.Button();
            lbl_subTotal = new System.Windows.Forms.Label();
            gb_Main = new System.Windows.Forms.GroupBox();
            rb_riceBowl = new System.Windows.Forms.RadioButton();
            rb_salad = new System.Windows.Forms.RadioButton();
            rb_riceWrap = new System.Windows.Forms.RadioButton();
            rb_wrap = new System.Windows.Forms.RadioButton();
            rb_6inFlatBread = new System.Windows.Forms.RadioButton();
            rb_12inFlatBread = new System.Windows.Forms.RadioButton();
            rb_6inBread = new System.Windows.Forms.RadioButton();
            rb_12inBread = new System.Windows.Forms.RadioButton();
            lstbx_orderItems = new System.Windows.Forms.ListBox();
            btn_remove = new System.Windows.Forms.Button();
            gb_drinks.SuspendLayout();
            gb_cookies.SuspendLayout();
            gb_type.SuspendLayout();
            gb_Main.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_userName
            // 
            lbl_userName.AutoSize = true;
            lbl_userName.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_userName.Location = new System.Drawing.Point(12, 9);
            lbl_userName.Name = "lbl_userName";
            lbl_userName.Size = new System.Drawing.Size(85, 21);
            lbl_userName.TabIndex = 0;
            lbl_userName.Text = "UserName";
            lbl_userName.Click += lbl_userName_Click;
            // 
            // lbl_orderItems
            // 
            lbl_orderItems.AutoSize = true;
            lbl_orderItems.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_orderItems.ForeColor = System.Drawing.Color.OrangeRed;
            lbl_orderItems.Location = new System.Drawing.Point(12, 30);
            lbl_orderItems.Name = "lbl_orderItems";
            lbl_orderItems.Size = new System.Drawing.Size(133, 29);
            lbl_orderItems.TabIndex = 1;
            lbl_orderItems.Text = "Order Items";
            // 
            // gb_drinks
            // 
            gb_drinks.Controls.Add(btn_water);
            gb_drinks.Controls.Add(btn_10oz);
            gb_drinks.Controls.Add(btn_20oz);
            gb_drinks.Controls.Add(btn_30oz);
            gb_drinks.Controls.Add(btn_softDrink);
            gb_drinks.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            gb_drinks.Location = new System.Drawing.Point(300, 30);
            gb_drinks.Name = "gb_drinks";
            gb_drinks.Size = new System.Drawing.Size(118, 261);
            gb_drinks.TabIndex = 3;
            gb_drinks.TabStop = false;
            gb_drinks.Text = "Drinks";
            // 
            // btn_water
            // 
            btn_water.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_water.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_water.Location = new System.Drawing.Point(11, 173);
            btn_water.Name = "btn_water";
            btn_water.Size = new System.Drawing.Size(91, 38);
            btn_water.TabIndex = 4;
            btn_water.Text = "Water";
            btn_water.UseVisualStyleBackColor = true;
            btn_water.Click += btn_water_Click;
            // 
            // btn_10oz
            // 
            btn_10oz.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_10oz.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_10oz.Location = new System.Drawing.Point(11, 41);
            btn_10oz.Name = "btn_10oz";
            btn_10oz.Size = new System.Drawing.Size(91, 38);
            btn_10oz.TabIndex = 1;
            btn_10oz.Text = "10 Oz";
            btn_10oz.UseVisualStyleBackColor = true;
            btn_10oz.Click += btn_10oz_Click;
            // 
            // btn_20oz
            // 
            btn_20oz.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_20oz.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_20oz.Location = new System.Drawing.Point(11, 85);
            btn_20oz.Name = "btn_20oz";
            btn_20oz.Size = new System.Drawing.Size(91, 38);
            btn_20oz.TabIndex = 2;
            btn_20oz.Text = "20 Oz";
            btn_20oz.UseVisualStyleBackColor = true;
            btn_20oz.Click += btn_20oz_Click;
            // 
            // btn_30oz
            // 
            btn_30oz.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_30oz.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_30oz.Location = new System.Drawing.Point(11, 129);
            btn_30oz.Name = "btn_30oz";
            btn_30oz.Size = new System.Drawing.Size(91, 38);
            btn_30oz.TabIndex = 3;
            btn_30oz.Text = "30 Oz";
            btn_30oz.UseVisualStyleBackColor = true;
            btn_30oz.Click += btn_30oz_Click;
            // 
            // btn_softDrink
            // 
            btn_softDrink.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_softDrink.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_softDrink.Location = new System.Drawing.Point(11, 217);
            btn_softDrink.Name = "btn_softDrink";
            btn_softDrink.Size = new System.Drawing.Size(91, 38);
            btn_softDrink.TabIndex = 5;
            btn_softDrink.Text = "Soft Drink";
            btn_softDrink.UseVisualStyleBackColor = true;
            btn_softDrink.Click += btn_softDrink_Click;
            // 
            // gb_cookies
            // 
            gb_cookies.Controls.Add(btn_1cookie);
            gb_cookies.Controls.Add(btn_3cookies);
            gb_cookies.Controls.Add(btn_6cookies);
            gb_cookies.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            gb_cookies.Location = new System.Drawing.Point(447, 30);
            gb_cookies.Name = "gb_cookies";
            gb_cookies.Size = new System.Drawing.Size(118, 186);
            gb_cookies.TabIndex = 4;
            gb_cookies.TabStop = false;
            gb_cookies.Text = "Cookies";
            // 
            // btn_1cookie
            // 
            btn_1cookie.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_1cookie.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_1cookie.Location = new System.Drawing.Point(11, 41);
            btn_1cookie.Name = "btn_1cookie";
            btn_1cookie.Size = new System.Drawing.Size(91, 38);
            btn_1cookie.TabIndex = 6;
            btn_1cookie.Text = "1 Cookie";
            btn_1cookie.UseVisualStyleBackColor = true;
            btn_1cookie.Click += btn_1cookie_Click;
            // 
            // btn_3cookies
            // 
            btn_3cookies.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_3cookies.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_3cookies.Location = new System.Drawing.Point(11, 85);
            btn_3cookies.Name = "btn_3cookies";
            btn_3cookies.Size = new System.Drawing.Size(91, 38);
            btn_3cookies.TabIndex = 7;
            btn_3cookies.Text = "3 Cookies";
            btn_3cookies.UseVisualStyleBackColor = true;
            btn_3cookies.Click += btn_3cookies_Click;
            // 
            // btn_6cookies
            // 
            btn_6cookies.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_6cookies.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_6cookies.Location = new System.Drawing.Point(11, 129);
            btn_6cookies.Name = "btn_6cookies";
            btn_6cookies.Size = new System.Drawing.Size(91, 38);
            btn_6cookies.TabIndex = 8;
            btn_6cookies.Text = "6 Cookies";
            btn_6cookies.UseVisualStyleBackColor = true;
            btn_6cookies.Click += btn_6cookies_Click;
            // 
            // gb_type
            // 
            gb_type.Controls.Add(btn_BLT);
            gb_type.Controls.Add(btn_chickenTeriyaki);
            gb_type.Controls.Add(btn_coldCut);
            gb_type.Controls.Add(btn_tuna);
            gb_type.Controls.Add(btn_grillChicken);
            gb_type.Controls.Add(btn_meatBall);
            gb_type.Controls.Add(btn_ham);
            gb_type.Controls.Add(btn_vegPatty);
            gb_type.Controls.Add(btn_steak);
            gb_type.Controls.Add(btn_vegDelight);
            gb_type.Controls.Add(btn_turky);
            gb_type.Controls.Add(btn_spcyItalian);
            gb_type.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            gb_type.Location = new System.Drawing.Point(592, 30);
            gb_type.Name = "gb_type";
            gb_type.Size = new System.Drawing.Size(259, 305);
            gb_type.TabIndex = 19;
            gb_type.TabStop = false;
            gb_type.Text = "Type";
            // 
            // btn_BLT
            // 
            btn_BLT.BackColor = System.Drawing.Color.Crimson;
            btn_BLT.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_BLT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_BLT.Location = new System.Drawing.Point(135, 261);
            btn_BLT.Name = "btn_BLT";
            btn_BLT.Size = new System.Drawing.Size(113, 38);
            btn_BLT.TabIndex = 20;
            btn_BLT.Text = "B.L.T";
            btn_BLT.UseVisualStyleBackColor = false;
            btn_BLT.Click += btn_BLT_Click;
            // 
            // btn_chickenTeriyaki
            // 
            btn_chickenTeriyaki.BackColor = System.Drawing.Color.Thistle;
            btn_chickenTeriyaki.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_chickenTeriyaki.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_chickenTeriyaki.Location = new System.Drawing.Point(11, 261);
            btn_chickenTeriyaki.Name = "btn_chickenTeriyaki";
            btn_chickenTeriyaki.Size = new System.Drawing.Size(113, 38);
            btn_chickenTeriyaki.TabIndex = 19;
            btn_chickenTeriyaki.Text = "Chkn Teriyaki";
            btn_chickenTeriyaki.UseVisualStyleBackColor = false;
            btn_chickenTeriyaki.Click += btn_chickenTeriyaki_Click;
            // 
            // btn_coldCut
            // 
            btn_coldCut.BackColor = System.Drawing.Color.CadetBlue;
            btn_coldCut.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_coldCut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_coldCut.Location = new System.Drawing.Point(135, 217);
            btn_coldCut.Name = "btn_coldCut";
            btn_coldCut.Size = new System.Drawing.Size(113, 38);
            btn_coldCut.TabIndex = 18;
            btn_coldCut.Text = "Cold Cut";
            btn_coldCut.UseVisualStyleBackColor = false;
            btn_coldCut.Click += btn_coldCut_Click;
            // 
            // btn_tuna
            // 
            btn_tuna.BackColor = System.Drawing.Color.FromArgb(255, 255, 128);
            btn_tuna.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_tuna.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_tuna.Location = new System.Drawing.Point(11, 217);
            btn_tuna.Name = "btn_tuna";
            btn_tuna.Size = new System.Drawing.Size(113, 38);
            btn_tuna.TabIndex = 17;
            btn_tuna.Text = "Tuna";
            btn_tuna.UseVisualStyleBackColor = false;
            btn_tuna.Click += btn_tuna_Click;
            // 
            // btn_grillChicken
            // 
            btn_grillChicken.BackColor = System.Drawing.Color.DarkKhaki;
            btn_grillChicken.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_grillChicken.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_grillChicken.Location = new System.Drawing.Point(135, 173);
            btn_grillChicken.Name = "btn_grillChicken";
            btn_grillChicken.Size = new System.Drawing.Size(113, 38);
            btn_grillChicken.TabIndex = 16;
            btn_grillChicken.Text = "Grill Chicken";
            btn_grillChicken.UseVisualStyleBackColor = false;
            btn_grillChicken.Click += btn_grillChicken_Click;
            // 
            // btn_meatBall
            // 
            btn_meatBall.BackColor = System.Drawing.Color.DarkOrange;
            btn_meatBall.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_meatBall.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_meatBall.Location = new System.Drawing.Point(135, 129);
            btn_meatBall.Name = "btn_meatBall";
            btn_meatBall.Size = new System.Drawing.Size(113, 38);
            btn_meatBall.TabIndex = 14;
            btn_meatBall.Text = "Meatball";
            btn_meatBall.UseVisualStyleBackColor = false;
            btn_meatBall.Click += btn_meatBall_Click;
            // 
            // btn_ham
            // 
            btn_ham.BackColor = System.Drawing.Color.Salmon;
            btn_ham.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_ham.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_ham.Location = new System.Drawing.Point(135, 85);
            btn_ham.Name = "btn_ham";
            btn_ham.Size = new System.Drawing.Size(113, 38);
            btn_ham.TabIndex = 12;
            btn_ham.Text = "Ham";
            btn_ham.UseVisualStyleBackColor = false;
            btn_ham.Click += btn_ham_Click;
            // 
            // btn_vegPatty
            // 
            btn_vegPatty.BackColor = System.Drawing.Color.YellowGreen;
            btn_vegPatty.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_vegPatty.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_vegPatty.Location = new System.Drawing.Point(135, 41);
            btn_vegPatty.Name = "btn_vegPatty";
            btn_vegPatty.Size = new System.Drawing.Size(113, 38);
            btn_vegPatty.TabIndex = 10;
            btn_vegPatty.Text = "Veg patty";
            btn_vegPatty.UseVisualStyleBackColor = false;
            btn_vegPatty.Click += btn_vegPatty_Click;
            // 
            // btn_steak
            // 
            btn_steak.BackColor = System.Drawing.Color.Tan;
            btn_steak.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_steak.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_steak.Location = new System.Drawing.Point(11, 173);
            btn_steak.Name = "btn_steak";
            btn_steak.Size = new System.Drawing.Size(107, 38);
            btn_steak.TabIndex = 15;
            btn_steak.Text = "Steak";
            btn_steak.UseVisualStyleBackColor = false;
            btn_steak.Click += btn_steak_Click;
            // 
            // btn_vegDelight
            // 
            btn_vegDelight.BackColor = System.Drawing.Color.DarkSeaGreen;
            btn_vegDelight.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_vegDelight.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_vegDelight.Location = new System.Drawing.Point(11, 41);
            btn_vegDelight.Name = "btn_vegDelight";
            btn_vegDelight.Size = new System.Drawing.Size(107, 38);
            btn_vegDelight.TabIndex = 9;
            btn_vegDelight.Text = "Veg Delight";
            btn_vegDelight.UseVisualStyleBackColor = false;
            btn_vegDelight.Click += btn_vegDelight_Click;
            // 
            // btn_turky
            // 
            btn_turky.BackColor = System.Drawing.Color.PeachPuff;
            btn_turky.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_turky.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_turky.Location = new System.Drawing.Point(11, 85);
            btn_turky.Name = "btn_turky";
            btn_turky.Size = new System.Drawing.Size(107, 38);
            btn_turky.TabIndex = 11;
            btn_turky.Text = "Turky";
            btn_turky.UseVisualStyleBackColor = false;
            btn_turky.Click += btn_turky_Click;
            // 
            // btn_spcyItalian
            // 
            btn_spcyItalian.BackColor = System.Drawing.Color.SandyBrown;
            btn_spcyItalian.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_spcyItalian.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_spcyItalian.Location = new System.Drawing.Point(11, 129);
            btn_spcyItalian.Name = "btn_spcyItalian";
            btn_spcyItalian.Size = new System.Drawing.Size(107, 38);
            btn_spcyItalian.TabIndex = 13;
            btn_spcyItalian.Text = "Spicy Italian";
            btn_spcyItalian.UseVisualStyleBackColor = false;
            btn_spcyItalian.Click += btn_spcyItalian_Click;
            // 
            // btn_total
            // 
            btn_total.BackColor = System.Drawing.SystemColors.InfoText;
            btn_total.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_total.ForeColor = System.Drawing.SystemColors.HighlightText;
            btn_total.Location = new System.Drawing.Point(216, 308);
            btn_total.Name = "btn_total";
            btn_total.Size = new System.Drawing.Size(105, 49);
            btn_total.TabIndex = 17;
            btn_total.Text = "Total";
            btn_total.UseVisualStyleBackColor = false;
            btn_total.Click += btn_total_Click;
            // 
            // lbl_subTotal
            // 
            lbl_subTotal.AutoSize = true;
            lbl_subTotal.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_subTotal.Location = new System.Drawing.Point(12, 318);
            lbl_subTotal.Name = "lbl_subTotal";
            lbl_subTotal.Size = new System.Drawing.Size(133, 29);
            lbl_subTotal.TabIndex = 18;
            lbl_subTotal.Text = "Sub Total : $";
            // 
            // gb_Main
            // 
            gb_Main.Controls.Add(rb_riceBowl);
            gb_Main.Controls.Add(rb_salad);
            gb_Main.Controls.Add(rb_riceWrap);
            gb_Main.Controls.Add(rb_wrap);
            gb_Main.Controls.Add(rb_6inFlatBread);
            gb_Main.Controls.Add(rb_12inFlatBread);
            gb_Main.Controls.Add(rb_6inBread);
            gb_Main.Controls.Add(rb_12inBread);
            gb_Main.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            gb_Main.Location = new System.Drawing.Point(880, 30);
            gb_Main.Name = "gb_Main";
            gb_Main.Size = new System.Drawing.Size(118, 384);
            gb_Main.TabIndex = 20;
            gb_Main.TabStop = false;
            gb_Main.Text = "Main";
            // 
            // rb_riceBowl
            // 
            rb_riceBowl.Appearance = System.Windows.Forms.Appearance.Button;
            rb_riceBowl.AutoSize = true;
            rb_riceBowl.BackColor = System.Drawing.Color.Bisque;
            rb_riceBowl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rb_riceBowl.Font = new System.Drawing.Font("Calibri", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rb_riceBowl.Location = new System.Drawing.Point(8, 340);
            rb_riceBowl.Name = "rb_riceBowl";
            rb_riceBowl.Padding = new System.Windows.Forms.Padding(11, 5, 11, 5);
            rb_riceBowl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            rb_riceBowl.Size = new System.Drawing.Size(100, 38);
            rb_riceBowl.TabIndex = 7;
            rb_riceBowl.Text = "Rice Bowl";
            rb_riceBowl.UseVisualStyleBackColor = false;
            rb_riceBowl.CheckedChanged += rb_riceBowl_CheckedChanged;
            // 
            // rb_salad
            // 
            rb_salad.Appearance = System.Windows.Forms.Appearance.Button;
            rb_salad.AutoSize = true;
            rb_salad.BackColor = System.Drawing.Color.Khaki;
            rb_salad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rb_salad.Font = new System.Drawing.Font("Calibri", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rb_salad.Location = new System.Drawing.Point(7, 296);
            rb_salad.Name = "rb_salad";
            rb_salad.Padding = new System.Windows.Forms.Padding(25, 5, 25, 5);
            rb_salad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            rb_salad.Size = new System.Drawing.Size(101, 38);
            rb_salad.TabIndex = 6;
            rb_salad.Text = "Salad";
            rb_salad.UseVisualStyleBackColor = false;
            rb_salad.CheckedChanged += rb_salad_CheckedChanged;
            // 
            // rb_riceWrap
            // 
            rb_riceWrap.Appearance = System.Windows.Forms.Appearance.Button;
            rb_riceWrap.AutoSize = true;
            rb_riceWrap.BackColor = System.Drawing.Color.Coral;
            rb_riceWrap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rb_riceWrap.Font = new System.Drawing.Font("Calibri", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rb_riceWrap.Location = new System.Drawing.Point(6, 252);
            rb_riceWrap.Name = "rb_riceWrap";
            rb_riceWrap.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            rb_riceWrap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            rb_riceWrap.Size = new System.Drawing.Size(101, 38);
            rb_riceWrap.TabIndex = 5;
            rb_riceWrap.Text = "Rice Wrap";
            rb_riceWrap.UseVisualStyleBackColor = false;
            rb_riceWrap.CheckedChanged += rb_riceWrap_CheckedChanged;
            // 
            // rb_wrap
            // 
            rb_wrap.Appearance = System.Windows.Forms.Appearance.Button;
            rb_wrap.AutoSize = true;
            rb_wrap.BackColor = System.Drawing.Color.DarkSalmon;
            rb_wrap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rb_wrap.Font = new System.Drawing.Font("Calibri", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rb_wrap.Location = new System.Drawing.Point(8, 208);
            rb_wrap.Name = "rb_wrap";
            rb_wrap.Padding = new System.Windows.Forms.Padding(25, 5, 25, 5);
            rb_wrap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            rb_wrap.Size = new System.Drawing.Size(102, 38);
            rb_wrap.TabIndex = 4;
            rb_wrap.Text = "Wrap";
            rb_wrap.UseVisualStyleBackColor = false;
            rb_wrap.CheckedChanged += rb_wrap_CheckedChanged;
            // 
            // rb_6inFlatBread
            // 
            rb_6inFlatBread.Appearance = System.Windows.Forms.Appearance.Button;
            rb_6inFlatBread.AutoSize = true;
            rb_6inFlatBread.BackColor = System.Drawing.Color.PowderBlue;
            rb_6inFlatBread.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rb_6inFlatBread.Font = new System.Drawing.Font("Calibri", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rb_6inFlatBread.Location = new System.Drawing.Point(8, 164);
            rb_6inFlatBread.Name = "rb_6inFlatBread";
            rb_6inFlatBread.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            rb_6inFlatBread.Size = new System.Drawing.Size(103, 38);
            rb_6inFlatBread.TabIndex = 3;
            rb_6inFlatBread.Text = "6\"   Sub Bread";
            rb_6inFlatBread.UseVisualStyleBackColor = false;
            rb_6inFlatBread.CheckedChanged += rb_6inFlatBread_CheckedChanged;
            // 
            // rb_12inFlatBread
            // 
            rb_12inFlatBread.Appearance = System.Windows.Forms.Appearance.Button;
            rb_12inFlatBread.AutoSize = true;
            rb_12inFlatBread.BackColor = System.Drawing.Color.LightCoral;
            rb_12inFlatBread.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rb_12inFlatBread.Font = new System.Drawing.Font("Calibri", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rb_12inFlatBread.Location = new System.Drawing.Point(7, 120);
            rb_12inFlatBread.Name = "rb_12inFlatBread";
            rb_12inFlatBread.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            rb_12inFlatBread.Size = new System.Drawing.Size(104, 38);
            rb_12inFlatBread.TabIndex = 2;
            rb_12inFlatBread.Text = "12\" Flat Bread";
            rb_12inFlatBread.UseVisualStyleBackColor = false;
            rb_12inFlatBread.CheckedChanged += rb_12inFlatBread_CheckedChanged;
            // 
            // rb_6inBread
            // 
            rb_6inBread.Appearance = System.Windows.Forms.Appearance.Button;
            rb_6inBread.AutoSize = true;
            rb_6inBread.BackColor = System.Drawing.Color.LightSteelBlue;
            rb_6inBread.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rb_6inBread.Font = new System.Drawing.Font("Calibri", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rb_6inBread.Location = new System.Drawing.Point(8, 76);
            rb_6inBread.Name = "rb_6inBread";
            rb_6inBread.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            rb_6inBread.Size = new System.Drawing.Size(103, 38);
            rb_6inBread.TabIndex = 1;
            rb_6inBread.Text = "6\"   Sub Bread";
            rb_6inBread.UseVisualStyleBackColor = false;
            rb_6inBread.CheckedChanged += rb_6inBread_CheckedChanged;
            // 
            // rb_12inBread
            // 
            rb_12inBread.Appearance = System.Windows.Forms.Appearance.Button;
            rb_12inBread.AutoSize = true;
            rb_12inBread.BackColor = System.Drawing.Color.LightGreen;
            rb_12inBread.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            rb_12inBread.Font = new System.Drawing.Font("Calibri", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rb_12inBread.Location = new System.Drawing.Point(6, 32);
            rb_12inBread.Name = "rb_12inBread";
            rb_12inBread.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            rb_12inBread.Size = new System.Drawing.Size(104, 38);
            rb_12inBread.TabIndex = 0;
            rb_12inBread.Text = "12\" Sub Bread";
            rb_12inBread.UseVisualStyleBackColor = false;
            rb_12inBread.CheckedChanged += rb_12inBread_CheckedChanged;
            // 
            // lstbx_orderItems
            // 
            lstbx_orderItems.BackColor = System.Drawing.SystemColors.MenuBar;
            lstbx_orderItems.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lstbx_orderItems.FormattingEnabled = true;
            lstbx_orderItems.ItemHeight = 14;
            lstbx_orderItems.Location = new System.Drawing.Point(12, 62);
            lstbx_orderItems.Name = "lstbx_orderItems";
            lstbx_orderItems.Size = new System.Drawing.Size(265, 214);
            lstbx_orderItems.TabIndex = 8;
            lstbx_orderItems.TabStop = false;
            lstbx_orderItems.SelectedIndexChanged += lstbx_orderItems_SelectedIndexChanged;
            // 
            // btn_remove
            // 
            btn_remove.BackColor = System.Drawing.Color.Red;
            btn_remove.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_remove.ForeColor = System.Drawing.SystemColors.HighlightText;
            btn_remove.Location = new System.Drawing.Point(12, 286);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new System.Drawing.Size(85, 29);
            btn_remove.TabIndex = 21;
            btn_remove.Text = "Remove";
            btn_remove.UseVisualStyleBackColor = false;
            btn_remove.Click += button1_Click;
            // 
            // PunchingScreenMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(1020, 425);
            Controls.Add(btn_remove);
            Controls.Add(lstbx_orderItems);
            Controls.Add(gb_Main);
            Controls.Add(gb_type);
            Controls.Add(lbl_subTotal);
            Controls.Add(btn_total);
            Controls.Add(gb_cookies);
            Controls.Add(gb_drinks);
            Controls.Add(lbl_orderItems);
            Controls.Add(lbl_userName);
            Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Name = "PunchingScreenMain";
            Text = "Subway POS";
            Load += PunchingScreenMain_Load;
            gb_drinks.ResumeLayout(false);
            gb_cookies.ResumeLayout(false);
            gb_type.ResumeLayout(false);
            gb_Main.ResumeLayout(false);
            gb_Main.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.Label lbl_orderItems;
        private System.Windows.Forms.GroupBox gb_drinks;
        private System.Windows.Forms.Button btn_softDrink;
        private System.Windows.Forms.Button btn_water;
        private System.Windows.Forms.Button btn_10oz;
        private System.Windows.Forms.Button btn_20oz;
        private System.Windows.Forms.Button btn_30oz;
        private System.Windows.Forms.GroupBox gb_cookies;
        private System.Windows.Forms.Button btn_1cookie;
        private System.Windows.Forms.Button btn_3cookies;
        private System.Windows.Forms.Button btn_6cookies;
        private System.Windows.Forms.Button btn_total;
        private System.Windows.Forms.Label lbl_subTotal;
        private System.Windows.Forms.GroupBox gb_type;
        private System.Windows.Forms.Button btn_grillChicken;
        private System.Windows.Forms.Button btn_meatBall;
        private System.Windows.Forms.Button btn_ham;
        private System.Windows.Forms.Button btn_vegPatty;
        private System.Windows.Forms.Button btn_steak;
        private System.Windows.Forms.Button btn_vegDelight;
        private System.Windows.Forms.Button btn_turky;
        private System.Windows.Forms.Button btn_spcyItalian;
        private System.Windows.Forms.Button btn_tuna;
        private System.Windows.Forms.Button btn_coldCut;
        private System.Windows.Forms.Button btn_BLT;
        private System.Windows.Forms.Button btn_chickenTeriyaki;
        private System.Windows.Forms.GroupBox gb_Main;
        private System.Windows.Forms.RadioButton rb_12inBread;
        private System.Windows.Forms.RadioButton rb_6inBread;
        private System.Windows.Forms.RadioButton rb_wrap;
        private System.Windows.Forms.RadioButton rb_6inFlatBread;
        private System.Windows.Forms.RadioButton rb_12inFlatBread;
        private System.Windows.Forms.RadioButton rb_riceWrap;
        private System.Windows.Forms.RadioButton rb_riceBowl;
        private System.Windows.Forms.RadioButton rb_salad;
        private System.Windows.Forms.ListBox lstbx_orderItems;
        private System.Windows.Forms.Button btn_remove;
    }
}