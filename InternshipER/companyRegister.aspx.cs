using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InternshipER.App_Code;

namespace InternshipER
{
    public partial class companyLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void registerClick_Event(object sender, EventArgs e)
        {
        
            Response.Write("<script>alert('Data inserted successfully')</script>");
            Database.registerCompany(companyName.Value, userName.Value, psw.Value, email.Value);
        }
    }
}