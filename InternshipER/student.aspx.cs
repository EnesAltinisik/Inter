using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using InternshipER.App_Code;
using System.Web.UI.WebControls;

namespace InternshipER
{
    public partial class studentForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string user_id = "0";
                try
                {
                    user_id = Request.QueryString["UserId"];
                }
                catch (Exception ex)
                {
                    if (Session["id"] != null && !Session["id"].Equals(""))
                    {
                        user_id = Session["id"].ToString();
                        if (!Database.isStudent(user_id.ToString()))
                        {
                            Response.Redirect("company.aspx");
                        }
                    }
                    else
                    {
                        Response.Redirect("login.aspx");
                    }
                }
                setStudentInfo(user_id);
            }
            
        }
        protected void setStudentInfo(string user_id)
        {
            List<String> infos = Database.studentInfo(user_id);
            if (infos.Count == 0)
                return;
            studentAdress.Text = infos[0];
            studentAge.Text = infos[1];
            studentCountry.Text = infos[2];
            studentDepartment.Text = infos[3];
            studentDescription.Text = infos[4];
            studentEmail.Text = infos[5];
            studentName.Text = infos[6];
            studentPhone.Text = infos[7];
            studentWebsite.Text = infos[8];
            studentSchool.Text = infos[9];

            studentAdressEdit.Value = infos[0];
            studentAgeEdit.Value = infos[1];
            studentCountryEdit.Value = infos[2];
            studentDepartmentEdit.Value = infos[3];
            studentDescriptionEdit.Value = infos[4];
            studentEmailEdit.Value = infos[5];
            studentNameEdit.Value = infos[6];
            studentPhoneEdit.Value = infos[7];
            studentWebsiteEdit.Value = infos[8];
            studentSchoolEdit.Value = infos[9];

        }
        protected void updateStudentProfile(object sender, EventArgs e)
        {
            Database.updateStudenProfile(Request.QueryString["UserId"], studentAdressEdit.Value, studentAgeEdit.Value, studentCountryEdit.Value, studentDepartmentEdit.Value
                , studentDescriptionEdit.Value,studentEmailEdit.Value, studentNameEdit.Value, studentPhoneEdit.Value, studentWebsiteEdit.Value, studentSchoolEdit.Value);
            setStudentInfo(Request.QueryString["UserId"]);
        }
    }
}