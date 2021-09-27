using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace electriccompanychargingmodel
{
    public partial class FrmElectrcCharge : Form
    {
        public FrmElectrcCharge()
        {
            InitializeComponent();
        }
        //An electric company measures the amount of electricity its customer use in kilowatt hours(kwh) and charges them
        //according to the following schedule:
        //first 12 kwh or less $2.80
        //next 78 kwh 8 cents each kwh
        //excess above 90 kwh 6 cents each kwh
        //Note that the minimum bill is $2.80. Write a program to calculate a customers bill.

        int electric = 0;
        double charge = 0;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            electric = int.Parse(txtChargeBox.Text);
            if(electric <= 12)
            {
                charge = 2.80;
                string formattedMoneyValue = String.Format("{0:C2}", charge);
                lblResult.Text = "Your charge is " + formattedMoneyValue;
                lblResult.Visible = true;
            }
            else if(electric >12 && electric <= 90)
            {

                charge = ((electric - 12) * 0.08) + 2.80;
                string formattedMoneyValue = String.Format("{0:C2}", charge);
                lblResult.Text = "Your charge is " + formattedMoneyValue;
                lblResult.Visible = true;
            }
            else if(electric > 90)
            {
                charge = (78 * 0.08) + ((electric - 90) * 0.06) + 2.80;
                string formattedMoneyValue = String.Format("{0:C2}", charge);
                lblResult.Text = "Your charge is " + formattedMoneyValue;
                lblResult.Visible = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtChargeBox.Text = "";
        }
    }
}
