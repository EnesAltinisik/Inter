using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InternshipER.App_Code;

namespace InternshipER
{
    public partial class studentRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void registerClick_Event(object sender, EventArgs e)
        {
            try
            {
                Database.registerStudent(studentName.Value, userName.Value, psw.Value, email.Value);
                Response.Redirect("login.aspx");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Kayıt Başarısız! Bilgileri kontrol ediniz.')</script>");

            }
        }
        protected void cancelbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
    }
}