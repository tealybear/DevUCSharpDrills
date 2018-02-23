using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeFirstPapaBobsWebsite
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double total;
            if (sizeRadio1.Checked)
            {
                total = 10.00;
            }
            else if (sizeRadio2.Checked)
            {
                total = 13.00;
            }
            else 
                total = 16.00;

            if (crustRadio2.Checked)
                total =+ 2.00;

            total = (pepperoniCheckBox.Checked) ? total + 1.50 : total;
            total = (onionCheckBox.Checked) ? total + .75 : total;
            total = (greenpeppersCheckBox.Checked) ? total + .50 : total;
            total = (redpeppersCheckBox.Checked) ? total + .75 : total;
            total = (anchoviesCheckBox.Checked) ? total + 2.00 : total;

            if ((pepperoniCheckBox.Checked 
                && greenpeppersCheckBox.Checked 
                && anchoviesCheckBox.Checked) 
                || (pepperoniCheckBox.Checked 
                && redpeppersCheckBox.Checked 
                && onionCheckBox.Checked))
            {
                total = total - 2.00;
            }

            totalLabel.Text = "$" + total.ToString();

            
        }
    }
}