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
                    html.Append("</tr>");
                }

              
                //Append the HTML string to Placeholder.
                searchTable.Controls.Add(new Literal { Text = html.ToString() });
            }
        }


    }
}