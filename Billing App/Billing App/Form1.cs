using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //Accepting Inputs
            string customer = TxtCustomer.Text;
            double units = Convert.ToDouble(TxtUnits.Text);

            //Calculation
            double bill = units * 23.45;

            //Output
            TxtBill.Text = bill.ToString();

            //Background Colour changing
            if (bill > 5000.0) {
                TxtBill.BackColor = Color.Yellow;
            }
            else if (bill >= 0.00) {
                TxtBill.BackColor = Color.Green;
            }
            else {
                TxtBill.BackColor = Color.Red;
            }

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtCustomer.Clear();
            TxtUnits.Clear();
            TxtBill.Clear();

            TxtBill.BackColor = Color.White;
        }

        private void TxtCustomer_Enter(object sender, EventArgs e)
        {
            TxtCustomer.BackColor = Color.LightBlue;
        }

        private void TxtUnits_Enter(object sender, EventArgs e)
        {
            TxtUnits.BackColor = Color.LightBlue;
        }

        private void TxtCustomer_Leave(object sender, EventArgs e)
        {
            if (TxtCustomer.Text == String.Empty) {
                TxtCustomer.BackColor = Color.Red;
            }
            else {  
                TxtCustomer.BackColor = Color.Green;
            }
        }

        private void TxtUnits_Leave(object sender, EventArgs e)
        {
            double units = 0.00;
            if (Double.TryParse(TxtUnits.Text,out units) == true) {
                if (units < 0.00)
                    TxtUnits.BackColor = Color.Red;
                else
                    TxtUnits.BackColor = Color.Green;
            }
            else {
                TxtUnits.BackColor = Color.Red;
            }
        }
    }
}
