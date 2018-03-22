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
            string user_id=null;
            if (!IsPostBack)
            {
                user_id = getUsirId();
                setStudentInfo(user_id);
            }

            setStudentInfo(user_id);

            Database.GetLastReviewsStudent(user_id);


            if (Database.GetLastReviewsStudent(user_id).Rows.Count !=0)
            {
                labelname1.Text = Database.GetLastReviewsStudent(user_id).Rows[0][3].ToString();
                labelname2.Text = Database.GetLastReviewsStudent(user_id).Rows[0][4].ToString();
                labelname3.Text = Database.GetLastReviewsStudent(user_id).Rows[0][0].ToString();
                labelname4.Text = Database.GetLastReviewsStudent(user_id).Rows[0][1].ToString();

                if (Database.GetLastReviewsStudent(user_id).Rows.Count!= 1)
                {
                    labelname5.Text = Database.GetLastReviewsStudent(user_id).Rows[1][3].ToString();
                    labelname6.Text = Database.GetLastReviewsStudent(user_id).Rows[1][4].ToString();
                    labelname7.Text = Database.GetLastReviewsStudent(user_id).Rows[1][0].ToString();
                    labelname8.Text = Database.GetLastReviewsStudent(user_id).Rows[1][1].ToString();
                }
            }

        }
        protected string getUsirId()
        {
            string user_id = "0";

            user_id = Request.QueryString["UserId"];
            if (user_id == null)
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
            return user_id;
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
            string user_id = getUsirId();
            Database.updateStudenProfile(user_id, studentAdressEdit.Value, studentAgeEdit.Value, studentCountryEdit.Value, studentDepartmentEdit.Value
                , studentDescriptionEdit.Value,studentEmailEdit.Value, studentNameEdit.Value, studentPhoneEdit.Value, studentWebsiteEdit.Value, studentSchoolEdit.Value);
            setStudentInfo(user_id);
        }
    }
}