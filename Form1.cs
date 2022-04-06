using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurgerStand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Variables
            const double Kids = 3.00;
            const double Small = 4.00;
            const double Medium = 5.00;
            const double Large = 6.00;
            const double Fries = 0;
            const double CurlyFries = 1.00;
            const double TattorTots = .50;
            const double Cheese = .50;
            const double Vegetables = .05;
            const double Condiments = .10;
            const double tax = .10;
            double taxes;
            double totalPrice;
            double addOn = 0;

            // Meal size
            if (rbKids.Checked)
            {
                totalPrice = Kids;
            }

            else
                if (rbSmall.Checked)
            {
                totalPrice = Small;
            }

            else
                if (rbMedium.Checked)
            {
                totalPrice = Medium;
            }

            else
                totalPrice = Large;

            // Sides
            if (rbFries.Checked)
            {
                totalPrice = totalPrice + Fries;
            }

            else
                if (rbCurlyFries.Checked)
            {
                totalPrice = totalPrice + CurlyFries;
            }

            else
                totalPrice = totalPrice + TattorTots;

            //Add-on and condiments
            if (cbCheese.Checked)
            {
                addOn = addOn + Cheese;
            }

            if (cbKetchup.Checked)
            {
                addOn = addOn + Condiments;
            }

            if (cbMustard.Checked)
            {
                addOn = addOn + Condiments;
            }

            if (cbLettuce.Checked)
            {
                addOn = addOn + Vegetables;
            }

            if (cbTomato.Checked)
            {
                addOn = addOn + Vegetables;
            }

            //Total 
            totalPrice = totalPrice + addOn;

            taxes = totalPrice * tax;

            totalPrice = totalPrice + taxes;

            //Output
            label2.Text = "Final Price: " + totalPrice.ToString("C2");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
