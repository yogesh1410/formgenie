/******************
 * dont use anymore
 * 
 *************************/



using System;
using formgenie.Engine.Views;
using Xamarin.Forms;

namespace formgenie.Microservices.Views
{
    public class QuestionSwitchPattern : ContentPage
    {
        Label lblQuestion = new Label();
        Switch switchAnswer = new Switch();
        Label lblSelectedAnswer = new Label();

        public QuestionSwitchPattern()
        {
            //Page level Padding
            this.Padding = new Thickness(5, 20, 0, 0);

            //Defining Question Label
            lblQuestion.Text = "Are chicks procured from SE-monitored breeder flocks that meet the National Poultry Improvement Plan's standards for “U.S. S. Enteritidis Clean” status (9 CFR 145.23(d)) or equivalent standard?";

            //Switch command
            switchAnswer.Toggled += SwitchAnswer_Toggled; 

            Content = new ScrollView
            {
                Content = new StackLayout
                {
                    Children = {
                        lblQuestion,
                        switchAnswer,
                        lblSelectedAnswer,
                                        }
                }
            };
        }

        private void SwitchAnswer_Toggled(object sender, ToggledEventArgs e)
        {
            lblSelectedAnswer.Text = e.Value.ToString();
        }
    }
}

