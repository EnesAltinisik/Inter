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
        public static String test_no;
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
                    if (j == 0)
                        test_no = dt.Rows[i][j].ToString();
                    else
                    {
                        html.Append("<td>");
                        html.Append("<a href = \"showTest?test_no=" + test_no + "\">");
                        html.Append("<div style = \"height:100%;width:100%\">");
                        html.Append(dt.Rows[i][j]);
                        html.Append("</div>");
                        html.Append("</a>");
                        html.Append("</td>");
                    }
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