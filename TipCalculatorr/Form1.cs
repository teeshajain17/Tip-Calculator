using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



/*  TIP CALCULATOR ASSIGNMENT MADE BY TEESHA JAIN FOR GRAPECITY*/

namespace TipCalculatorr
{
    public partial class TipCalculator : Form
    {
        // Initialising variables to store values
        double billVal=0;
        int tipVal=0;
        int numberOfPeople=0;
        // After opening the calculator it must display the default values
        public TipCalculator()
        {
            InitializeComponent();
            DisplayResult();
        }
        //Method to calulate bill value from the input string
        double Calculate_Bill(string str)
        {
            if (str == "") return 0;
            return Math.Round(Convert.ToDouble(str),2);
         
            
        }
        //Common method to calculate Tip % or Number of People
        int Calculate_TipOrNumberOfPeople(string str)
        {
            
                if (str == "") return 0;
            int i = 0,n = str.Length;
            string ans = "";
            while (i<n && str[i]>= '0' && str[i]<='9')
            {
                ans += str[i];i++;
            }
            if (ans == "") return 0;
                return Convert.ToInt32(ans);
           
        }
        //Method to calculate Tip per person
        double Calculate_TipPerPerson(double bill, int tip, int number)
        {
            double tipPerPerson = (bill * tip) / 100;
            if (number != 0)
            {
                tipPerPerson /= number;
            }
            else
            {
                tipPerPerson = 0;
            }
            return Math.Round(tipPerPerson, 2);

        }
        double Calculate_TotalPerPerson(double bill, int tip, int number)
        {
            double total = (bill * tip) / 100 + bill;
            if (number != 0)
            {
                total /= number;
            }
            else
            {
                total = 0;
            }
            return Math.Round(total, 2);
        }

        // Method to display values on click 
        private void TipPerperson_click(object sender, EventArgs e)
        {
            billVal = Calculate_Bill(txtBill.Text);
            billVal = Math.Round(billVal, 2);

            tipVal = Calculate_TipOrNumberOfPeople(txtTip.Text);


            numberOfPeople = Calculate_TipOrNumberOfPeople(txtNumberOfPeople.Text);
            DisplayResult();
        }
        // Method to define the functioning of Minus button on Tip%

        private void btnTipMinus_Click(object sender, EventArgs e)
        {
            tipVal -= 1;
            if (tipVal < 0) tipVal = 0;
            txtTip.Text = Convert.ToString(tipVal);
            DisplayResult();

        }
        // Method to define the functioning of Plus button on Tip%

        private void btnTipPlus_Click(object sender, EventArgs e)
        {
            tipVal += 1;
            txtTip.Text = Convert.ToString(tipVal);
            DisplayResult();
        }

        // Method to define the functioning of Minus button on Number of People
        private void btnNumberMinus_Click(object sender, EventArgs e)
        {
            numberOfPeople -= 1;
            if (numberOfPeople < 0) numberOfPeople = 0;
            txtNumberOfPeople.Text = Convert.ToString(numberOfPeople);
            DisplayResult();
        }

        //Method to define the functioning of Plus button on Number of People
        private void btnNumberPlus_Click(object sender, EventArgs e)
        {
            numberOfPeople += 1;
            txtNumberOfPeople.Text = Convert.ToString(numberOfPeople);
            DisplayResult();
        }

        // Function to display values after calculation
        void DisplayResult()
        {
            
            txtTipPerPerson.Text = "$" + Convert.ToString(Calculate_TipPerPerson(billVal, tipVal, numberOfPeople));
            txtTotalPerPerson.Text = "$" +
                Convert.ToString(Calculate_TotalPerPerson(billVal, tipVal, numberOfPeople));
            txtBill.Text = Convert.ToString(billVal);
            if (txtTip.Text == "0") txtTip.Clear(); 
            else
                txtTip.Text = Convert.ToString(tipVal) + "%";
            txtNumberOfPeople.Text = Convert.ToString(numberOfPeople);


        }

        // Method to display values when text changes on the textbox which contains number of people

        private void txtNumberOfPeople_TextChanged(object sender, EventArgs e)
        {
            billVal = Calculate_Bill(txtBill.Text);
            billVal = Math.Round(billVal, 2);

            tipVal = Calculate_TipOrNumberOfPeople(txtTip.Text);
            if (billVal > 0 && tipVal > 0)
            {

                numberOfPeople = Calculate_TipOrNumberOfPeople(txtNumberOfPeople.Text);
                if(numberOfPeople!=0)
                DisplayResult();
            }
        }

        // Method to display values when text changes on the textbox which contains tip %
        private void txtTip_TextChanged(object sender, EventArgs e)
        {
            
          billVal = Calculate_Bill(txtBill.Text);
          billVal = Math.Round(billVal, 2);
          numberOfPeople = Calculate_TipOrNumberOfPeople(txtNumberOfPeople.Text);
          
            if (billVal>0 && numberOfPeople > 0) { 
            tipVal = Calculate_TipOrNumberOfPeople(txtTip.Text);
                if(tipVal!=0)
                    DisplayResult();
            }
        }

        // Method to take proper input on bill box
        private void txtBill_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            char ch = e.KeyChar;
            if(!char.IsDigit(ch) && ch!=8 && ch != '.')
            {
                e.Handled = true;
            }
        }

        // Method to take proper input on tip % box
        private void txtTip_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch!='%')
            {
                e.Handled = true;
            }
        }
        // Method to take proper input on number of people box
        private void txtNumberOfPeople_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
    } 
