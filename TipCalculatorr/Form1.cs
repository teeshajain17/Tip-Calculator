using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculatorr
{
    public partial class TipCalculator : Form
    {
        double billVal=0;
        int tipVal=0;
        int numberOfPeople=0;
        public TipCalculator()
        {
            InitializeComponent();
            DisplayResult();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        double Calculate_Bill(string str)
        {
            if (str == "") return 0;
            return Math.Round(Convert.ToDouble(str),2);
         
            
        }
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
        private void TipPerperson_click(object sender, EventArgs e)
        {
            billVal = Calculate_Bill(txtBill.Text);
            billVal = Math.Round(billVal, 2);

            tipVal = Calculate_TipOrNumberOfPeople(txtTip.Text);


            numberOfPeople = Calculate_TipOrNumberOfPeople(txtNumberOfPeople.Text);
            DisplayResult();
        }

        private void btnTipMinus_Click(object sender, EventArgs e)
        {
            tipVal -= 1;
            if (tipVal < 0) tipVal = 0;
            txtTip.Text = Convert.ToString(tipVal);
            DisplayResult();

        }

        private void btnTipPlus_Click(object sender, EventArgs e)
        {
            tipVal += 1;
            txtTip.Text = Convert.ToString(tipVal);
            DisplayResult();
        }

        private void btnNumberMinus_Click(object sender, EventArgs e)
        {
            numberOfPeople -= 1;
            if (numberOfPeople < 0) numberOfPeople = 0;
            txtNumberOfPeople.Text = Convert.ToString(numberOfPeople);
            DisplayResult();
        }
        private void btnNumberPlus_Click(object sender, EventArgs e)
        {
            numberOfPeople += 1;
            txtNumberOfPeople.Text = Convert.ToString(numberOfPeople);
            DisplayResult();
        }
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

        private void txtBill_TextChanged(object sender, EventArgs e)
        {
            numberOfPeople = Calculate_TipOrNumberOfPeople(txtNumberOfPeople.Text);
            tipVal = Calculate_TipOrNumberOfPeople(txtTip.Text);
            if(tipVal>0 && numberOfPeople > 0)
            {
                billVal = Calculate_Bill(txtBill.Text);
                billVal = Math.Round(billVal, 2);
                if (billVal > 0) DisplayResult();
            }
        }

        private void txtBill_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!char.IsDigit(ch) && ch!=8 && ch != '.')
            {
                e.Handled = true;
            }
        }

        private void txtTip_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch!='%' && ch != '.')
            {
                e.Handled = true;
            }
        }

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
