using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InternshipER.App_Code;

namespace InternshipER
{
    public partial class SiteMaster : MasterPage
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