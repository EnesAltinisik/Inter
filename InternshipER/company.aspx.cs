using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InternshipER.App_Code;

namespace InternshipER
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int user_id=0;
            try
            {
                user_id= int.Parse(Request.QueryString["UserId"]);
            }
            catch (Exception ex)
            {
                //user_id = int.Parse(Session["id"].ToString());
            }
            //getCompanyInfo(user_id);
        }
        protected void getCompanyInfo(int user_id)
        {
            List<String> infos = Database.companyInfo(user_id);
            description.Text = infos[1];
            name.Text = infos[1];
            email.Text = infos[2];
            address.Text = infos[3];
            tel.Text = infos[4];
            website.Text = infos[5];
            title.Text = infos[6];
        }
        protected void updateCompanyProfile(object sender, EventArgs e)
        {
            Database.updateCompanyProfile(int.Parse(Session["Id"].ToString()), companyName.ToString(), companyTitle.ToString(), companyWebsite.ToString(), companyEmail.ToString(), companyDescription.ToString(), companyPhone.ToString(), companyAddress.ToString());
        }

    }
}