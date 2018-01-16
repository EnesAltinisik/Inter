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
                Page.Title = "Giriş Ekranı";
            }
        }
        protected void registerClick_Event(object sender, EventArgs e)
        {
            Submit1.Text = username.Text;
            Response.Write("<script>alert('Data inserted successfully')</script>");
            Database.registerFirstStep(loginUsername.Value, password.Text, email.Text);
        }

    }
}