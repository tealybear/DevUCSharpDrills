using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstChallenge
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void uploadButton_Click(object sender, EventArgs e)
        {
            string victimName = nameTextBox.Text;
            string victimIq = iqTextBox.Text;

            string result = "Thank you for your contribution " + victimName + ". Your brain, IQ of " + victimIq + ", will gladly be accepted into our central hivemind. Please wait while your mind is reformatted.";

            resultLabel.Text = result;
        }
    }
}