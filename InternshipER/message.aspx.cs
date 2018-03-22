using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InternshipER.App_Code;

namespace InternshipER
{
    public partial class messageForm : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            addMessage();
        }
        protected void addMessage()
        {
            string user_id = "0";

            user_id = Request.QueryString["UserId"];
            if (user_id == null)
            {
                if (Session["id"] != null && !Session["id"].Equals(""))
                {
                    user_id = Session["id"].ToString();
                }
                else
                {
                    Response.Redirect("login.aspx");
                }
            }
            //Populating a DataTable from database.
            System.Data.DataTable dt = Database.GetMessage(user_id);

            //Building an HTML string.
            StringBuilder html = new StringBuilder();



            //Building the Data rows.
            foreach (System.Data.DataRow row in dt.Rows)
            {
                html.Append("<tr>");
                foreach (System.Data.DataColumn column in dt.Columns)
                {
                    html.Append("<td>");
                    html.Append(row[column.ColumnName]);
                    html.Append("</td>");
                }
                html.Append("</tr>");
            }


            //Append the HTML string to Placeholder.
            messageTable.Controls.Add(new Literal { Text = html.ToString() });
        }
    }
}