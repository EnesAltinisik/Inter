using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InternshipER.App_Code;

namespace InternshipER
{
    public partial class showTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String test_no = Request.QueryString["test_no"];
            testContext.Controls.Add(new LiteralControl { Text = Database.getTestContext(test_no) });
        }
    }
}