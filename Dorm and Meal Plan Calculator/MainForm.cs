using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dorm_and_Meal_Plan_Calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal dormPrice = 0, mealPlanPrice = 0;
            ChargesForm charges = new ChargesForm();

            if (rbtnAllenHall.Checked)
            {
                charges.lblDorm.Text = "Allen Hall";
                charges.lblDormPrice.Text = "$1,500.00";
                dormPrice = 1500;

            }

            if (rbtnPikeHall.Checked)
            {
                charges.lblDorm.Text = "Pike Hall";
                charges.lblDormPrice.Text = "$1,600.00";
                dormPrice = 1600;
            }

            if (rbtnFarthingHall.Checked)
            {
                charges.lblDorm.Text = "Farthing Hall";
                charges.lblDormPrice.Text = "$1,800.00";
                dormPrice = 1800;
            }


            if (rbtnUnivSuites.Checked)
            {
                charges.lblDorm.Text = "University Suites";
                charges.lblDormPrice.Text = "$2,500.00";
                dormPrice = 2500;
            }

            if (!rbtnAllenHall.Checked && !rbtnPikeHall.Checked &&
                !rbtnFarthingHall.Checked && !rbtnUnivSuites.Checked)
            {
                charges.lblDorm.Text = "N/A";
                charges.lblDormPrice.Text = "$0.00";
                dormPrice = 0;
            }

            if (rbtn7Meals.Checked)
            {
                charges.lblMeal.Text = "7 meals per week";
                charges.lblMealPlanPrice.Text = "$600.00";
                mealPlanPrice = 600;
            }

            if (rbtn14Meals.Checked)
            {
                charges.lblMeal.Text = "14 meals per week";
                charges.lblMealPlanPrice.Text = "$1,200.00";
                mealPlanPrice = 1200;
            }

            if (rbtnUnlimited.Checked)
            {
                charges.lblMeal.Text = "Unlimited meals";
                charges.lblMealPlanPrice.Text = "$1,700.00";
                mealPlanPrice = 1700;
            }

            if (!rbtn7Meals.Checked && !rbtn14Meals.Checked &&
                !rbtnUnlimited.Checked)
            {
                charges.lblMeal.Text = "N/A";
                charges.lblMealPlanPrice.Text = "$0.00";
                mealPlanPrice = 0;
            }
            
            // Calculates and displays total charges             
            decimal total = dormPrice + mealPlanPrice;
            charges.lblTotal.Text = string.Format("{0:C}", total);

            // Pops ChargesForm up
            charges.ShowDialog();
        }
        
        // Sets all buttons to unchecked
        private void btnClear_Click(object sender, EventArgs e)
        {
            rbtnAllenHall.Checked = false;
            rbtnPikeHall.Checked = false;
            rbtnFarthingHall.Checked = false;
            rbtnUnivSuites.Checked = false;
            rbtn7Meals.Checked = false;
            rbtn14Meals.Checked = false;
            rbtnUnlimited.Checked = false;            
        }
    }
}
