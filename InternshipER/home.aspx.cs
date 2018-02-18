using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InternshipER.App_Code;

namespace InternshipER
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            addNews();
        }
        protected void addNews()
        {
            String sender_image = "";
            String sender_url = "";
            String sender = "";
            String title = "";
            String rating = "";
            String content = "";

            //Populating a DataTable from database.
            System.Data.DataTable dt_Review = Database.GetHomeStream()[0];
            System.Data.DataTable dt_Job = Database.GetHomeStream()[1];
            int bound,max;
            bool flag = false;
            if (dt_Review.Rows.Count <= dt_Job.Rows.Count)
            {
                bound = dt_Review.Rows.Count;
                max = dt_Job.Rows.Count;
                flag = true;
            }
            else
            {
                bound = dt_Job.Rows.Count;
                max = dt_Review.Rows.Count;
            }
            //Building an HTML string.

            StringBuilder html = new StringBuilder();


            int pointer_job = 0;
            int pointer_review = 0;

            //Building the Data rows.
            if (bound > 10)
            {
                for (int i = 0; i < 10; i++)
                {

                    if (flag)
                    {
                        System.Diagnostics.Debug.WriteLine("*****************" + dt_Job.Rows.Count);
                        System.Diagnostics.Debug.WriteLine("*****************" + dt_Job.Rows[pointer_job].ItemArray[0]);
                        if (DateTime.Parse(dt_Job.Rows[pointer_job].ItemArray[0].ToString()) > DateTime.Parse(dt_Review.Rows[pointer_review].ItemArray[0].ToString()))
                        {
                            sender_url = "/company.aspx?userid=" + dt_Job.Rows[pointer_job][1].ToString();
                            sender = Database.companyInfo(int.Parse(dt_Job.Rows[pointer_job][1].ToString()))[1];
                            title = dt_Job.Rows[pointer_job].ItemArray[2].ToString();
                            content = dt_Job.Rows[pointer_job].ItemArray[3].ToString();
                            pointer_job++;
                        }
                        else
                        {
                            if (Database.isStudent(dt_Review.Rows[pointer_review][1].ToString()))
                            {
                                sender_url = "/student.aspx?userid=" + dt_Review.Rows[pointer_review][1].ToString();
                                sender = Database.studentInfo(dt_Review.Rows[pointer_review].ItemArray[1].ToString())[6];
                            }
                            else
                            {
                                sender_url = "/company.aspx?userid=" + dt_Review.Rows[pointer_review][1].ToString();
                                sender = Database.companyInfo(int.Parse(dt_Review.Rows[pointer_review].ItemArray[1].ToString()))[6];
                            }
                            title = dt_Review.Rows[pointer_review].ItemArray[3].ToString();
                            content = dt_Review.Rows[pointer_review].ItemArray[4].ToString();
                            pointer_review++;

                        }
                    }



                    html.Append("<tr> ");
                    html.Append("<div class=\"reviews\"> ");
                    html.Append("<div class=\"row blockquote review-item\"> ");
                    html.Append("<div class=\"col-md-3 text-center\"> ");
                    html.Append("<img class=\"rounded-circle reviewer\" src=\"" + sender_image + "\"> ");
                    html.Append("<div class=\"caption\"> ");
                    html.Append("<small>by<a href=\"" + sender_url + "\">" + sender + "</a></small> ");
                    html.Append("</div> ");

                    html.Append("</div> ");
                    html.Append("<div class=\"col-md-9\"> ");
                    html.Append(" <h4>" + title + "</h4> ");
                    html.Append("<div class=\"ratebox text-center\" data-id=\"0\" data-rating=\"" + rating + "\"></div> ");
                    html.Append("<p class=\"review-text\"> " + content + "</p> ");

                    html.Append("<small class=\"review-date\"> March 26, 2017 </small> ");
                    html.Append(" </div> ");
                    html.Append(" </div> ");
                    html.Append("</div> ");
                    html.Append("</tr> ");
                }
                //Append the HTML string to Placeholder.
                newsfeed.Controls.Add(new LiteralControl { Text = html.ToString() });
            }
                
            else
            {
                for (int i = 0; i < bound; i++)
                {
                        System.Diagnostics.Debug.WriteLine("*****************" + dt_Job.Rows.Count);
                        System.Diagnostics.Debug.WriteLine("*****************" + dt_Job.Rows[pointer_job].ItemArray[0]);
                        if (DateTime.Parse(dt_Job.Rows[pointer_job].ItemArray[0].ToString()) > DateTime.Parse(dt_Review.Rows[pointer_review].ItemArray[0].ToString()))
                        {
                            sender_url = "/company.aspx?userid=" + dt_Job.Rows[pointer_job][1].ToString();
                            sender = Database.companyInfo(int.Parse(dt_Job.Rows[pointer_job][1].ToString()))[1];
                            content = dt_Job.Rows[pointer_job].ItemArray[3].ToString();
                            title = dt_Job.Rows[pointer_job].ItemArray[2].ToString();
                            pointer_job++;
                        }
                        else
                        {
                            if (Database.isStudent(dt_Review.Rows[pointer_review][1].ToString()))
                            {
                                sender_url = "/student.aspx?userid=" + dt_Review.Rows[pointer_review][1].ToString();
                                sender = Database.studentInfo(dt_Review.Rows[pointer_review].ItemArray[1].ToString())[6];
                            }
                            else
                            {
                                sender_url = "/company.aspx?userid=" + dt_Review.Rows[pointer_review][1].ToString();
                                sender = Database.companyInfo(int.Parse(dt_Review.Rows[pointer_review].ItemArray[1].ToString()))[6];
                            }
                            title = dt_Review.Rows[pointer_review].ItemArray[3].ToString();
                            content = dt_Review.Rows[pointer_review].ItemArray[4].ToString();
                        pointer_review++;

                        }
                    
                    html.Append("<tr> ");
                    html.Append("<div class=\"reviews\"> ");
                    html.Append("<div class=\"row blockquote review-item\"> ");
                    html.Append("<div class=\"col-md-3 text-center\"> ");
                    html.Append("<img class=\"rounded-circle reviewer\" src=\"" + sender_image + "\"> ");
                    html.Append("<div class=\"caption\"> ");
                    html.Append("<small>by<a href=\"" + sender_url + "\">" + sender + "</a></small> ");
                    html.Append("</div> ");

                    html.Append("</div> ");
                    html.Append("<div class=\"col-md-9\"> ");
                    html.Append(" <h4>" + title + "</h4> ");
                    html.Append("<div class=\"ratebox text-center\" data-id=\"0\" data-rating=\"" + rating + "\"></div> ");
                    html.Append("<p class=\"review-text\"> " + content + "</p> ");

                    html.Append("<small class=\"review-date\"> March 26, 2017 </small> ");
                    html.Append(" </div> ");
                    html.Append(" </div> ");
                    html.Append("</div> ");
                    html.Append("</tr> ");
                }
                if (flag) //fill left job
                {
                    for (int i = 0; i < max-bound; i++)
                    {
                        System.Diagnostics.Debug.WriteLine("*****************" + dt_Job.Rows.Count);
                        System.Diagnostics.Debug.WriteLine("*****************" + dt_Job.Rows[pointer_job].ItemArray[0]);

                        sender_url = "/company.aspx?userid=" + dt_Job.Rows[pointer_job][1].ToString();
                        sender = Database.companyInfo(int.Parse(dt_Job.Rows[pointer_job][1].ToString()))[1];
                        title = dt_Job.Rows[pointer_job].ItemArray[2].ToString();
                        content = dt_Job.Rows[pointer_job].ItemArray[3].ToString();
                        pointer_job++;
                        html.Append("<tr> ");
                        html.Append("<div class=\"reviews\"> ");
                        html.Append("<div class=\"row blockquote review-item\"> ");
                        html.Append("<div class=\"col-md-3 text-center\"> ");
                        html.Append("<img class=\"rounded-circle reviewer\" src=\"" + sender_image + "\"> ");
                        html.Append("<div class=\"caption\"> ");
                        html.Append("<small>by<a href=\"" + sender_url + "\">" + sender + "</a></small> ");
                        html.Append("</div> ");

                        html.Append("</div> ");
                        html.Append("<div class=\"col-md-9\"> ");
                        html.Append(" <h4>" + title + "</h4> ");
                        html.Append("<div class=\"ratebox text-center\" data-id=\"0\" data-rating=\"" + rating + "\"></div> ");
                        html.Append("<p class=\"review-text\"> " + content + "</p> ");

                        html.Append("<small class=\"review-date\"> March 26, 2017 </small> ");
                        html.Append(" </div> ");
                        html.Append(" </div> ");
                        html.Append("</div> ");
                        html.Append("</tr> ");
                    }
                }
                else //fill review
                {
                    for (int i = 0; i < max - bound; i++)
                    {
                        System.Diagnostics.Debug.WriteLine("*****************" + dt_Job.Rows.Count);
                        System.Diagnostics.Debug.WriteLine("*****************" + dt_Job.Rows[pointer_job].ItemArray[0]);

                        if (Database.isStudent(dt_Review.Rows[pointer_review][1].ToString()))
                        {
                            sender_url = "/student.aspx?userid=" + dt_Review.Rows[pointer_review][1].ToString();
                            sender = Database.studentInfo(dt_Review.Rows[pointer_review][1].ToString())[6];
                        }
                        else
                        {
                            sender_url = "/company.aspx?userid=" + dt_Review.Rows[pointer_review][1].ToString();
                            sender = Database.companyInfo(int.Parse(dt_Review.Rows[pointer_review][1].ToString()))[6];
                        }
                        title = dt_Review.Rows[pointer_review].ItemArray[3].ToString();
                        content = dt_Review.Rows[pointer_review].ItemArray[4].ToString();
                        pointer_job++;
                        html.Append("<tr> ");
                        html.Append("<div class=\"reviews\"> ");
                        html.Append("<div class=\"row blockquote review-item\"> ");
                        html.Append("<div class=\"col-md-3 text-center\"> ");
                        html.Append("<img class=\"rounded-circle reviewer\" src=\"" + sender_image + "\"> ");
                        html.Append("<div class=\"caption\"> ");
                        html.Append("<small>by<a href=\"" + sender_url + "\">" + sender + "</a></small> ");
                        html.Append("</div> ");

                        html.Append("</div> ");
                        html.Append("<div class=\"col-md-9\"> ");
                        html.Append(" <h4>" + title + "</h4> ");
                        html.Append("<div class=\"ratebox text-center\" data-id=\"0\" data-rating=\"" + rating + "\"></div> ");
                        html.Append("<p class=\"review-text\"> " + content + "</p> ");

                        html.Append("<small class=\"review-date\"> March 26, 2017 </small> ");
                        html.Append(" </div> ");
                        html.Append(" </div> ");
                        html.Append("</div> ");
                        html.Append("</tr> ");
                    }
                }
                //Append the HTML string to Placeholder.
                newsfeed.Controls.Add(new LiteralControl { Text = html.ToString() });
            }

        }
    }
}