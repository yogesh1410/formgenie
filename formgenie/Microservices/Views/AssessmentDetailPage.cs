using System;
using formgenie.DependencyServices;
using formgenie.Engine.Services;
using Newtonsoft.Json.Linq;
using Xamarin.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Schema;
using System.Collections.Generic;
using System.Linq;

namespace formgenie.Microservices.Views
{
    //this is the page that will get the dynamic form JSON to bind and create components*/
    public class AssessmentDetailPage : ContentPage
    {
        


        public AssessmentDetailPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Default Placeholder for Status Control", FontSize=30 }
                }
            };

        }
        string friendlyName;
        string validationSchema;
        Label lblError;
        public AssessmentDetailPage(string selectedItem)
        {
            lblError = new Label();
            lblError.TextColor = Color.DarkRed;

            friendlyName = selectedItem;
            FormDataService.FormData = string.Empty;

            FormService formService = new FormService();
            //Get Form Instance
            var formInstance = formService.GetFormInstance(selectedItem);
            validationSchema = formInstance.ValidationSchema;
            //generate Layout Dynamically

            //Set static FormData
            FormDataService.FormData = formInstance.FormData;;
            Layout formModelLayout = formService.GenerateLayout(formInstance.FormModelView, formInstance.FormData);

            Button saveButton = new Button();
            saveButton.Text = "Save";
            saveButton.Clicked += SaveButton_Clicked;

            Content = new ScrollView
            {
                Content = new StackLayout
                {
                    Children = {
                        lblError,
                        formModelLayout,
                        saveButton,

                }
                }
            };
        }

        void SaveButton_Clicked(object sender, EventArgs e)
        {
            //Read formData
            string formData = FormDataService.FormData;

            //Validate
            JObject fd = JObject.Parse(formData);
            IList<string> messages;
            JSchema schema = JSchema.Parse(validationSchema); 
            bool valid = fd.IsValid(schema, out messages);

            //Show Error
            lblError.Text = string.Join(",", messages.ToArray());;

            //Save
            DependencyService.Get<ISaveAndLoad>().SaveText(friendlyName, formData);

            if (messages.Count == 0)
            {
                var answer = DisplayAlert("Saved with No Errors", "Form Saved Succesfully", "OK");
            }
            else
            {
                var answer = DisplayAlert("Saved With Errors ("+messages.Count+")", "Please check the Error messages for more details.", "OK");
            }
        }

    }
}

