using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class Form1 : Form
    {
        // Enables all pizza option controls.
        public void EnableUI()
        {
            gbSize.Enabled = true;
            gb_CurstType.Enabled = true;
            gb_Toppings.Enabled = true;
            gb_WhereToEat.Enabled = true;

            btn_OrderPizza.Enabled = true;
        }

        // Disables all pizza option controls.
        public void DisableUI()
        {
            gbSize.Enabled = false;
            gb_CurstType.Enabled = false;
            gb_WhereToEat.Enabled = false;
            gb_Toppings.Enabled = false;

            btn_OrderPizza.Enabled = false;

        }

        // Returns the selected toppings as text.
        public string GetCheckedToppings()
        {
            string Toppings = "";

            if (chk_extracheese.Checked)
            {
                Toppings += "Extra Chesse";
            }

            if (chk_mushrooms.Checked)
            {
                Toppings += ", Mushrooms";
            }

            if (chk_tomatoes.Checked)
            {
                Toppings += ", Tomatoes";
            }

            if (chk_onion.Checked)
            {
                Toppings += ", Onions";
            }

            if (chk_olives.Checked)
            {
                Toppings += ", Olives";
            }

            if (chk_greenpappers.Checked)
            {
                Toppings += ", Green Pappers";
            }

            return Toppings;
        }

        // Gets the price of the selected pizza size.
        public float GetSizePrice()
        {
            float TotalPrice = 0;

            if (rb_small.Checked)
            {
                TotalPrice = Convert.ToSingle(rb_small.Tag);
            }

            if (rb_medium.Checked)
            {
                TotalPrice = Convert.ToSingle(rb_medium.Tag);
            }

            if (rb_large.Checked)
            {
                TotalPrice = Convert.ToSingle(rb_large.Tag);
            }

            return TotalPrice;
        }

        // Gets the price of the selected crust type.
        public float GetCurstTypePrice()
        {
            float TotalPrice = 0;

            if (rb_thincrust.Checked)
            {
                TotalPrice = Convert.ToSingle(rb_thincrust.Tag);
            }

            if (rb_thiccrust.Checked)
            {
                TotalPrice = Convert.ToSingle(rb_thiccrust.Tag);
            }

            return TotalPrice;
        }

        // Adds the prices of all selected toppings.
        public float GetToppingsPrice()
        {
            float TotalPrice = 0;

            if (chk_extracheese.Checked)
            {
                TotalPrice += Convert.ToSingle(chk_extracheese.Tag);
            }

            if (chk_mushrooms.Checked)
            {
                TotalPrice += Convert.ToSingle(chk_mushrooms.Tag);
            }

            if (chk_tomatoes.Checked)
            {
                TotalPrice += Convert.ToSingle(chk_tomatoes.Tag);
            }

            if (chk_onion.Checked)
            {
                TotalPrice += Convert.ToSingle(chk_onion.Tag);
            }

            if (chk_olives.Checked)
            {
                TotalPrice += Convert.ToSingle(chk_olives.Tag);
            }

            if (chk_greenpappers.Checked)
            {
                TotalPrice += Convert.ToSingle(chk_greenpappers.Tag);
            }

            return TotalPrice;
        }

        // Calculates the full pizza price.
        public float GetTotalPrice()
        {
            return GetSizePrice() + GetCurstTypePrice() + GetToppingsPrice();
        }

        // Resets all options to their default values.
        public void SetUpToDefaultOptions()
        {
            rb_small.Checked = true;
            
            rb_thincrust.Checked = true;

            rb_eatin.Checked = true;

            chk_extracheese.Checked = true;
            chk_mushrooms.Checked = false;
            chk_olives.Checked = false;
            chk_greenpappers.Checked = false;
            chk_onion.Checked = false;
            chk_tomatoes.Checked = false;
        }

        // Updates the total price label.
        public void UpdateTotalPrice()
        {
            lbl_totalprice_result.Text = "$ " + GetTotalPrice().ToString();
        }

        // Creates the form and loads its controls.
        public Form1()
        {
            InitializeComponent();
        }

        // Handles entering the toppings group box.
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        // Updates the summary when small size is selected.
        private void rb_small_CheckedChanged(object sender, EventArgs e)
        {
            lbl_sizeresult.Text = rb_small.Text;
            UpdateTotalPrice();
        }

        // Updates the summary when medium size is selected.
        private void rb_medium_CheckedChanged(object sender, EventArgs e)
        {
            lbl_sizeresult.Text = rb_medium.Text;
            UpdateTotalPrice();
        }

        // Updates the summary when large size is selected.
        private void rb_large_CheckedChanged(object sender, EventArgs e)
        {
            lbl_sizeresult.Text = rb_large.Text;
            UpdateTotalPrice();
        }

        // Updates the summary when thin crust is selected.
        private void rb_thincrust_CheckedChanged(object sender, EventArgs e)
        {
            lbl_crustresult.Text = rb_thincrust.Text;
            UpdateTotalPrice();
        }

        // Updates the summary when thick crust is selected.
        private void rb_thiccrust_CheckedChanged(object sender, EventArgs e)
        {
            lbl_crustresult.Text = rb_thiccrust.Text;
            UpdateTotalPrice();
        }

        // Updates the summary when eat in is selected.
        private void rb_eatin_CheckedChanged(object sender, EventArgs e)
        {
            lbl_wheretoeatresult.Text = rb_eatin.Text;
            UpdateTotalPrice();
        }

        // Updates the summary when take out is selected.
        private void rb_takeout_CheckedChanged(object sender, EventArgs e)
        {
            lbl_wheretoeatresult.Text = rb_takeout.Text;
            UpdateTotalPrice();
        }

        // Updates toppings and price when extra cheese changes.
        private void chk_extracheese_CheckedChanged(object sender, EventArgs e)
        {
            lbl_toppingsresult.Text = GetCheckedToppings();
            UpdateTotalPrice();
        }

        // Updates toppings and price when mushrooms changes.
        private void chk_mushrooms_CheckedChanged(object sender, EventArgs e)
        {
            lbl_toppingsresult.Text = GetCheckedToppings();
            UpdateTotalPrice();
        }

        // Updates toppings and price when tomatoes changes.
        private void chk_tomatoes_CheckedChanged(object sender, EventArgs e)
        {
            lbl_toppingsresult.Text = GetCheckedToppings();
            UpdateTotalPrice();  
        }

        // Updates toppings and price when onion changes.
        private void chk_onion_CheckedChanged(object sender, EventArgs e)
        {
            lbl_toppingsresult.Text = GetCheckedToppings();
            UpdateTotalPrice();
        }

        // Updates toppings and price when olives changes.
        private void chk_olives_CheckedChanged(object sender, EventArgs e)
        {
            lbl_toppingsresult.Text = GetCheckedToppings();
            UpdateTotalPrice();
        }

        // Updates toppings and price when green peppers changes.
        private void chk_greenpappers_CheckedChanged(object sender, EventArgs e)
        {
            lbl_toppingsresult.Text = GetCheckedToppings();
            UpdateTotalPrice();
        }

        // Handles entering the order summary group box.
        private void gb_OrderSummary_Enter(object sender, EventArgs e)
        {

        }

        // Confirms the pizza order and disables editing.
        private void btn_OrderPizza_Click(object sender, EventArgs e)
        {
            DisableUI();

            if (MessageBox.Show("Are you sure you want this Pizza?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Order Done Successfully!", "Order Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                EnableUI();
            }
        }

        // Resets the form and enables editing again.
        private void btn_ResetForm_Click(object sender, EventArgs e)
        {
            SetUpToDefaultOptions();
            EnableUI();
        }

        // Sets the default selected options when the form loads.
        private void Form1_Load_1(object sender, EventArgs e)
        {
            rb_small.Checked = true;
            rb_thincrust.Checked = true;
            rb_eatin.Checked = true;
        }
    }
}
