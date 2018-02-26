using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        public static string htmlChoice = "";
        public static TextBox[] textAll = new TextBox[100];
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void RadioButton_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("deneme");
            if (questionType.SelectedItem.Text == "Çoktan Seçmeli")
            {
                addChoice.Visible = true;
                StringBuilder html2 = new StringBuilder();
                html2.Append(htmlChoice);
                multipleChoices.Controls.Add(new LiteralControl { Text = html2.ToString() });

            }
            else
            {
                addChoice.Visible = false;
            }

        }

    

        protected void addChoice_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("girdiiiiiiiiiii");
            TextBox MyTextBox = new TextBox();
            //Assigning the textbox ID name 
            MyTextBox.ID = "choice" + numberOfChoice;
            MyTextBox.Width = 100;
            MyTextBox.Height = 15;
            //MyTextBox.Text = "deneme";
            textAll[numberOfChoice] = MyTextBox;
            numberOfChoice++;
           
            for (int i = 0; i < numberOfChoice; i++)
            {
                System.Diagnostics.Debug.WriteLine("************" + textAll[i].Text);
                char choose = (char)('A' + i);
                Literal lt1 = new Literal();
                lt1.Text = choose + " : ";
                pnlTextBoxes.Controls.Add(lt1);// "pnl1" is a id of Panel

                pnlTextBoxes.Controls.Add(textAll[i]);


                //bu button post back yapmaması lazım o zaman kod çalısıyor.

                Button btn = new Button();
                btn.Text = "Kaydet";
                btn.Click += new EventHandler(saveValue2textBox );
                btn.OnClientClick = " saveValue2textBox";
                pnlTextBoxes.Controls.Add(btn);
            }
        }
        protected void saveValue2textBox(object sender, EventArgs e)
        {
            int i = 0;
            System.Diagnostics.Debug.WriteLine("deneme************" );
            foreach (TextBox textBox in pnlTextBoxes.Controls.OfType<TextBox>())
            {
                if (!textBox.ID.Equals("question"))
                {
                    System.Diagnostics.Debug.WriteLine("deneme************" + textBox.Text);
                    textAll[i].Text= textBox.Text;

                    i++;
                }
            }
        }
        protected void Submit_onClick(object sender, EventArgs e)
        {
            if (questionType.SelectedItem.Text == "Çoktan Seçmeli")
            {
                String[] choices = new String[numberOfChoice];
                int i = 0;
               // System.Diagnostics.Debug.WriteLine(this.GetType().GetField("choice0", BindingFlags.Public | BindingFlags.Instance).GetValue(this).GetType());
                foreach (TextBox textBox in pnlTextBoxes.Controls.OfType<TextBox>())
                {
                    if (!textBox.ID.Equals("question")){
                        System.Diagnostics.Debug.WriteLine("************"+textBox.Text);
                        choices[i] += textBox.Text;
                        
                        i++;
                    }
                }
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
            addChoice.Visible = false;
        }
        protected void addNewQuestion(String type, String question, String[] choices)
        {
            numberOfQuestion++;

            StringBuilder html = new StringBuilder();

            html.Append("<div class=\"question\" > <br/>");
            //html.Append("<br/>");
            html.Append("<br/>");
            html.Append("<p> "+numberOfQuestion+ ". Soru (" + type + "): </p> <br/>");
            html.Append("<p>" + question + "</p> <br/>");
            if (choices != null)
            {
                for(int i = 0; i < choices.Length; i++)
                {
                    char choose = (char)('A' + i);
                    html.Append("<br/> "+choose+":"+choices[i]+"<br/>");
                }

            }
            html.Append("</div>");
            addedQuestions.Controls.Add(new LiteralControl { Text = html.ToString() });

        }

    }
}