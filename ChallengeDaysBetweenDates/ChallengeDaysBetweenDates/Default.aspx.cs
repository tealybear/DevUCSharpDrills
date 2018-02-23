using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeDaysBetweenDates
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            if (calendar1.SelectedDate > calendar2.SelectedDate)
            {
                resultLabel.Text = calendar1.SelectedDate
                    .Subtract(calendar2.SelectedDate)
                    .TotalDays.ToString() + " days between those dates";
            }
            else
            {
                resultLabel.Text = calendar2.SelectedDate
                    .Subtract(calendar1.SelectedDate)
                    .TotalDays.ToString() + " days between those dates";
            }
        }
    }
}