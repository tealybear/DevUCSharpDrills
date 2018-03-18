using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_019_Challenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                myCalendar1.SelectedDate = DateTime.Now.Date;
                myCalendar2.SelectedDate = DateTime.Now.Date.AddDays(14);
                myCalendar3.SelectedDate = DateTime.Now.Date.AddDays(21);
            }
        }

        protected void myButton_Click(object sender, EventArgs e)
        {
            TimeSpan totalDuration = myCalendar3.SelectedDate.Subtract(myCalendar2.SelectedDate);
            double budgetTotal = totalDuration.TotalDays * 500.0;

            if (totalDuration.TotalDays > 21)
            {
                budgetTotal += 1000.0;
            }

            resultLabel.Text = String.Format("Assignment of {0} to assignment {1} is authorized. Budget total: {2:C}", 
                myTextBox1, myTextBox2, budgetTotal);


            TimeSpan lapseOfEmployment = myCalendar2.SelectedDate.Subtract(myCalendar1.SelectedDate);
            if (lapseOfEmployment.TotalDays < 14)
            {
                resultLabel.Text = "Error: Must allow atleast two weeks between previous assignment and new assignment.";

                DateTime soonestAvailable = myCalendar1.SelectedDate.AddDays(14);

                myCalendar2.SelectedDate = soonestAvailable;
                myCalendar2.VisibleDate = soonestAvailable;
            }  
        }

        protected void myCalendar2_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}