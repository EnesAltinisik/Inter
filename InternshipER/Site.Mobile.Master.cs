using InternshipER.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InternshipER
{
    public partial class Site_Mobile : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((bool)Session["loginPage"])
            {
                rightMenu.Visible = false;
            }
            else
            {
                rightMenu.Visible = true;
            }
            if (Session["id"] != null)
            {
                if (Database.isStudent(Session["id"].ToString()))
                {
                    jobReq.Visible = true;
                }
                else
                {
                    jobReq.Visible = false;
                }
            }
            if (!this.IsPostBack)
            {
                if (Session["id"] != null)
                {
                    System.Data.DataTable dt = Database.GetAssignedJobs(Session["id"].ToString());
                    StringBuilder html = new StringBuilder();
                    foreach (System.Data.DataRow row in dt.Rows)
                    {
                        html.Append("<tr>");
                        foreach (System.Data.DataColumn column in dt.Columns)
                        {
                            html.Append("<td>");
                            html.Append(row[column.ColumnName]);
                            html.Append("</td>");
                        }
                        html.Append("<td>  <a class='btn btn-info btn-xs' href=\"search?UserId=");
                        html.Append(Session["id"].ToString());
                        html.Append("&jobid=");
                        html.Append(row["job_id"]);
                        html.Append("\" >Ýptal</a> </td>");
                        html.Append("</tr>");
                    }


                    //Append the HTML string to Placeholder.
                    jobReqTable.Controls.Add(new LiteralControl { Text = html.ToString() });
                }
            }
        }
        protected void profileClick_Event(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Session["id"] as string))
            {
                if (Database.isStudent(Session["id"].ToString()))
                {
                    Response.Redirect("student.aspx");
                }
                else
                {
                    Response.Redirect("company.aspx");
                }
            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }
        protected void logout_Event(object sender, EventArgs e)
        {
            Session["id"] = null;
            Response.Redirect("login.aspx");
        }
    }
}