using System;
using formgenie.Engine.Entities;
using formgenie.Engine.Services;
using Xamarin.Forms;

namespace formgenie.Engine.Views.Components
{
    public class LabelEditorView : ContentView
    {
        void DataEntry_Completed(object sender, EventArgs e)
        {
            //string insaneValue = dataEntry.Text;
            FormDataService.UpdateFormDataValue(editorPath, dataEntry.Text);
        }


        LabelEditorViewModel lblEditorModel;

        LabelView lblText;
        Editor dataEntry;
        string editorPath;
        public LabelEditorView(Component c, string formData)
        {
            editorPath = c.path;
            var dataEntryValue = Utilities.Utility.GetFormDataValue(formData, editorPath);

            lblEditorModel = new LabelEditorViewModel(c.text, dataEntryValue.ToString());
            BindingContext = lblEditorModel;
 
            dataEntry = new Editor();
            dataEntry.BackgroundColor = Color.LightGray;
            dataEntry.WidthRequest = 200;
            dataEntry.HeightRequest = 200;

            dataEntry.SetBinding(Editor.TextProperty, "EditorText");
            dataEntry.BindingContext = lblEditorModel;
            dataEntry.Completed += DataEntry_Completed;
            lblText = new LabelView(lblEditorModel.LabelText);

            var editorLayout = new StackLayout
            {
                Padding = new Thickness(5, 10),
                Children ={
                    dataEntry
                }
            };

            Content = new StackLayout
            {
                Children ={
                lblText,
                editorLayout
                }
            };
        }
    }
}

