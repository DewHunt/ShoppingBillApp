using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class ShoppingBillUI : Form
    {
        public ShoppingBillUI()
        {
            InitializeComponent();
        }

        private double riceUnit, fishUnit, meatUnit, totalGross, netBill, discount, discountAmount;
        private void totalButton_Click(object sender, EventArgs e)
        {
            riceUnit = Convert.ToDouble(riceUnitTextBox.Text);
            fishUnit = Convert.ToDouble(fishUnitTextBox.Text);
            meatUnit = Convert.ToDouble(meatUnitTextBox.Text);

            totalGross = (riceUnit * 20) + (fishUnit * 80) + (meatUnit * 100);

            totalGrossTextBox.Text = totalGross.ToString();
        }

        private void netBillButton_Click(object sender, EventArgs e)
        {

            if (discountTextBox.Text == "")
            {
                discount = 0;
            }
            else
            {
                discount = Convert.ToDouble(discountTextBox.Text);
            }

            discountAmount = (totalGross * discount) / 100;
            netBill = totalGross - discountAmount;

            netBill = netBill + (totalGross*5)/100;

            MessageBox.Show("Your Net Bill : " + netBill.ToString());
        }
    }
}
