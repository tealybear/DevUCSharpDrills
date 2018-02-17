using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace simpleCalculator
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int firstNumber = int.Parse(firstNumberTextBox.Text);
            int secondNumber = int.Parse(secondNumberTextBox.Text);
            int result = firstNumber + secondNumber;
            resultLabel.Text = result.ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            double firstNumber = double.Parse(firstNumberTextBox.Text);
            double secondNumber = double.Parse(secondNumberTextBox.Text);
            double result = firstNumber / secondNumber;
            resultLabel.Text = result.ToString();
        }

        protected void subtractButton_Click(object sender, EventArgs e)
        {
            int firstNumber = int.Parse(firstNumberTextBox.Text);
            int secondNumber = int.Parse(secondNumberTextBox.Text);
            int result = firstNumber - secondNumber;
            resultLabel.Text = result.ToString();
        }

        protected void multiplyButton_Click(object sender, EventArgs e)
        {
            int firstNumber = int.Parse(firstNumberTextBox.Text);
            int secondNumber = int.Parse(secondNumberTextBox.Text);
            int result = firstNumber * secondNumber;
            resultLabel.Text = result.ToString();
        }
    }
}