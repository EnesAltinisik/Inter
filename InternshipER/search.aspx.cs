using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InternshipER.App_Code;

namespace InternshipER
{
    public partial class searchForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string user_id = "0";

            user_id = Request.QueryString["UserId"];
            if (user_id == null)
            {
                if (Session["id"] != null && !Session["id"].Equals(""))
                {
                    user_id =  Session["id"].ToString();               
                }
                else
                {
                    Response.Redirect("login.aspx");
                }
            }
            string jobid = "0";
            try
            {
                jobid = Request.QueryString["jobid"];
            }
            catch (Exception ex)
            {
                jobid = null;
            }
            if(jobid!=null)
                Database.jobAdd2User(jobid, user_id, "", new DateTime());  /* TODO database sop ve date eklemesi ve mevcutsa silinmesi*/
            if (!this.IsPostBack)
            {
                //Populating a DataTable from database.
                System.Data.DataTable dt = Database.GetJob();

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
                    html.Append("<td>  <a class='btn btn-info btn-xs' href=\"search?UserId=");
                    html.Append(user_id);
                    html.Append("&jobid=");
                    html.Append(row["job_id"]);
                    html.Append("\" >Başvur</a> </td>");
                    html.Append("</tr>");
                }

              
                //Append the HTML string to Placeholder.
                searchTable.Controls.Add(new LiteralControl { Text = html.ToString() });
            }
        }
        protected void jobAdd2User(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string job_id= Request.QueryString["jobid"];
            sop.Value = job_id;
            string user_id = "0";
            try
            {
                user_id = Request.QueryString["UserId"];
            }
            catch (Exception ex)
            {
                user_id = Session["id"].ToString();
            }
            Database.jobAdd2User(job_id,user_id,"",new DateTime());

        }


    }
}