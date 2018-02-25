using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InternshipER
{
    public partial class createTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(questionType.SelectedItem.Text == "Çoktan Seçmeli")
            {

            }
            else if (questionType.SelectedItem.Text == "Kod")
            {

            }
            else if (questionType.SelectedItem.Text == "Açık Uçlu")
            {

            }
            else if (questionType.SelectedItem.Text == "Ses Kaydı")
            {

            }
        }
    }
}