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
    public partial class jobAds : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //buildnewline her şirketin ilanı için çağırılacak.
            DataTable dt = Database.GetUserJobWithTitleAndLocation(int.Parse(Session["id"].ToString()));
            int m = 0;
            foreach (System.Data.DataRow row in dt.Rows)
            {
                String[] list = new String[3];
                int i = 0;
                foreach (System.Data.DataColumn column in dt.Columns)
                {
                    list[i] = row[column.ColumnName].ToString();
                    i++;
                }
                openAds.Controls.Add(new LiteralControl { Text = buildNewLine(list[0], list[1],list[2],m).ToString() });
                i = 0;
                m++;
            }
            m = 0;
        }
        protected StringBuilder buildNewLine(String JobTitle, String Location, String jobId,int num)
        {
            
            StringBuilder html2 = new StringBuilder();
            html2.Append("<div class=\"panel panel - default\">");
            html2.Append("<div class=\"panel-heading\">");
            html2.Append("<h4 class=\"panel - title\">");
            html2.Append("<a class=\"accordion - toggle\" data-toggle=\"collapse\" data-parent=\"#accordion\" href=\"#collapse"+num+"\">"+JobTitle+" - "+Location+"</a>");//ilanın başlığı yazılacak parametrelerle
            html2.Append("</h4>");
            html2.Append("</div>");
            html2.Append("<div id = \"collapse" + num + "\" class=\"panel - collapse collapse\">");
            html2.Append("<div class=\"panel - body\">");
            html2.Append("");// Başvuranların iplement edilmesi
            html2.Append("<table  class=\"table table-striped custab table-list-search\">");
            html2.Append("<thead>");
            html2.Append("<tr>");
            html2.Append("<th>#</th>");
            html2.Append("<th> İsim </th>");
            html2.Append("<th> Email </th>");
            html2.Append("<th> Okul </th>");
            html2.Append("<th> Bölüm </th>");
            html2.Append("<th class=\"text-center\"></th>");
            html2.Append("</tr>");
            html2.Append("</thead>");
            html2.Append("<tbody>");
            DataTable dt = Database.GetJobsAttendees(jobId);

            //Building the Data rows.
            foreach (System.Data.DataRow row in dt.Rows)
            {
                html2.Append("<tr>");
                foreach (System.Data.DataColumn column in dt.Columns)
                {
                    html2.Append("<td>");
                    html2.Append(row[column.ColumnName]);
                    html2.Append("</td>");
                }
                //if (param == null)
                //{
                //    html.Append("<td>  <a class='btn btn-info btn-xs' href=\"search?UserId=");
                //    //html.Append(user_id);
                //    html.Append("&jobid=");
                //    html.Append(row["job_id"]);
                //    html.Append("\" >Başvur</a> </td>");

                //}

                html2.Append("</tr>");
            }
            html2.Append("</tbody>");
            html2.Append("</table>");
            html2.Append("</div>");
            html2.Append("</div>");
            html2.Append("</div>");
            return html2;
        }
    }
   
}