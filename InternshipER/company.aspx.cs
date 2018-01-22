using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InternshipER.App_Code;

namespace InternshipER
{
    public partial class companyForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int user_id = 0;
            try
            {
                user_id = int.Parse(Request.QueryString["UserId"]);
            }
            catch (Exception ex)
            {
                user_id = int.Parse(Session["id"].ToString());
            }
            getCompanyInfo(user_id);
            if (!IsPostBack)
            {
                getCompanyInfo(user_id);
            }
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

            companyDescription.Value = infos[1];
            companyName.Value = infos[1];
            companyEmail.Value = infos[2];
            companyAddress.Value = infos[3];
            companyPhone.Value = infos[4];
            companyWebsite.Value = infos[5];
            companyTitle.Value = infos[6];
        }
        protected void updateCompanyProfile(object sender, EventArgs e)
        {
            description.Text = companyTitle.Value;
            Database.updateCompanyProfile(int.Parse(Session["id"].ToString()), companyName.Value, companyTitle.Value, companyWebsite.Value, companyEmail.Value, companyDescription.Value, companyPhone.Value, companyAddress.Value);
        }
        protected void createNewJob(object sender, EventArgs e)
        {
            Database.createNewJob(Session["id"].ToString(), jobTitle.Value, jobDesc.Value, jobLocation.Value, true);
        }

    }
}