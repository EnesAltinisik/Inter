using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using InternshipER.App_Code;

namespace InternshipER
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["loginPage"] = true;
                Page.Title = "Giriş Ekranı";
            }

        }
        protected void loginClick_Event(object sender, EventArgs e)
        {
            if (Database.loginAttempt(loginUsername.Value, loginPassword.Value) == true)
            {
                Session["id"] = Database.getUserId(loginUsername.Value, loginPassword.Value);
                Session["loginPage"] = false;
                Response.Redirect("home.aspx");
            }
            else
            {
                Response.Write("<script>alert('Giriş Bilgilerini kontrol ediniz!')</script>");
            }
        }

    }
}