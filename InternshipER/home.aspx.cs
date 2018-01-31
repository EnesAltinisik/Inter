using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InternshipER.App_Code;

namespace InternshipER
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            addNews();
        }
        protected void addNews()
        {
            //Populating a DataTable from database.
            System.Data.DataTable dt = Database.GetJob();

            //Building an HTML string.
            StringBuilder html = new StringBuilder();



            //Building the Data rows.
            foreach (System.Data.DataRow row in dt.Rows)
            {
                html.Append("<tr>");
                html.Append("<div class=\"reviews\">");
                html.Append("<div class=\"row blockquote review-item\">");
                html.Append("<div class=\"col-md-3 text-center\">");
                html.Append(" <img class=\"rounded-circle reviewer\" src=\"http://standaloneinstaller.com/upload/avatar.png\">");
                html.Append("<div class=\"caption\">");
                html.Append(" <small>by<a href=\"#joe\"> Joe</a></small>");
                html.Append("</div>");

                html.Append("</div>");
                html.Append("<div class=\"col-md-9\">");
                html.Append(" <h4>My awesome review</h4>");
                html.Append("<div class=\"ratebox text-center\" data-id=\"0\" data-rating=\"5\"></div>");
                html.Append("<p class=\"review-text\">My awesome review.My awesome review. </p>");

                html.Append("<small class=\"review-date\">March 26, 2017</small>");
                html.Append(" </div>");
                html.Append(" </div>");
                html.Append("</div>");
                html.Append("</tr>");
            }

            


            //Append the HTML string to Placeholder.
            newsfeed.Controls.Add(new LiteralControl { Text = html.ToString() });
        }
    }
}