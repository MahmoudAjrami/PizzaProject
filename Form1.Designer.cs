namespace Pizza_Project
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rb_large = new System.Windows.Forms.RadioButton();
            this.rb_medium = new System.Windows.Forms.RadioButton();
            this.rb_small = new System.Windows.Forms.RadioButton();
            this.gb_CurstType = new System.Windows.Forms.GroupBox();
            this.rb_thiccrust = new System.Windows.Forms.RadioButton();
            this.rb_thincrust = new System.Windows.Forms.RadioButton();
            this.gb_Toppings = new System.Windows.Forms.GroupBox();
            this.chk_greenpappers = new System.Windows.Forms.CheckBox();
            this.chk_olives = new System.Windows.Forms.CheckBox();
            this.chk_onion = new System.Windows.Forms.CheckBox();
            this.chk_tomatoes = new System.Windows.Forms.CheckBox();
            this.chk_mushrooms = new System.Windows.Forms.CheckBox();
            this.chk_extracheese = new System.Windows.Forms.CheckBox();
            this.gb_WhereToEat = new System.Windows.Forms.GroupBox();
            this.rb_takeout = new System.Windows.Forms.RadioButton();
            this.rb_eatin = new System.Windows.Forms.RadioButton();
            this.gb_OrderSummary = new System.Windows.Forms.GroupBox();
            this.lbl_totalprice_result = new System.Windows.Forms.Label();
            this.lbl_wheretoeatresult = new System.Windows.Forms.Label();
            this.lbl_crustresult = new System.Windows.Forms.Label();
            this.lbl_toppingsresult = new System.Windows.Forms.Label();
            this.lbl_sizeresult = new System.Windows.Forms.Label();
            this.lbl_totalprice = new System.Windows.Forms.Label();
            this.lbl_wheretoeat = new System.Windows.Forms.Label();
            this.lbl_crusttype = new System.Windows.Forms.Label();
            this.lbl_toppings = new System.Windows.Forms.Label();
            this.lbl_size = new System.Windows.Forms.Label();
            this.btn_OrderPizza = new System.Windows.Forms.Button();
            this.btn_ResetForm = new System.Windows.Forms.Button();
            this.gbSize.SuspendLayout();
            this.gb_CurstType.SuspendLayout();
            this.gb_Toppings.SuspendLayout();
            this.gb_WhereToEat.SuspendLayout();
            this.gb_OrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Helvetica Neue", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(389, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make Your Pizza";
            // 
            // gbSize
            // 
            this.gbSize.BackColor = System.Drawing.Color.Transparent;
            this.gbSize.Controls.Add(this.rb_large);
            this.gbSize.Controls.Add(this.rb_medium);
            this.gbSize.Controls.Add(this.rb_small);
            this.gbSize.Font = new System.Drawing.Font("Helvetica Neue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbSize.Location = new System.Drawing.Point(49, 146);
            this.gbSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSize.Name = "gbSize";
            this.gbSize.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSize.Size = new System.Drawing.Size(252, 196);
            this.gbSize.TabIndex = 1;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rb_large
            // 
            this.rb_large.AutoSize = true;
            this.rb_large.Font = new System.Drawing.Font("Helvetica Neue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_large.Location = new System.Drawing.Point(40, 143);
            this.rb_large.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_large.Name = "rb_large";
            this.rb_large.Size = new System.Drawing.Size(63, 20);
            this.rb_large.TabIndex = 2;
            this.rb_large.Tag = "40";
            this.rb_large.Text = "Large";
            this.rb_large.UseVisualStyleBackColor = true;
            this.rb_large.CheckedChanged += new System.EventHandler(this.rb_large_CheckedChanged);
            // 
            // rb_medium
            // 
            this.rb_medium.AutoSize = true;
            this.rb_medium.Font = new System.Drawing.Font("Helvetica Neue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_medium.Location = new System.Drawing.Point(40, 93);
            this.rb_medium.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_medium.Name = "rb_medium";
            this.rb_medium.Size = new System.Drawing.Size(79, 20);
            this.rb_medium.TabIndex = 1;
            this.rb_medium.Tag = "30";
            this.rb_medium.Text = "Medium";
            this.rb_medium.UseVisualStyleBackColor = true;
            this.rb_medium.CheckedChanged += new System.EventHandler(this.rb_medium_CheckedChanged);
            // 
            // rb_small
            // 
            this.rb_small.AutoSize = true;
            this.rb_small.Checked = true;
            this.rb_small.Font = new System.Drawing.Font("Helvetica Neue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_small.Location = new System.Drawing.Point(40, 41);
            this.rb_small.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_small.Name = "rb_small";
            this.rb_small.Size = new System.Drawing.Size(62, 20);
            this.rb_small.TabIndex = 0;
            this.rb_small.TabStop = true;
            this.rb_small.Tag = "20";
            this.rb_small.Text = "Small";
            this.rb_small.UseVisualStyleBackColor = true;
            this.rb_small.CheckedChanged += new System.EventHandler(this.rb_small_CheckedChanged);
            // 
            // gb_CurstType
            // 
            this.gb_CurstType.BackColor = System.Drawing.Color.Transparent;
            this.gb_CurstType.Controls.Add(this.rb_thiccrust);
            this.gb_CurstType.Controls.Add(this.rb_thincrust);
            this.gb_CurstType.Font = new System.Drawing.Font("Helvetica Neue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_CurstType.Location = new System.Drawing.Point(49, 383);
            this.gb_CurstType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_CurstType.Name = "gb_CurstType";
            this.gb_CurstType.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_CurstType.Size = new System.Drawing.Size(250, 163);
            this.gb_CurstType.TabIndex = 2;
            this.gb_CurstType.TabStop = false;
            this.gb_CurstType.Text = "Crust Type";
            // 
            // rb_thiccrust
            // 
            this.rb_thiccrust.AutoSize = true;
            this.rb_thiccrust.Font = new System.Drawing.Font("Helvetica Neue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_thiccrust.Location = new System.Drawing.Point(40, 108);
            this.rb_thiccrust.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_thiccrust.Name = "rb_thiccrust";
            this.rb_thiccrust.Size = new System.Drawing.Size(93, 20);
            this.rb_thiccrust.TabIndex = 4;
            this.rb_thiccrust.Tag = "10";
            this.rb_thiccrust.Text = "Thic Crust";
            this.rb_thiccrust.UseVisualStyleBackColor = true;
            this.rb_thiccrust.CheckedChanged += new System.EventHandler(this.rb_thiccrust_CheckedChanged);
            // 
            // rb_thincrust
            // 
            this.rb_thincrust.AutoSize = true;
            this.rb_thincrust.Checked = true;
            this.rb_thincrust.Font = new System.Drawing.Font("Helvetica Neue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_thincrust.Location = new System.Drawing.Point(40, 59);
            this.rb_thincrust.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_thincrust.Name = "rb_thincrust";
            this.rb_thincrust.Size = new System.Drawing.Size(93, 20);
            this.rb_thincrust.TabIndex = 3;
            this.rb_thincrust.TabStop = true;
            this.rb_thincrust.Tag = "0";
            this.rb_thincrust.Text = "Thin Crust";
            this.rb_thincrust.UseVisualStyleBackColor = true;
            this.rb_thincrust.CheckedChanged += new System.EventHandler(this.rb_thincrust_CheckedChanged);
            // 
            // gb_Toppings
            // 
            this.gb_Toppings.BackColor = System.Drawing.Color.Transparent;
            this.gb_Toppings.Controls.Add(this.chk_greenpappers);
            this.gb_Toppings.Controls.Add(this.chk_olives);
            this.gb_Toppings.Controls.Add(this.chk_onion);
            this.gb_Toppings.Controls.Add(this.chk_tomatoes);
            this.gb_Toppings.Controls.Add(this.chk_mushrooms);
            this.gb_Toppings.Controls.Add(this.chk_extracheese);
            this.gb_Toppings.Font = new System.Drawing.Font("Helvetica Neue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_Toppings.Location = new System.Drawing.Point(367, 146);
            this.gb_Toppings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_Toppings.Name = "gb_Toppings";
            this.gb_Toppings.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_Toppings.Size = new System.Drawing.Size(432, 196);
            this.gb_Toppings.TabIndex = 3;
            this.gb_Toppings.TabStop = false;
            this.gb_Toppings.Text = "Toppings";
            this.gb_Toppings.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // chk_greenpappers
            // 
            this.chk_greenpappers.AutoSize = true;
            this.chk_greenpappers.Font = new System.Drawing.Font("Helvetica Neue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chk_greenpappers.Location = new System.Drawing.Point(240, 143);
            this.chk_greenpappers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk_greenpappers.Name = "chk_greenpappers";
            this.chk_greenpappers.Size = new System.Drawing.Size(126, 20);
            this.chk_greenpappers.TabIndex = 5;
            this.chk_greenpappers.Tag = "5";
            this.chk_greenpappers.Text = "Green Pappers";
            this.chk_greenpappers.UseVisualStyleBackColor = true;
            this.chk_greenpappers.CheckedChanged += new System.EventHandler(this.chk_greenpappers_CheckedChanged);
            // 
            // chk_olives
            // 
            this.chk_olives.AutoSize = true;
            this.chk_olives.Font = new System.Drawing.Font("Helvetica Neue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chk_olives.Location = new System.Drawing.Point(240, 93);
            this.chk_olives.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk_olives.Name = "chk_olives";
            this.chk_olives.Size = new System.Drawing.Size(65, 20);
            this.chk_olives.TabIndex = 4;
            this.chk_olives.Tag = "5";
            this.chk_olives.Text = "Olives";
            this.chk_olives.UseVisualStyleBackColor = true;
            this.chk_olives.CheckedChanged += new System.EventHandler(this.chk_olives_CheckedChanged);
            // 
            // chk_onion
            // 
            this.chk_onion.AutoSize = true;
            this.chk_onion.Font = new System.Drawing.Font("Helvetica Neue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chk_onion.Location = new System.Drawing.Point(240, 41);
            this.chk_onion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk_onion.Name = "chk_onion";
            this.chk_onion.Size = new System.Drawing.Size(65, 20);
            this.chk_onion.TabIndex = 3;
            this.chk_onion.Tag = "5";
            this.chk_onion.Text = "Onion";
            this.chk_onion.UseVisualStyleBackColor = true;
            this.chk_onion.CheckedChanged += new System.EventHandler(this.chk_onion_CheckedChanged);
            // 
            // chk_tomatoes
            // 
            this.chk_tomatoes.AutoSize = true;
            this.chk_tomatoes.Font = new System.Drawing.Font("Helvetica Neue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chk_tomatoes.Location = new System.Drawing.Point(33, 143);
            this.chk_tomatoes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk_tomatoes.Name = "chk_tomatoes";
            this.chk_tomatoes.Size = new System.Drawing.Size(93, 20);
            this.chk_tomatoes.TabIndex = 2;
            this.chk_tomatoes.Tag = "5";
            this.chk_tomatoes.Text = "Tomatoes";
            this.chk_tomatoes.UseVisualStyleBackColor = true;
            this.chk_tomatoes.CheckedChanged += new System.EventHandler(this.chk_tomatoes_CheckedChanged);
            // 
            // chk_mushrooms
            // 
            this.chk_mushrooms.AutoSize = true;
            this.chk_mushrooms.Font = new System.Drawing.Font("Helvetica Neue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chk_mushrooms.Location = new System.Drawing.Point(33, 93);
            this.chk_mushrooms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk_mushrooms.Name = "chk_mushrooms";
            this.chk_mushrooms.Size = new System.Drawing.Size(105, 20);
            this.chk_mushrooms.TabIndex = 1;
            this.chk_mushrooms.Tag = "5";
            this.chk_mushrooms.Text = "Mushrooms";
            this.chk_mushrooms.UseVisualStyleBackColor = true;
            this.chk_mushrooms.CheckedChanged += new System.EventHandler(this.chk_mushrooms_CheckedChanged);
            // 
            // chk_extracheese
            // 
            this.chk_extracheese.AutoSize = true;
            this.chk_extracheese.Checked = true;
            this.chk_extracheese.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_extracheese.Font = new System.Drawing.Font("Helvetica Neue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chk_extracheese.Location = new System.Drawing.Point(33, 41);
            this.chk_extracheese.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk_extracheese.Name = "chk_extracheese";
            this.chk_extracheese.Size = new System.Drawing.Size(114, 20);
            this.chk_extracheese.TabIndex = 0;
            this.chk_extracheese.Tag = "5";
            this.chk_extracheese.Text = "Extra Cheese";
            this.chk_extracheese.UseVisualStyleBackColor = true;
            this.chk_extracheese.CheckedChanged += new System.EventHandler(this.chk_extracheese_CheckedChanged);
            // 
            // gb_WhereToEat
            // 
            this.gb_WhereToEat.BackColor = System.Drawing.Color.Transparent;
            this.gb_WhereToEat.Controls.Add(this.rb_takeout);
            this.gb_WhereToEat.Controls.Add(this.rb_eatin);
            this.gb_WhereToEat.Font = new System.Drawing.Font("Helvetica Neue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_WhereToEat.Location = new System.Drawing.Point(366, 383);
            this.gb_WhereToEat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_WhereToEat.Name = "gb_WhereToEat";
            this.gb_WhereToEat.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_WhereToEat.Size = new System.Drawing.Size(432, 113);
            this.gb_WhereToEat.TabIndex = 4;
            this.gb_WhereToEat.TabStop = false;
            this.gb_WhereToEat.Text = "Where To Eat";
            // 
            // rb_takeout
            // 
            this.rb_takeout.AutoSize = true;
            this.rb_takeout.Font = new System.Drawing.Font("Helvetica Neue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_takeout.Location = new System.Drawing.Point(241, 49);
            this.rb_takeout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_takeout.Name = "rb_takeout";
            this.rb_takeout.Size = new System.Drawing.Size(84, 20);
            this.rb_takeout.TabIndex = 6;
            this.rb_takeout.Text = "Take Out";
            this.rb_takeout.UseVisualStyleBackColor = true;
            this.rb_takeout.CheckedChanged += new System.EventHandler(this.rb_takeout_CheckedChanged);
            // 
            // rb_eatin
            // 
            this.rb_eatin.AutoSize = true;
            this.rb_eatin.Checked = true;
            this.rb_eatin.Font = new System.Drawing.Font("Helvetica Neue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_eatin.Location = new System.Drawing.Point(34, 49);
            this.rb_eatin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_eatin.Name = "rb_eatin";
            this.rb_eatin.Size = new System.Drawing.Size(63, 20);
            this.rb_eatin.TabIndex = 5;
            this.rb_eatin.TabStop = true;
            this.rb_eatin.Text = "Eat In";
            this.rb_eatin.UseVisualStyleBackColor = true;
            this.rb_eatin.CheckedChanged += new System.EventHandler(this.rb_eatin_CheckedChanged);
            // 
            // gb_OrderSummary
            // 
            this.gb_OrderSummary.BackColor = System.Drawing.Color.Transparent;
            this.gb_OrderSummary.Controls.Add(this.lbl_totalprice_result);
            this.gb_OrderSummary.Controls.Add(this.lbl_wheretoeatresult);
            this.gb_OrderSummary.Controls.Add(this.lbl_crustresult);
            this.gb_OrderSummary.Controls.Add(this.lbl_toppingsresult);
            this.gb_OrderSummary.Controls.Add(this.lbl_sizeresult);
            this.gb_OrderSummary.Controls.Add(this.lbl_totalprice);
            this.gb_OrderSummary.Controls.Add(this.lbl_wheretoeat);
            this.gb_OrderSummary.Controls.Add(this.lbl_crusttype);
            this.gb_OrderSummary.Controls.Add(this.lbl_toppings);
            this.gb_OrderSummary.Controls.Add(this.lbl_size);
            this.gb_OrderSummary.Font = new System.Drawing.Font("Helvetica Neue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_OrderSummary.Location = new System.Drawing.Point(880, 146);
            this.gb_OrderSummary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_OrderSummary.Name = "gb_OrderSummary";
            this.gb_OrderSummary.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_OrderSummary.Size = new System.Drawing.Size(292, 413);
            this.gb_OrderSummary.TabIndex = 5;
            this.gb_OrderSummary.TabStop = false;
            this.gb_OrderSummary.Text = "Order Summary";
            this.gb_OrderSummary.Enter += new System.EventHandler(this.gb_OrderSummary_Enter);
            // 
            // lbl_totalprice_result
            // 
            this.lbl_totalprice_result.AutoSize = true;
            this.lbl_totalprice_result.BackColor = System.Drawing.Color.Transparent;
            this.lbl_totalprice_result.Font = new System.Drawing.Font("Helvetica Neue", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_totalprice_result.ForeColor = System.Drawing.Color.Red;
            this.lbl_totalprice_result.Location = new System.Drawing.Point(116, 335);
            this.lbl_totalprice_result.Name = "lbl_totalprice_result";
            this.lbl_totalprice_result.Size = new System.Drawing.Size(69, 35);
            this.lbl_totalprice_result.TabIndex = 9;
            this.lbl_totalprice_result.Text = "$30";
            // 
            // lbl_wheretoeatresult
            // 
            this.lbl_wheretoeatresult.AutoSize = true;
            this.lbl_wheretoeatresult.Font = new System.Drawing.Font("Helvetica Neue", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_wheretoeatresult.Location = new System.Drawing.Point(119, 273);
            this.lbl_wheretoeatresult.Name = "lbl_wheretoeatresult";
            this.lbl_wheretoeatresult.Size = new System.Drawing.Size(51, 16);
            this.lbl_wheretoeatresult.TabIndex = 8;
            this.lbl_wheretoeatresult.Text = "Eat In";
            // 
            // lbl_crustresult
            // 
            this.lbl_crustresult.AutoSize = true;
            this.lbl_crustresult.Font = new System.Drawing.Font("Helvetica Neue", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_crustresult.Location = new System.Drawing.Point(100, 212);
            this.lbl_crustresult.Name = "lbl_crustresult";
            this.lbl_crustresult.Size = new System.Drawing.Size(85, 16);
            this.lbl_crustresult.TabIndex = 7;
            this.lbl_crustresult.Text = "Thin Crust";
            // 
            // lbl_toppingsresult
            // 
            this.lbl_toppingsresult.AutoSize = true;
            this.lbl_toppingsresult.Font = new System.Drawing.Font("Helvetica Neue", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_toppingsresult.Location = new System.Drawing.Point(46, 134);
            this.lbl_toppingsresult.MaximumSize = new System.Drawing.Size(220, 0);
            this.lbl_toppingsresult.Name = "lbl_toppingsresult";
            this.lbl_toppingsresult.Size = new System.Drawing.Size(106, 16);
            this.lbl_toppingsresult.TabIndex = 6;
            this.lbl_toppingsresult.Text = "Extra Chesse";
            // 
            // lbl_sizeresult
            // 
            this.lbl_sizeresult.AutoSize = true;
            this.lbl_sizeresult.Font = new System.Drawing.Font("Helvetica Neue", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_sizeresult.Location = new System.Drawing.Point(66, 46);
            this.lbl_sizeresult.Name = "lbl_sizeresult";
            this.lbl_sizeresult.Size = new System.Drawing.Size(49, 16);
            this.lbl_sizeresult.TabIndex = 5;
            this.lbl_sizeresult.Text = "Small";
            // 
            // lbl_totalprice
            // 
            this.lbl_totalprice.AutoSize = true;
            this.lbl_totalprice.Font = new System.Drawing.Font("Helvetica Neue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_totalprice.Location = new System.Drawing.Point(25, 337);
            this.lbl_totalprice.Name = "lbl_totalprice";
            this.lbl_totalprice.Size = new System.Drawing.Size(82, 16);
            this.lbl_totalprice.TabIndex = 4;
            this.lbl_totalprice.Text = "Total Price:";
            // 
            // lbl_wheretoeat
            // 
            this.lbl_wheretoeat.AutoSize = true;
            this.lbl_wheretoeat.Font = new System.Drawing.Font("Helvetica Neue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_wheretoeat.Location = new System.Drawing.Point(25, 273);
            this.lbl_wheretoeat.Name = "lbl_wheretoeat";
            this.lbl_wheretoeat.Size = new System.Drawing.Size(101, 16);
            this.lbl_wheretoeat.TabIndex = 3;
            this.lbl_wheretoeat.Text = "Where To Eat:";
            // 
            // lbl_crusttype
            // 
            this.lbl_crusttype.AutoSize = true;
            this.lbl_crusttype.Font = new System.Drawing.Font("Helvetica Neue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_crusttype.Location = new System.Drawing.Point(22, 212);
            this.lbl_crusttype.Name = "lbl_crusttype";
            this.lbl_crusttype.Size = new System.Drawing.Size(83, 16);
            this.lbl_crusttype.TabIndex = 2;
            this.lbl_crusttype.Text = "Crust Type:";
            // 
            // lbl_toppings
            // 
            this.lbl_toppings.AutoSize = true;
            this.lbl_toppings.Font = new System.Drawing.Font("Helvetica Neue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_toppings.Location = new System.Drawing.Point(25, 109);
            this.lbl_toppings.Name = "lbl_toppings";
            this.lbl_toppings.Size = new System.Drawing.Size(73, 16);
            this.lbl_toppings.TabIndex = 1;
            this.lbl_toppings.Text = "Toppings:";
            // 
            // lbl_size
            // 
            this.lbl_size.AutoSize = true;
            this.lbl_size.Font = new System.Drawing.Font("Helvetica Neue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_size.Location = new System.Drawing.Point(25, 46);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(39, 16);
            this.lbl_size.TabIndex = 0;
            this.lbl_size.Text = "Size:";
            // 
            // btn_OrderPizza
            // 
            this.btn_OrderPizza.Font = new System.Drawing.Font("Helvetica Neue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_OrderPizza.Location = new System.Drawing.Point(366, 533);
            this.btn_OrderPizza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_OrderPizza.Name = "btn_OrderPizza";
            this.btn_OrderPizza.Size = new System.Drawing.Size(191, 54);
            this.btn_OrderPizza.TabIndex = 6;
            this.btn_OrderPizza.Text = "Order Pizza";
            this.btn_OrderPizza.UseVisualStyleBackColor = true;
            this.btn_OrderPizza.Click += new System.EventHandler(this.btn_OrderPizza_Click);
            // 
            // btn_ResetForm
            // 
            this.btn_ResetForm.Font = new System.Drawing.Font("Helvetica Neue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ResetForm.Location = new System.Drawing.Point(608, 533);
            this.btn_ResetForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ResetForm.Name = "btn_ResetForm";
            this.btn_ResetForm.Size = new System.Drawing.Size(191, 54);
            this.btn_ResetForm.TabIndex = 7;
            this.btn_ResetForm.Text = "Reset Form";
            this.btn_ResetForm.UseVisualStyleBackColor = true;
            this.btn_ResetForm.Click += new System.EventHandler(this.btn_ResetForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pizza_Project.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1188, 623);
            this.Controls.Add(this.btn_ResetForm);
            this.Controls.Add(this.btn_OrderPizza);
            this.Controls.Add(this.gb_OrderSummary);
            this.Controls.Add(this.gb_WhereToEat);
            this.Controls.Add(this.gb_Toppings);
            this.Controls.Add(this.gb_CurstType);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Helvetica Neue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gb_CurstType.ResumeLayout(false);
            this.gb_CurstType.PerformLayout();
            this.gb_Toppings.ResumeLayout(false);
            this.gb_Toppings.PerformLayout();
            this.gb_WhereToEat.ResumeLayout(false);
            this.gb_WhereToEat.PerformLayout();
            this.gb_OrderSummary.ResumeLayout(false);
            this.gb_OrderSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.GroupBox gb_CurstType;
        private System.Windows.Forms.GroupBox gb_Toppings;
        private System.Windows.Forms.GroupBox gb_WhereToEat;
        private System.Windows.Forms.GroupBox gb_OrderSummary;
        private System.Windows.Forms.Button btn_OrderPizza;
        private System.Windows.Forms.Button btn_ResetForm;
        private System.Windows.Forms.RadioButton rb_large;
        private System.Windows.Forms.RadioButton rb_medium;
        private System.Windows.Forms.RadioButton rb_small;
        private System.Windows.Forms.RadioButton rb_thiccrust;
        private System.Windows.Forms.RadioButton rb_thincrust;
        private System.Windows.Forms.CheckBox chk_greenpappers;
        private System.Windows.Forms.CheckBox chk_olives;
        private System.Windows.Forms.CheckBox chk_onion;
        private System.Windows.Forms.CheckBox chk_tomatoes;
        private System.Windows.Forms.CheckBox chk_mushrooms;
        private System.Windows.Forms.CheckBox chk_extracheese;
        private System.Windows.Forms.RadioButton rb_takeout;
        private System.Windows.Forms.RadioButton rb_eatin;
        private System.Windows.Forms.Label lbl_crusttype;
        private System.Windows.Forms.Label lbl_toppings;
        private System.Windows.Forms.Label lbl_size;
        private System.Windows.Forms.Label lbl_totalprice;
        private System.Windows.Forms.Label lbl_wheretoeat;
        private System.Windows.Forms.Label lbl_toppingsresult;
        private System.Windows.Forms.Label lbl_sizeresult;
        private System.Windows.Forms.Label lbl_totalprice_result;
        private System.Windows.Forms.Label lbl_wheretoeatresult;
        private System.Windows.Forms.Label lbl_crustresult;
    }
}

