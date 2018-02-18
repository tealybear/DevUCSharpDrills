using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeConditionalRadioButton
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            /*if (pencilRadio.Checked)
                resultLabel.Text = "You selected Pencil";
            else if (penRadio.Checked)
                resultLabel.Text = "You selected Pen";
            else if (phoneRadio.Checked)
                resultLabel.Text = "You selected Phone";
            else if (tabletRadio.Checked)
                resultLabel.Text = "You selected Tablet";
            else
                resultLabel.Text = "Please select an item";*/

            if (pencilRadio.Checked)
            {
                resultImage.ImageUrl = "pencil.png";
                resultLabel.Text = "You selected Pencil";
            }
            else if (penRadio.Checked)
            {
                resultImage.ImageUrl = "pen.png";
                resultLabel.Text = "You selected Pen";
            }
            else if (phoneRadio.Checked)
            {
                resultImage.ImageUrl = "phone.png";
                resultLabel.Text = "You selected Phone";
            }
            else if (tabletRadio.Checked)
            {
                resultImage.ImageUrl = "tablet.png";
                resultLabel.Text = "You selected Tablet";
            }
            else
                resultLabel.Text = "Please select an item";

        }

        protected void pencilRadio_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}