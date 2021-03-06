﻿using Npgsql;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InternshipER.App_Code;
using System.Data;

namespace InternshipER
{
    public partial class companyForm : System.Web.UI.Page
    {
        bool flag;
        protected void Page_Load(object sender, EventArgs e)
        {
            int user_id = getCompanyId();
            getCompanyInfo(user_id);
            //Öğrenci için company sayfasında saklanacak objeler.
            if (Session["id"] != null)
            {
                if (Database.isStudent(Session["id"].ToString()))
                {
                    if (Database.favouriteCheck(Session["id"].ToString(), Request.QueryString["UserId"]))
                    {
                        flag = true;
                        JobOrFav.Text = "Favorilerden Çıkar";
                    }
                    else
                    {
                        flag = false;
                        JobOrFav.Text = "Favorilere Ekle";
                    }
                    postReviewBox.Visible = true;

                }
                else // Şirket için görüntülenme ayarları
                {
                    postReviewBox.Visible = false;
                    JobOrFav.Text = "Yeni İlan";

                }
            }

            if (!IsPostBack)
            {

                DataSet ds = new DataSet();
                DataTable dtFields = new DataTable();
                dtFields.Columns.Add("Id", typeof(int));
                dtFields.Columns.Add("FName", typeof(string));

                //Populating a DataTable from database.
                System.Data.DataTable dt = Database.GetUserInter(user_id + "");
                foreach (System.Data.DataRow row in dt.Rows)
                {
                    dtFields.Rows.Add(row[1], row[0]);
                }
                startInter.DataSource = dtFields;
                startInter.DataTextField = "FName";
                startInter.DataValueField = "Id";
                startInter.DataBind();
                startInter.Items.Insert(0, "Mülakat Baslat");

                DataSet ds1 = new DataSet();
                DataTable dtFields1 = new DataTable();
                dtFields1.Columns.Add("Id", typeof(int));
                dtFields1.Columns.Add("FName", typeof(string));

                //Populating a DataTable from database.
                dt = Database.GetAllUserInter(user_id + "");
                foreach (System.Data.DataRow row in dt.Rows)
                {
                    dtFields1.Rows.Add(row[0], row[1]);
                }
                callInter.DataSource = dtFields1;
                callInter.DataTextField = "FName";
                callInter.DataValueField = "Id";
                callInter.DataBind();
                callInter.Items.Insert(0, "Mülakata Çağır");

                getCompanyInfo(user_id);
                //Populating a DataTable from database.
                System.Data.DataTable dt1 = Database.GetUserJob(user_id);

                //Building an HTML string.
                StringBuilder html = new StringBuilder();



                //Building the Data rows.
                foreach (System.Data.DataRow row in dt1.Rows)
                {
                    html.Append("<tr>");
                    foreach (System.Data.DataColumn column in dt1.Columns)
                    {
                        html.Append("<td>");
                        html.Append(row[column.ColumnName]);
                        html.Append("</td>");
                    }
                    html.Append("<td>  <a class='btn btn-info btn-xs' href=\"search?UserId=");
                    html.Append(user_id);
                    html.Append("&jobid=");
                    html.Append(row["job_id"]);
                    html.Append("\" >Başvur</a> </td>");
                    html.Append("</tr>");
                }


                //Append the HTML string to Placeholder.
                searchTable.Controls.Add(new LiteralControl { Text = html.ToString() });
            }

            ///////////////////////// Row sayisini bul ve yorumlari getirmek icin kullan////////////////////
            Database.GetLastReviews(user_id.ToString());
           /* String connectionString = ConfigurationManager.ConnectionStrings["internshiper"].ConnectionString;
            NpgsqlConnection con = new NpgsqlConnection(connectionString);
            int rowcount = 0;
            using (con)
            {
                using (Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand("SELECT count(*) as total_row_count from review where target=@UserId"))
                {
                    NpgsqlParameter total_row = null;
                    cmd.Parameters.AddWithValue("@UserId", user_id);
                    cmd.Connection = con;
                    cmd.Parameters.TryGetValue("@total_row_count", out total_row);
                    rowcount = (int)total_row.Value;
                    Console.Write(rowcount);
                    con.Open();

                }
            }*/
            if (Database.GetLastReviews(user_id.ToString()).Rows.Count != 0)
            {
                labelname1.Text = Database.GetLastReviews(user_id.ToString()).Rows[0][3].ToString();
                labelname2.Text = Database.GetLastReviews(user_id.ToString()).Rows[0][4].ToString();
                labelname3.Text = Database.GetLastReviews(user_id.ToString()).Rows[0][0].ToString();
                labelname4.Text = Database.GetLastReviews(user_id.ToString()).Rows[0][1].ToString();
                if (Database.GetLastReviews(user_id.ToString()).Rows.Count != 1)
                {
                    labelname5.Text = Database.GetLastReviews(user_id.ToString()).Rows[1][3].ToString();
                    labelname6.Text = Database.GetLastReviews(user_id.ToString()).Rows[1][4].ToString();
                    labelname7.Text = Database.GetLastReviews(user_id.ToString()).Rows[1][0].ToString();
                    labelname8.Text = Database.GetLastReviews(user_id.ToString()).Rows[1][1].ToString();
                }
            }




        }
        protected int getCompanyId()
        {
            int user_id = 0;
            try
            {
                user_id = int.Parse(Request.QueryString["UserId"]);
            }
            catch (Exception ex)
            {
                if (Session["id"] != null && !Session["id"].Equals(""))
                {
                    user_id = int.Parse(Session["id"].ToString());
                    if (Database.isStudent(user_id.ToString()))
                    {
                        Response.Redirect("student.aspx");
                    }
                }
                else
                {
                    Response.Redirect("login.aspx");
                }
            }
            return user_id;
        }
        protected void getCompanyInfo(int user_id)
        {

            //mkutlu düzeltme gerekebilir. 
            List<String> infos = Database.companyInfo(user_id);
            if (infos.Count > 1)
            {
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
            else
            {
                if (Database.isStudent(user_id.ToString()))
                {
                    Response.Redirect("student.aspx");
                }
                else
                {
                    Response.Redirect("company.aspx");
                }
            }
        }
        protected void SaveReviewClick_Event(object sender, EventArgs e)
        {

            int rating = 0;
            if (ratingsHidden == null || ratingsHidden.Value.Equals("")) ;
            else
                rating = int.Parse(ratingsHidden.Value);
            Database.saveEvaluation(Session["id"].ToString(), Request.QueryString["UserId"], reviewTitle.Value, newReview.Value, rating, "");
        }
        protected void updateCompanyProfile(object sender, EventArgs e)
        {
            Database.updateCompanyProfile(getCompanyId(), companyName.Value, companyTitle.Value, companyWebsite.Value, companyEmail.Value, companyDescription.Value, companyPhone.Value, companyAddress.Value);
            getCompanyInfo(getCompanyId());
        }
        protected void createNewJob(object sender, EventArgs e)
        {
            Database.createNewJob(getCompanyId().ToString(), jobTitle.Value, jobDesc.Value, jobLocation.Value, true);
        }
        protected void FavouritesClick_Event(object sender, EventArgs e)
        {
            if (Database.isStudent(Session["id"].ToString()))
            {
                Response.Write("<script>alert('Kayıt Başarısız! Bilgileri kontrol ediniz.')</script>");
                Database.organizeFavourite(Session["id"].ToString(), Request.QueryString["UserId"], flag);
                Response.Redirect(Request.RawUrl);
            }
            else // Şirket için görüntülenme ayarları
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
            }
        }

        protected void callInterView(object sender, EventArgs e)
        {
            if (Database.isStudent(Session["id"].ToString()))
            {
                Response.Write("<script>alert('Kayıt Başarısız! Bilgileri kontrol ediniz.')</script>");
                Database.organizeFavourite(Session["id"].ToString(), Request.QueryString["UserId"], flag);
                Response.Redirect(Request.RawUrl);
                return;
            }

            string student_id = callInter.SelectedValue + "";
            if (startInter.SelectedValue.Equals("0"))
                return;
            string mesaj = mülakatDate.Value + " Tarihinde video mülakatınız vardır.  ";
            JobOrFav.Text = mesaj + student_id;
            Database.createMessage(student_id, getCompanyId() + "", mesaj);
            Database.createInterview(student_id, getCompanyId() + "");

        }
        protected void startInterview(object sender, EventArgs e)
        {
            if (Database.isStudent(Session["id"].ToString()))
            {
                Response.Write("<script>alert('Kayıt Başarısız! Bilgileri kontrol ediniz.')</script>");
                Database.organizeFavourite(Session["id"].ToString(), Request.QueryString["UserId"], flag);
                Response.Redirect(Request.RawUrl);
                return;
            }

            string student_id = startInter.SelectedValue + "";
            if (startInter.SelectedValue.Equals("0"))
                return;
            string baglantı = "https://appr.tc/r/" + new Random().Next(1, 10000000);
            string mesaj = "Mülakat linkiniz: " + baglantı;
            Database.createMessage(student_id, getCompanyId() + "", mesaj);
            Page.ClientScript.RegisterStartupScript(
            this.GetType(), "OpenWindow", "window.open('" + baglantı + "','_newtab');", true);

        }


    }
}