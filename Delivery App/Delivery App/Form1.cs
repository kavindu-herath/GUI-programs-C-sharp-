using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delivery_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //Read inputs
            string address = TxtAddress.Text;
            double weight = Convert.ToDouble(TxtWeight.Text);

            //Accepting selected value from combo box
            string branch = CmbBranch.SelectedItem.ToString();

            //Delivery Type
            string type = (RdbSpeed.Checked) ? "speed" : "normal";
            //(<condition> ? <statement if true> : <statement> if false>);

            //Calculation
            double rate = 0.00;
            if (branch == "Colombo") { rate = 450.00;  }
            else if (branch == "Kurunegala" || branch == "Mathara") { rate = 700.00; }
            else { rate = 1200.00; }
            double cost = rate * weight;

            //Adding 1500 if user has selected delivery type as speed
            if (type == "speed") { cost = cost + 1500.00; }

            //Output
            TxtCost.Text = cost.ToString();
        }
    }
}
