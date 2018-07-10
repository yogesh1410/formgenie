using System;
using System.Collections;
using System.Collections.Generic;
using formgenie.Data;
using Xamarin.Forms;

namespace formgenie.Microservices.Views
{
    public class AssessmentMasterPage : MasterDetailPage
    {
        public AssessmentMasterPage(string selectedValue)
        {
            //string[] assessmentList = new string[] { "Pullets", "Biosecurity" };
            List<string> assessmentList = PreventionSectionList.GetPreventionSectionList();
            ListView assessmentListView = new ListView
            {
                ItemsSource = assessmentList

            };

            // Create the master page with the ListView.
            this.Master = new ContentPage
            {
                Title = "List",
                Content = new StackLayout
                {
                    Spacing = 10,
                    Padding = 10,
                    Children =
                    {
                        assessmentListView
                    }

                }
            };

            // Define a selected handler for the ListView.
            assessmentListView.ItemSelected += (sender, args) =>
            {
                this.Detail = new AssessmentDetailPage(args.SelectedItem.ToString());
                // Set the BindingContext of the detail page.
                this.Detail.BindingContext = args.SelectedItem;

                // Show the detail page.
                this.IsPresented = false;
                this.Title = "List";

            };

            // Initialize the ListView selection.
           
            this.Detail = new NavigationPage(new AssessmentDetailPage());
        }
    }
}

