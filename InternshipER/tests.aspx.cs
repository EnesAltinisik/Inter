using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InternshipER.App_Code;

namespace InternshipER
{
    public partial class tests : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = Database.getTests(Session["id"].ToString());
            StringBuilder html = new StringBuilder();

            //foreach (System.Data.DataRow row in dt.Rows)
            //{
            //    html.Append("<tr>");
            //    foreach (System.Data.DataColumn column in dt.Columns)
            //    {
            //        html.Append("<td>");
            //        html.Append(row[column.ColumnName]);
            //        html.Append("</td>");
            //    }
            //    html.Append("</tr>");
            //}

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                html.Append("<tr>");
                for (int j=0; j< dt.Columns.Count; j++)
                {
                    html.Append("<td>");
                    html.Append(dt.Rows[i][j]);
                    html.Append("</td>");
                }
                html.Append("</tr>");
            }

            //Append the HTML string to Placeholder.
            testTable.Controls.Add(new LiteralControl { Text = html.ToString() });
        }
        protected void testClick_Event(object sender, EventArgs e)
        {
            Response.Redirect("createTest.aspx");
        }
    }
}