using System;

using Xamarin.Forms;

namespace formgenie.Microservices.Views
{
    public class AvailableAssessmentList : ContentPage
    {
        public AvailableAssessmentList()
        {
            string[] assessmentList = new string[] { "Assessment 1", "Assessment 2" };

            ListView assessmentListView = new ListView
            {
                ItemsSource = assessmentList
            };

            assessmentListView.ItemSelected += (sender, args) =>
            {
                //var assessmenPage = new NavigationPage(new AssessmentMasterPage(args.SelectedItem.ToString()));
                Navigation.PushAsync(new AssessmentMasterPage(args.SelectedItem.ToString()), false);
            };

            Content = new StackLayout
            {
                Children = {
                    assessmentListView 
                }
            };
        }
    }
}

