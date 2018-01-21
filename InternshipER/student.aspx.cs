using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using InternshipER.App_Code;
using System.Web.UI.WebControls;

namespace InternshipER
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            int user_id=1;
            try
            {
                user_id = int.Parse(Request.QueryString["UserId"]);
            }
            catch (Exception ex)
            {
            }
            setStudentInfo(user_id);
        }
        protected void setStudentInfo(int user_id)
        {
            List<String> infos = Database.studentInfo(user_id);
            studentAdress.Text = infos[0];
            studentAge.Text = infos[1];
            studentCountry.Text = infos[2];
            studentDepartment.Text = infos[3];
            studentDescription.Text = infos[4];
            studentEmail.Text = infos[5];
            studentName.Text = infos[6];
            studentPhone.Text = infos[7];
            studentWebsite.Text = infos[8];
        }
        protected void updateStudentProfile(object sender, EventArgs e)
        {
            Database.updateStudenProfile(int.Parse(Request.QueryString["UserId"]), studentAdressEdit.Value, studentAgeEdit.Value, studentCountryEdit.Value, studentDepartmentEdit.Value
                , studentDescriptionEdit.Value,studentEmailEdit.Value, studentNameEdit.Value, studentPhoneEdit.Value, studentWebsiteEdit.Value);
            setStudentInfo(int.Parse(Request.QueryString["UserId"]));
        }
    }
}