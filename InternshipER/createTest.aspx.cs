using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InternshipER
{
    public partial class createTest : System.Web.UI.Page
    {
        public static int numberOfQuestion = 0;
        public static int numberOfChoice = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("deneme");
            if (questionType.SelectedItem.Text == "Çoktan Seçmeli")
            {
                addChoice.Visible = true;
            }
            else
            {
                addChoice.Visible = false;
            }

        }
        protected void addChoice_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("girdiiiiiiiiiii");

            StringBuilder html2 = new StringBuilder();
            if (numberOfChoice > 0)
            {
                System.IO.TextWriter tw = new System.IO.StringWriter();
                HtmlTextWriter h = new HtmlTextWriter(tw);
                multipleChoices.RenderControl(h);
                string html = tw.ToString();
                html2.Append(html);
                System.Diagnostics.Debug.WriteLine(html);
            }
            html2.Append(" <br/> ");
            html2.Append("<input runat=\"server\" ID=\"choice" + numberOfChoice + "\"/> ");
            //html.Append("<br/>");
            numberOfChoice++;
            multipleChoices.Controls.Add(new LiteralControl { Text = html2.ToString() });
        }
        protected void Submit_onClick(object sender, EventArgs e)
        {
            if (questionType.SelectedItem.Text == "Çoktan Seçmeli")
            {
                String[] choices = new String[numberOfChoice];
                int i = 0;
                //foreach (TextBox textBox in pnlTextBoxes.Controls.OfType<TextBox>())
                //{
                //    choices[i] += textBox.Text;
                //    i++;
                //}
                addNewQuestion("Çoktan Seçmeli", question.Text, choices);
            }
            else if (questionType.SelectedItem.Text == "Kod")
            {
                addNewQuestion("Kod", question.Text, null);
            }
            else if (questionType.SelectedItem.Text == "Açık Uçlu")
            {
                addNewQuestion("Açık Uçlu", question.Text, null);
            }
            else if (questionType.SelectedItem.Text == "Ses Kaydı")
            {
                addNewQuestion("Ses Kaydı", question.Text, null);
            }
            numberOfChoice = 0;
            numberOfQuestion++;
            addChoice.Visible = false;
        }
        protected void addNewQuestion(String type, String question, String[] choices)
        {
            numberOfQuestion++;

            StringBuilder html = new StringBuilder();

            html.Append("<div class=\"question\" > <br/>");
            //html.Append("<br/>");
            html.Append("<br/>");
            html.Append("<p> Soru (" + type + "): </p> <br/>");
            html.Append("<p>" + question + "</p> <br/>");
            if (choices != null)
            {
                html.Append("<br/>");
            }
            html.Append("</div>");
            addedQuestions.Controls.Add(new LiteralControl { Text = html.ToString() });

        }

    }
}